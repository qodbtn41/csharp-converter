using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace CSharp2JavaConverter
{
    public partial class Form1 : Form
    {
        public static readonly char SEPERATOR = ':';

        public string FilePath { get; set; }
        public Dictionary<string, string> Properties { get; set; }
        public string ClassName { get; set; }

        public Form1()
        {
            InitializeComponent();
            AddEventHandler();
        }

        private void AddEventHandler()
        {
            this.Load += new EventHandler(Form1_Load);
            this.buttonSearch.Click += new EventHandler(buttonSearch_Click);
            this.buttonApply.Click += new EventHandler(buttonApply_Click);
            this.buttonAdd.Click += new EventHandler(buttonAdd_Click);
            this.textBefore.TextChanged += new EventHandler(textBefore_TextChanged);
        }

        /// <summary>
        /// ClassName을 찾기위한 함수
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void textBefore_TextChanged(object sender, EventArgs e)
        {
            string text = this.textBefore.Text;
            List<string> lines = text.Split('\n').ToList();
            foreach(string line in lines)
            {
                if (line.Contains("public") && line.Contains("class"))
                {
                    List<string> words = line.Split(' ').ToList();
                    words.RemoveAll(word => word.Equals(""));
                    words.RemoveAll(word => word.Equals("public"));
                    words.RemoveAll(word => word.Equals("private"));
                    words.RemoveAll(word => word.Equals("class"));
                    words.RemoveAll(word => word.Equals("static"));
                    words.RemoveAll(word => word.Equals("partial"));

                    this.ClassName = words[0];
                    break;
                }
            }
        }

        void buttonAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("아직 개발되지 않은 기능입니다.");
        }

        // 적용한다.
        void buttonApply_Click(object sender, EventArgs e)
        {
            string textAfter = this.textAfter.Text;

            foreach (object itemChecked in this.listFilters.CheckedItems)
            {
                string strChecked = (string)itemChecked;

                if(strChecked != null && strChecked != "")
                {
                    if (strChecked.StartsWith("`"))
                    {
                        Console.WriteLine("strChecked : " + strChecked.Substring(1));
                        Console.WriteLine("value : " + this.Properties[strChecked]);
                        textAfter = Regex.Replace(textAfter, strChecked.Substring(1), this.Properties[strChecked]);
                    }
                    else
                    {
                        textAfter = textAfter.Replace(strChecked, this.Properties[strChecked]);
                    }
                }
            }

            textAfter = this.ApplyPredefined(textAfter);

            textAfter = Regex.Replace(textAfter, @"^\s+$[\r\n]*", string.Empty, RegexOptions.Multiline);

            
            this.textAfter.Text = textAfter;
        }

        private string ApplyPredefined(string text)
        {

            if (this.checkBoxComment.Checked)
            {
                text = this.RemoveComment(text);
                text = this.RemoveMultiLineComment(text);
            }
            text = this.RemoveNamespace(text);
            if (this.checkBoxException.Checked)
            {
                text = this.RemoveException(text);
            }
            if(this.checkBoxConstructor.Checked){
                text = this.RemoveConstructor(text);
            }

            return text;
        }

        private string RemoveMultiLineComment(string text)
        {
            List<string> lines = text.Split('\n').ToList();
            int startIndex = -1, endIndex = -1;
            bool started = false;
            // /*로 시작하면 */로 끝난다.
            for (int i = 0 ; i < lines.Count ; i++)
            {
                string line = lines[i];
                if (started == false)
                {
                    if (line.Contains("/*"))
                    {
                        startIndex = i;
                        started = true;
                    }
                }

                if (started && line.Contains("*/"))
                {
                    endIndex = i;
                    break;
                }
            }


            if (started)
            {
                for (int i = endIndex; i >= startIndex; i--)
                {
                    lines.RemoveAt(i);
                }

                text = string.Join("\n", lines);
            }
            return text;
        }

        private string RemoveConstructor(string text)
        {
            if (this.ClassName == null || this.ClassName.Equals("")) return text;

            List<string> lines = text.Split('\n').ToList();
            int startIndex = -1, endIndex = -1, stack = 0;
            bool started = false, blockStart = false;

            // 클래스 명을 알아야 한다.
            string className = this.ClassName;
            //처음부터 끝까지
            for (int i = 0; i < lines.Count; i++)
            {
                string line = lines[i];
                //클래스 명()을 찾으면
                if (started == false)
                {
                    if (line.Contains(className)
                        && line.Contains(" class ") == false)
                    {
                        startIndex = i;
                        started = true;
                    }
                }
                
                if(started)
                {
                    //해당 index부터 블록'{'을 찾고
                    //블록'}'을 찾는다.
                    //블록 '{' 과 '}' 사이에 새로운 블록'{'을 찾으면 스택 변수에 +1 한다.
                    // 스택 변수가 0이면서 블록'}' 를 찾을때까지 반복한다.
                    stack += line.Count(ch => ch == '{');
                    if (stack > 0) blockStart = true;
                    stack -= line.Count(ch => ch == '}');

                    if (blockStart && stack == 0)
                    {
                        endIndex = i;
                        break;
                    }
                }
            }

            if (started)
            {
                //다 지운다.
                for (int i = endIndex; i >= startIndex; i--)
                {
                    lines.RemoveAt(i);
                }

                text = string.Join("\n", lines);
                text = this.RemoveConstructor(text);
            }
            return text;
        }

        private string RemoveException(string text)
        {
            // try는 벗긴다.
            text = this.PeelOffBlockStartWith(text, "try");
            // catch는 지운다.
            text = this.RemoveBlockStartWith(text, "catch");
            // finally는 지운다.
            text = this.RemoveBlockStartWith(text, "finally");

            return text;
        }

        private string RemoveBlockStartWith(string text, string startWith)
        {
            List<string> lines = text.Split('\n').ToList();
            int startIndex = -1, endIndex = -1, stack = 0;
            bool started = false, blockStart = false;

            //처음부터 끝까지
            for (int i = 0; i < lines.Count; i++)
            {
                string line = lines[i];
                //해당 단어를 찾으면
                if (started == false)
                {
                    if (line.Contains(startWith)
                        && line.Contains(" class ") == false)
                    {
                        startIndex = i;
                        started = true;
                    }
                }

                if (started)
                {
                    //해당 index부터 블록'{'을 찾고
                    //블록'}'을 찾는다.
                    //블록 '{' 과 '}' 사이에 새로운 블록'{'을 찾으면 스택 변수에 +1 한다.
                    // 스택 변수가 0이면서 블록'}' 를 찾을때까지 반복한다.
                    stack += line.Count(ch => ch == '{');
                    if (stack > 0) blockStart = true;
                    stack -= line.Count(ch => ch == '}');

                    if (blockStart && stack == 0)
                    {
                        endIndex = i;
                        break;
                    }
                }
            }

            if (started)
            {
                //다 지운다.
                for (int i = endIndex; i >= startIndex; i--)
                {
                    lines.RemoveAt(i);
                }

                text = string.Join("\n", lines);
                text = this.RemoveBlockStartWith(text, startWith);
            }
            return text;
        }

        private string PeelOffBlockStartWith(string text, string startWith)
        {
            List<string> lines = text.Split('\n').ToList();
            List<int> removeIndex = new List<int>();
            int stack = 0;
            bool wordFound = false, blockStart = false;

            //처음부터 끝까지
            for (int i = 0; i < lines.Count; i++)
            {
                string line = lines[i];
                //해당 단어를 찾으면
                if (wordFound == false)
                {
                    if (line.Contains(startWith))
                    {
                        removeIndex.Add(i);
                        if (line.Contains("{"))
                        {
                            //skip
                        }
                        else if (lines[i + 1].Contains("{"))
                        {
                            removeIndex.Add(i + 1);
                        }
                        else
                        {
                            removeIndex.Clear();
                            continue;
                        }

                        wordFound = true;
                    }
                }

                if (wordFound)
                {
                    //해당 index부터 블록'{'을 찾고
                    //블록'}'을 찾는다.
                    //블록 '{' 과 '}' 사이에 새로운 블록'{'을 찾으면 스택 변수에 +1 한다.
                    // 스택 변수가 0이면서 블록'}' 를 찾을때까지 반복한다.
                    stack += line.Count(ch => ch == '{');
                    if (stack > 0) blockStart = true;
                    stack -= line.Count(ch => ch == '}');

                    if (blockStart && stack == 0)
                    {
                        removeIndex.Add(i);
                        break;
                    }
                }
            }

            if (wordFound)
            {
                foreach (int removeIndedx in removeIndex.OrderByDescending(index => index))
                {
                    lines.RemoveAt(removeIndedx);
                }

                text = string.Join("\n", lines);
                text = this.PeelOffBlockStartWith(text, startWith);
            }
            return text;
        }

        private string RemoveNamespace(string text)
        {
            List<string> lines = text.Split('\n').ToList();
            List<int> removeIndex = new List<int>();

            for (int i = 0; i < lines.Count; i++)
            {
                string line = lines[i];
                if (line.Contains("namespace"))
                {
                    removeIndex.Add(i);
                    if (line.Contains("{"))
                    {
                        //skip
                    }
                    else if (lines[i + 1].Contains("{"))
                    {
                        removeIndex.Add(i + 1);
                    }
                    break;
                }
            }

            for (int i = lines.Count - 1; i > 0; i--)
            {
                string line = lines[i];
                if (line.Contains("}"))
                {
                    removeIndex.Add(i);
                    break;
                }
            }

            foreach (int removeIndedx in removeIndex.OrderByDescending(index => index))
            {
                lines.RemoveAt(removeIndedx);
            }
            text = string.Join("\n", lines);
            return text;
        }

        private string RemoveComment(string text)
        {
            text = Regex.Replace(text, @"//.*", string.Empty);
            return text;
        }

        /// <summary>
        /// 프로퍼티 파일을 한줄씩 읽어온다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void Form1_Load(object sender, EventArgs e)
        {
            string propertyPath = Environment.CurrentDirectory + @"\filter.properties";
            System.IO.StreamReader file = new System.IO.StreamReader(propertyPath);  
            this.Properties = new Dictionary<string,string>();

            string line;  
            while((line = file.ReadLine()) != null)  
            {  
                System.Console.WriteLine(line);
                string[] beforeAfter = line.Split(SEPERATOR);
                if (beforeAfter != null && beforeAfter.Length == 2)
                {
                    string before = beforeAfter[0];
                    string after = beforeAfter[1] != null ? beforeAfter[1] : "";

                    if (before == null || before.Equals("")) continue;

                    if (this.Properties.ContainsKey(before))
                    {
                        this.Properties[before] = after;
                    }
                    else
                    {
                        this.Properties.Add(before, after);
                    }
                }
            }

            this.listFilters.Items.AddRange(this.Properties.Keys.ToArray());
            for(int i = 0 ; i < this.listFilters.Items.Count ; i++){
                this.listFilters.SetItemChecked(i, true);
            }
            file.Close();
        }

        /// <summary>
        /// 변경할 파일을 선택한다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void buttonSearch_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = this.openFileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                string fileName = openFileDialog.SafeFileName;
                string fileFullName = openFileDialog.FileName;
                string filePath = fileFullName.Replace(fileName, "");

                this.FilePath = filePath;

                if (this.radioFile.Checked)
                {
                    this.textFile.Text = fileFullName;
                }
                else
                {
                    this.textFile.Text = filePath;
                }

                this.LoadFile();
            }
        }
        
        /// <summary>
        /// 파일 데이터를 읽어들인다.
        /// </summary>
        private void LoadFile()
        {
            string filePath = this.textFile.Text;
            string textValue = System.IO.File.ReadAllText(filePath);
            this.textBefore.Text = textValue;
            this.textAfter.Text = textValue;
        }



    }
}

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
        public Dictionary<string,string> Properties { get; set; }

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
            text = this.RemoveComment(text);
            text = this.RemoveNamespace(text);
            text = this.RemoveException(text);
            text = this.RemoveConstructor(text);

            return text;
        }

        private string RemoveConstructor(string text)
        {
            return text;
        }

        private string RemoveException(string text)
        {
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
            if (this.checkBoxComment.Checked)
            {
                text = Regex.Replace(text, @"//.*", string.Empty);
            }
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

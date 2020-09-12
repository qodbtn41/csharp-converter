using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace CSharp2JavaConverter
{
    public partial class Form1 : Form
    {
        public string FilePath { get; set; }
        public List<string> Properties { get; set; }

        public Form1()
        {
            InitializeComponent();
            AddEventHandler();
        }

        private void AddEventHandler()
        {
            this.Load += new EventHandler(Form1_Load);
            this.buttonSearch.Click += new EventHandler(buttonSearch_Click);
        }

        void Form1_Load(object sender, EventArgs e)
        {
            // Read the file and display it line by line.  
            string propertyPath = Environment.CurrentDirectory + @"\filter.properties";
            System.IO.StreamReader file = new System.IO.StreamReader(propertyPath);  
            this.Properties = new List<string>();

            string line;  
            while((line = file.ReadLine()) != null)  
            {  
                System.Console.WriteLine(line);
                this.Properties.Add(line);
            }  
  
            file.Close();
        }

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

        private void LoadFile()
        {
            string filePath = this.textFile.Text;
            string textValue = System.IO.File.ReadAllText(filePath);
            this.textBefore.Text = textValue;
        }


    }
}

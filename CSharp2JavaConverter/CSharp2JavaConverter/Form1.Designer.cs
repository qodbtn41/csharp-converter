namespace CSharp2JavaConverter
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textFile = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioDirectory = new System.Windows.Forms.RadioButton();
            this.radioFile = new System.Windows.Forms.RadioButton();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonApply = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.textNewFilter = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBefore = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textAfter = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listFilters = new System.Windows.Forms.CheckedListBox();
            this.checkBoxComment = new System.Windows.Forms.CheckBox();
            this.checkBoxConstructor = new System.Windows.Forms.CheckBox();
            this.checkBoxException = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(782, 74);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textFile);
            this.groupBox5.Controls.Add(this.buttonSearch);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(194, 21);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(585, 50);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "File";
            // 
            // textFile
            // 
            this.textFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textFile.Location = new System.Drawing.Point(3, 21);
            this.textFile.Name = "textFile";
            this.textFile.ReadOnly = true;
            this.textFile.Size = new System.Drawing.Size(494, 25);
            this.textFile.TabIndex = 2;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonSearch.Location = new System.Drawing.Point(497, 21);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(85, 26);
            this.buttonSearch.TabIndex = 1;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioDirectory);
            this.groupBox4.Controls.Add(this.radioFile);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox4.Location = new System.Drawing.Point(3, 21);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(191, 50);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Mode";
            // 
            // radioDirectory
            // 
            this.radioDirectory.AutoSize = true;
            this.radioDirectory.Dock = System.Windows.Forms.DockStyle.Left;
            this.radioDirectory.Enabled = false;
            this.radioDirectory.Location = new System.Drawing.Point(53, 21);
            this.radioDirectory.Name = "radioDirectory";
            this.radioDirectory.Size = new System.Drawing.Size(86, 26);
            this.radioDirectory.TabIndex = 1;
            this.radioDirectory.TabStop = true;
            this.radioDirectory.Text = "Directory";
            this.radioDirectory.UseVisualStyleBackColor = true;
            // 
            // radioFile
            // 
            this.radioFile.AutoSize = true;
            this.radioFile.Checked = true;
            this.radioFile.Dock = System.Windows.Forms.DockStyle.Left;
            this.radioFile.Location = new System.Drawing.Point(3, 21);
            this.radioFile.Name = "radioFile";
            this.radioFile.Size = new System.Drawing.Size(50, 26);
            this.radioFile.TabIndex = 0;
            this.radioFile.TabStop = true;
            this.radioFile.Text = "File";
            this.radioFile.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.panel2);
            this.groupBox6.Controls.Add(this.panel1);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox6.Location = new System.Drawing.Point(0, 493);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(782, 100);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Filter";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonApply);
            this.panel1.Controls.Add(this.groupBox7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(386, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(393, 76);
            this.panel1.TabIndex = 4;
            // 
            // buttonApply
            // 
            this.buttonApply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonApply.Location = new System.Drawing.Point(284, 0);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(109, 76);
            this.buttonApply.TabIndex = 3;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.textNewFilter);
            this.groupBox7.Controls.Add(this.buttonAdd);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox7.Location = new System.Drawing.Point(0, 0);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(284, 76);
            this.groupBox7.TabIndex = 1;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Add";
            // 
            // textNewFilter
            // 
            this.textNewFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textNewFilter.Location = new System.Drawing.Point(3, 21);
            this.textNewFilter.Multiline = true;
            this.textNewFilter.Name = "textNewFilter";
            this.textNewFilter.Size = new System.Drawing.Size(278, 28);
            this.textNewFilter.TabIndex = 3;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonAdd.Location = new System.Drawing.Point(3, 49);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(278, 24);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Add Filter";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "C#프로그램|*.cs";
            this.openFileDialog.Title = "CS 파일 선택";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 74);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer1.Size = new System.Drawing.Size(782, 419);
            this.splitContainer1.SplitterDistance = 379;
            this.splitContainer1.SplitterWidth = 10;
            this.splitContainer1.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBefore);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(379, 419);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Before";
            // 
            // textBefore
            // 
            this.textBefore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBefore.Location = new System.Drawing.Point(3, 21);
            this.textBefore.Multiline = true;
            this.textBefore.Name = "textBefore";
            this.textBefore.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBefore.Size = new System.Drawing.Size(373, 395);
            this.textBefore.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textAfter);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(393, 419);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "After";
            // 
            // textAfter
            // 
            this.textAfter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textAfter.Location = new System.Drawing.Point(3, 21);
            this.textAfter.Multiline = true;
            this.textAfter.Name = "textAfter";
            this.textAfter.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textAfter.Size = new System.Drawing.Size(387, 395);
            this.textAfter.TabIndex = 1;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.checkBoxException);
            this.groupBox8.Controls.Add(this.checkBoxConstructor);
            this.groupBox8.Controls.Add(this.checkBoxComment);
            this.groupBox8.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox8.Location = new System.Drawing.Point(183, 0);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(200, 76);
            this.groupBox8.TabIndex = 8;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Predefined";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listFilters);
            this.panel2.Controls.Add(this.groupBox8);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(383, 76);
            this.panel2.TabIndex = 9;
            // 
            // listFilters
            // 
            this.listFilters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listFilters.FormattingEnabled = true;
            this.listFilters.Location = new System.Drawing.Point(0, 0);
            this.listFilters.Name = "listFilters";
            this.listFilters.Size = new System.Drawing.Size(183, 76);
            this.listFilters.TabIndex = 11;
            // 
            // checkBoxComment
            // 
            this.checkBoxComment.AutoSize = true;
            this.checkBoxComment.Location = new System.Drawing.Point(11, 24);
            this.checkBoxComment.Name = "checkBoxComment";
            this.checkBoxComment.Size = new System.Drawing.Size(59, 19);
            this.checkBoxComment.TabIndex = 0;
            this.checkBoxComment.Text = "주석";
            this.checkBoxComment.UseVisualStyleBackColor = true;
            // 
            // checkBoxConstructor
            // 
            this.checkBoxConstructor.AutoSize = true;
            this.checkBoxConstructor.Location = new System.Drawing.Point(11, 49);
            this.checkBoxConstructor.Name = "checkBoxConstructor";
            this.checkBoxConstructor.Size = new System.Drawing.Size(74, 19);
            this.checkBoxConstructor.TabIndex = 1;
            this.checkBoxConstructor.Text = "생성자";
            this.checkBoxConstructor.UseVisualStyleBackColor = true;
            // 
            // checkBoxException
            // 
            this.checkBoxException.AutoSize = true;
            this.checkBoxException.Location = new System.Drawing.Point(90, 24);
            this.checkBoxException.Name = "checkBoxException";
            this.checkBoxException.Size = new System.Drawing.Size(94, 19);
            this.checkBoxException.TabIndex = 2;
            this.checkBoxException.Text = "예외 처리";
            this.checkBoxException.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 593);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "C# to Java Converter";
            this.groupBox1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textFile;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radioDirectory;
        private System.Windows.Forms.RadioButton radioFile;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox textNewFilter;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBefore;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textAfter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckedListBox listFilters;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.CheckBox checkBoxException;
        private System.Windows.Forms.CheckBox checkBoxConstructor;
        private System.Windows.Forms.CheckBox checkBoxComment;
    }
}


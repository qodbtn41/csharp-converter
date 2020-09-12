﻿namespace CSharp2JavaConverter
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioFile = new System.Windows.Forms.RadioButton();
            this.radioDirectory = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBefore = new System.Windows.Forms.TextBox();
            this.textAfter = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textFile = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBefore);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(0, 74);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(383, 519);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Before";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textAfter);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(383, 74);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(399, 519);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "After";
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
            // radioFile
            // 
            this.radioFile.AutoSize = true;
            this.radioFile.Dock = System.Windows.Forms.DockStyle.Left;
            this.radioFile.Location = new System.Drawing.Point(3, 21);
            this.radioFile.Name = "radioFile";
            this.radioFile.Size = new System.Drawing.Size(50, 26);
            this.radioFile.TabIndex = 0;
            this.radioFile.TabStop = true;
            this.radioFile.Text = "File";
            this.radioFile.UseVisualStyleBackColor = true;
            this.radioFile.Checked = true;
            // 
            // radioDirectory
            // 
            this.radioDirectory.AutoSize = true;
            this.radioDirectory.Dock = System.Windows.Forms.DockStyle.Left;
            this.radioDirectory.Location = new System.Drawing.Point(53, 21);
            this.radioDirectory.Name = "radioDirectory";
            this.radioDirectory.Size = new System.Drawing.Size(86, 26);
            this.radioDirectory.TabIndex = 1;
            this.radioDirectory.TabStop = true;
            this.radioDirectory.Text = "Directory";
            this.radioDirectory.UseVisualStyleBackColor = true;
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
            // textBefore
            // 
            this.textBefore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBefore.Location = new System.Drawing.Point(3, 21);
            this.textBefore.Multiline = true;
            this.textBefore.Name = "textBefore";
            this.textBefore.Size = new System.Drawing.Size(377, 495);
            this.textBefore.TabIndex = 0;
            // 
            // textAfter
            // 
            this.textAfter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textAfter.Location = new System.Drawing.Point(3, 21);
            this.textAfter.Multiline = true;
            this.textAfter.Name = "textAfter";
            this.textAfter.Size = new System.Drawing.Size(393, 495);
            this.textAfter.TabIndex = 1;
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
            // textFile
            // 
            this.textFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textFile.Location = new System.Drawing.Point(3, 21);
            this.textFile.Name = "textFile";
            this.textFile.ReadOnly = true;
            this.textFile.Size = new System.Drawing.Size(494, 25);
            this.textFile.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 593);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBefore;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textAfter;
    }
}

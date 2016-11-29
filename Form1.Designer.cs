namespace WordRead
{
    partial class frmWordRead
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnWordRead = new System.Windows.Forms.Button();
            this.btnSQLTest = new System.Windows.Forms.Button();
            this.tbHtmlPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHtmlPath = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tbTitle2Xpath2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTitle2Xpath = new System.Windows.Forms.Button();
            this.tbTitle2Xpath1 = new System.Windows.Forms.TextBox();
            this.tbTitle2Xpath3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTitle1Xpath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTitle1Xpath = new System.Windows.Forms.Button();
            this.tbcMode = new System.Windows.Forms.TabControl();
            this.tabcontent = new System.Windows.Forms.TabPage();
            this.tabCategory = new System.Windows.Forms.TabPage();
            this.rdbtContent = new System.Windows.Forms.RadioButton();
            this.rdbtCatagory = new System.Windows.Forms.RadioButton();
            this.grpMode = new System.Windows.Forms.GroupBox();
            this.grpContent = new System.Windows.Forms.GroupBox();
            this.grpCatagory = new System.Windows.Forms.GroupBox();
            this.tbcMode.SuspendLayout();
            this.tabcontent.SuspendLayout();
            this.tabCategory.SuspendLayout();
            this.grpMode.SuspendLayout();
            this.grpContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnWordRead
            // 
            this.btnWordRead.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWordRead.Location = new System.Drawing.Point(15, 288);
            this.btnWordRead.Name = "btnWordRead";
            this.btnWordRead.Size = new System.Drawing.Size(91, 23);
            this.btnWordRead.TabIndex = 0;
            this.btnWordRead.Text = "文档录入";
            this.btnWordRead.UseVisualStyleBackColor = true;
            this.btnWordRead.Click += new System.EventHandler(this.btnWordRead_Click);
            // 
            // btnSQLTest
            // 
            this.btnSQLTest.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSQLTest.Location = new System.Drawing.Point(387, 27);
            this.btnSQLTest.Name = "btnSQLTest";
            this.btnSQLTest.Size = new System.Drawing.Size(91, 23);
            this.btnSQLTest.TabIndex = 1;
            this.btnSQLTest.Text = "SQL连接测试";
            this.btnSQLTest.UseVisualStyleBackColor = true;
            this.btnSQLTest.Click += new System.EventHandler(this.btnSQLTest_Click);
            // 
            // tbHtmlPath
            // 
            this.tbHtmlPath.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHtmlPath.Location = new System.Drawing.Point(6, 166);
            this.tbHtmlPath.Name = "tbHtmlPath";
            this.tbHtmlPath.Size = new System.Drawing.Size(288, 22);
            this.tbHtmlPath.TabIndex = 2;
            this.tbHtmlPath.Text = "../../../htmlRcgTest/Part3_07.htm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "Html 路径:";
            // 
            // btnHtmlPath
            // 
            this.btnHtmlPath.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHtmlPath.Location = new System.Drawing.Point(300, 166);
            this.btnHtmlPath.Name = "btnHtmlPath";
            this.btnHtmlPath.Size = new System.Drawing.Size(75, 23);
            this.btnHtmlPath.TabIndex = 4;
            this.btnHtmlPath.Text = "选择Html";
            this.btnHtmlPath.UseVisualStyleBackColor = true;
            this.btnHtmlPath.Click += new System.EventHandler(this.btnHtmlPath_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.InitialDirectory = "../";
            this.openFileDialog1.Title = "选择Html";
            // 
            // tbTitle2Xpath2
            // 
            this.tbTitle2Xpath2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTitle2Xpath2.Location = new System.Drawing.Point(211, 125);
            this.tbTitle2Xpath2.Name = "tbTitle2Xpath2";
            this.tbTitle2Xpath2.Size = new System.Drawing.Size(288, 22);
            this.tbTitle2Xpath2.TabIndex = 5;
            this.tbTitle2Xpath2.Text = "font-size:14.0pt;font-family:楷体_GB2312";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(208, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 14);
            this.label2.TabIndex = 6;
            this.label2.Text = "二级标题style:";
            // 
            // btnTitle2Xpath
            // 
            this.btnTitle2Xpath.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTitle2Xpath.Location = new System.Drawing.Point(611, 125);
            this.btnTitle2Xpath.Name = "btnTitle2Xpath";
            this.btnTitle2Xpath.Size = new System.Drawing.Size(44, 23);
            this.btnTitle2Xpath.TabIndex = 7;
            this.btnTitle2Xpath.Text = "确认";
            this.btnTitle2Xpath.UseVisualStyleBackColor = true;
            this.btnTitle2Xpath.Click += new System.EventHandler(this.btnTitle2Xpath_Click);
            // 
            // tbTitle2Xpath1
            // 
            this.tbTitle2Xpath1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTitle2Xpath1.Location = new System.Drawing.Point(6, 125);
            this.tbTitle2Xpath1.Name = "tbTitle2Xpath1";
            this.tbTitle2Xpath1.Size = new System.Drawing.Size(199, 22);
            this.tbTitle2Xpath1.TabIndex = 8;
            this.tbTitle2Xpath1.Text = "//span[position()<3 and @style=\'";
            // 
            // tbTitle2Xpath3
            // 
            this.tbTitle2Xpath3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTitle2Xpath3.Location = new System.Drawing.Point(505, 125);
            this.tbTitle2Xpath3.Name = "tbTitle2Xpath3";
            this.tbTitle2Xpath3.Size = new System.Drawing.Size(100, 22);
            this.tbTitle2Xpath3.TabIndex = 9;
            this.tbTitle2Xpath3.Text = "\']\"";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 14);
            this.label3.TabIndex = 10;
            this.label3.Text = "二级标题xPath:";
            // 
            // tbTitle1Xpath
            // 
            this.tbTitle1Xpath.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTitle1Xpath.Location = new System.Drawing.Point(6, 36);
            this.tbTitle1Xpath.Multiline = true;
            this.tbTitle1Xpath.Name = "tbTitle1Xpath";
            this.tbTitle1Xpath.Size = new System.Drawing.Size(412, 69);
            this.tbTitle1Xpath.TabIndex = 11;
            this.tbTitle1Xpath.Text = "/html[1]/body[1]/div[@class=\'WordSection2\']//b[1] |/html[1]/body[1]/div[@class=\'W" +
    "ordSection2\']//h1[1]|/html[1]/body[1]/div[@class=\'WordSection2\']//a[1]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 14);
            this.label4.TabIndex = 12;
            this.label4.Text = "一级标题xPath:";
            // 
            // btnTitle1Xpath
            // 
            this.btnTitle1Xpath.Location = new System.Drawing.Point(424, 82);
            this.btnTitle1Xpath.Name = "btnTitle1Xpath";
            this.btnTitle1Xpath.Size = new System.Drawing.Size(44, 23);
            this.btnTitle1Xpath.TabIndex = 13;
            this.btnTitle1Xpath.Text = "确认";
            this.btnTitle1Xpath.UseVisualStyleBackColor = true;
            this.btnTitle1Xpath.Click += new System.EventHandler(this.btnTitle1Xpath_Click);
            // 
            // tbcMode
            // 
            this.tbcMode.Controls.Add(this.tabcontent);
            this.tbcMode.Controls.Add(this.tabCategory);
            this.tbcMode.Location = new System.Drawing.Point(15, 56);
            this.tbcMode.Name = "tbcMode";
            this.tbcMode.SelectedIndex = 0;
            this.tbcMode.Size = new System.Drawing.Size(679, 226);
            this.tbcMode.TabIndex = 14;
            // 
            // tabcontent
            // 
            this.tabcontent.BackColor = System.Drawing.SystemColors.Control;
            this.tabcontent.Controls.Add(this.grpContent);
            this.tabcontent.Location = new System.Drawing.Point(4, 22);
            this.tabcontent.Name = "tabcontent";
            this.tabcontent.Padding = new System.Windows.Forms.Padding(3);
            this.tabcontent.Size = new System.Drawing.Size(671, 200);
            this.tabcontent.TabIndex = 0;
            this.tabcontent.Text = "从正文";
            // 
            // tabCategory
            // 
            this.tabCategory.BackColor = System.Drawing.SystemColors.Control;
            this.tabCategory.Controls.Add(this.grpCatagory);
            this.tabCategory.Location = new System.Drawing.Point(4, 22);
            this.tabCategory.Name = "tabCategory";
            this.tabCategory.Padding = new System.Windows.Forms.Padding(3);
            this.tabCategory.Size = new System.Drawing.Size(671, 200);
            this.tabCategory.TabIndex = 1;
            this.tabCategory.Text = "从目录";
            // 
            // rdbtContent
            // 
            this.rdbtContent.AutoSize = true;
            this.rdbtContent.Checked = true;
            this.rdbtContent.Location = new System.Drawing.Point(6, 16);
            this.rdbtContent.Name = "rdbtContent";
            this.rdbtContent.Size = new System.Drawing.Size(107, 16);
            this.rdbtContent.TabIndex = 15;
            this.rdbtContent.TabStop = true;
            this.rdbtContent.Text = "从正文识别标题";
            this.rdbtContent.UseVisualStyleBackColor = true;
            this.rdbtContent.CheckedChanged += new System.EventHandler(this.rdbtContent_CheckedChanged);
            // 
            // rdbtCatagory
            // 
            this.rdbtCatagory.AutoSize = true;
            this.rdbtCatagory.Location = new System.Drawing.Point(6, 38);
            this.rdbtCatagory.Name = "rdbtCatagory";
            this.rdbtCatagory.Size = new System.Drawing.Size(107, 16);
            this.rdbtCatagory.TabIndex = 16;
            this.rdbtCatagory.Text = "从目录识别标题";
            this.rdbtCatagory.UseVisualStyleBackColor = true;
            this.rdbtCatagory.CheckedChanged += new System.EventHandler(this.rdbtCatagory_CheckedChanged);
            // 
            // grpMode
            // 
            this.grpMode.Controls.Add(this.rdbtCatagory);
            this.grpMode.Controls.Add(this.rdbtContent);
            this.grpMode.Location = new System.Drawing.Point(539, 12);
            this.grpMode.Name = "grpMode";
            this.grpMode.Size = new System.Drawing.Size(139, 60);
            this.grpMode.TabIndex = 17;
            this.grpMode.TabStop = false;
            this.grpMode.Text = "识别模式";
            // 
            // grpContent
            // 
            this.grpContent.Controls.Add(this.tbTitle1Xpath);
            this.grpContent.Controls.Add(this.btnTitle1Xpath);
            this.grpContent.Controls.Add(this.btnTitle2Xpath);
            this.grpContent.Controls.Add(this.tbHtmlPath);
            this.grpContent.Controls.Add(this.tbTitle2Xpath1);
            this.grpContent.Controls.Add(this.label4);
            this.grpContent.Controls.Add(this.label2);
            this.grpContent.Controls.Add(this.label1);
            this.grpContent.Controls.Add(this.tbTitle2Xpath3);
            this.grpContent.Controls.Add(this.btnHtmlPath);
            this.grpContent.Controls.Add(this.tbTitle2Xpath2);
            this.grpContent.Controls.Add(this.label3);
            this.grpContent.Location = new System.Drawing.Point(3, 4);
            this.grpContent.Name = "grpContent";
            this.grpContent.Size = new System.Drawing.Size(660, 190);
            this.grpContent.TabIndex = 18;
            this.grpContent.TabStop = false;
            // 
            // grpCatagory
            // 
            this.grpCatagory.Location = new System.Drawing.Point(6, 6);
            this.grpCatagory.Name = "grpCatagory";
            this.grpCatagory.Size = new System.Drawing.Size(659, 188);
            this.grpCatagory.TabIndex = 18;
            this.grpCatagory.TabStop = false;
            // 
            // frmWordRead
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 394);
            this.Controls.Add(this.grpMode);
            this.Controls.Add(this.tbcMode);
            this.Controls.Add(this.btnSQLTest);
            this.Controls.Add(this.btnWordRead);
            this.Name = "frmWordRead";
            this.Text = "法规录入";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tbcMode.ResumeLayout(false);
            this.tabcontent.ResumeLayout(false);
            this.tabCategory.ResumeLayout(false);
            this.grpMode.ResumeLayout(false);
            this.grpMode.PerformLayout();
            this.grpContent.ResumeLayout(false);
            this.grpContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnWordRead;
        private System.Windows.Forms.Button btnSQLTest;
        private System.Windows.Forms.TextBox tbHtmlPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHtmlPath;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox tbTitle2Xpath2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTitle2Xpath;
        private System.Windows.Forms.TextBox tbTitle2Xpath1;
        private System.Windows.Forms.TextBox tbTitle2Xpath3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTitle1Xpath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTitle1Xpath;
        private System.Windows.Forms.TabControl tbcMode;
        private System.Windows.Forms.TabPage tabcontent;
        private System.Windows.Forms.TabPage tabCategory;
        private System.Windows.Forms.RadioButton rdbtContent;
        private System.Windows.Forms.RadioButton rdbtCatagory;
        private System.Windows.Forms.GroupBox grpMode;
        private System.Windows.Forms.GroupBox grpContent;
        private System.Windows.Forms.GroupBox grpCatagory;
    }
}


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
            this.tbHtmlPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHtmlPath = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tbTitle2Xpath2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTitle2Xpath1 = new System.Windows.Forms.TextBox();
            this.tbTitle2Xpath3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTitle1Xpath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbcMode = new System.Windows.Forms.TabControl();
            this.tabcontent = new System.Windows.Forms.TabPage();
            this.grpContent = new System.Windows.Forms.GroupBox();
            this.tabCategory = new System.Windows.Forms.TabPage();
            this.grpCatagory = new System.Windows.Forms.GroupBox();
            this.rdbtContent = new System.Windows.Forms.RadioButton();
            this.rdbtCatagory = new System.Windows.Forms.RadioButton();
            this.grpMode = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbParentTitleCnFolder = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbParentIDfolder = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbParentDepth = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbParentGuid = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.数据库连接测试ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.单条录入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tbFilesPath = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbcMode.SuspendLayout();
            this.tabcontent.SuspendLayout();
            this.grpContent.SuspendLayout();
            this.tabCategory.SuspendLayout();
            this.grpMode.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnWordRead
            // 
            this.btnWordRead.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWordRead.Location = new System.Drawing.Point(496, 47);
            this.btnWordRead.Name = "btnWordRead";
            this.btnWordRead.Size = new System.Drawing.Size(72, 25);
            this.btnWordRead.TabIndex = 0;
            this.btnWordRead.Text = "文档录入";
            this.btnWordRead.UseVisualStyleBackColor = true;
            this.btnWordRead.Click += new System.EventHandler(this.btnWordRead_Click);
            // 
            // tbHtmlPath
            // 
            this.tbHtmlPath.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHtmlPath.Location = new System.Drawing.Point(15, 100);
            this.tbHtmlPath.Name = "tbHtmlPath";
            this.tbHtmlPath.Size = new System.Drawing.Size(284, 24);
            this.tbHtmlPath.TabIndex = 2;
            this.tbHtmlPath.Text = "../../../htmlRcgTest/Part3_07.htm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Html 路径:";
            // 
            // btnHtmlPath
            // 
            this.btnHtmlPath.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHtmlPath.Location = new System.Drawing.Point(306, 98);
            this.btnHtmlPath.Name = "btnHtmlPath";
            this.btnHtmlPath.Size = new System.Drawing.Size(74, 25);
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
            this.tbTitle2Xpath2.Location = new System.Drawing.Point(6, 181);
            this.tbTitle2Xpath2.Name = "tbTitle2Xpath2";
            this.tbTitle2Xpath2.Size = new System.Drawing.Size(339, 24);
            this.tbTitle2Xpath2.TabIndex = 5;
            this.tbTitle2Xpath2.Text = "font-size:14.0pt;font-family:楷体_GB2312";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "二级标题style:";
            // 
            // tbTitle2Xpath1
            // 
            this.tbTitle2Xpath1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTitle2Xpath1.Location = new System.Drawing.Point(6, 134);
            this.tbTitle2Xpath1.Name = "tbTitle2Xpath1";
            this.tbTitle2Xpath1.Size = new System.Drawing.Size(339, 24);
            this.tbTitle2Xpath1.TabIndex = 8;
            this.tbTitle2Xpath1.Text = "//span[position()<3 and @style=\'";
            // 
            // tbTitle2Xpath3
            // 
            this.tbTitle2Xpath3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTitle2Xpath3.Location = new System.Drawing.Point(5, 221);
            this.tbTitle2Xpath3.Name = "tbTitle2Xpath3";
            this.tbTitle2Xpath3.Size = new System.Drawing.Size(339, 24);
            this.tbTitle2Xpath3.TabIndex = 9;
            this.tbTitle2Xpath3.Text = "\']";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "二级标题xPath:";
            // 
            // tbTitle1Xpath
            // 
            this.tbTitle1Xpath.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTitle1Xpath.Location = new System.Drawing.Point(6, 38);
            this.tbTitle1Xpath.Multiline = true;
            this.tbTitle1Xpath.Name = "tbTitle1Xpath";
            this.tbTitle1Xpath.Size = new System.Drawing.Size(338, 74);
            this.tbTitle1Xpath.TabIndex = 11;
            this.tbTitle1Xpath.Text = "/html[1]/body[1]/div[@class=\'WordSection2\']//b[1] |/html[1]/body[1]/div[@class=\'W" +
    "ordSection2\']//h1[1]|/html[1]/body[1]/div[@class=\'WordSection2\']//a[1]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "一级标题xPath:";
            // 
            // tbcMode
            // 
            this.tbcMode.Controls.Add(this.tabcontent);
            this.tbcMode.Controls.Add(this.tabCategory);
            this.tbcMode.Location = new System.Drawing.Point(341, 130);
            this.tbcMode.Name = "tbcMode";
            this.tbcMode.SelectedIndex = 0;
            this.tbcMode.Size = new System.Drawing.Size(364, 333);
            this.tbcMode.TabIndex = 14;
            // 
            // tabcontent
            // 
            this.tabcontent.BackColor = System.Drawing.SystemColors.Control;
            this.tabcontent.Controls.Add(this.grpContent);
            this.tabcontent.Location = new System.Drawing.Point(4, 23);
            this.tabcontent.Name = "tabcontent";
            this.tabcontent.Padding = new System.Windows.Forms.Padding(3);
            this.tabcontent.Size = new System.Drawing.Size(356, 306);
            this.tabcontent.TabIndex = 0;
            this.tabcontent.Text = "从正文";
            // 
            // grpContent
            // 
            this.grpContent.Controls.Add(this.tbTitle1Xpath);
            this.grpContent.Controls.Add(this.tbTitle2Xpath1);
            this.grpContent.Controls.Add(this.label4);
            this.grpContent.Controls.Add(this.label2);
            this.grpContent.Controls.Add(this.tbTitle2Xpath3);
            this.grpContent.Controls.Add(this.tbTitle2Xpath2);
            this.grpContent.Controls.Add(this.label3);
            this.grpContent.Location = new System.Drawing.Point(3, 4);
            this.grpContent.Name = "grpContent";
            this.grpContent.Size = new System.Drawing.Size(350, 296);
            this.grpContent.TabIndex = 18;
            this.grpContent.TabStop = false;
            // 
            // tabCategory
            // 
            this.tabCategory.BackColor = System.Drawing.SystemColors.Control;
            this.tabCategory.Controls.Add(this.grpCatagory);
            this.tabCategory.Location = new System.Drawing.Point(4, 23);
            this.tabCategory.Name = "tabCategory";
            this.tabCategory.Padding = new System.Windows.Forms.Padding(3);
            this.tabCategory.Size = new System.Drawing.Size(451, 306);
            this.tabCategory.TabIndex = 1;
            this.tabCategory.Text = "从目录";
            // 
            // grpCatagory
            // 
            this.grpCatagory.Location = new System.Drawing.Point(7, 7);
            this.grpCatagory.Name = "grpCatagory";
            this.grpCatagory.Size = new System.Drawing.Size(769, 204);
            this.grpCatagory.TabIndex = 18;
            this.grpCatagory.TabStop = false;
            // 
            // rdbtContent
            // 
            this.rdbtContent.AutoSize = true;
            this.rdbtContent.Checked = true;
            this.rdbtContent.Location = new System.Drawing.Point(7, 17);
            this.rdbtContent.Name = "rdbtContent";
            this.rdbtContent.Size = new System.Drawing.Size(123, 18);
            this.rdbtContent.TabIndex = 15;
            this.rdbtContent.TabStop = true;
            this.rdbtContent.Text = "从正文识别标题";
            this.rdbtContent.UseVisualStyleBackColor = true;
            this.rdbtContent.CheckedChanged += new System.EventHandler(this.rdbtContent_CheckedChanged);
            // 
            // rdbtCatagory
            // 
            this.rdbtCatagory.AutoSize = true;
            this.rdbtCatagory.Location = new System.Drawing.Point(7, 41);
            this.rdbtCatagory.Name = "rdbtCatagory";
            this.rdbtCatagory.Size = new System.Drawing.Size(123, 18);
            this.rdbtCatagory.TabIndex = 16;
            this.rdbtCatagory.Text = "从目录识别标题";
            this.rdbtCatagory.UseVisualStyleBackColor = true;
            this.rdbtCatagory.CheckedChanged += new System.EventHandler(this.rdbtCatagory_CheckedChanged);
            // 
            // grpMode
            // 
            this.grpMode.Controls.Add(this.rdbtCatagory);
            this.grpMode.Controls.Add(this.rdbtContent);
            this.grpMode.Location = new System.Drawing.Point(574, 33);
            this.grpMode.Name = "grpMode";
            this.grpMode.Size = new System.Drawing.Size(135, 63);
            this.grpMode.TabIndex = 17;
            this.grpMode.TabStop = false;
            this.grpMode.Text = "识别模式";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tbParentTitleCnFolder);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbParentIDfolder);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbParentDepth);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbParentGuid);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(15, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 333);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "父节点信息";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 228);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 17);
            this.label8.TabIndex = 26;
            this.label8.Text = "父节点TitleCnFloder:";
            // 
            // tbParentTitleCnFolder
            // 
            this.tbParentTitleCnFolder.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbParentTitleCnFolder.Location = new System.Drawing.Point(9, 248);
            this.tbParentTitleCnFolder.Multiline = true;
            this.tbParentTitleCnFolder.Name = "tbParentTitleCnFolder";
            this.tbParentTitleCnFolder.Size = new System.Drawing.Size(308, 68);
            this.tbParentTitleCnFolder.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 17);
            this.label7.TabIndex = 24;
            this.label7.Text = "父节点IDfolder:";
            // 
            // tbParentIDfolder
            // 
            this.tbParentIDfolder.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbParentIDfolder.Location = new System.Drawing.Point(9, 129);
            this.tbParentIDfolder.Multiline = true;
            this.tbParentIDfolder.Name = "tbParentIDfolder";
            this.tbParentIDfolder.Size = new System.Drawing.Size(308, 96);
            this.tbParentIDfolder.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "父节点Depth:";
            // 
            // tbParentDepth
            // 
            this.tbParentDepth.Location = new System.Drawing.Point(9, 84);
            this.tbParentDepth.Name = "tbParentDepth";
            this.tbParentDepth.Size = new System.Drawing.Size(86, 23);
            this.tbParentDepth.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "父节点Guid:";
            // 
            // tbParentGuid
            // 
            this.tbParentGuid.Location = new System.Drawing.Point(9, 38);
            this.tbParentGuid.Name = "tbParentGuid";
            this.tbParentGuid.Size = new System.Drawing.Size(308, 23);
            this.tbParentGuid.TabIndex = 19;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.数据库连接测试ToolStripMenuItem,
            this.单条录入ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(721, 28);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 数据库连接测试ToolStripMenuItem
            // 
            this.数据库连接测试ToolStripMenuItem.Name = "数据库连接测试ToolStripMenuItem";
            this.数据库连接测试ToolStripMenuItem.Size = new System.Drawing.Size(119, 24);
            this.数据库连接测试ToolStripMenuItem.Text = "数据库连接测试";
            this.数据库连接测试ToolStripMenuItem.Click += new System.EventHandler(this.数据库连接测试ToolStripMenuItem_Click);
            // 
            // 单条录入ToolStripMenuItem
            // 
            this.单条录入ToolStripMenuItem.Name = "单条录入ToolStripMenuItem";
            this.单条录入ToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.单条录入ToolStripMenuItem.Text = "单条录入";
            this.单条录入ToolStripMenuItem.Click += new System.EventHandler(this.单条录入ToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 480);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(721, 22);
            this.statusStrip1.TabIndex = 20;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // tbFilesPath
            // 
            this.tbFilesPath.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFilesPath.Location = new System.Drawing.Point(398, 100);
            this.tbFilesPath.Name = "tbFilesPath";
            this.tbFilesPath.Size = new System.Drawing.Size(306, 24);
            this.tbFilesPath.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(400, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(168, 17);
            this.label9.TabIndex = 22;
            this.label9.Text = "图片文件xxx.files所在路径:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(15, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(468, 24);
            this.textBox1.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 17);
            this.label10.TabIndex = 24;
            this.label10.Text = "连接字符串:";
            // 
            // frmWordRead
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 502);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbFilesPath);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpMode);
            this.Controls.Add(this.tbHtmlPath);
            this.Controls.Add(this.tbcMode);
            this.Controls.Add(this.btnWordRead);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHtmlPath);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmWordRead";
            this.Text = "法规录入";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tbcMode.ResumeLayout(false);
            this.tabcontent.ResumeLayout(false);
            this.grpContent.ResumeLayout(false);
            this.grpContent.PerformLayout();
            this.tabCategory.ResumeLayout(false);
            this.grpMode.ResumeLayout(false);
            this.grpMode.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWordRead;
        private System.Windows.Forms.TextBox tbHtmlPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHtmlPath;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox tbTitle2Xpath2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTitle2Xpath1;
        private System.Windows.Forms.TextBox tbTitle2Xpath3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTitle1Xpath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tbcMode;
        private System.Windows.Forms.TabPage tabcontent;
        private System.Windows.Forms.TabPage tabCategory;
        private System.Windows.Forms.RadioButton rdbtContent;
        private System.Windows.Forms.RadioButton rdbtCatagory;
        private System.Windows.Forms.GroupBox grpMode;
        private System.Windows.Forms.GroupBox grpContent;
        private System.Windows.Forms.GroupBox grpCatagory;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbParentGuid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbParentDepth;
        private System.Windows.Forms.TextBox tbParentIDfolder;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbParentTitleCnFolder;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 单条录入ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 数据库连接测试ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TextBox tbFilesPath;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label10;
    }
}


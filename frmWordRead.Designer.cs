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
            this.tbTitle2SpanStyle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTitle2Xpath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTitle1Xpath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbcMode = new System.Windows.Forms.TabControl();
            this.tabRecognize = new System.Windows.Forms.TabPage();
            this.grpRecognize = new System.Windows.Forms.GroupBox();
            this.tbTitle2TagName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lblTitle1TagName = new System.Windows.Forms.Label();
            this.tbTitle1TagName = new System.Windows.Forms.TextBox();
            this.tbTitle1SpanStyle = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabInfo = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.tbTitle1Guids = new System.Windows.Forms.TextBox();
            this.rdbtTitle1Bold = new System.Windows.Forms.RadioButton();
            this.rdbtTitleHTag = new System.Windows.Forms.RadioButton();
            this.grpMode = new System.Windows.Forms.GroupBox();
            this.rdbtTitleSpanStyle = new System.Windows.Forms.RadioButton();
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
            this.menuSQLTest = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSingle = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUpdateData = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCount = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tbFilesPath = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.grpConnectStr = new System.Windows.Forms.GroupBox();
            this.rdbtConStrLocal_work = new System.Windows.Forms.RadioButton();
            this.rdbtConStrLocal = new System.Windows.Forms.RadioButton();
            this.rdbtConStrServer = new System.Windows.Forms.RadioButton();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnReDo = new System.Windows.Forms.Button();
            this.treeConventionCount = new System.Windows.Forms.TreeView();
            this.tbcMode.SuspendLayout();
            this.tabRecognize.SuspendLayout();
            this.grpRecognize.SuspendLayout();
            this.tabInfo.SuspendLayout();
            this.grpMode.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.grpConnectStr.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnWordRead
            // 
            this.btnWordRead.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnWordRead.Location = new System.Drawing.Point(493, 36);
            this.btnWordRead.Name = "btnWordRead";
            this.btnWordRead.Size = new System.Drawing.Size(65, 23);
            this.btnWordRead.TabIndex = 0;
            this.btnWordRead.Text = "文档录入";
            this.btnWordRead.UseVisualStyleBackColor = true;
            this.btnWordRead.Click += new System.EventHandler(this.btnWordRead_Click);
            // 
            // tbHtmlPath
            // 
            this.tbHtmlPath.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHtmlPath.Location = new System.Drawing.Point(13, 92);
            this.tbHtmlPath.Name = "tbHtmlPath";
            this.tbHtmlPath.Size = new System.Drawing.Size(273, 22);
            this.tbHtmlPath.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(10, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Html 路径:";
            // 
            // btnHtmlPath
            // 
            this.btnHtmlPath.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnHtmlPath.Location = new System.Drawing.Point(294, 91);
            this.btnHtmlPath.Name = "btnHtmlPath";
            this.btnHtmlPath.Size = new System.Drawing.Size(41, 23);
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
            // tbTitle2SpanStyle
            // 
            this.tbTitle2SpanStyle.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTitle2SpanStyle.Location = new System.Drawing.Point(5, 196);
            this.tbTitle2SpanStyle.Multiline = true;
            this.tbTitle2SpanStyle.Name = "tbTitle2SpanStyle";
            this.tbTitle2SpanStyle.Size = new System.Drawing.Size(302, 26);
            this.tbTitle2SpanStyle.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "二级标题Span Style:";
            // 
            // tbTitle2Xpath
            // 
            this.tbTitle2Xpath.Enabled = false;
            this.tbTitle2Xpath.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTitle2Xpath.Location = new System.Drawing.Point(6, 136);
            this.tbTitle2Xpath.Multiline = true;
            this.tbTitle2Xpath.Name = "tbTitle2Xpath";
            this.tbTitle2Xpath.Size = new System.Drawing.Size(386, 39);
            this.tbTitle2Xpath.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "二级标题xPath:";
            // 
            // tbTitle1Xpath
            // 
            this.tbTitle1Xpath.Enabled = false;
            this.tbTitle1Xpath.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTitle1Xpath.Location = new System.Drawing.Point(5, 31);
            this.tbTitle1Xpath.Multiline = true;
            this.tbTitle1Xpath.Name = "tbTitle1Xpath";
            this.tbTitle1Xpath.Size = new System.Drawing.Size(387, 39);
            this.tbTitle1Xpath.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "一级标题xPath:";
            // 
            // tbcMode
            // 
            this.tbcMode.Controls.Add(this.tabRecognize);
            this.tbcMode.Controls.Add(this.tabInfo);
            this.tbcMode.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbcMode.Location = new System.Drawing.Point(294, 148);
            this.tbcMode.Name = "tbcMode";
            this.tbcMode.SelectedIndex = 0;
            this.tbcMode.Size = new System.Drawing.Size(412, 290);
            this.tbcMode.TabIndex = 14;
            // 
            // tabRecognize
            // 
            this.tabRecognize.BackColor = System.Drawing.SystemColors.Control;
            this.tabRecognize.Controls.Add(this.grpRecognize);
            this.tabRecognize.Location = new System.Drawing.Point(4, 26);
            this.tabRecognize.Name = "tabRecognize";
            this.tabRecognize.Padding = new System.Windows.Forms.Padding(3);
            this.tabRecognize.Size = new System.Drawing.Size(404, 260);
            this.tabRecognize.TabIndex = 0;
            this.tabRecognize.Text = "从正文";
            // 
            // grpRecognize
            // 
            this.grpRecognize.Controls.Add(this.tbTitle2TagName);
            this.grpRecognize.Controls.Add(this.label12);
            this.grpRecognize.Controls.Add(this.lblTitle1TagName);
            this.grpRecognize.Controls.Add(this.tbTitle1TagName);
            this.grpRecognize.Controls.Add(this.tbTitle1SpanStyle);
            this.grpRecognize.Controls.Add(this.label10);
            this.grpRecognize.Controls.Add(this.tbTitle1Xpath);
            this.grpRecognize.Controls.Add(this.tbTitle2Xpath);
            this.grpRecognize.Controls.Add(this.label4);
            this.grpRecognize.Controls.Add(this.label2);
            this.grpRecognize.Controls.Add(this.tbTitle2SpanStyle);
            this.grpRecognize.Controls.Add(this.label3);
            this.grpRecognize.Location = new System.Drawing.Point(3, 15);
            this.grpRecognize.Name = "grpRecognize";
            this.grpRecognize.Size = new System.Drawing.Size(398, 239);
            this.grpRecognize.TabIndex = 18;
            this.grpRecognize.TabStop = false;
            // 
            // tbTitle2TagName
            // 
            this.tbTitle2TagName.Enabled = false;
            this.tbTitle2TagName.Location = new System.Drawing.Point(313, 195);
            this.tbTitle2TagName.Multiline = true;
            this.tbTitle2TagName.Name = "tbTitle2TagName";
            this.tbTitle2TagName.Size = new System.Drawing.Size(79, 27);
            this.tbTitle2TagName.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(274, 178);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(119, 17);
            this.label12.TabIndex = 24;
            this.label12.Text = "二级标题唯一标签名:";
            // 
            // lblTitle1TagName
            // 
            this.lblTitle1TagName.AutoSize = true;
            this.lblTitle1TagName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle1TagName.Location = new System.Drawing.Point(278, 73);
            this.lblTitle1TagName.Name = "lblTitle1TagName";
            this.lblTitle1TagName.Size = new System.Drawing.Size(119, 17);
            this.lblTitle1TagName.TabIndex = 23;
            this.lblTitle1TagName.Text = "一级标题唯一标签名:";
            // 
            // tbTitle1TagName
            // 
            this.tbTitle1TagName.Enabled = false;
            this.tbTitle1TagName.Location = new System.Drawing.Point(313, 90);
            this.tbTitle1TagName.Multiline = true;
            this.tbTitle1TagName.Name = "tbTitle1TagName";
            this.tbTitle1TagName.Size = new System.Drawing.Size(79, 27);
            this.tbTitle1TagName.TabIndex = 22;
            // 
            // tbTitle1SpanStyle
            // 
            this.tbTitle1SpanStyle.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTitle1SpanStyle.Location = new System.Drawing.Point(6, 91);
            this.tbTitle1SpanStyle.Multiline = true;
            this.tbTitle1SpanStyle.Name = "tbTitle1SpanStyle";
            this.tbTitle1SpanStyle.Size = new System.Drawing.Size(302, 26);
            this.tbTitle1SpanStyle.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 17);
            this.label10.TabIndex = 14;
            this.label10.Text = "一级标题Span Style:";
            // 
            // tabInfo
            // 
            this.tabInfo.BackColor = System.Drawing.SystemColors.Control;
            this.tabInfo.Controls.Add(this.label11);
            this.tabInfo.Controls.Add(this.tbTitle1Guids);
            this.tabInfo.Location = new System.Drawing.Point(4, 26);
            this.tabInfo.Name = "tabInfo";
            this.tabInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabInfo.Size = new System.Drawing.Size(404, 260);
            this.tabInfo.TabIndex = 1;
            this.tabInfo.Text = "生成条目信息";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(221, 17);
            this.label11.TabIndex = 21;
            this.label11.Text = "所生成的一级标题的Guids和二级标题：";
            // 
            // tbTitle1Guids
            // 
            this.tbTitle1Guids.Location = new System.Drawing.Point(9, 24);
            this.tbTitle1Guids.Multiline = true;
            this.tbTitle1Guids.Name = "tbTitle1Guids";
            this.tbTitle1Guids.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbTitle1Guids.Size = new System.Drawing.Size(389, 229);
            this.tbTitle1Guids.TabIndex = 0;
            // 
            // rdbtTitle1Bold
            // 
            this.rdbtTitle1Bold.AutoSize = true;
            this.rdbtTitle1Bold.Location = new System.Drawing.Point(6, 16);
            this.rdbtTitle1Bold.Name = "rdbtTitle1Bold";
            this.rdbtTitle1Bold.Size = new System.Drawing.Size(114, 21);
            this.rdbtTitle1Bold.TabIndex = 15;
            this.rdbtTitle1Bold.Text = "从标题class属性";
            this.rdbtTitle1Bold.UseVisualStyleBackColor = true;
            this.rdbtTitle1Bold.CheckedChanged += new System.EventHandler(this.rdbtTitle1Bold_CheckedChanged);
            // 
            // rdbtTitleHTag
            // 
            this.rdbtTitleHTag.AutoSize = true;
            this.rdbtTitleHTag.Location = new System.Drawing.Point(6, 61);
            this.rdbtTitleHTag.Name = "rdbtTitleHTag";
            this.rdbtTitleHTag.Size = new System.Drawing.Size(141, 21);
            this.rdbtTitleHTag.TabIndex = 16;
            this.rdbtTitleHTag.Text = "从标题h标签识别标题";
            this.rdbtTitleHTag.UseVisualStyleBackColor = true;
            this.rdbtTitleHTag.CheckedChanged += new System.EventHandler(this.rdbtTitleTag_CheckedChanged);
            // 
            // grpMode
            // 
            this.grpMode.Controls.Add(this.rdbtTitleSpanStyle);
            this.grpMode.Controls.Add(this.rdbtTitleHTag);
            this.grpMode.Controls.Add(this.rdbtTitle1Bold);
            this.grpMode.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grpMode.Location = new System.Drawing.Point(561, 30);
            this.grpMode.Name = "grpMode";
            this.grpMode.Size = new System.Drawing.Size(145, 84);
            this.grpMode.TabIndex = 17;
            this.grpMode.TabStop = false;
            this.grpMode.Text = "识别模式";
            // 
            // rdbtTitleSpanStyle
            // 
            this.rdbtTitleSpanStyle.AutoSize = true;
            this.rdbtTitleSpanStyle.Checked = true;
            this.rdbtTitleSpanStyle.Location = new System.Drawing.Point(6, 38);
            this.rdbtTitleSpanStyle.Name = "rdbtTitleSpanStyle";
            this.rdbtTitleSpanStyle.Size = new System.Drawing.Size(142, 21);
            this.rdbtTitleSpanStyle.TabIndex = 17;
            this.rdbtTitleSpanStyle.TabStop = true;
            this.rdbtTitleSpanStyle.Text = "从标题SpanStyle识别";
            this.rdbtTitleSpanStyle.UseVisualStyleBackColor = true;
            this.rdbtTitleSpanStyle.CheckedChanged += new System.EventHandler(this.rdbtTitleSpanStyle_CheckedChanged);
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
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(13, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 307);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "父节点信息";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(8, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 17);
            this.label8.TabIndex = 26;
            this.label8.Text = "父节点TitleCnFloder:";
            // 
            // tbParentTitleCnFolder
            // 
            this.tbParentTitleCnFolder.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbParentTitleCnFolder.Location = new System.Drawing.Point(8, 229);
            this.tbParentTitleCnFolder.Multiline = true;
            this.tbParentTitleCnFolder.Name = "tbParentTitleCnFolder";
            this.tbParentTitleCnFolder.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbParentTitleCnFolder.Size = new System.Drawing.Size(265, 63);
            this.tbParentTitleCnFolder.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(8, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 17);
            this.label7.TabIndex = 24;
            this.label7.Text = "父节点IDfolder:";
            // 
            // tbParentIDfolder
            // 
            this.tbParentIDfolder.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbParentIDfolder.Location = new System.Drawing.Point(8, 119);
            this.tbParentIDfolder.Multiline = true;
            this.tbParentIDfolder.Name = "tbParentIDfolder";
            this.tbParentIDfolder.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbParentIDfolder.Size = new System.Drawing.Size(265, 89);
            this.tbParentIDfolder.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(8, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "父节点Depth:";
            // 
            // tbParentDepth
            // 
            this.tbParentDepth.Location = new System.Drawing.Point(8, 78);
            this.tbParentDepth.Name = "tbParentDepth";
            this.tbParentDepth.Size = new System.Drawing.Size(74, 23);
            this.tbParentDepth.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(8, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "父节点Guid:";
            // 
            // tbParentGuid
            // 
            this.tbParentGuid.Location = new System.Drawing.Point(8, 35);
            this.tbParentGuid.Name = "tbParentGuid";
            this.tbParentGuid.Size = new System.Drawing.Size(265, 23);
            this.tbParentGuid.TabIndex = 19;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSQLTest,
            this.menuSingle,
            this.menuUpdateData,
            this.menuCount});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(722, 25);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuSQLTest
            // 
            this.menuSQLTest.Name = "menuSQLTest";
            this.menuSQLTest.Size = new System.Drawing.Size(104, 21);
            this.menuSQLTest.Text = "数据库连接测试";
            this.menuSQLTest.Click += new System.EventHandler(this.menuSQLTest_Click);
            // 
            // menuSingle
            // 
            this.menuSingle.Name = "menuSingle";
            this.menuSingle.Size = new System.Drawing.Size(68, 21);
            this.menuSingle.Text = "单条录入";
            this.menuSingle.Click += new System.EventHandler(this.menuSingle_Click);
            // 
            // menuUpdateData
            // 
            this.menuUpdateData.Name = "menuUpdateData";
            this.menuUpdateData.Size = new System.Drawing.Size(80, 21);
            this.menuUpdateData.Text = "修改脏数据";
            this.menuUpdateData.Click += new System.EventHandler(this.menuUpdateData_Click);
            // 
            // menuCount
            // 
            this.menuCount.Name = "menuCount";
            this.menuCount.Size = new System.Drawing.Size(68, 21);
            this.menuCount.Text = "条目统计";
            this.menuCount.Click += new System.EventHandler(this.menuCount_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 441);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
            this.statusStrip1.Size = new System.Drawing.Size(722, 22);
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
            this.tbFilesPath.Location = new System.Drawing.Point(344, 120);
            this.tbFilesPath.Name = "tbFilesPath";
            this.tbFilesPath.Size = new System.Drawing.Size(360, 22);
            this.tbFilesPath.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(341, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 17);
            this.label9.TabIndex = 22;
            this.label9.Text = "图片文件所在路径:";
            // 
            // grpConnectStr
            // 
            this.grpConnectStr.Controls.Add(this.rdbtConStrLocal_work);
            this.grpConnectStr.Controls.Add(this.rdbtConStrLocal);
            this.grpConnectStr.Controls.Add(this.rdbtConStrServer);
            this.grpConnectStr.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grpConnectStr.Location = new System.Drawing.Point(6, 28);
            this.grpConnectStr.Name = "grpConnectStr";
            this.grpConnectStr.Size = new System.Drawing.Size(484, 43);
            this.grpConnectStr.TabIndex = 25;
            this.grpConnectStr.TabStop = false;
            this.grpConnectStr.Text = "连接字符串：";
            // 
            // rdbtConStrLocal_work
            // 
            this.rdbtConStrLocal_work.AutoSize = true;
            this.rdbtConStrLocal_work.Location = new System.Drawing.Point(335, 16);
            this.rdbtConStrLocal_work.Name = "rdbtConStrLocal_work";
            this.rdbtConStrLocal_work.Size = new System.Drawing.Size(134, 21);
            this.rdbtConStrLocal_work.TabIndex = 28;
            this.rdbtConStrLocal_work.Text = "公司电脑本地数据库";
            this.rdbtConStrLocal_work.UseVisualStyleBackColor = true;
            this.rdbtConStrLocal_work.CheckedChanged += new System.EventHandler(this.rdbtConStrLocal_work_CheckedChanged);
            // 
            // rdbtConStrLocal
            // 
            this.rdbtConStrLocal.AutoSize = true;
            this.rdbtConStrLocal.Location = new System.Drawing.Point(166, 16);
            this.rdbtConStrLocal.Name = "rdbtConStrLocal";
            this.rdbtConStrLocal.Size = new System.Drawing.Size(134, 21);
            this.rdbtConStrLocal.TabIndex = 27;
            this.rdbtConStrLocal.Text = "我的电脑本地数据库";
            this.rdbtConStrLocal.UseVisualStyleBackColor = true;
            this.rdbtConStrLocal.CheckedChanged += new System.EventHandler(this.rdbtConStrLocal_CheckedChanged);
            // 
            // rdbtConStrServer
            // 
            this.rdbtConStrServer.AutoSize = true;
            this.rdbtConStrServer.Checked = true;
            this.rdbtConStrServer.Location = new System.Drawing.Point(7, 16);
            this.rdbtConStrServer.Name = "rdbtConStrServer";
            this.rdbtConStrServer.Size = new System.Drawing.Size(122, 21);
            this.rdbtConStrServer.TabIndex = 26;
            this.rdbtConStrServer.TabStop = true;
            this.rdbtConStrServer.Text = "正式服务器数据库";
            this.rdbtConStrServer.UseVisualStyleBackColor = true;
            this.rdbtConStrServer.CheckedChanged += new System.EventHandler(this.rdbtConStrServer_CheckedChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnUpdate.Location = new System.Drawing.Point(493, 63);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(65, 23);
            this.btnUpdate.TabIndex = 26;
            this.btnUpdate.Text = "数据提交";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnReDo
            // 
            this.btnReDo.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnReDo.Location = new System.Drawing.Point(493, 89);
            this.btnReDo.Name = "btnReDo";
            this.btnReDo.Size = new System.Drawing.Size(65, 23);
            this.btnReDo.TabIndex = 27;
            this.btnReDo.Text = "撤销提交";
            this.btnReDo.UseVisualStyleBackColor = true;
            this.btnReDo.Click += new System.EventHandler(this.btnReDo_Click);
            // 
            // treeConventionCount
            // 
            this.treeConventionCount.Location = new System.Drawing.Point(715, 36);
            this.treeConventionCount.Name = "treeConventionCount";
            this.treeConventionCount.Size = new System.Drawing.Size(259, 398);
            this.treeConventionCount.TabIndex = 28;
            // 
            // frmWordRead
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 463);
            this.Controls.Add(this.treeConventionCount);
            this.Controls.Add(this.btnReDo);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.grpConnectStr);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmWordRead";
            this.Text = "法规录入";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tbcMode.ResumeLayout(false);
            this.tabRecognize.ResumeLayout(false);
            this.grpRecognize.ResumeLayout(false);
            this.grpRecognize.PerformLayout();
            this.tabInfo.ResumeLayout(false);
            this.tabInfo.PerformLayout();
            this.grpMode.ResumeLayout(false);
            this.grpMode.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.grpConnectStr.ResumeLayout(false);
            this.grpConnectStr.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWordRead;
        private System.Windows.Forms.TextBox tbHtmlPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHtmlPath;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox tbTitle2SpanStyle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTitle2Xpath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTitle1Xpath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tbcMode;
        private System.Windows.Forms.TabPage tabRecognize;
        private System.Windows.Forms.TabPage tabInfo;
        private System.Windows.Forms.RadioButton rdbtTitle1Bold;
        private System.Windows.Forms.RadioButton rdbtTitleHTag;
        private System.Windows.Forms.GroupBox grpMode;
        private System.Windows.Forms.GroupBox grpRecognize;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuSingle;
        private System.Windows.Forms.ToolStripMenuItem menuSQLTest;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox grpConnectStr;
        private System.Windows.Forms.RadioButton rdbtConStrLocal_work;
        private System.Windows.Forms.RadioButton rdbtConStrLocal;
        private System.Windows.Forms.RadioButton rdbtConStrServer;
        private System.Windows.Forms.Button btnUpdate;
        internal System.Windows.Forms.TextBox tbParentGuid;
        internal System.Windows.Forms.TextBox tbParentDepth;
        internal System.Windows.Forms.TextBox tbParentIDfolder;
        internal System.Windows.Forms.TextBox tbParentTitleCnFolder;
        private System.Windows.Forms.RadioButton rdbtTitleSpanStyle;
        private System.Windows.Forms.TextBox tbTitle1SpanStyle;
        private System.Windows.Forms.Label label10;
        internal System.Windows.Forms.TextBox tbTitle2TagName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblTitle1TagName;
        internal System.Windows.Forms.TextBox tbTitle1TagName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbTitle1Guids;
        private System.Windows.Forms.Button btnReDo;
        internal System.Windows.Forms.TextBox tbFilesPath;
        private System.Windows.Forms.ToolStripMenuItem menuUpdateData;
        private System.Windows.Forms.ToolStripMenuItem menuCount;
        private System.Windows.Forms.TreeView treeConventionCount;
    }
}


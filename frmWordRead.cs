using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using System.Text.RegularExpressions;
using System.IO;
using System.Data.SqlClient;
namespace WordRead
{
    public partial class frmWordRead : Form
    {
        internal ConventionRead conventionRead = new ConventionRead();
        internal frmSingleAdd singleAdd;
        internal ReturnInfo info;
        //SQLUtils sqlUtils;
        public frmWordRead()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.tbParentGuid.Text = "4a2d1293-2f13-46da-9b0c-ae14c99fa6a0";
            this.tbParentDepth.Text = "3";
            this.tbParentIDfolder.Text = "#f088ad64-8a9e-4ef6-a3e3-ac872a380283#ea00e0c5-53ca-4ce3-80b6-ff727c27f0b0#8addb82d-dd27-456b-9ff2-bb179bacb549#4a2d1293-2f13-46da-9b0c-ae14c99fa6a0";
            this.tbParentTitleCnFolder.Text = "0#@`船舶检验技术规则#@`国内海船#@`沿海小型船舶检验技术规则2016";
            this.tbHtmlPath.Text = @"../../../htmlRcgTest/1/1_2016.htm";
            this.tbFilesPath.Text = @"/Uploads/imagesrc/guoneihaichuan/num1";
            this.tbTitle1SpanStyle.Text = @"font-size:15.0pt;font-family:黑体";
            this.tbTitle1Xpath.Text = @"/html[1]/body[1]//span[@style='font-size:15.0pt;font-family:黑体']";
            this.tbTitle2Xpath.Text = @"//span[@style='";
            this.tbTitle2SpanStyle.Text = @"font-size:14.0pt;font-family:" + "\"" + "楷体_GB2312" + "\"" + ",serif";
            this.tbTitle1TagName.Text = "h2";
            this.tbTitle2TagName.Text = "h3";
            this.toolStripStatusLabel1.Text = "";
            //this.tbTitle2Xpath1.Text = @"//span[position()<3 and @style='";
            //this.tbTitle1Xpath.Text = @"/html[1]/body[1]//b[1] |/html[1]/body[1]//h1[1]|/html[1]/body[1]//a[1]";
        }

        private void btnWordRead_Click(object sender, EventArgs e)
        {
            if (this.tbHtmlPath.Text != string.Empty && this.tbParentGuid.Text != string.Empty && 
                this.tbParentDepth.Text != string.Empty &&this.tbParentIDfolder.Text != string.Empty &&
                this.tbParentTitleCnFolder.Text != string.Empty &&this.tbFilesPath.Text != string.Empty)
            {
                try
                {
                    conventionRead.imageFilePath = tbFilesPath.Text;
                    ConventionRow rootNode = new ConventionRow(new Guid(this.tbParentGuid.Text), int.Parse(this.tbParentDepth.Text),
                        this.tbParentIDfolder.Text, this.tbParentTitleCnFolder.Text);
                    conventionRead.htmlPath = tbHtmlPath.Text;
                    if (rdbtTitle1Bold.Checked)
                    {
                        if (this.tbTitle1Xpath.Text != string.Empty && tbTitle2Xpath.Text.Trim() != String.Empty)
                        {
                            conventionRead.title1_select = tbTitle1Xpath.Text;
                            conventionRead.title2_select = tbTitle2Xpath.Text;
                            conventionRead.method = ReadMethod.TITLE1_BOLD;
                        }
                    }
                    else if (rdbtTitleHTag.Checked)
                    {
                        if (tbTitle1TagName.Text.Trim()!=string.Empty&& tbTitle2TagName.Text.Trim() != string.Empty)
                        {
                            conventionRead.title1_select = tbTitle1TagName.Text;
                            conventionRead.title2_select = tbTitle2TagName.Text;
                            conventionRead.method = ReadMethod.TITLE_TAG; 
                        }
                    }
                    else 
                    {
                        if (tbTitle1SpanStyle.Text.Trim() != String.Empty && tbTitle2SpanStyle.Text.Trim() != String.Empty)
                        {
                            conventionRead.title1_select = tbTitle1SpanStyle.Text;
                            conventionRead.title2_select = tbTitle2SpanStyle.Text;
                            conventionRead.method = ReadMethod.TITLE_SPANSTYLE;
                        }
                    }
                    info = conventionRead.ReadHtml(rootNode);
                    this.toolStripStatusLabel1.Text = "Html识别成功：一级目录有" + info.title1s.Count + "个,二级目录共有" + info.title2s.Count+"个";
                    for (int i = 0; i < info.title1Guids.Count; i++)
                        this.tbTitle1Guids.Text += info.title1Guids[i]+"\r\n";
                    this.tbTitle1Guids.Text += "\r\n\r\n";
                    for (int i = 0; i < info.title2s.Count; i++)
                        this.tbTitle1Guids.Text += info.title2s[i] + "\r\n";
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                    this.toolStripStatusLabel1.Text = err.Message;
                }
            }
            else
                MessageBox.Show("请输入信息!");

            #region 废弃代码
            // ConventionRow rootNode=new ConventionRow(new Guid("1b506d0f-8956-46d3-a023-78d24e300ed0"),2,ConventionOptions.CATEGORY.IS_CATEGORY);
            // conventionRead.ReadCatalogue(rootNode);


            //    Word.Application app = new Word.Application();
            //    Word.Document doc = null;
            //    object unknow = Type.Missing;
            //    app.Visible = false;
            //    string str = @"D:\work\WordRead\test.docx";
            //    object file = str;
            //    doc = app.Documents.Open(ref file,
            //        ref unknow, ref unknow, ref unknow, ref unknow,
            //        ref unknow, ref unknow, ref unknow, ref unknow,
            //        ref unknow, ref unknow, ref unknow, ref unknow,
            //        ref unknow, ref unknow, ref unknow);
            //    string temp;
            //    //int paraCount = doc.Paragraphs.Count;                
            //    //for (int i = 1; i < paraCount + 1; i++)
            //    //{
            //    //    temp = doc.Paragraphs[i].Range.Text.Trim();
            //    //    Console.WriteLine(temp);
            //    //}                
            //    doc.ActiveWindow.Selection.WholeStory();
            //    doc.ActiveWindow.Selection.Copy();
            //    IDataObject data = Clipboard.GetDataObject();
            //    temp = data.GetData(DataFormats.Text).ToString();
            //    //回车换行使用了\r\n   和   \n
            //    string pattern_title1 = @"第\d{1,}章 {1,2}[\w ]+\r";//查找一级标题
            //    string pattern_title2 = @"(?<=\r\n|\r\n\s{1,})\d{1,}\s{1,}\w[^，。]+?\r";//查找二级标题
            //    string pattern_zhengwen = @"(?<=(?<=\r\n|\r\n\s{1,})\d{1,}\s{1,}\w[^，。]+?\r)" +
            //        @"[\s\S]+?(?=((?<=\r\n|\r\n\s{1,})\d{1,}\s{1,}\w[^，。]+?\r)|" +
            //        @"第\d{1,}章 {1,2}[\w ]+\r\n|(?<=\n|\n\s+)附录[\w\W]+?(?=\r\n)|$)";//查找正文
            //    string pattern_fulu = @"(?<=\n|\n\s+)附录[\w\W]+?(?=\r\n)"; //查找附录
            //    /*******缩进*********/
            //    string pattern_suojin1 = @"(?<=\n|^)[ \t\s]*(?=\d+[\.．]\d+)";//匹配1.1、1.1.1缩进，替换顶行无缩进
            //    string pattern_suojin2 = @"(?<=\n)[ \t\s]*(?=[（(]\d+[）)])";//查找正文中的（1）替换为2空格
            //    string pattern_suojin3 = @"(?<=\n)[ \t\s]*(?=[①②③④⑤⑥⑦⑧⑨⑩])";//匹配 ①缩进，替换为6空格
            //    string pattern_suojin4 = @"(?<=\n)[ \t\s]*(?=[（(][a-z]+[）)])";//匹配（a）缩进，替换为8空格
            //    Regex.Replace(temp, pattern_suojin1, "");
            //    Regex.Replace(temp, pattern_suojin2, "  ");
            //    Regex.Replace(temp, pattern_suojin3, "      ");
            //    Regex.Replace(temp, pattern_suojin4, "        ");
            //    /****************/
            //    //FileStream mytxt = new FileStream(@"D:\work\WordRead\testResult.txt",
            //    //    FileMode.Open, FileAccess.Read, FileShare.ReadWrite);  
            //    MatchCollection mymatches = Regex.Matches(temp, pattern_zhengwen);
            //    foreach (Match match in mymatches)
            //    {
            //        File.AppendAllText(@"D:\work\WordRead\testResult.txt", match.Value);
            //        File.AppendAllText(@"D:\work\WordRead\testResult.txt", "\r\n\r\n\r\n\r\n完成一段正文。\r\n\r\n\r\n\r\n");
            //    }
            //    Console.WriteLine(mymatches.Count);
            //    Console.WriteLine("\nFinished");
            //    doc.Close();

            #endregion
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SQLUtils sqlUtils = SQLUtils.getInstance();
            if (sqlUtils.isConnected)
            {
                try
                {
                    sqlUtils.updateTable();
                    this.toolStripStatusLabel1.Text = "数据更新成功";
                }
                catch (Exception err)
                {
                    this.toolStripStatusLabel1.Text = err.Message;
                }
            }
        }
        private void btnHtmlPath_Click(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tbHtmlPath.Text = openFileDialog1.FileName;
            }
        }

        #region 识别模式选项
        private void rdbtTitleTag_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                grpRecognize.Enabled = true;
                tbTitle2TagName.Enabled = true;
                tbTitle1TagName.Enabled = true;
                tbTitle1SpanStyle.Enabled = false;
                tbTitle1Xpath.Enabled = false;
                tbTitle2Xpath.Enabled = false;
                tbTitle2SpanStyle.Enabled = false;
            }
        }
        private void rdbtTitleSpanStyle_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                grpRecognize.Enabled = true;
                tbTitle1SpanStyle.Enabled = true;
                tbTitle1Xpath.Enabled = false;
                tbTitle2Xpath.Enabled = false;
                tbTitle2SpanStyle.Enabled = true;
                tbTitle2TagName.Enabled = false;
                tbTitle1TagName.Enabled = false;
            }
        }
        private void rdbtTitle1Bold_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                grpRecognize.Enabled = true;
                tbTitle1SpanStyle.Enabled = false;
                tbTitle1Xpath.Enabled = true;
                tbTitle2Xpath.Enabled = true;
                tbTitle2SpanStyle.Enabled = false;
                tbTitle2TagName.Enabled = false;
                tbTitle1TagName.Enabled = false;
            }
        }
        #endregion

        #region 菜单按钮
        private void menuSingle_Click(object sender, EventArgs e)
        {
            if (singleAdd == null)
            {
                singleAdd = new frmSingleAdd(this);
                singleAdd.Show();
            }
            else
            {
                singleAdd.Activate();
            }
        }

        private void menuSQLTest_Click(object sender, EventArgs e)
        {
            SQLUtils sqlUtils = SQLUtils.getInstance();
            try
            {
                sqlUtils.makeConnect();
                if (sqlUtils.isConnected)
                {
                    MessageBox.Show("连接成功");
                    this.toolStripStatusLabel1.Text = "连接成功";
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("连接失败");
                this.toolStripStatusLabel1.Text = "连接失败" + err.Message;
            }
        } 
        #endregion

        #region 数据库选择
        private void rdbtConStrServer_CheckedChanged(object sender, EventArgs e)
        {
            SQLUtils sqlUtils = SQLUtils.getInstance();
            if (((RadioButton)sender).Checked)
            {
                sqlUtils.ConStr = @"server=60.30.247.219;database=MRCS_0515;uid=pscadmin1;pwd=http://psc20131105";
            }
        }

        private void rdbtConStrLocal_CheckedChanged(object sender, EventArgs e)
        {
            SQLUtils sqlUtils = SQLUtils.getInstance();
            if (((RadioButton)sender).Checked)
            {
                sqlUtils.ConStr = @"Server=(local);Database=mrcs_0515;Integrated Security=true;";
            }
        }

        private void rdbtConStrLocal_work_CheckedChanged(object sender, EventArgs e)
        {
            SQLUtils sqlUtils = SQLUtils.getInstance();
            if (((RadioButton)sender).Checked)
            {
                sqlUtils.ConStr = @"Server=(local)\MILESGESQL;Database=mrcs_0515;Integrated Security=true;";
            }
        }
        #endregion
    }
}
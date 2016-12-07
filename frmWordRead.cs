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
        //SQLUtils sqlUtils;
        public frmWordRead()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.tbParentGuid.Text = "e909ba4e-4fc4-45e8-be0f-b1dcbc8724fa";
            this.tbParentDepth.Text = "3";
            this.tbParentIDfolder.Text = "#fa6fe77d-7a97-4735-9da2-cd54c1c5fdcd#6d6aee87-657f-4bdb-b957-623a16ff5fe2#dd141ee3-00b9-4a90-9fdb-6822325283c8#e909ba4e-4fc4-45e8-be0f-b1dcbc8724fa";
            this.tbParentTitleCnFolder.Text = "#@`其他公约#@`2011国内航行海船法定检验技术规则#@`第5篇  防止船舶造成污染的结构与设备#@`2014修改通报";
            this.tbHtmlPath.Text = @"../../../htmlRcgTest/2/xiugaitongbao/5/1.htm";
            //this.tbTitle1Xpath.Text = @"/html[1]/body[1]/div[@class='WordSection2']//b[1] |/html[1]/body[1]/div[@class='WordSection2']//h1[1]|/html[1]/body[1]/div[@class='WordSection2']//a[1]";
            //this.tbTitle2Xpath1.Text = @"//span[position()<3 and @style='";
            this.tbTitle1Xpath.Text = @"/html[1]/body[1]//b[1] |/html[1]/body[1]//h1[1]|/html[1]/body[1]//a[1]";
            this.tbTitle2Xpath1.Text = @"//span[@style='";
            this.tbTitle2Xpath2.Text = @"font-size:14.0pt;font-family:楷体_GB2312";
            this.tbTitle2Xpath3.Text = @"']|//span[@style='font-size:14.0pt;" + "\r\n" + "font-family:楷体_GB2312']|" +
                @"//span[@style='font-size:" + "\r\n" + "14.0pt;font-family:楷体_GB2312']" +
                @"//span[@style='font-size:14.0pt;font-family:" + "\r\n" + "楷体_GB2312']" +
                @"//span[@style='font-size:14.0pt;line-height:300%;font-family:楷体_GB2312']";
            this.toolStripStatusLabel1.Text = "";
            this.tbFilesPath.Text = @"/Uploads/imagesrc/guoneihaichuan/num2/xiugaitongbao/5";
        }

        private void btnWordRead_Click(object sender, EventArgs e)
        {
            if (this.tbHtmlPath.Text != string.Empty && this.tbParentGuid.Text != string.Empty && this.tbParentDepth.Text != string.Empty &&
            this.tbParentIDfolder.Text != string.Empty && this.tbParentTitleCnFolder.Text != string.Empty &&
            this.tbFilesPath.Text != string.Empty && this.tbTitle1Xpath.Text != string.Empty &&
            tbTitle2Xpath1.Text.Trim() != String.Empty && tbTitle2Xpath2.Text.Trim() != String.Empty
            && tbTitle2Xpath3.Text.Trim() != String.Empty)
            {
                try
                {
                    conventionRead.title1_xPath = tbTitle1Xpath.Text;
                    conventionRead.title2_xPath = tbTitle2Xpath1.Text + tbTitle2Xpath2.Text + tbTitle2Xpath3.Text;
                    conventionRead.imageFilePath = tbFilesPath.Text;
                    ConventionRow rootNode = new ConventionRow(new Guid(this.tbParentGuid.Text), int.Parse(this.tbParentDepth.Text),
                        this.tbParentIDfolder.Text, this.tbParentTitleCnFolder.Text);
                    conventionRead.htmlPath = tbHtmlPath.Text;
                    if (rdbtContent.Checked)
                        this.toolStripStatusLabel1.Text = conventionRead.ReadHtml(rootNode,ReadMethod.CONTENT);
                    else if (rdbtTitleTag.Checked)
                        this.toolStripStatusLabel1.Text = conventionRead.ReadHtml(rootNode, ReadMethod.TITLE_TAG);
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
        private void btnHtmlPath_Click(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tbHtmlPath.Text = openFileDialog1.FileName;
            }
        }

        private void rdbtCatagory_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                grpContent.Enabled = false;
                grpCatagory.Enabled = true;
            }
        }

        private void rdbtContent_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                grpContent.Enabled = true;
                grpCatagory.Enabled = false;
            }
        }

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
                    //this.btnWordRead.Enabled = true;
                    //this.singleAdd.Enabled = true;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("连接失败");
                this.toolStripStatusLabel1.Text = "连接失败" + err.Message;
            }
        }

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
    }
}
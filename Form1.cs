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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnWordRead_Click(object sender, EventArgs e)
        {
            
            ConventionRead conventionRead=new ConventionRead();
            ConventionRow rootNode=new ConventionRow(new Guid("1b506d0f-8956-46d3-a023-78d24e300ed0"),2,CATEGORY.IS_CATEGORY);
            conventionRead.ReadCatalogue(rootNode);
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

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //    try
            //    {
            //        DataRow myRow = myTable.NewRow();
            Guid guid1 = Guid.NewGuid();
            //        Guid guid2 = Guid.NewGuid();
            Console.WriteLine(guid1);
            //        myRow["Guid"] = guid1;
            //        myRow["Depth"] = 1;
            //        myRow["ParentNodeGuid"] = guid2;
            //        myRow["Category"] = 1;
            //        myRow["Display"] = 0;
            //        myRow["SequenceNumber"]=1;
            //        myRow["Purposes"]=0;
            //        myTable.Rows.Add(myRow);
            //        SqlCommandBuilder mySqlCommandBuilder = new SqlCommandBuilder(myDataAdapter);
            //        myDataAdapter.Update(myDataSet, "tblConvention");
            //        connect.Close();

            //    }                    
            //    catch(Exception err)
            //    {
            //        connect.Close();
            //        Console.WriteLine(err.Message + mycmd.CommandText);
            //    }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            test1 t1 = new test1();
            t1.num = 2;
            //test2 t2_2 = new test2(t1);
            Console.WriteLine(t1.num);
            for (int i = 1; i < 3; i++)
            {
                test2 t2 = new test2();
                t2.num2 = 1;
                t2.num2 = t2.num2 + 1;
                Console.WriteLine(t2.num2);

            }
            Console.WriteLine(t1.num);

        }
    }
    class test1
    {
        public int num = 0;
    }
    class test2
    {
        public int num2;

        public test2()
        {

        }

    }
}

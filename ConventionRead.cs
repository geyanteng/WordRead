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
using DataStructure;
namespace WordRead
{
    class ConventionRead
    {
        private const string catalogPath = @"F:/1work/WordRead/test.docx";
        //private ConventionRow rootNode;
        private string text;
        private string catalogue;
        public Tree<ConventionRow> ConventionRowTree = new Tree<ConventionRow>();
        public ConventionRead(string docPath = catalogPath)
        {
            Word.Application app = new Word.Application();
            Word.Document doc = null;
            try
            {
                object unknow = Type.Missing;
                app.Visible = false;
                object file = catalogPath;
                doc = app.Documents.Open(ref file,
                    ref unknow, ref unknow, ref unknow, ref unknow,
                    ref unknow, ref unknow, ref unknow, ref unknow,
                    ref unknow, ref unknow, ref unknow, ref unknow,
                    ref unknow, ref unknow, ref unknow);
                doc.ActiveWindow.Selection.WholeStory();
                doc.ActiveWindow.Selection.Copy();
                IDataObject data = Clipboard.GetDataObject();
                text = data.GetData(DataFormats.Text).ToString();
                doc.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                doc.Close();
            }
        }
        //public MLTree<ConventionRow> ConventionRowTree;       
        public void ReadCatalogue(ConventionRow rootNode, string catalogue,string pattern)
        {
            ConventionRowTree.Data = rootNode;
            MatchCollection mymatches = Regex.Matches(catalogue, pattern);
            foreach (Match match in mymatches)
            {
                //Console.WriteLine(match.Value);
                ConventionRow tempRow = new ConventionRow(ConventionOptions.CATEGORY.IS_CATEGORY);
                tempRow.ParentNodeGuid = rootNode.Guid;
                tempRow.TitleCn = match.Value;
                Tree<ConventionRow> ConventionNode1 = new Tree<ConventionRow>(tempRow);
                ConventionRowTree.AddNode(ConventionNode1);
                //Console.WriteLine(ConventionNode1.Data);
            }
        }
        public void ReadCatalogue(ConventionRow rootNode)
        {
            ConventionRowTree.Data = rootNode;
            MatchCollection allTitle_matches = Regex.Matches(text, Patterns.allTitle, RegexOptions.Multiline);
            MatchCollection title1_matches = Regex.Matches(text, Patterns.Title1,RegexOptions.Multiline);
            foreach (Match mymatch in allTitle_matches)
            {
                
                Console.WriteLine(mymatch.Value);
            }
            //string[] subTitles = text.Split(new string[] { "\r\r" },StringSplitOptions.RemoveEmptyEntries);
            //删除空行
            for (int i = 0; i < title1_matches.Count; i++)
            {
                ConventionRow tempRow = new ConventionRow(rootNode.Guid, rootNode.Depth + 1, title1_matches[i].Value,
                    ConventionRowTree.NodeNumber + 1, ConventionOptions.CATEGORY.IS_CATEGORY);
                Tree<ConventionRow> ConventionNode1 = new Tree<ConventionRow>(tempRow);
                ConventionRowTree.AddNode(ConventionNode1);
                //Console.WriteLine(ConventionRowTree.NodeNumber);
                //Console.WriteLine(ConventionNode1.Data.TitleCn);  
            }
            for (int i = -1, j = 0; j < allTitle_matches.Count; j++)
            {
                if (title1_matches[i+1].Value == allTitle_matches[j].Value)
                {
                    i++;
                    continue;
                }
                ConventionRow tempRow2 = new ConventionRow(ConventionRowTree.Nodes[i].Data.Guid, 
                    ConventionRowTree.Nodes[i].Data.Depth + 1, allTitle_matches[j].Value,
                    ConventionRowTree.Nodes[i].NodeNumber + 1, ConventionOptions.CATEGORY.IS_CONTENT);
                Tree<ConventionRow> ConventionNode2 = new Tree<ConventionRow>(tempRow2);
                ConventionRowTree.Nodes[i].AddNode(ConventionNode2);
                Console.WriteLine(ConventionNode2.Data.TitleCn);
            }
            Console.WriteLine("Yes");
        }
    }
    public static class Patterns
    {
        public static string Title1 = @"第\d{1,}章[\s\S]+?(?=\s\d{1,3}\r)";//查找一级标题
        public static string subTitle = @"第\d{1,}章[\s\S]+?(?=\r)";//查找一级标题
        public static string allTitle = @"^[^\r][\s\S]+?(?=\s\d{1,3}\r)";//按行查找，去除空行，去除页码，匹配两种标题
    }
    public static class ConventionOptions
    {
        public  enum CATEGORY
        {
            IS_CATEGORY = 1,
            IS_CONTENT = 2,
        }
        public  enum DISPLAY
        {
            IS_DISPLAY = 0,
            IS_HIDE = 1,
        }
    }  
}

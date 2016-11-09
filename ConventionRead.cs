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
        private const string catalogPath = @"F:\1work\WordRead\test.docx";
        //private ConventionRow rootNode;
        private string text;
        private string catalogue;
        public Tree<ConventionRow> ConventionRowTree = new Tree<ConventionRow>();
        public ConventionRead(string docPath = catalogPath)
        {
            try
            {
                Word.Application app = new Word.Application();
                Word.Document doc = null;
                object unknow = Type.Missing;
                app.Visible = false;
                Console.WriteLine("end00");
                object file = catalogPath;
                Console.WriteLine("end0");
                doc = app.Documents.Open(ref file,
                    ref unknow, ref unknow, ref unknow, ref unknow,
                    ref unknow, ref unknow, ref unknow, ref unknow,
                    ref unknow, ref unknow, ref unknow, ref unknow,
                    ref unknow, ref unknow, ref unknow);
                doc.ActiveWindow.Selection.WholeStory();
                doc.ActiveWindow.Selection.Copy();
                IDataObject data = Clipboard.GetDataObject();
                text = data.GetData(DataFormats.Text).ToString();
                Console.WriteLine("end");
                doc.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }    
        //public MLTree<ConventionRow> ConventionRowTree;       
        public void ReadCatalogue(ConventionRow rootNode, string catalogue, string pattern = Pattern.Title1)
        {              
            ConventionRowTree.Data=rootNode;
            MatchCollection mymatches = Regex.Matches(text, pattern);

            foreach (Match match in mymatches)
            {
                Console.WriteLine(match.Value);
                ConventionRow tempRow = new ConventionRow(CATEGORY.IS_CATEGORY);
                tempRow.ParentNodeGuid=rootNode.Guid;
                tempRow.TitleCn=match.Value;
                Tree<ConventionRow> ConventionNode1 = new Tree<ConventionRow>(tempRow);
                ConventionRowTree.AddNode(ConventionNode1);
                Console.WriteLine(ConventionNode1.Data);
            }           
        }
        public void ReadCatalogue(ConventionRow rootNode, string pattern = Pattern.Title1)
        {
            ConventionRowTree.Data = rootNode;
            MatchCollection mymatches = Regex.Matches(text, pattern);           
            foreach (Match match in mymatches)
            {
                Console.WriteLine(match.Value);
                ConventionRow tempRow = new ConventionRow(rootNode.Guid, rootNode.Depth+1,match.Value,
                    ConventionRowTree.NodeNumber+1,CATEGORY.IS_CATEGORY);
                Tree<ConventionRow> ConventionNode1 = new Tree<ConventionRow>(tempRow);
                ConventionRowTree.AddNode(ConventionNode1);
                Console.WriteLine(ConventionRowTree.NodeNumber);
                Console.WriteLine(ConventionNode1.Data.TitleCn);
            }
            Console.WriteLine(ConventionRowTree.Nodes[2].Data.TitleCn);
        }
    }
    public class Pattern
    {
        public const string Title1 = @"第\d{1,}章[\s\S]+?(?=\s\d{1,3}\r)";//查找一级标题
        //public const string Title2 = @"第\d{1,}章[\s\S]+?(?=\s\d{1,3}\r)";//查找一级标题

    }
    public enum CATEGORY
    {
        IS_CATEGORY=1,
        IS_CONTENT=2,
    }
    public enum DISPLAY
    {
        IS_DISPLAY=0,
        IS_HIDE=1,
    }
}

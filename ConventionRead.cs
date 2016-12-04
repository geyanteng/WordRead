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
using mshtml;
using System.Net;
using HtmlAgilityPack;
namespace WordRead
{
    class ConventionRead
    {
        const string catalogPath = @"F:/1work/WordRead/test.docx";
        public string imageFilePath;
        public string htmlPath;//= @"D:\1work\htmlRcgTest\Part3_07.htm";
        //@"../../../htmlRcgTest/Part3_07.htm";
        //private ConventionRow rootNode;
        //public string title2Style= @"font-size:14.0pt;font-family:楷体_GB2312";
        public string title2_xPath = @"//span[position()<3 and @style='font-size:14.0pt;font-family:楷体_GB2312']";
        public string title1_xPath = @"/html[1]/body[1]/div[@class='WordSection2']//b[1] |" +
                @"/html[1]/body[1]/div[@class='WordSection2']//h1[1]|" +
                @"/html[1]/body[1]/div[@class='WordSection2']//a[1]";
        private string text;
        private string catalogue;
        
        public Tree<ConventionRow> ConventionRowTree = new Tree<ConventionRow>();
        public ConventionRead()
        {
        }
        public void ReadWordText()
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
        /// <summary>
        ///  附录需要在word里按目录要求，手动改为一级或者二级标题的格式
        /// </summary>
        /// <param name="rootConvention"></param>
        public string ReadHtml(ConventionRow rootConvention)
        {
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.Load(htmlPath);
            HtmlNode htmlRootNode = doc.DocumentNode;            
            //一级标题
            var title1Nodes_init = htmlRootNode.SelectNodes(title1_xPath);
            //二级标题可能所在span
            var title2Nodes_init = htmlRootNode.SelectNodes(title2_xPath);//|//span[@style='font-size:12.0pt;font-family:黑体']");
            //脚注可能所在的p
            var footNoteReferenceNums = htmlRootNode.SelectNodes(@"//p[@class='MsoFootnoteText']");
            List<string> str_contentList = new List<string>();
            List<string> str_title2List = new List<string>();
            List<string> str_title1List = new List<string>();
            string htmlTxt = htmlRootNode.InnerHtml;
            #region 找出一级标题，HtmlNode保存在title1Nodes,文本存储在 str_title1List
            HtmlNodeCollection title1Nodes = new HtmlNodeCollection(htmlRootNode.Clone());
            
            if (title1Nodes_init!=null)
            {
                for (int i = 0; i < title1Nodes_init.Count; i++)
                {
                    if ((title1Nodes_init[i].ParentNode.Name == "p" && title1Nodes_init[i].ParentNode.ParentNode.Name == "div" && title1Nodes_init[i].HasChildNodes)
                        || (title1Nodes_init[i].Name == "h1" && title1Nodes_init[i].ParentNode.Name == "div")
                        || (title1Nodes_init[i].ParentNode.Name == "a" && title1Nodes_init[i].ParentNode.ParentNode.Name == "p"))
                    {
                        foreach (var child in title1Nodes_init[i].ChildNodes)
                        {
                            if (child.Name == "span" && child.HasAttributes)
                            {
                                foreach (var atbt in child.Attributes)
                                {
                                    if (atbt.Name == "style")
                                    {
                                        if ((title1Nodes_init[i].ParentNode.InnerText.Contains("第") && title1Nodes_init[i].ParentNode.InnerText.Contains("章"))
                                            )
                                        {
                                            if (title1Nodes_init[i].ParentNode.ParentNode.Name == "p")
                                            {
                                                title1Nodes.Add(title1Nodes_init[i].ParentNode.ParentNode);
                                                str_title1List.Add(title1Nodes_init[i].ParentNode.ParentNode.InnerText);
                                            }
                                            else if (title1Nodes_init[i].ParentNode.Name == "p")
                                            {
                                                title1Nodes.Add(title1Nodes_init[i].ParentNode);
                                                str_title1List.Add(title1Nodes_init[i].ParentNode.InnerText.Replace("&nbsp;"," ").Replace("\r\n",""));
                                            }
                                            else if (title1Nodes_init[i].Name == "h")
                                            {
                                                title1Nodes.Add(title1Nodes_init[i]);
                                                str_title1List.Add(title1Nodes_init[i].InnerText.Replace("&nbsp;", " ").Replace("\r\n", ""));
                                            }
                                        }
                                        break;
                                    }
                                }
                                break;
                            }
                        }
                    }
                }
            }
            #endregion

            #region 找出html文本末尾可能存在的各脚注div，HtmlNode存储在ftNoteRefnodes
            HtmlNodeCollection ftNoteRefnodes = new HtmlNodeCollection(htmlRootNode.Clone());
            if (footNoteReferenceNums != null)
            {
                for (int i = 0; i < footNoteReferenceNums.Count; i++)
                {
                    if (footNoteReferenceNums[i].ParentNode.Name == "div" && footNoteReferenceNums[i].ParentNode.HasAttributes)
                    {
                        string tmp = footNoteReferenceNums[i].ParentNode.GetAttributeValue("id", "notfound");
                        if (tmp != "notfound")
                        {
                            ftNoteRefnodes.Add(footNoteReferenceNums[i].ParentNode);
                        }
                    }
                }
            } 
            #endregion

            #region 找出二级小节标题，HtmlNode保存在title2Nodes ，文本存储在str_title2List
            //span所在的几种情形：div->p->a->span   div->p->span  div->h1->span
            HtmlNodeCollection title2Nodes = new HtmlNodeCollection(htmlRootNode.Clone());
            
            if (title2Nodes_init != null)
            {
                for (int i = 0; i < title2Nodes_init.Count; i++)
                {
                    //标题span存在的情形1
                    if (title2Nodes_init[i].ParentNode.Name == "a" && title2Nodes_init[i].ParentNode.ParentNode.Name == "p")
                    {
                        //避免添加重复的部分
                        if((i == 0) || (i>0&& title2Nodes_init[i].ParentNode.ParentNode.Line != title2Nodes_init[i - 1].ParentNode.ParentNode.Line))
                        {
                            title2Nodes.Add(title2Nodes_init[i].ParentNode.ParentNode);
                            str_title2List.Add(title2Nodes_init[i].ParentNode.ParentNode.InnerText.Replace("&nbsp;", " ").Replace("\r\n", ""));
                        }
                    }
                    //标题span存在的情形2、3
                    else if ((title2Nodes_init[i].ParentNode.Name == "p" && title2Nodes_init[i].ParentNode.ParentNode.Name == "div")
                        || (title2Nodes_init[i].ParentNode.Name == "h1" && title2Nodes_init[i].ParentNode.ParentNode.Name == "div"))
                    {
                        //避免添加重复的部分
                        if ((i==0)||(i > 0 && title2Nodes_init[i].ParentNode.Line != title2Nodes_init[i - 1].ParentNode.Line))
                        {
                            title2Nodes.Add(title2Nodes_init[i].ParentNode);
                            str_title2List.Add(title2Nodes_init[i].ParentNode.InnerText.Replace("&nbsp;", " ").Replace("\r\n", ""));
                        }
                    }
                }
            #endregion

                #region html文档中去除一级标题部分，以及文档末尾的脚注，保存在 htmlTxt 字符串
                
                if (title1Nodes!=null)
                {
                    for (int i = 0; i < title1Nodes.Count; i++)
                    {
                        //Console.WriteLine(title1Nodes[i].OuterHtml + "\r\n");
                        htmlTxt = htmlTxt.Replace(title1Nodes[i].OuterHtml, "");
                    } 
                }
                if (ftNoteRefnodes!=null)
                {
                    for (int i = 0; i < ftNoteRefnodes.Count; i++)
                    {
                        htmlTxt = htmlTxt.Replace(ftNoteRefnodes[i].OuterHtml, "");
                    }  
                }
                //替换图片路径
                Regex reg=new Regex(Patterns.imageSrc);
                htmlTxt = reg.Replace(htmlTxt, "${1}" + imageFilePath + "${2}");
                MatchCollection a = reg.Matches(htmlTxt);
                foreach (Match b in a)
                {
                    Console.WriteLine(b.Value );
                }
                System.IO.File.WriteAllText(@"../../../htmlRcgTest/1234.html", htmlTxt);
                #endregion

                #region 按二级标题，分小节存储html文本，HtmlNode节点存储在contentNodes,文本存储在str_contentList

                
                HtmlNodeCollection contentNodes = new HtmlNodeCollection(htmlRootNode.Clone());
                try
                {
                    for (int i = 0; i < title2Nodes.Count; i++)
                    {
                        HtmlAgilityPack.HtmlDocument contentNodeDoc = new HtmlAgilityPack.HtmlDocument();
                        string str_content;
                        int index_PartStart = 0;
                        if (i < title2Nodes.Count - 1)
                        {
                            index_PartStart = htmlTxt.IndexOf(title2Nodes[i].OuterHtml);
                            int index_PartEnd = htmlTxt.IndexOf(title2Nodes[i + 1].OuterHtml);
                            if (index_PartStart != -1 && index_PartEnd > index_PartStart)
                                str_content = htmlTxt.Substring(index_PartStart, index_PartEnd - index_PartStart);
                            else
                                throw new Exception("提取出错");
                        }
                        else
                        {
                            index_PartStart = htmlTxt.IndexOf(title2Nodes[title2Nodes.Count - 1].OuterHtml);
                            if(index_PartStart !=-1)
                                str_content = htmlTxt.Substring(index_PartStart);
                            else
                                throw new Exception("提取出错");
                        }
                        foreach (var ftnref in ftNoteRefnodes)
                        {
                            if (str_content.Contains("#_" + ftnref.Attributes["id"].Value))
                            {
                                str_content = str_content + ftnref.OuterHtml;
                            }
                        }
                        contentNodeDoc.LoadHtml(str_content);
                        contentNodes.Add(contentNodeDoc.DocumentNode);
                        str_contentList.Add(contentNodes[i].OuterHtml);
                        System.IO.File.WriteAllText(@"../../../htmlRcgTest/" + i + @".html", str_contentList[i]);
                    }
                }
                catch (Exception err)
                {
                    Console.WriteLine(err + "\r\n");
                }
                #endregion

                #region 获取各一级目录下小节的数量，存储在title2InTitle1Nums[]。将两级标题录入数据库（如何任意多级别都可以录入？）
                try
                {
                    int[] title2InTitle1Nums = new int[title1Nodes.Count];
                    SQLUtils sqlUtils = SQLUtils.getInstance();
                    ConventionRow tmp_rootConvention = rootConvention;
                    for (int i = 0; i < title1Nodes.Count; i++)
                    {
                        ConventionRow tempRow1 = new ConventionRow(rootConvention, str_title1List[i],
                            i+1, ConventionOptions.CATEGORY.IS_CATEGORY);
                        sqlUtils.writeRow_local(tempRow1);
                        for (int j = 0,k=0; j < title2Nodes.Count; j++)
                        {
                            tmp_rootConvention = tempRow1;
                            if (i < title1Nodes.Count - 1)
                            {
                                if (title2Nodes[j].Line < title1Nodes[i + 1].Line && title2Nodes[j].Line > title1Nodes[i].Line)
                                {
                                    ConventionRow tempRow2 = new ConventionRow(tmp_rootConvention, str_title2List[j],
                                        ++k, ConventionOptions.CATEGORY.IS_CONTENT, str_contentList[j]);
                                    sqlUtils.writeRow_local(tempRow2);
                                    //title2InTitle1Nums[i]++;
                                }
                            }
                            else
                                if (title2Nodes[j].Line > title1Nodes[i].Line)
                            {
                                ConventionRow tempRow2 = new ConventionRow(tmp_rootConvention, str_title2List[j],
                                    ++k, ConventionOptions.CATEGORY.IS_CONTENT, str_contentList[j]);
                                sqlUtils.writeRow_local(tempRow2);
                                //title2InTitle1Nums[i]++;
                            }
                        }
                    }
                    sqlUtils.updateTable();
                    return "录入成功：一级目录有"+str_title1List.Count+"个,二级目录共有"+str_title2List.Count+"个";
                }
                catch (Exception err)
                {
                    Console.WriteLine(err.Message);
                    return "录入失败。错误原因：" + err.Message;
                }
                
                #endregion

            }
            return "";
        }
        //public MLTree<ConventionRow> ConventionRowTree;       
        public void ReadCatalogue(ConventionRow rootNode, string catalogue, string pattern)
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
            MatchCollection title1_matches = Regex.Matches(text, Patterns.Title1, RegexOptions.Multiline);
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
                if (title1_matches[i + 1].Value == allTitle_matches[j].Value)
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
        public static string imageSrc = @"(<img\s+width="+"\""+@"?\d+"+"\""+@"?\s+height="+"\""+@"?\d+"+"\""+@"?\s+src=['"+"\""+@"])[\s\S]+?(/image[\s\S]+?['"+"\""+@"]>)";
        public static string Title1 = @"第\d{1,}章[\s\S]+?(?=\s\d{1,3}\r)";//查找一级标题
        public static string subTitle = @"第\d{1,}章[\s\S]+?(?=\r)";//查找一级标题
        public static string allTitle = @"^[^\r][\s\S]+?(?=\s\d{1,3}\r)";//按行查找，去除空行，去除页码，匹配两种标题
    }
    public static class ConventionOptions
    {
        public enum CATEGORY
        {
            IS_CATEGORY = 1,
            IS_CONTENT = 2,
        }
        public enum DISPLAY
        {
            IS_DISPLAY = 0,
            IS_HIDE = 1,
        }
    }
}

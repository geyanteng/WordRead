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
using System.Net;
using HtmlAgilityPack;
namespace WordRead
{
    class ConventionRead
    {
        public string htmlPath;
        public string imageFilePath;
        public string title1_select;
        public string title2_select;
        public ReturnInfo retInfo=new ReturnInfo();
        public ReadMethod method;
        public ConventionRead()
        {
        }
        /// <summary>
        ///  附录需要在word里按目录要求，手动改为一级或者二级标题的格式
        /// </summary>
        /// <param name="rootConvention"></param>
        public ReturnInfo ReadHtml(ConventionRow rootConvention)
        {
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.Load(htmlPath);
            HtmlNode htmlRootNode = doc.DocumentNode;
            HtmlNodeCollection titleNodes_init;
            HtmlNodeCollection title1Nodes_init;
            HtmlNodeCollection title2Nodes_init;
            List<string> str_contentList = new List<string>();
            List<string> str_titleList = new List<string>();
            List<string> str_title1List = new List<string>();
            List<string> str_title2List = new List<string>();
            HtmlNodeCollection contentNodes = new HtmlNodeCollection(htmlRootNode.Clone());
            Dictionary<int, string> dic_title1Content = new Dictionary<int, string>();
            HtmlNodeCollection titleNodes = new HtmlNodeCollection(htmlRootNode.Clone());
            HtmlNodeCollection title1Nodes = new HtmlNodeCollection(htmlRootNode.Clone());
            HtmlNodeCollection title2Nodes = new HtmlNodeCollection(htmlRootNode.Clone());
            HtmlNodeCollection ftNoteRefnodes = new HtmlNodeCollection(htmlRootNode.Clone());
            string htmlTxt = htmlRootNode.InnerHtml;
            //正文识别标题 

            #region 选项1：一级标题粗体识别
            if (method == ReadMethod.TITLE1_BOLD)
            {
                //一级标题
                title1Nodes_init = htmlRootNode.SelectNodes(title1_select);
                //二级标题可能所在span
                title2Nodes_init = htmlRootNode.SelectNodes(title2_select);
                #region 找出一级标题，HtmlNode保存在title1Nodes,文本存储在 str_title1List

                if (title1Nodes_init != null)
                {
                    for (int i = 0; i < title1Nodes_init.Count; i++)
                    {
                        if ((title1Nodes_init[i].ParentNode.Name == "p" && title1Nodes_init[i].ParentNode.ParentNode.Name == "div" && title1Nodes_init[i].HasChildNodes)
                            || (title1Nodes_init[i].Name == "h1" && title1Nodes_init[i].ParentNode.Name == "div")
                            || (title1Nodes_init[i].Name == "h2" && title1Nodes_init[i].ParentNode.Name == "div")
                            || (title1Nodes_init[i].ParentNode.Name == "a" && title1Nodes_init[i].ParentNode.ParentNode.Name == "p")
                            )
                        {
                            foreach (var child in title1Nodes_init[i].DescendantsAndSelf())
                            {
                                if (child.Name == "span" && child.HasAttributes)
                                {
                                    foreach (var atbt in child.Attributes)
                                    {
                                        if (atbt.Name == "style")//&& atbt.Value== "font-size:15.0pt;font-family:黑体")
                                        {
                                            if ((title1Nodes_init[i].ParentNode.InnerText.Contains("第") && title1Nodes_init[i].ParentNode.InnerText.Contains("章"))
                                                )
                                            {
                                                if (title1Nodes_init[i].ParentNode.ParentNode.Name == "p")
                                                {
                                                    title1Nodes.Add(title1Nodes_init[i].ParentNode.ParentNode);
                                                    str_title1List.Add(title1Nodes_init[i].ParentNode.ParentNode.InnerText.Replace("&nbsp;", " ").Replace("\r\n", ""));
                                                }
                                                else if (title1Nodes_init[i].ParentNode.Name == "p")
                                                {
                                                    title1Nodes.Add(title1Nodes_init[i].ParentNode);
                                                    str_title1List.Add(title1Nodes_init[i].ParentNode.InnerText.Trim().Replace("&nbsp;", " ").Replace("\r\n", ""));
                                                }
                                                else if (title1Nodes_init[i].Name == "h" || title1Nodes_init[i].Name == "h1" || title1Nodes_init[i].Name == "h2")
                                                {
                                                    title1Nodes.Add(title1Nodes_init[i]);
                                                    str_title1List.Add(title1Nodes_init[i].InnerText.Trim().Replace("&nbsp;", " ").Replace("\r\n", ""));
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

                #region 找出二级小节标题，HtmlNode保存在title2Nodes ，文本存储在str_title2List
                //span所在的几种情形：div->p->a->span   div->p->span  div->h1->span

                if (title2Nodes_init != null)
                {
                    for (int i = 0; i < title2Nodes_init.Count; i++)
                    {
                        //标题span存在的情形1
                        if (title2Nodes_init[i].ParentNode.Name == "a" && title2Nodes_init[i].ParentNode.ParentNode.Name == "p")
                        {
                            //避免添加重复的部分
                            if ((i == 0) || (i > 0 && title2Nodes_init[i].ParentNode.ParentNode.Line != title2Nodes_init[i - 1].ParentNode.ParentNode.Line))
                            {
                                title2Nodes.Add(title2Nodes_init[i].ParentNode.ParentNode);
                                str_title2List.Add(title2Nodes_init[i].ParentNode.ParentNode.InnerText.Trim().Replace("&nbsp;", " ").Replace("\r\n", ""));
                            }
                        }
                        //标题span存在的情形2、3
                        else if ((title2Nodes_init[i].ParentNode.Name == "p" && title2Nodes_init[i].ParentNode.ParentNode.Name == "div")
                            || (title2Nodes_init[i].ParentNode.Name == "h1" && title2Nodes_init[i].ParentNode.ParentNode.Name == "div"))
                        {
                            //避免添加重复的部分
                            if ((i == 0) || (i > 0 && title2Nodes_init[i].ParentNode.Line != title2Nodes_init[i - 1].ParentNode.Line))
                            {
                                title2Nodes.Add(title2Nodes_init[i].ParentNode);
                                str_title2List.Add(title2Nodes_init[i].ParentNode.InnerText.Trim().Replace("&nbsp;", " ").Replace("\r\n", ""));
                            }
                        }
                    }
                    for (int i = 0; i < title2Nodes.Count; i++)
                    {
                        if ((i > 0 && title2Nodes[i].Line == title2Nodes[i - 1].Line))
                        {
                            str_title2List.RemoveAt(i);
                            title2Nodes.RemoveAt(i);
                        }
                    }
                }
                #endregion
            }
            #endregion

            #region 选项2：标题中Span 标签 Style属性识别
            else if (method == ReadMethod.TITLE_SPANSTYLE)
            {
                title1Nodes_init = htmlRootNode.SelectNodes(@"//h1");//span[@style]");
                title2Nodes_init = htmlRootNode.SelectNodes(@"//span[@style]");
                #region 提取一级标题节点，生成一级目录的节点集合title1Nodes，和字符串集合str_title1List
                if (title1Nodes_init != null)
                {
                    for (int i = 0; i < title1Nodes_init.Count; i++)
                    {
                        //string tmpstr = title1Nodes_init[i].InnerText;
                        //if (title1Nodes_init[i].Attributes["style"].Value.Replace("\r\n", "").Contains(title1_select))
                        //{
                        //    foreach (var match in title1Nodes_init[i].AncestorsAndSelf())
                        //    {
                        //        Console.WriteLine(match.Name);
                        //        if (match.Name == "p")
                        //        {
                        //            title1Nodes.Add(match);
                        //            break;
                        //        }
                        //    }
                        //}
                        title1Nodes.Add(title1Nodes_init[i]);
                    }
                    for (int i = 0; i < title1Nodes.Count; i++)
                    {
                        if (title1Nodes[i].InnerText.Trim() != string.Empty &&
                        (i == 0 || (i > 0 && title1Nodes[i].Line != title1Nodes[i - 1].Line)))
                        {
                            str_title1List.Add(title1Nodes[i].InnerText.Trim().Replace("&nbsp;", " ").Replace("\r\n", ""));
                        }
                        else
                        {
                            title1Nodes.RemoveAt(i);
                        }
                    }
                }
                #endregion

                #region 提取二级标题节点，生成二级目录的节点集合title2Nodes，和字符串集合str_title2List
                if (title2Nodes_init != null)
                {
                    HtmlNodeCollection tempNodes = new HtmlNodeCollection(htmlRootNode.Clone());

                    for (int i = 0; i < title2Nodes_init.Count; i++)
                    {
                        if (title2Nodes_init[i].Attributes["style"].Value.Replace("\r\n", "").Contains(title2_select)
                            && title2Nodes_init[i].ParentNode.Name=="b")
                        {
                            foreach (var match in title2Nodes_init[i].AncestorsAndSelf())
                            {
                                if (match.Name == "p")
                                {
                                    foreach(var match1 in match.Descendants())
                                    {
                                        if (match1.Name == "a")
                                        {
                                            tempNodes.Add(match);
                                            break;
                                       }                                           
                                    }
                                    break;                                  
                                }
                            }
                        }
                    }
                    for (int i = 0; i < tempNodes.Count; i++)
                    {
                        if (tempNodes[i].InnerText.Replace("&nbsp;", "").Trim() != String.Empty &&
                        (i == 0 || (i > 0 && tempNodes[i].Line != tempNodes[i - 1].Line)))
                        {
                            title2Nodes.Add(tempNodes[i]);
                            str_title2List.Add(tempNodes[i].InnerText.Trim().Replace("&nbsp;", " ").Replace("\r\n", ""));
                        }
                    }
                }
                #endregion

                #region 生成包含按序排列的一二级目录的节点集合titleNodes，和字符串集合str_titleList
                foreach (var match in title1Nodes)
                    titleNodes.Add(match);
                foreach (var match in title2Nodes)
                    titleNodes.Add(match);
                for (int i = 0; i < titleNodes.Count; i++)
                {
                    for (int j = i; j < titleNodes.Count; j++)
                    {
                        if (titleNodes[i].Line > titleNodes[j].Line)
                        {
                            var temp = titleNodes[i];
                            titleNodes[i] = titleNodes[j];
                            titleNodes[j] = temp;
                        }
                    }
                }
                for (int i = 0; i < titleNodes.Count; i++)
                {
                    str_titleList.Add(titleNodes[i].InnerText.Trim().Replace("&nbsp;", " ").Replace("\r\n", ""));
                }
                #endregion
            }
            #endregion

            #region 选项3：h1/h2/h3标签识别标题
            else if (method == ReadMethod.TITLE_TAG)
            {
                titleNodes_init = htmlRootNode.SelectNodes(@"//" + title1_select + @"|" + @"//" + title2_select);
                title1Nodes_init = htmlRootNode.SelectNodes(@"//" + title1_select);
                title2Nodes_init = htmlRootNode.SelectNodes(@"//" + title2_select);
                for (int i = 0; i < titleNodes_init.Count; i++)
                {
                    string tmpstr = titleNodes_init[i].InnerText;
                    if (titleNodes_init[i].Name == title1_select && tmpstr.Contains("第") && tmpstr.Contains("章"))
                    {
                        titleNodes.Add(titleNodes_init[i]);
                        title1Nodes.Add(titleNodes_init[i]);
                        str_titleList.Add(titleNodes_init[i].InnerText.Trim().Replace("&nbsp;", " ").Replace("\r\n", ""));
                        str_title1List.Add(titleNodes_init[i].InnerText.Trim().Replace("&nbsp;", " ").Replace("\r\n", ""));
                    }
                    else if (titleNodes_init[i].Name == title2_select)
                    {
                        titleNodes.Add(titleNodes_init[i]);
                        title2Nodes.Add(titleNodes_init[i]);
                        str_titleList.Add(titleNodes_init[i].InnerText.Trim().Replace("&nbsp;", " ").Replace("\r\n", ""));
                        str_title2List.Add(titleNodes_init[i].InnerText.Trim().Replace("&nbsp;", " ").Replace("\r\n", ""));
                    }
                }
            }
            #endregion

            try
            {
                #region 找出html文本末尾可能存在的各脚注div，HtmlNode存储在ftNoteRefnodes

                foreach (var match in htmlRootNode.Descendants())
                {
                    if (match.Name == "div" && match.HasAttributes)
                    {
                        string tmp = match.GetAttributeValue("id", "notfound");
                        if (tmp != "notfound")
                        {
                            ftNoteRefnodes.Add(match);
                        }
                    }
                }
                #endregion

                #region html文档中去除文档末尾的脚注，保存在 htmlTxt 字符串          
                if (ftNoteRefnodes != null)
                {
                    for (int i = 0; i < ftNoteRefnodes.Count; i++)
                    {
                        htmlTxt = htmlTxt.Replace(ftNoteRefnodes[i].OuterHtml, "");
                    }
                }
                //替换图片路径
                Regex reg = new Regex(Patterns.imageSrc);
                htmlTxt = reg.Replace(htmlTxt, "${1}" + imageFilePath + "${2}");
                MatchCollection a = reg.Matches(htmlTxt);
                //System.IO.File.WriteAllText(@"../../../htmlRcgTest/全文.html", htmlTxt);
                #endregion

                #region 提取一级标题下可能有的正文，此标题序号和正文键值对 存储在字典dic_title1Content
                Dictionary<int, string> dic_title1Content_tmp = new Dictionary<int, string>();
                for (int i = 0; i < titleNodes.Count; i++)
                {
                    for (int j = 0; j < title1Nodes.Count - 1; j++)
                    {
                        if (titleNodes[i].Line == title1Nodes[j].Line)
                        {
                            if ((i < titleNodes.Count - 1 && titleNodes[i + 1].Line == title1Nodes[j + 1].Line))
                            {
                                int start = htmlTxt.IndexOf(title1Nodes[j].OuterHtml);
                                int end = htmlTxt.IndexOf(title1Nodes[j + 1].OuterHtml, start + 1);
                                Console.WriteLine("1:"+j);
                                if (start != -1 && end > start)
                                {
                                    dic_title1Content_tmp.Add(j, htmlTxt.Substring(start, end - start));
                                    break;
                                }
                                else
                                    throw new Exception("title1 content提取出错");
                            }
                        }
                        else if(titleNodes[i].Line == title1Nodes.Last().Line)
                        {
                            Console.WriteLine("2:"+title1Nodes.Count);
                            int start = htmlTxt.IndexOf(title1Nodes.Last().OuterHtml);
                            if (start != -1)
                            {
                                dic_title1Content_tmp.Add(title1Nodes.Count - 1, htmlTxt.Substring(start));
                                break;
                            }
                            else
                                throw new Exception("title1 last content提取出错");
                        }
                    }
                }
                foreach (var pair in dic_title1Content_tmp)
                {
                    string v = pair.Value;
                    foreach (var ftnref in ftNoteRefnodes)
                    {
                        if (pair.Value.Contains("href=\"#_" + ftnref.Attributes["id"].Value + "\""))
                        {
                            v = v + ftnref.OuterHtml;
                        }
                    }
                    dic_title1Content.Add(pair.Key, v);
                }
                #endregion

                #region 更新 htmlTxt 字符串，将html文本中一级标题内容删除
                if (title1Nodes != null)
                {
                    for (int i = 0; i < title1Nodes.Count; i++)
                    {
                        htmlTxt = htmlTxt.Replace(title1Nodes[i].OuterHtml, "");
                    }
                }
                #endregion

                #region 提取二级标题下Html正文，分小节存储，HtmlNode节点存储在contentNodes,文本存储在str_contentList
                for (int i = 0; i < title2Nodes.Count; i++)
                {
                    HtmlAgilityPack.HtmlDocument contentNodeDoc = new HtmlAgilityPack.HtmlDocument();
                    string str_content;
                    int index_PartStart = 0;
                    if (i < title2Nodes.Count - 1)
                    {
                        index_PartStart = htmlTxt.IndexOf(title2Nodes[i].OuterHtml);
                        int index_PartEnd = htmlTxt.IndexOf(title2Nodes[i + 1].OuterHtml, index_PartStart + 1);
                        if (index_PartStart != -1 && index_PartEnd > index_PartStart)
                            str_content = htmlTxt.Substring(index_PartStart, index_PartEnd - index_PartStart);
                        else
                            throw new Exception("提取出错");
                    }
                    else
                    {
                        index_PartStart = htmlTxt.IndexOf(title2Nodes[title2Nodes.Count - 1].OuterHtml);
                        if (index_PartStart != -1)
                            str_content = htmlTxt.Substring(index_PartStart);
                        else
                            throw new Exception("提取出错");
                    }
                    foreach (var ftnref in ftNoteRefnodes)
                    {
                        if (str_content.Contains("href=\"#_" + ftnref.Attributes["id"].Value + "\""))
                        {
                            str_content = str_content + ftnref.OuterHtml;
                        }
                    }
                    contentNodeDoc.LoadHtml(str_content);
                    contentNodes.Add(contentNodeDoc.DocumentNode);
                    str_contentList.Add(contentNodes[i].OuterHtml);
                    //System.IO.File.WriteAllText(@"../../../htmlRcgTest/" + i + @".html", str_contentList[i]);
                }
                #endregion
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }

            #region 将一、二级标题及内容录入数据库
            try
            {
                SQLUtils sqlUtils = SQLUtils.getInstance();
                sqlUtils.makeConnect();
                ConventionRow tmp_rootConvention = rootConvention;
                for (int i = 0; i < title1Nodes.Count; i++)
                {
                    ConventionRow tempRow1 = null;
                    foreach (var pair in dic_title1Content)
                    {
                        if (pair.Key == i)//若一级标题下有内容，而无二级目录
                        {
                            tempRow1 = new ConventionRow(rootConvention, str_title1List[i],
                                i + 1, ConventionOptions.CATEGORY.IS_TITLE1_BOLD, pair.Value);
                            sqlUtils.writeRow_local(tempRow1);
                            retInfo.title1Guids.Add(tempRow1.TitleCn + "\r\n" + tempRow1.Guid);
                            //retInfo.retTable.Rows.Add(tempRow1);
                            break;
                        }
                    }
                    if (tempRow1 == null)////若一级标题下无内容，有二级目录
                    {
                        tempRow1 = new ConventionRow(rootConvention, str_title1List[i],
                                i + 1, ConventionOptions.CATEGORY.IS_CATEGORY);
                        sqlUtils.writeRow_local(tempRow1);
                        retInfo.title1Guids.Add(tempRow1.TitleCn + "\r\n" + tempRow1.Guid);
                        //retInfo.retTable.Rows.Add(tempRow1);
                    }
                    for (int j = 0, k = 0; j < title2Nodes.Count; j++)
                    {
                        tmp_rootConvention = tempRow1;
                        if (i < title1Nodes.Count - 1)
                        {
                            if (title2Nodes[j].Line < title1Nodes[i + 1].Line && title2Nodes[j].Line > title1Nodes[i].Line)
                            {
                                ConventionRow tempRow2 = new ConventionRow(tmp_rootConvention, str_title2List[j],
                                    ++k, ConventionOptions.CATEGORY.IS_TITLE1_BOLD, str_contentList[j]);
                                sqlUtils.writeRow_local(tempRow2);
                                //retInfo.retTable.Rows.Add(tempRow2);                         
                            }
                        }
                        else if (title2Nodes[j].Line > title1Nodes[i].Line)
                        {
                            ConventionRow tempRow2 = new ConventionRow(tmp_rootConvention, str_title2List[j],
                                ++k, ConventionOptions.CATEGORY.IS_TITLE1_BOLD, str_contentList[j]);
                            sqlUtils.writeRow_local(tempRow2);
                            //retInfo.retTable.Rows.Add(tempRow2);
                        }
                    }
                }
                retInfo.title1s = str_title1List;
                retInfo.title2s = str_title2List;
                retInfo.dic_title1Contents = str_title2List;
                retInfo.title2Contents = str_contentList;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                retInfo.errorInfo="录入失败。错误原因：" + err.Message;
            }
            return retInfo;
            #endregion
        }
        #region 废弃代码
        //public void ReadWordText()
        //{
        //    Word.Application app = new Word.Application();
        //    Word.Document doc = null;
        //    try
        //    {
        //        object unknow = Type.Missing;
        //        app.Visible = false;
        //        object file = catalogPath;
        //        doc = app.Documents.Open(ref file,
        //            ref unknow, ref unknow, ref unknow, ref unknow,
        //            ref unknow, ref unknow, ref unknow, ref unknow,
        //            ref unknow, ref unknow, ref unknow, ref unknow,
        //            ref unknow, ref unknow, ref unknow);
        //        doc.ActiveWindow.Selection.WholeStory();
        //        doc.ActiveWindow.Selection.Copy();
        //        IDataObject data = Clipboard.GetDataObject();
        //        text = data.GetData(DataFormats.Text).ToString();
        //        doc.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //        doc.Close();
        //    }
        //}
        //public void ReadCatalogue(ConventionRow rootNode)
        //{
        //    ConventionRowTree.Data = rootNode;
        //    MatchCollection allTitle_matches = Regex.Matches(text, Patterns.allTitle, RegexOptions.Multiline);
        //    MatchCollection title1_matches = Regex.Matches(text, Patterns.Title1, RegexOptions.Multiline);
        //    foreach (Match mymatch in allTitle_matches)
        //    {
        //        Console.WriteLine(mymatch.Value);
        //    }
        //    //string[] subTitles = text.Split(new string[] { "\r\r" },StringSplitOptions.RemoveEmptyEntries);
        //    //删除空行
        //    for (int i = 0; i < title1_matches.Count; i++)
        //    {
        //        ConventionRow tempRow = new ConventionRow(rootNode.Guid, rootNode.Depth + 1, title1_matches[i].Value,
        //            ConventionRowTree.NodeNumber + 1, ConventionOptions.CATEGORY.IS_CATEGORY);
        //        Tree<ConventionRow> ConventionNode1 = new Tree<ConventionRow>(tempRow);
        //        ConventionRowTree.AddNode(ConventionNode1);
        //        //Console.WriteLine(ConventionRowTree.NodeNumber);
        //        //Console.WriteLine(ConventionNode1.Data.TitleCn);  
        //    }
        //    for (int i = -1, j = 0; j < allTitle_matches.Count; j++)
        //    {
        //        if (title1_matches[i + 1].Value == allTitle_matches[j].Value)
        //        {
        //            i++;
        //            continue;
        //        }
        //        ConventionRow tempRow2 = new ConventionRow(ConventionRowTree.Nodes[i].Data.Guid,
        //            ConventionRowTree.Nodes[i].Data.Depth + 1, allTitle_matches[j].Value,
        //            ConventionRowTree.Nodes[i].NodeNumber + 1, ConventionOptions.CATEGORY.IS_TITLE1_BOLD);
        //        Tree<ConventionRow> ConventionNode2 = new Tree<ConventionRow>(tempRow2);
        //        ConventionRowTree.Nodes[i].AddNode(ConventionNode2);
        //        Console.WriteLine(ConventionNode2.Data.TitleCn);
        //    }
        //    Console.WriteLine("Yes");
        //} 
        #endregion
       
    }
    public class ReturnInfo
    {
        public List<string> titles=new List<string> ();
        public List<string> title1s=new List<string> ();
        public List<string> title2s=new List<string>();
        public List<string> dic_title1Contents=new List<string> ();
        public List<string> title2Contents=new List<string>();
        public List<string> title1Guids=new List<string>();
        public string errorInfo;
        public DataTable retTable=new DataTable ();
    }
    public static class Patterns
    {
        public static string imageSrc = @"(<img\s+width=" + "\"" + @"?\d+" + "\"" + @"?\s+height=" + "\"" + @"?\d+" + "\"" + @"?\s+src=['" + "\"" + @"])[\s\S]+?(/image[\s\S]+?['" + "\"" + @"]>)";
        //public static string Title1 = @"第\d{1,}章[\s\S]+?(?=\s\d{1,3}\r)";//查找一级标题
        //public static string subTitle = @"第\d{1,}章[\s\S]+?(?=\r)";//查找一级标题
        //public static string allTitle = @"^[^\r][\s\S]+?(?=\s\d{1,3}\r)";//按行查找，去除空行，去除页码，匹配两种标题
    }
    public enum ReadMethod
    {
        TITLE1_BOLD = 0,
        TITLE_TAG = 1,
        TITLE_SPANSTYLE = 2,
    }
}

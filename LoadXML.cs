using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Collections;
using System.IO;
using System.Xml.Linq;
namespace WordRead
{
    public class ToXML
    {        
        static public void SaveToXml(TreeView treeView1,string path)
        {
            XDeclaration dec = new XDeclaration("1.0", "utf-8", "yes");
            XDocument xml = new XDocument(dec);
            XElement root = new XElement("Tree");
            foreach (TreeNode node in treeView1.Nodes)
            {
                XElement e = CreateElements(node);
                root.Add(e);
            }
            xml.Add(root);
            xml.Save(path);
        }
        static private XElement CreateElements(TreeNode node)
        {
            XElement root = CreateElement(node);
            foreach (TreeNode n in node.Nodes)
            {
                XElement e = CreateElements(n);
                root.Add(e);
            }
            return root;
        }
        static private XElement CreateElement(TreeNode node)
        {
            return new XElement("Node",
                new XAttribute("Name", node.Name),
                new XAttribute("Text", node.Text)
                );
        }
        #region 废弃代码
        //XmlDocument doc = new XmlDocument();
        //StringBuilder sb = new StringBuilder();
        ////XML每行的内容
        //private string xmlLine = "";
        //private void parseNode(TreeNode tn, StringBuilder sb)
        //{
        //    IEnumerator ie = tn.Nodes.GetEnumerator();
        //    while (ie.MoveNext())
        //    {
        //        TreeNode ctn = (TreeNode)ie.Current;
        //        xmlLine = GetRSSText(ctn);
        //        sb.Append(xmlLine);
        //        //如果还有子节点则继续遍历
        //        if (ctn.Nodes.Count > 0)
        //        {
        //            parseNode(ctn, sb);
        //        }
        //        sb.Append("</Node>");
        //    }
        //}
        ////成生RSS节点的XML文本行
        //private string GetRSSText(TreeNode node)
        //{
        //    //根据Node属性生成XML文本
        //    string rssText = "<Node Name=\"" + node.Name + "\" Text=\"" + node.Text + "\" >";
        //    return rssText;
        //}
        //public void SaveXml_Click(TreeView treeView1,string path)
        //{
        //    try
        //    {
        //        //写文件头部内容
        //        //下面是生成RSS的OPML文件
        //        sb.Append("<?xml version=\"1.0\" encoding=\"UTF-8\"?>");
        //        sb.Append("<Tree>");
        //        //遍历根节点
        //        foreach (TreeNode node in treeView1.Nodes)
        //        {
        //            xmlLine = GetRSSText(node);
        //            sb.Append(xmlLine);
        //            //递归遍历节点
        //            parseNode(node, sb);
        //            sb.Append("</Node>");
        //        }
        //        sb.Append("</Tree>");
        //        StreamWriter sr = new StreamWriter(path, false, System.Text.Encoding.UTF8);
        //        sr.Write(sb.ToString());
        //        sr.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //    }
        //} 
        #endregion
    }
}

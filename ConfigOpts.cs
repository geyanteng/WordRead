using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordRead
{
    public static class RecogOptions
    {
        public const int title2RecogMethod = 0;//0->style;1->正则表达式识别
        public const bool title1_has_zitizihao = true;
        public const bool title2_has_zitizihao = true;
        public const int title1_child = 0;//0->不做子节点标签判断；1->加粗，包含b标签；2->包含a标签；
        public const int title2_child = 1;//0->不做子节点标签判断；1->加粗，包含b标签；2->包含a标签；
    }
    public partial class frmWordRead : Form
    {
        private void Form1_Load(object sender, EventArgs e)
        {
            this.tbParentGuid.Text = "11b6741f-a794-4f46-aaa5-2d539bf239a5";
            this.tbParentDepth.Text = "6";
            this.tbParentIDfolder.Text =
            "#f088ad64-8a9e-4ef6-a3e3-ac872a380283#ea00e0c5-53ca-4ce3-80b6-ff727c27f0b0#ce49ecc9-10cb-4760-8e9c-9446ad3f0eec#d4a72406-962b-410f-b489-49ad17fd55fd#181dd56b-44f2-4e82-85b1-dee286b520b0#b4a1dec0-c220-44b0-aa9f-ba9e529f68de#3f5b7215-5b30-4d2e-8d0b-a35568f77488";
            this.tbParentTitleCnFolder.Text =
            "0#@`船舶检验技术规则#@`国际海船#@`国际航行海船法定检验技术规则 2008#@`第5篇  防止船舶造成污染的结构与设备#@`2008规则#@`第1章   MARPOL73/78附则I—防止油类污染规则";
            this.tbHtmlPath.Text = @"../../../htmlRcgTest/1-gjhc(120)/num2(60)/di5pian/di1zhang/others.htm";
            this.tbFilesPath.Text = @"/Uploads/imagesrc/guojihaichuan/num2/di5pian/di1zhang";
            this.tbTitle1SpanStyle.Text = @"font-size:14.0pt;font-family:楷体_GB2312";
            this.tbTitle2SpanStyle.Text = @"font-size:12.0pt;font-family:宋体";
            /*****************************************/
            this.tbTitle1Xpath.Text = @"/html[1]/body[1]//span[@style]";
            this.tbTitle1TagName.Text = "h1";
            this.tbTitle2TagName.Text = "b";
            this.tbTitle2Xpath.Text = "";
            this.toolStripStatusLabel1.Text = "";
        }
    }
}

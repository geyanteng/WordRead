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
            this.tbParentGuid.Text = "a9bcff22-105d-4d3c-88e2-a620d11bd7de";
            this.tbParentDepth.Text = "";
            this.tbParentIDfolder.Text =
            "";
            this.tbParentTitleCnFolder.Text =
            "";
            this.tbHtmlPath.Text = @"../../../fagui\2009\3.htm";
            this.tbFilesPath.Text = @"/Uploads/imagesrc/guojihaichuan/num1/2009/3";
            this.tbTitle1SpanStyle.Text = @"font-size:15.0pt;font-family:黑体";
            this.tbTitle2SpanStyle.Text = @"ffont-size:14.0pt;font-family:仿宋";
            /*****************************************/
            this.tbTitle1Xpath.Text = @"/html[1]/body[1]//span[@style]";
            this.tbTitle1TagName.Text = "h1";
            this.tbTitle2TagName.Text = "b";
            this.tbTitle2Xpath.Text = "";
            this.toolStripStatusLabel1.Text = "";
        }
    }
}

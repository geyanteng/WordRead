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
        public const int title2_child = 0;//0->不做子节点标签判断；1->加粗，包含b标签；2->包含a标签；
    }
    public partial class frmWordRead : Form
    {
        private void Form1_Load(object sender, EventArgs e)
        {
            this.tbParentGuid.Text = "e0247277-bc23-4af0-b26a-c057a31acc2f";
            this.tbParentDepth.Text = "3";
            this.tbParentIDfolder.Text =
            "#f088ad64-8a9e-4ef6-a3e3-ac872a380283#ea00e0c5-53ca-4ce3-80b6-ff727c27f0b0#090ee5f5-1d77-4561-a17b-8b464aaad7aa#e0247277-bc23-4af0-b26a-c057a31acc2f";
            this.tbParentTitleCnFolder.Text =
            "0#@`船舶检验技术规则#@`内河船舶#@`内河船舶无线电通信设备规范 1995";
            this.tbHtmlPath.Text = @"../../../htmlRcgTest/3-nhcb(14_big53)/num18/1.htm";
            this.tbFilesPath.Text = @"/Uploads/imagesrc/neihechuanbo/num18";
            this.tbTitle1SpanStyle.Text = @"font-size:16.0pt;font-family:黑体";
            this.tbTitle2SpanStyle.Text = @"font-size:14.0pt;font-family:楷体";
            /*****************************************/
            this.tbTitle1Xpath.Text = @"/html[1]/body[1]//span[@style]";
            this.tbTitle1TagName.Text = "h1";
            this.tbTitle2TagName.Text = "b";
            this.tbTitle2Xpath.Text = "";
            this.toolStripStatusLabel1.Text = "";
        }
    }
}

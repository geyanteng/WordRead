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
        public const bool title1_has_zitizihao = false;
        public const bool title2_has_zitizihao = false;
        public const int title1_child = 0;//0->不做子节点标签判断；1->加粗，包含b标签；2->包含a标签；
        public const int title2_child = 0;//0->不做子节点标签判断；1->加粗，包含b标签；2->包含a标签；
    }
    public partial class frmWordRead : Form
    {
        private void Form1_Load(object sender, EventArgs e)
        {
            this.tbParentGuid.Text = "22f93a92-2f90-4b06-bced-74672612548f";
            this.tbParentDepth.Text = "3";
            this.tbParentIDfolder.Text =
            "#f088ad64-8a9e-4ef6-a3e3-ac872a380283#ea00e0c5-53ca-4ce3-80b6-ff727c27f0b0#8addb82d-dd27-456b-9ff2-bb179bacb549#22f93a92-2f90-4b06-bced-74672612548f";
            this.tbParentTitleCnFolder.Text =
            "0#@`船舶检验技术规则#@`国内海船#@`海上营运船舶检验规程（1984）";
            this.tbHtmlPath.Text = @"../../../htmlRcgTest/2-gnhc(56)/num10/1.htm";
            this.tbFilesPath.Text = @"/Uploads/imagesrc/guoneihaichuan/num10";
            this.tbTitle1SpanStyle.Text = @"font-family:宋体";
            this.tbTitle2SpanStyle.Text = @"font-family:宋体";
            /*****************************************/
            this.tbTitle1Xpath.Text = @"/html[1]/body[1]//span[@style]";
            this.tbTitle1TagName.Text = "h1";
            this.tbTitle2TagName.Text = "b";
            this.tbTitle2Xpath.Text = "";
            this.toolStripStatusLabel1.Text = "";
        }
    }
}

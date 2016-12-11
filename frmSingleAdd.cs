using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordRead
{
    public partial class frmSingleAdd : Form
    {
        private frmWordRead frm_WordRead; 
        public frmSingleAdd(frmWordRead frmwordread)
        {
            this.frm_WordRead = frmwordread;
            InitializeComponent();
        }
        private void SingleAdd_Load(object sender, EventArgs e)
        {
            
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Guid guid= new Guid();
            ConventionOptions.CATEGORY isCategory;
            if (tbGuid.Text == string.Empty)
            {
                guid = Guid.NewGuid();
                tbGuid.Text = guid.ToString();
            }
            else
            {
                guid = new Guid(this.tbGuid.Text);
            }
            if (cbkIsCategory.Checked)
                isCategory = ConventionOptions.CATEGORY.IS_CATEGORY;
            else
                isCategory = ConventionOptions.CATEGORY.IS_TITLE1_BOLD;
            try
            {
                ConventionRow tempRow = new ConventionRow(guid, new Guid(this.tbParentGuid.Text),
                    int.Parse(this.tbDepth.Text), this.tbTitle.Text, int.Parse(this.tbSNum.Text),
                    isCategory, this.tbIDfloder.Text + "#"+guid, this.tbTitleCNFolder.Text + "#@`"+this.tbTitle.Text,this.tbTag.Text);
                SQLUtils sqlUtils = SQLUtils.getInstance();
                sqlUtils.writeRow_local(tempRow);
                sqlUtils.updateTable();
                this.toolStripStatusLabel1.Text = "添加成功";
                this.frm_WordRead.tbParentDepth.Text = this.tbDepth.Text;
                this.frm_WordRead.tbParentGuid.Text = this.tbGuid.Text;
                this.frm_WordRead.tbParentIDfolder.Text = this.tbIDfloder.Text + "#" + this.tbGuid.Text;
                this.frm_WordRead.tbParentTitleCnFolder.Text = this.tbTitleCNFolder.Text + "@#`" + this.tbTitle.Text;
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
                this.toolStripStatusLabel1.Text = "添加失败" + err.Message;
            }
        }

        private void SingleAdd_FormClosed(object sender, FormClosedEventArgs e)
        {            
            this.frm_WordRead.singleAdd=null;
        }

        private void btnGetInfo_Click(object sender, EventArgs e)
        {
            if (this.tbParentGuid.Text != string.Empty)
            {
                try
                {
                    Guid guid = new Guid(this.tbParentGuid.Text);
                    SQLUtils sqlUtils = SQLUtils.getInstance();
                    DataRow infoRow=sqlUtils.getInfo(new Guid(this.tbParentGuid.Text));
                    this.tbTitleCNFolder.Text = infoRow["TitleCnFolder"].ToString();
                    this.tbIDfloder.Text = infoRow["IDFolder"].ToString();
                    this.tbDepth.Text = (int.Parse(infoRow["Depth"].ToString())+1).ToString();
                    this.toolStripStatusLabel1.Text = "获取信息成功";                 
                }
                catch(Exception err)
                {
                    Console.WriteLine(err.Message);
                    this.toolStripStatusLabel1.Text = "获取信息失败";
                }
            }
        }

        private void cbkIsCategory_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked == false)
            {
                this.tbTag.Enabled = true;
            }
            else
            {
                this.tbTag.Enabled = false;
            }
        }
    }
}

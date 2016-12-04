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
                isCategory = ConventionOptions.CATEGORY.IS_CONTENT;
            try
            {
                ConventionRow tempRow = new ConventionRow(guid, new Guid(this.tbParentGuid.Text),
                    int.Parse(this.tbDepth.Text), this.tbTitle.Text, int.Parse(this.tbSNum.Text),
                    isCategory, this.tbIDfloder.Text + "#"+guid, this.tbTitleCNFolder.Text + "#@`"+this.tbTitle.Text,this.tbTag.Text);
                SQLUtils sqlUtils = SQLUtils.getInstance();
                sqlUtils.writeRow_local(tempRow);
                sqlUtils.updateTable();
                this.toolStripStatusLabel1.Text = "添加成功";
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


    }
}

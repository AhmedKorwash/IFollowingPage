using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPageFollowing
{
    public partial class FacebookPages : Form
    {
        public FacebookPages()
        {
            InitializeComponent();
        }

        private void page_id_select_CheckedChanged(object sender, EventArgs e)
        {
            id_link_selector.Text = "ID";
        }

        private void page_link_select_CheckedChanged(object sender, EventArgs e)
        {
            id_link_selector.Text = "Page Profile Picture Link";
        }

        private void reg_btn_Click(object sender, EventArgs e)
        {
            MysqlFuncation sql = new MysqlFuncation();
            if (page_id_select.Checked)
            {
                if (sql.AddPage(id_link_text.Text, TypeInsertPage.ID))
                {
                    MessageBox.Show("Page Added");
                }
            }
            else
            {
                if (sql.AddPage(id_link_text.Text, TypeInsertPage.Link))
                {
                    MessageBox.Show("Page Added");
                }
            }
        }
    }
}

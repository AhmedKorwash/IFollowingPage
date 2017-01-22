using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;

namespace IPageFollowing
{
    public partial class FBAccount : Form
    {
        public FBAccount()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            EditeFBAccount edite = new EditeFBAccount();
            edite.ShowDialog();
        }

        private void FBAccount_Load(object sender, EventArgs e)
        {

        }

        private void reg_btn_Click(object sender, EventArgs e)
        {
            MysqlFuncation sql = new MysqlFuncation();
            if (sql.CreatAccount(Email_text.Text, pass_text.Text, token_text.Text))
            {
                MessageBox.Show("Account Created Successfully");
            }
        }
    }
}

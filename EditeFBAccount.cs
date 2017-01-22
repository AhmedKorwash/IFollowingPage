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
    public partial class EditeFBAccount : Form
    {
        public EditeFBAccount()
        {
            InitializeComponent();
        }
        private Dictionary<string, string> Pages;
        private Dictionary<string, string> Accounts;
        private void EditeFBAccount_Load(object sender, EventArgs e)
        {
            MysqlFuncation sql = new MysqlFuncation();
            Pages = new Dictionary<string, string>();
            Pages = sql.GetDataDictionary(TypeDataToGet.Pages);
            Accounts = new Dictionary<string, string>();
            Accounts = sql.GetDataDictionary(TypeDataToGet.Accounts);

            foreach (KeyValuePair<string, string> item in Accounts)
            {
                list_of_accounts.AddItem(item.Value);
                list_of_accounts_to_page.AddItem(item.Value);
            }
            foreach (KeyValuePair<string, string> item in Pages)
            {
                list_of_pages.AddItem(item.Key);
            }
        }

        private void reg_btn_Click(object sender, EventArgs e)
        {
            FBAcc acc = new FBAcc();
            acc.email = Email_text.Text;
            acc.password = pass_text.Text;
            acc.token = token_text.Text;
            MysqlFuncation sql = new MysqlFuncation();
            if (sql.UpdateAccount(list_of_accounts.selectedValue, acc))
            {
                MessageBox.Show("Account Updated");
            }
        }

        private void list_of_accounts_onItemSelected(object sender, EventArgs e)
        {
            MysqlFuncation sql = new MysqlFuncation();
            
            FBAcc acc = sql.GetSelectedAccount(list_of_accounts.selectedValue);
            Email_text.Text = acc.email;
            pass_text.Text = acc.password;
            token_text.Text = acc.token;
        }

        private void list_of_accounts_to_page_onItemSelected(object sender, EventArgs e)
        {
            
        }

        private void list_of_pages_onItemSelected(object sender, EventArgs e)
        {
            
        }

        private void setPageOwner_Click(object sender, EventArgs e)
        {
            if (list_of_pages.selectedValue != "" && list_of_accounts_to_page.selectedValue != "")
            {
                MysqlFuncation sql = new MysqlFuncation();
                if (sql.SetOwner(list_of_pages.selectedValue, list_of_accounts_to_page.selectedValue))
                {
                    MessageBox.Show(" Owner Setting Successfully Done");
                }
            }
        }

        
    }
}

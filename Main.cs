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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        private Dictionary<string, string> Accounts;
        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Enabled = false;
            save_task.Enabled = false;
            MysqlFuncation sql = new MysqlFuncation();
            Accounts = new Dictionary<string, string>();
            Accounts = sql.GetDataDictionary(TypeDataToGet.Accounts);
            foreach (KeyValuePair<string, string> item in Accounts)
            {
                account_for_setting.AddItem(item.Value);
            }
            List<string> commentfilename = sql.GetCommentFilesName();
            for (int i = 0; i < commentfilename.Count; i++)
            {
                comments_setting.AddItem(commentfilename[i]);
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            FBAccount account = new FBAccount();
            account.ShowDialog();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            EditeFBAccount edite = new EditeFBAccount();
            edite.ShowDialog();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            FacebookPages pages = new FacebookPages();
            pages.ShowDialog();
        }

        private void bunifuSlider1_ValueChanged(object sender, EventArgs e)
        {
            DesplayDelay.Text = ""+delay_setting.Value;
        }

        private void account_for_setting_onItemSelected(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (!listBox1.Enabled)
            {
                listBox1.Enabled = true;
            }
            MysqlFuncation sql = new MysqlFuncation();
            List<string> PagesId = sql.GetAccountPages(account_for_setting.selectedValue);
            for (int i = 0; i < PagesId.Count; i++)
            {
                listBox1.Items.Add(PagesId[i]);
            }
        }

        private void comment_adder_Click(object sender, EventArgs e)
        {
            if (commet_content.Text == "")
            {
                MessageBox.Show("This Comment Invalied Its Empty", "Error", MessageBoxButtons.OK , MessageBoxIcon.Error);
            }
            else
            {
                if (comment_list.Items.Contains(commet_content.Text))
                {
                    DialogResult res = MessageBox.Show("This Comment Found Do You need to Inserted", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res == System.Windows.Forms.DialogResult.Yes)
                    {
                        comment_list.Items.Add(commet_content.Text);
                    }
                }
                else
                {
                    comment_list.Items.Add(commet_content.Text);
                }
            }
            
        }

        private void save_comment_setting_Click(object sender, EventArgs e)
        {
            if (comment_name_setting.text == "")
            {
                MessageBox.Show("The Name Of Comment File Invalied Its Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comment_name_setting.Focus();
            }
            else
            {
                if (comment_list.Items.Count == 0)
                {
                    MessageBox.Show("The Comments File Empty Please Write at least one Comment", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    commet_content.Focus();
                }
                else
                {
                    MysqlFuncation sql = new MysqlFuncation();
                    if (sql.SendCommentFile(comment_list.Items, comment_name_setting.text))
                    {
                        MessageBox.Show("Comment File Genrated Successfully \nName is : "+comment_name_setting.text, "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        comment_list.Items.Clear();
                        commet_content.Text = "";
                    }
                }
            }
        }
        private bool stepTask = false;
        private void save_task_Click(object sender, EventArgs e)
        {
            try
            {
                Task task = new Task();
                task.Account = account_for_setting.selectedValue;
                task.CommentFile = comments_setting.selectedValue;
                task.Delay = delay_setting.Value;
                task.name = TaskName.Text;
                task.Pages = new List<string>();
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    if (listBox1.SelectedItems.Contains(listBox1.Items[i]))
                    task.Pages.Add(listBox1.Items[i].ToString());
                }
                MysqlFuncation sql = new MysqlFuncation();
                if (sql.MakeTask(task))
                {
                    MessageBox.Show("Task Genrated Successfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pages_setting_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comments_setting_onItemSelected(object sender, EventArgs e)
        {
            if (stepTask)
            {
                save_task.Enabled = true;
            }
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            Tasks task = new Tasks();
            task.ShowDialog();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            stepTask = true;
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            Informationss ins = new Informationss();
            ins.ShowDialog();

        }
    }
}

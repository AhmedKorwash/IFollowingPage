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
    public partial class Tasks : Form
    {
        public Tasks()
        {
            InitializeComponent();
        }
        private Dictionary<string, string> Accounts;
        private Dictionary<string, string> ListPost;
        private void Tasks_Load(object sender, EventArgs e)
        {
            ListPost = new Dictionary<string, string>();
            MysqlFuncation sql = new MysqlFuncation();
            List<string> list = sql.GetListOfTask();
            for (int i = 0; i < list.Count; i++)
            {
                slect_task.AddItem(list[i]);
            }
            SelectedPostRange.Hide();
            Accounts = new Dictionary<string, string>();
            Accounts = sql.GetDataDictionary(TypeDataToGet.Accounts);
            foreach (KeyValuePair<string, string> item in Accounts)
            {
                UserContainer.AddItem(item.Value);
            }
            List<string> commentfilename = sql.GetCommentFilesName();
            for (int i = 0; i < commentfilename.Count; i++)
            {
                CommentFILEContainer.AddItem(commentfilename[i]);
            }
        }

        private void FullRange_CheckedChanged(object sender, EventArgs e)
        {
            SelectedPostRange.Hide();
        }

        private void SelectRange_CheckedChanged(object sender, EventArgs e)
        {
            SelectedPostRange.Show();
        }

        private void play_task_Click(object sender, EventArgs e)
        {
            MysqlFuncation sql = new MysqlFuncation();
            Task tsk = sql.GetTask(slect_task.selectedValue);
            string token = sql.TokenGetter(tsk.Account);
            FacebookOperation face = new FacebookOperation(tsk,new Facebook.FacebookClient(token));
            face.Run(!FullRange.Checked);
        }

        private void UserContainer_onItemSelected(object sender, EventArgs e)
        {
            PageContainer.Clear();
            MysqlFuncation sql = new MysqlFuncation();
            List<string> PagesId = sql.GetAccountPages(UserContainer.selectedValue);
            for (int i = 0; i < PagesId.Count; i++)
            {
                PageContainer.AddItem(PagesId[i]);
            }
        }

        private void reloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (NumberOfPost.Text != string.Empty)
            {
                try
                {
                    MysqlFuncation sql = new MysqlFuncation();
                    string pageid = sql.PageIdGet(PageContainer.selectedValue);
                    sql.EditePostsContainer(ref PostContainer,ref ListPost, pageid,int.Parse( NumberOfPost.Text ));

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }   
            }
            else
            {
                MessageBox.Show("Sorry Please Check you have Select Page and Put Number Of Post To Retrive it");
            }
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PostContainer.Items.Clear();
            ListPost.Clear();
        }

        private void PlayerCommenter_Click(object sender, EventArgs e)
        {
            MysqlFuncation sql = new MysqlFuncation();
            sql.RunCommenter(ref PostContainer, ref ListPost, CommentFILEContainer.selectedValue, delay_setting.Value);
        }

        private void delay_setting_ValueChanged(object sender, EventArgs e)
        {
            DesplayDelay.Text = "" + delay_setting.Value;
        }
    }
}

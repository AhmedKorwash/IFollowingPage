using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Facebook;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace IPageFollowing
{
    class FacebookOperation
    {
        private Task task;
        private FacebookClient fb;
        public FacebookOperation(Task tsk,FacebookClient fb)
        {
            this.task = tsk;
            this.fb = fb;
        }
        public void Run(bool ranged)
        {
            ListOfPostId();
            if (ranged)
            {
                Thread th = new Thread(() =>
                {

                });
                th.Start();
            }
            else
            {
                Thread th = new Thread(() =>
                {
                    CommentingFull();
                });
                th.Start();
            }
        }
        private void ListOfPostId()
        {
            try
            {
                MysqlFuncation sql = new MysqlFuncation();

                for (int i = 0; i < task.Pages.Count; i++)
                {
                    string postid = PageId(task.Pages[i]);
                    dynamic datafull = fb.Get(postid + "/feed?fields=id");
                    int Count = (int)datafull.data.Count;
                    for (int u = 0; u < Count; u++)
                    {
                        string query = "";
                        query = "SELECT * FROM posts Where ID='" + datafull.data[u].id + "'";
                        int C = 0;
                        using (MySqlCommand cmd = new MySqlCommand(query, sql.conn))
                        {
                            sql.reader = cmd.ExecuteReader();
                            while (sql.reader.Read())
                            {
                                C++;
                            }
                            sql.reader.Close();
                        }
                        if (C == 0)
                        {
                            query = "Insert into posts(ID,Text) values ('" + datafull.data[u].id + "','" + datafull.data[u].message + "')";
                            using (MySqlCommand cmd = new MySqlCommand(query, sql.conn))
                            {
                                cmd.ExecuteNonQuery();
                            }
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private string PageId(string name)
        {
            MysqlFuncation sql = new MysqlFuncation();
            string id = "";
            string query = "SELECT * FROM pages Where Name='" + name + "'";
            MySqlCommand cmd = new MySqlCommand(query, sql.conn);
            sql.reader = cmd.ExecuteReader();
            while (sql.reader.Read())
            {
                 id = sql.reader["ID"].ToString();
            }
            sql.reader.Close();
            return id;
        }
        private bool CheckCommenting(string postid)
        {
            try
            {
                MysqlFuncation sql = new MysqlFuncation();
                string query = "SELECT * FROM garbage Where ID='" + postid + "'";
                using (MySqlCommand cmd = new MySqlCommand(query, sql.conn))
                {
                    sql.reader = cmd.ExecuteReader();
                    int count = 0;
                    while (sql.reader.Read())
                    {
                        count++;
                    }
                    sql.reader.Close();
                    if (count >= 1)
                        return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            
        }
        private void CommentingFull()
        {
            List<string> Comments = GetListComment(task.CommentFile);
            Random r = new Random();
            MysqlFuncation sql = new MysqlFuncation();
            string query = "SELECT * FROM posts";
            using (MySqlCommand cmd = new MySqlCommand(query, sql.conn))
            {

                sql.reader = cmd.ExecuteReader();
                while (sql.reader.Read())
                {
                    string postid = sql.reader["ID"].ToString();
                    if (!CheckCommenting(postid))
                    {
                        try
                        {
                            var parameters = new Dictionary<string, object>(); parameters["message"] = Comments[r.Next(0, Comments.Count - 1)];
                            dynamic result = fb.Post("/" + postid + "/comments", parameters);
                            DeletPost(postid);
                            Thread.Sleep(r.Next(task.Delay * 1000 * 60));
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                sql.reader.Close();
                
            }
        }
        private List<string> GetListComment(string filename)
        {
            try
            {
                List<string> list = new List<string>();
                MysqlFuncation sql = new MysqlFuncation();
                string query = "SELECT * FROM comments Where Name='" + filename + "'";
                using (MySqlCommand cmd = new MySqlCommand(query, sql.conn))
                {
                    sql.reader = cmd.ExecuteReader();
                    while (sql.reader.Read())
                    {
                        list.Add(sql.reader["Comment"].ToString());
                    }
                    sql.reader.Close();
                }
                return list;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            
        }
        private void DeletPost(string postid)
        {
            try
            {
                MysqlFuncation sql = new MysqlFuncation();
                string query = "Insert into garbage(ID) values ('" + postid + "')";
                using (MySqlCommand cmd = new MySqlCommand(query, sql.conn))
                {
                    cmd.ExecuteNonQuery();
                }
                query = "DELETE FROM posts Where ID='" + postid + "'";
                using (MySqlCommand cmd = new MySqlCommand(query, sql.conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        

        
    }
}

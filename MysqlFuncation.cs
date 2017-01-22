using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using Facebook;
using System.Windows.Forms;
using System.Threading;

namespace IPageFollowing
{
    public enum TypeInsertPage
    {
        ID = 1,
        Link =2
    }
    public enum TypeDataToGet
    {
        Accounts = 1,
        Pages = 2
    }
    public struct FBAcc
    {
        public string email;
        public string password;
        public string token;
    }
   public struct Task
    {
        public string Account;
        public List<string> Pages;
        public string CommentFile;
        public string name;
        public int Delay;
    }
  public  class MysqlFuncation
    {
        private string ConnectionString = "datasource=localhost;port=3306;database=xhd;username=root;password=123456";
        public MySqlConnection conn;
        public MySqlDataReader reader;

        public MysqlFuncation()
        {
            conn = new MySqlConnection(ConnectionString);
            conn.Open();
        }
         ~MysqlFuncation()
        {
            
            try
            {
                if(conn.State == System.Data.ConnectionState.Open)
                conn.Close();
            }
            catch { }
            try
            {
                if (!reader.IsClosed)
                {
                    reader.Close();
                }
            }
            catch { }
            
        }
         public string TokenGetter(string name)
         {
             string token = "";
             string query = "SELECT * FROM FBACC Where Name='" + name + "'";
             using (MySqlCommand cmd = new MySqlCommand(query, conn))
             {
                 reader = cmd.ExecuteReader();
                 while (reader.Read())
                 {
                     token = reader["Token"].ToString();
                     if (token != "")
                         break;
                 }
                 reader.Close();
             }
             return token;
         }
         public string TokenGetter()
         {
             string token = "";
             string query = "SELECT * FROM FBACC";
             using (MySqlCommand cmd = new MySqlCommand(query, conn))
             {
                 reader = cmd.ExecuteReader();
                 while (reader.Read())
                 {
                     token = reader["Token"].ToString();
                     if (token != "")
                         break;
                 }
                 reader.Close();
             }
             return token;
         }
         public string PageIdGet(string name)
         {
             string token = "";
             string query = "SELECT * FROM pages Where Name='" + name + "'";
             using (MySqlCommand cmd = new MySqlCommand(query, conn))
             {
                 reader = cmd.ExecuteReader();
                 while (reader.Read())
                 {
                     token = reader["ID"].ToString();
                     if (token != "")
                         break;
                 }
                 reader.Close();
             }
             return token;
         }
         public bool CreatAccount(string email,string password,string token)
         {
             try
             {
                 FacebookClient fb = new FacebookClient(token);
                 dynamic data = fb.Get("/me?fields=id,name");
                 dynamic datapic = fb.Get("/me?fields=picture");
                 string image = datapic.picture.data.url;
                 string query = "Insert into FBACC(UID,Name,Password,Email,Token,Image) values ('" + data.id + "','" + data.name + "','" + password + "','" + email + "','" + token + "','" + image + "')";
                 using (MySqlCommand cmd = new MySqlCommand(query, conn))
                 {
                     cmd.ExecuteNonQuery();
                     conn.Close();
                 }
                 
                 return true;
             }catch(Exception ex)
             {
                 MessageBox.Show(ex.Message);
                 return false;
             }
             
         }
         public bool AddPage(string id,TypeInsertPage type)
         {
             string query = "";
             try
             {
                 string token = TokenGetter();
                 FacebookClient fb = new FacebookClient(token);
                 if (type == TypeInsertPage.ID)
                 {
                     dynamic data = fb.Get(id + "?fields=id,name");
                     query = "Insert into pages(ID,Name) values ('" + data.id + "','" + data.name + "')";
                     using (MySqlCommand cmd = new MySqlCommand(query, conn))
                     {
                         cmd.ExecuteNonQuery();
                     }
                     conn.Close();
                     return true;
                 }
                 else
                 {
                     string[] ids = id.Split('/');
                     string idtemp = ids[5];
                     ids = idtemp.Split('.');
                     id = ids[3];
                     dynamic data = fb.Get(id + "?fields=id,name");
                     query = "Insert into pages(ID,Name) values ('" + id + "','" + data.name + "')";
                     using (MySqlCommand cmd = new MySqlCommand(query, conn))
                     {
                         cmd.ExecuteNonQuery();
                     }
                     conn.Close();
                     return true;
                 }
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message);
                 return false;
             }
         }
         public Dictionary<string, string> GetDataDictionary(TypeDataToGet type)
         {
             Dictionary<string, string> data = new Dictionary<string, string>();
             if (type == TypeDataToGet.Accounts)
             {
                 string query = "SELECT * FROM FBACC";
                 using (MySqlCommand cmd = new MySqlCommand(query, conn))
                 {
                     reader = cmd.ExecuteReader();
                     while (reader.Read())
                     {
                         data.Add(reader["UID"].ToString(), reader["Name"].ToString());
                     }
                     reader.Close();
                 }
             }
             else
             {
                 string query = "SELECT * FROM pages";
                 using (MySqlCommand cmd = new MySqlCommand(query, conn))
                 {
                     reader = cmd.ExecuteReader();
                     while (reader.Read())
                     {
                         data.Add(reader["Name"].ToString(), reader["ID"].ToString());
                     }
                     reader.Close();
                 }
             }
                 
             return data;
         }
         public FBAcc GetSelectedAccount(string name)
         {
             FBAcc fb = new FBAcc();
             string query = "SELECT * FROM FBACC WHERE Name='" + name + "'";
             using (MySqlCommand cmd = new MySqlCommand(query, conn))
             {
                 reader = cmd.ExecuteReader();
                 while (reader.Read())
                 {
                     fb.email = reader["Email"].ToString();
                     fb.password = reader["Password"].ToString();
                     fb.token = reader["Token"].ToString();
                 }
                 reader.Close();
             }
             
             
             return fb;
         }
         public void EditePostsContainer(ref CheckedListBox list, ref Dictionary<string, string> posts, string id, int max)
         {
             FacebookClient fb = new FacebookClient(TokenGetter());
             dynamic datapost = fb.Get(id + "/feed?fields=id,message&limit="+max);
             int Count = (int)datapost.data.Count;
             for (int i = 0; i < Count; i++)
             {
                 try
                 {
                     list.Items.Add(datapost.data[i].message);
                     posts.Add(datapost.data[i].message, datapost.data[i].id);
                 }
                 catch { }
             }
         }
         public bool UpdateAccount(string name,FBAcc fb)
         {
             try
             {
                 try
                 {
                     FacebookClient f = new FacebookClient(fb.token);
                     dynamic data = f.Get("/me?fields=picture");
                     string query = "Update fbacc Set Email='" + fb.email + "' Password='" + fb.password + "' Token='" + fb.token + "' Image='" + data.picture.data.url + "' WHERE Name='" + name + "'";
                     using (MySqlCommand cmd = new MySqlCommand(query, conn))
                     {
                         cmd.ExecuteNonQuery();
                     }
                     return true;
                 }
                 catch
                 {
                     MessageBox.Show("Your Accsess Token Not Valied !!!");
                     return false;
                 }
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message);
                 return false;
             }
         }
         public bool SetOwner(string pageName, string idOwner)
         {
             try
             {
                 string query = "Update pages Set Owner='" + idOwner + "'  WHERE Name='" + pageName + "'";
                 using (MySqlCommand cmd = new MySqlCommand(query, conn))
                 { cmd.ExecuteNonQuery(); }
                 return true;
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message);
                 return false;
             }
         }
         public List<string> GetAccountPages(string name)
         {
             List<string> id = new List<string>();
             try
             {
                 string query = "SELECT * FROM pages WHERE Owner='" + name + "'";
                 using (MySqlCommand cmd = new MySqlCommand(query, conn))
                 {
                     reader = cmd.ExecuteReader();
                     while (reader.Read())
                     {
                         id.Add(reader["Name"].ToString());
                     }
                     reader.Close();
                 }
                 return id;
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message);
                 return id;
             }
             
         }
         public bool SendCommentFile(ListBox.ObjectCollection listComment,string filename)
         {
             string query = "";
             try
             {
                 for (int i = 0; i < listComment.Count; i++)
                 {
                     query = "Insert into Comments(Comment,Name) values ('" + listComment[i] + "','" + filename + "')";
                     using (MySqlCommand cmd = new MySqlCommand(query, conn))
                     {
                         cmd.ExecuteNonQuery();
                     }
                 }
                 query = "Insert into CommentFile(CommentFile) values ('" + filename + "')";
                 using (MySqlCommand cmds = new MySqlCommand(query, conn))
                 {
                     cmds.ExecuteNonQuery();
                 }
                 if (conn.State == System.Data.ConnectionState.Open)
                     conn.Close();
                 return true;
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message);
                 return false;
             }   
         }
         public List<string> GetCommentFilesName()
         {
             List<string> list = new List<string>();
             try
             {
                 string query = "SELECT * FROM CommentFile";
                 MySqlCommand cmd = new MySqlCommand(query, conn);
                 reader = cmd.ExecuteReader();
                 while (reader.Read())
                 {
                     list.Add(reader["CommentFile"].ToString());
                 }
                 reader.Close();
                 return list;
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message);
             }
             return null;
         }
         public bool MakeTask(Task task)
         {
             try
             {
                 string listOfPageId = "";
                 for (int i = 0; i < task.Pages.Count; i++)
                 {
                     listOfPageId += task.Pages[i];
                     if (i != 0)
                         listOfPageId += "|";
                 }
                 string query = "";
                 query = "Insert into Task(Name,Account,Pages,Delay,CommentFile) values ('" + task.name + "','" + task.Account + "','" + listOfPageId + "','" + task.Delay + "','" + task.CommentFile + "')";
                 using (MySqlCommand cmd = new MySqlCommand(query, conn))
                 {
                     cmd.ExecuteNonQuery();
                 }
                 return true;
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message);
                 return false;
             }
         }
         public List<string> GetListOfTask()
         {
             List<string> list = new List<string>();

             try
             {
                 string query = "SELECT * FROM Task";
                 MySqlCommand cmd = new MySqlCommand(query, conn);
                 reader = cmd.ExecuteReader();
                 while (reader.Read())
                 {
                     list.Add(reader["Name"].ToString());
                 }
                 reader.Close();
                 return list;
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message);
             }
             return null;
         }
         public Task GetTask(string name)
         {
             Task tsk = new Task();
             try
             {
                 string query = "SELECT * FROM Task Where Name='" + name + "'";
                 MySqlCommand cmd = new MySqlCommand(query, conn);
                 reader = cmd.ExecuteReader();
                 while (reader.Read())
                 {
                     tsk.name = reader["Name"].ToString();
                     tsk.Account = reader["Account"].ToString();
                     tsk.CommentFile = reader["CommentFile"].ToString();
                     tsk.Delay = int.Parse(reader["Delay"].ToString());
                     string pages = reader["Pages"].ToString();
                     string[] arr = pages.Split('|');
                     tsk.Pages = new List<string>();
                     for (int i = 0; i < arr.Length; i++)
                     {
                         if (arr[i] !="")
                         tsk.Pages.Add(arr[i]);
                     }
                 }
                 reader.Close();
                 return tsk;
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message);
                 return tsk;
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
         public void RunCommenter(ref CheckedListBox list, ref Dictionary<string, string> posts,string commentfile,int delay)
         {
             var messpost = list.CheckedItems;
             List<string> ids = new List<string>();
             for (int i = 0; i < messpost.Count; i++)
             {
                 ids.Add(posts[messpost[i].ToString()]);
             }
             List<string> Comments = GetListComment(commentfile);
             Random r = new Random();
             FacebookClient fb = new FacebookClient(TokenGetter());
             Thread th = new Thread(() =>
             {
                 for (int i = 0; i < ids.Count; i++)
                 {
                     var parameters = new Dictionary<string, object>(); parameters["message"] = Comments[r.Next(0, Comments.Count - 1)];
                     dynamic result = fb.Post("/" + ids[i] + "/comments", parameters);
                     Thread.Sleep(delay * 1000 * 60);
                 }
             });
             th.Start();
         }
    }
}

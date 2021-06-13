using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InnoProjectSystem.src.Util;
using System.Data.SqlClient;

namespace InnoProjectSystem.src.models
{
    public class User
    {
        private string id;
        private string pwd;
        private string name;

        public User()
        {
        }

        public User(string id, string pwd, string name=null)
        {
            this.Id = id;
            this.Pwd = pwd;
            this.Name = name;
        }

        public string Id { get => id; set => id = value; }
        public string Pwd { get => pwd; set => pwd = value; }
        public string Name { get => name; set => name = value; }


        /*以下是User方法*/

        public bool ChangePwd(string newPwd)
        {
            bool res = false;

            SqlConnection cnn = DbUtil.getConnection();
            string cmdTxt = "Update Users set pwd=@pwd where Id=@Id";
            SqlCommand cmd = new SqlCommand(cmdTxt, cnn);

            cmd.Parameters.AddWithValue("@pwd", newPwd);
            cmd.Parameters.AddWithValue("@Id", this.Id);

            try
            {
                cnn.Open();
                res = cmd.ExecuteNonQuery() == 1 ? true : false;
            }
            catch(Exception e)
            {
                ;
            }
            finally
            {
                if (cnn.State == System.Data.ConnectionState.Open)
                    cnn.Close();
            }

            return res;
        }

        public bool Login()
        {
            SqlConnection cnn = DbUtil.getConnection();
            string cmdTxt = "Select name from Users where Id=@userid and pwd=@userpwd";
            SqlCommand cmd = new SqlCommand(cmdTxt, cnn);

            cmd.Parameters.AddWithValue("@userid", this.Id);
            cmd.Parameters.AddWithValue("@userpwd", this.Pwd);

            try
            {
                cnn.Open();
                object tempobj = cmd.ExecuteScalar();
                if (tempobj == null)
                {
                    cnn.Close();
                    return false;
                }
                this.name = tempobj.ToString();
            }
            catch (Exception e)
            {
                ;
            }
            finally
            {
                if (cnn.State == System.Data.ConnectionState.Open)
                    cnn.Close();
            }

            return true;
        }
    }
}

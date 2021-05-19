using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using System.Data.SqlClient;
using InnoProjectSystem.src.Util;

namespace InnoProjectSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        /*取消按钮，退出程序*/
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /*登录按钮，首先进行输入验证，再进行身份验证，均通过后进入程序*/
        private void AckBtn_Click(object sender, EventArgs e)
        {
            //输入验证
            if(UseridTxt.Text == String.Empty || PwdTxt.Text == String.Empty)
            {
                FaultLabel.Visible = true;
                return;
            }

            //身份验证
            string userid = UseridTxt.Text;
            string userpwd = PwdTxt.Text;

            string cmdTxt = "Select name from Users where Id=@userid and pwd=@userpwd";
            SqlConnection cnn = DbUtil.getConnection();
            SqlCommand cmd = new SqlCommand(cmdTxt, cnn);
            cmd.Parameters.AddWithValue("@userid", userid);
            cmd.Parameters.AddWithValue("@userpwd", userpwd);

            try
            {
                cnn.Open();
                if (cmd.ExecuteScalar() == null)
                {
                    FaultLabel.Visible = true;
                    return;
                }
            }
            catch(Exception ex)
            {
                ;
            }
            finally
            {
                if (cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }
            }

            //登录成功，返回确认值
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

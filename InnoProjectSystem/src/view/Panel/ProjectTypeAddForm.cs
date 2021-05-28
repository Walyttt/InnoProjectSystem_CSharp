using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using InnoProjectSystem.src.Util;
using InnoProjectSystem.src.models;

namespace InnoProjectSystem.src.view.Panel
{
    public partial class ProjectTypeAddForm : Form
    {
        public ProjectTypeAddForm()
        {
            InitializeComponent();
            this.PTNameTxt.Text = "";
            this.PTDescTxt.Text = "";
        }

        /*添加按钮事件*/
        private void AckBtn_Click(object sender, EventArgs e)
        {
            if(PTNameTxt.Text == String.Empty)
            {
                MessageBox.Show("请输入类型名");
                return;
            }

            SqlConnection sqlConnection = DbUtil.getConnection();
            string cmdTxt = "Insert Into ProjectType(PTName, PTDesc) Values(@ptname, @ptdesc)";
            SqlCommand cmd = new SqlCommand(cmdTxt, sqlConnection);
            cmd.Parameters.AddWithValue("@ptname", this.PTNameTxt.Text);
            cmd.Parameters.AddWithValue("@ptdesc", this.PTDescTxt.Text);

            int flag = 0;
            try
            {
                sqlConnection.Open();
                flag = cmd.ExecuteNonQuery();
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("失败：" + ex.Message);
            }
            finally
            {
                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }

            if (flag == 1)
            {
                MessageBox.Show("添加成功");
            }
            this.PTNameTxt.Text = "";
            this.PTDescTxt.Text = "";

            return;
        }
    }
}

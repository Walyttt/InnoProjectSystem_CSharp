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
    public partial class ProjectTypePanel : UserControl
    {
        private bool hasLoad = false;   //用于指示页面已加载完成
        public ProjectTypePanel()
        {
            InitializeComponent();
        }

        /*页面加载事件*/
        private void ProjectTypePanel_Load(object sender, EventArgs e)
        {
            //填充项目类型名列表框
            this.loadPTName();
            return;
        }

        /*选中项目类型查看描述*/
        private void PTNameLBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.hasLoad)
            {
                SqlConnection sqlConnection = DbUtil.getConnection();
                string cmdTxt = "Select PTDesc From ProjectType Where PTNo=@ptno";
                SqlCommand cmd = new SqlCommand(cmdTxt, sqlConnection);
                cmd.Parameters.AddWithValue("@ptno", this.PTNameLBox.SelectedValue.ToString());

                try
                {
                    sqlConnection.Open();
                    this.PTDescTxt.Text = cmd.ExecuteScalar().ToString();
                    sqlConnection.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if(sqlConnection.State == ConnectionState.Open)
                    {
                        sqlConnection.Close();
                    }
                }

                return;
            }
        }

        /*删除按钮处理*/
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if(PTNameLBox.SelectedItems.Count != 1)
            {
                MessageBox.Show("请选择一项");
                return;
            }
            if (MessageBox.Show("此操作会将该类型下所有项目同时删除，确认删除？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK) {
                SqlConnection sqlConnection1 = DbUtil.getConnection();
                SqlConnection sqlConnection2 = DbUtil.getConnection();
                string cmdTxt1 = "Delete From Project Where PTNo=@ptno";
                string cmdTxt2 = "Delete From ProjectType Where PTNo=@ptno";
                SqlCommand cmd1 = new SqlCommand(cmdTxt1, sqlConnection1);
                SqlCommand cmd2 = new SqlCommand(cmdTxt2, sqlConnection2);
                cmd1.Parameters.AddWithValue("@ptno", this.PTNameLBox.SelectedValue.ToString());
                cmd2.Parameters.AddWithValue("@ptno", this.PTNameLBox.SelectedValue.ToString());

                try
                {
                    sqlConnection1.Open();
                    sqlConnection2.Open();
                    cmd1.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();
                    sqlConnection1.Close();
                    sqlConnection2.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if (sqlConnection1.State == ConnectionState.Open)
                    {
                        sqlConnection1.Close();
                    }
                    if (sqlConnection2.State == ConnectionState.Open)
                    {
                        sqlConnection2.Close();
                    }
                }
            }
            this.loadPTName();
            return;
        }

        /*添加按钮*/
        private void AddBtn_Click(object sender, EventArgs e)
        {
            //以对话框形式打开添加窗口
            ProjectTypeAddForm projectpypeAddForm = new ProjectTypeAddForm();
            projectpypeAddForm.StartPosition = FormStartPosition.CenterScreen;
            projectpypeAddForm.ShowDialog();

            //重新加载类型名列表
            this.loadPTName();
            return;
        }

        /*加载类型名列表*/
        private void loadPTName()
        {
            DataTable ProjectTypeTable = new DataTable();
            SqlConnection sqlConnection = DbUtil.getConnection();
            SqlDataAdapter projecttypeAdapter = new SqlDataAdapter("select * from ProjectType", sqlConnection);
            projecttypeAdapter.Fill(ProjectTypeTable);

            this.PTNameLBox.DataSource = ProjectTypeTable;
            this.PTNameLBox.DisplayMember = "PTName";
            this.PTNameLBox.ValueMember = "PTNo";

            this.hasLoad = true;
            return;
        }
    }
}

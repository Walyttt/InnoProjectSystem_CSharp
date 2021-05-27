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

        /*选中项目类型查看描述*/
        private void PTNameLBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.hasLoad)
            {
                SqlConnection sqlConnection = DbUtil.getConnection();
                string cmdTxt = "Select PTDes From ProjectType Where PTNo=@ptno";
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
    }
}

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
    public partial class FacultyAddPanel : UserControl
    {
        public FacultyAddPanel()
        {
            InitializeComponent();
        }

        /*页面加载事件*/
        private void FacultyAddPanel_Load(object sender, EventArgs e)
        {
            //填充院系下拉框
            DataTable CollegeTable = new DataTable();
            SqlConnection sqlConnection = DbUtil.getConnection();
            SqlDataAdapter collegeAdapter = new SqlDataAdapter("select * from College", sqlConnection);
            collegeAdapter.Fill(CollegeTable);

            DataRow newrow = CollegeTable.NewRow();    //多创建一空选项
            
            this.CollegeCBox.DataSource = CollegeTable;
            this.CollegeCBox.DisplayMember = "ColName";
            this.CollegeCBox.ValueMember = "ColNo";

            this.Reset();
        }

        /*重置按钮*/
        private void RsBtn_Click(object sender, EventArgs e)
        {
            this.Reset();
        }

        private void AckBtn_Click(object sender, EventArgs e)
        {
            //判断必要信息是否填写完整
            if (this.IdTxt.Text == String.Empty ||
                this.NameTxt.Text == String.Empty ||
                this.GenderCBox.SelectedItem == null ||
                this.CollegeCBox.SelectedItem == null)
            {
                MessageBox.Show("请将必要信息填写完整");
                return;
            }

            //判断FNo的唯一
            object flag = null;
            SqlConnection sqlConnection = DbUtil.getConnection();
            string cmdTxt = "Select FName From Faculty Where FNo=@Fno";
            SqlCommand cmd = new SqlCommand(cmdTxt, sqlConnection);
            cmd.Parameters.AddWithValue("@Fno", IdTxt.Text);
            try
            {
                sqlConnection.Open();
                flag = cmd.ExecuteScalar();
                sqlConnection.Close();
            }
            catch(Exception ex)
            {
                ;
            }
            finally
            {
                if (sqlConnection.State == ConnectionState.Open)
                    sqlConnection.Close();
            }
            if(flag == null)
            {
                MessageBox.Show("编号已被占用");
                return;
            }

            //添加进入数据库
            cmdTxt = "Insert into Faculty Values(@FNo, @FName, @FGender, @ColNo, @FTitle, @FEmail)";
            cmd = new SqlCommand(cmdTxt, sqlConnection);
            cmd.Parameters.AddWithValue("@FNo", this.IdTxt.Text);
            cmd.Parameters.AddWithValue("@FName", this.NameTxt.Text);
            cmd.Parameters.AddWithValue("@FGender", this.GenderCBox.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@ColNo", this.CollegeCBox.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@FTitle", this.TitleTxt.Text);
            cmd.Parameters.AddWithValue("@FEmail", this.EmailTxt.Text);
            try
            {
                sqlConnection.Open();
                cmd.ExecuteNonQuery();
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                ;
            }
            finally
            {
                if (sqlConnection.State == ConnectionState.Open)
                    sqlConnection.Close();
            }
            return;
        }

        private void Reset()
        {
            this.IdTxt.Text = String.Empty;
            this.NameTxt.Text = String.Empty;
            this.GenderCBox.SelectedItem = null;
            this.CollegeCBox.SelectedItem = null;
            this.TitleTxt.Text = String.Empty;
            this.EmailTxt.Text = String.Empty;
        }
    }
}

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
    public partial class FacultyUpdateForm : Form
    {
        private Faculty f;

        public FacultyUpdateForm(Faculty faculty)
        {
            InitializeComponent();
            this.f = faculty;
        }

        //窗体加载事件
        private void FacultyUpdateForm_Load(object sender, EventArgs e)
        {
            //填充院系下拉框
            DataTable CollegeTable = new DataTable();
            SqlConnection sqlConnection = DbUtil.getConnection();
            SqlDataAdapter collegeAdapter = new SqlDataAdapter("select * from College", sqlConnection);
            collegeAdapter.Fill(CollegeTable);

            this.CollegeCBox.DataSource = CollegeTable;
            this.CollegeCBox.DisplayMember = "ColName";
            this.CollegeCBox.ValueMember = "ColNo";

            //填充当前教师信息
            this.IdTxt.Text = this.f.FNo;
            this.NameTxt.Text = this.f.FName;
            this.CollegeCBox.SelectedIndex = this.CollegeCBox.FindString(this.f.FCollege);
            this.GenderCBox.SelectedIndex = this.GenderCBox.FindString(this.f.FGender);
            this.TitleTxt.Text = this.f.FTitle;
            this.EmailTxt.Text = this.f.FEmail;
            
        }

        //取消按钮
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //确认修改按钮
        private void AckBtn_Click(object sender, EventArgs e)
        {
            //判断必要信息是否填写完整
            if (this.NameTxt.Text == String.Empty ||
                this.GenderCBox.SelectedItem == null ||
                this.CollegeCBox.SelectedItem == null)
            {
                MessageBox.Show("请将必要信息填写完整");
                return;
            }

            //修改进入数据库
            SqlConnection sqlConnection = DbUtil.getConnection();
            string cmdTxt = "Update Faculty set FName=@FName, FGender=@FGender, ColNo=@ColNo, FTitle=@FTitle, FEmail=@FEmail Where FNo=@Fno";
            SqlCommand cmd = new SqlCommand(cmdTxt, sqlConnection);
            cmd.Parameters.AddWithValue("@FNo", this.IdTxt.Text);
            cmd.Parameters.AddWithValue("@FName", this.NameTxt.Text);
            cmd.Parameters.AddWithValue("@FGender", this.GenderCBox.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@ColNo", this.CollegeCBox.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("@FTitle", this.TitleTxt.Text);
            cmd.Parameters.AddWithValue("@FEmail", this.EmailTxt.Text);
            try
            {
                sqlConnection.Open();
                if (cmd.ExecuteNonQuery() == 1)
                    MessageBox.Show("修改成功！");
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); ;
            }
            finally
            {
                if (sqlConnection.State == ConnectionState.Open)
                    sqlConnection.Close();
            }
            this.Close();
            return;
        }
    }
}

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
using System.Text.RegularExpressions;

namespace InnoProjectSystem.src.view.Panel
{
    public partial class ProjectUpdateForm : Form
    {
        private Project project;
        public ProjectUpdateForm(Project p)
        {
            InitializeComponent();
            this.project = p;
        }

        /*页面加载事件*/
        private void ProjectUpdateForm_Load(object sender, EventArgs e)
        {
            this.FillCollegeCBox();
            this.FillFacultyCBox();
            this.FillProjectTypeCBox();
            this.FillSubjectCBox();

            //填充信息
            this.IdTxt.Text = this.project.PNo;
            this.NameTxt.Text = this.project.PName;
            this.GroupTxt.Text = this.project.PGroup.ToString();
            this.CollegeCBox.SelectedIndex = this.CollegeCBox.FindString(this.project.ColName);
            this.FacultyCBox.SelectedIndex = this.FacultyCBox.FindString(this.project.FName);
            this.SubjectCBox.SelectedIndex = this.SubjectCBox.FindString(this.project.SubName);
            this.ProjectTypeCBox.SelectedIndex = this.ProjectTypeCBox.FindString(this.project.PtName);
            
            return;
        }

        /*切换院系单位时，重新加载负责人*/
        private void CollegeCBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.FillFacultyCBox(CollegeCBox.SelectedValue.ToString());
            FacultyCBox.SelectedItem = null;
        }

        /*取消按钮事件*/
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*确认修改事件*/
        private void AckBtn_Click(object sender, EventArgs e)
        {
            //首先判断信息输入完整
            if (this.NameTxt.Text == String.Empty ||
                this.GroupTxt.Text == String.Empty ||
                CollegeCBox.SelectedItem == null ||
                FacultyCBox.SelectedItem == null ||
                ProjectTypeCBox.SelectedItem == null ||
                SubjectCBox.SelectedItem == null)
            {
                MessageBox.Show("请完整填写信息");
                return;
            }

            //判断项目批次为正整数
            if (!this.IsPNumeric(this.GroupTxt.Text))
            {
                MessageBox.Show("请输入正确的项目批次");
                return;
            }

            //开始修改
            SqlConnection sqlConnection = DbUtil.getConnection();
            string cmdTxt = "Update Project Set PName=@PName, FNo=@FNo, PTNo=@PTNo, SubNo=@SubNo, PGroup=@PGroup where PNo=@PNo";
            SqlCommand cmd = new SqlCommand(cmdTxt, sqlConnection);
            cmd.Parameters.AddWithValue("@PNo", this.IdTxt.Text);
            cmd.Parameters.AddWithValue("@PName", this.NameTxt.Text);
            cmd.Parameters.AddWithValue("@FNo", this.FacultyCBox.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("@PTNo", Convert.ToInt32(this.ProjectTypeCBox.SelectedValue));
            cmd.Parameters.AddWithValue("@SubNo", this.SubjectCBox.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("@PGroup", int.Parse(this.GroupTxt.Text));
            try
            {
                sqlConnection.Open();
                if (cmd.ExecuteNonQuery() == 1)
                    MessageBox.Show("修改成功！"); ;
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

        //填充院系单位下拉框
        private void FillCollegeCBox()
        {
            DataTable CollegeTable = new DataTable();
            SqlConnection sqlConnection = DbUtil.getConnection();
            SqlDataAdapter collegeAdapter = new SqlDataAdapter("select * from College", sqlConnection);
            collegeAdapter.Fill(CollegeTable);

            this.CollegeCBox.DataSource = CollegeTable;
            this.CollegeCBox.DisplayMember = "ColName";
            this.CollegeCBox.ValueMember = "ColNo";
        }

        //根据院系单位填充负责人下拉框
        private void FillFacultyCBox(string ColNo = "")
        {
            DataTable FacultyTable = new DataTable();
            SqlConnection sqlConnection = DbUtil.getConnection();
            string cmdTxt = "select * from Faculty";
            if (ColNo != String.Empty)
            {
                cmdTxt += (" Where ColNo='" + ColNo + "'");
            }
            SqlDataAdapter facultyAdapter = new SqlDataAdapter(cmdTxt, sqlConnection);
            facultyAdapter.Fill(FacultyTable);

            this.FacultyCBox.DataSource = FacultyTable;
            this.FacultyCBox.DisplayMember = "FName";
            this.FacultyCBox.ValueMember = "FNo";
        }

        //填充学科下拉框
        private void FillSubjectCBox()
        {
            DataTable SubjectTable = new DataTable();
            SqlConnection sqlConnection = DbUtil.getConnection();
            SqlDataAdapter subjectAdapter = new SqlDataAdapter("select * from Subject", sqlConnection);
            subjectAdapter.Fill(SubjectTable);

            this.SubjectCBox.DataSource = SubjectTable;
            this.SubjectCBox.DisplayMember = "SubName";
            this.SubjectCBox.ValueMember = "SubNo";
        }

        //填充项目类型下拉框
        private void FillProjectTypeCBox()
        {
            DataTable ProjectTypeTable = new DataTable();
            SqlConnection sqlConnection = DbUtil.getConnection();
            SqlDataAdapter projecttypeAdapter = new SqlDataAdapter("select * from ProjectType", sqlConnection);
            projecttypeAdapter.Fill(ProjectTypeTable);

            this.ProjectTypeCBox.DataSource = ProjectTypeTable;
            this.ProjectTypeCBox.DisplayMember = "PTName";
            this.ProjectTypeCBox.ValueMember = "PTNo";
        }

        //判断字符串为正整数
        private bool IsPNumeric(string value)
        {
            return Regex.IsMatch(value, @"^[1-9]\d*$");
        }

    }
}

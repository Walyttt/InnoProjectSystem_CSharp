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
    public partial class ProjectQueryAndAlter : UserControl
    {
        public ProjectQueryAndAlter()
        {
            InitializeComponent();
        }

        /*查询事件处理*/
        private void QueryBtn_Click(object sender, EventArgs e)
        {

        }

        /*更改院系单位时，同时更新负责人下拉框*/
        private void CollegeCBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.FillFacultyCBox(CollegeCBox.SelectedValue.ToString());
            FacultyCBox.SelectedItem = null;
        }

        private void ProjectQueryAndAlter_Load(object sender, EventArgs e)
        {
            this.FillCollegeCBox();
            this.FillFacultyCBox();
            this.FillProjectTypeCBox();
            this.FillSubjectCBox();

            this.Reset();
            return;
        }

        /*将数据更新至DataView中*/
        private void DisplayData2View()
        {
            //构建查询语句
            string queryCmd = "Select FNo, FName, ColName, FGender, FTitle, FEmail " +
                "From Faculty, College " +
                "Where Faculty.ColNo = College.ColNo";
            if (CollegeCBox.SelectedValue != String.Empty)
            {
                queryCmd += (" and Faculty.ColNo='" + CollegeCBox.SelectedValue.ToString() + "'");
            }
            if (GenderCBox.SelectedItem != null && GenderCBox.SelectedItem.ToString() != String.Empty)
            {
                queryCmd += (" and FGender='" + GenderCBox.SelectedItem.ToString() + "'");
            }
            if (TitleTxt.Text != String.Empty)
            {
                queryCmd += (" and FTitle like '%" + TitleTxt.Text.ToString() + "%'");
            }
            if (NameTxt.Text != String.Empty)
            {
                queryCmd += (" and FName like '%" + NameTxt.Text.ToString() + "%'");
            }
            if (IdTxt.Text != String.Empty)
            {
                queryCmd += (" and FNo like '%" + IdTxt.Text.ToString() + "%'");
            }

            SqlDataAdapter FacultyAdapter = new SqlDataAdapter(queryCmd, this.sqlConnection);
            this.FacultyTable.Clear();
            FacultyAdapter.Fill(this.FacultyTable);
            this.FacultyView.DataSource = this.FacultyTable;

            string[] vs =
            {
                "员工号",
                "姓名",
                "院系单位",
                "性别",
                "职称",
                "电子邮箱"
            };
            for (int i = 0; i < 6; i++)
            {
                this.FacultyView.Columns[i].HeaderText = vs[i];
            }

            return;
        }


        //填充院系单位下拉框
        private void FillCollegeCBox()
        {
            DataTable CollegeTable = new DataTable();
            SqlConnection sqlConnection = DbUtil.getConnection();
            SqlDataAdapter collegeAdapter = new SqlDataAdapter("select * from College", sqlConnection);
            collegeAdapter.Fill(CollegeTable);

            DataRow newrow = CollegeTable.NewRow();    //多创建一空选项
            newrow["ColNo"] = "";
            newrow["ColName"] = "";
            CollegeTable.Rows.InsertAt(newrow, 0);

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

            DataRow newrow = FacultyTable.NewRow();    //多创建一空选项
            newrow["FNo"] = "";
            newrow["FName"] = "";
            FacultyTable.Rows.InsertAt(newrow, 0);

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

            DataRow newrow = SubjectTable.NewRow();    //多创建一空选项
            newrow["SubNo"] = "";
            newrow["SubName"] = "";
            SubjectTable.Rows.InsertAt(newrow, 0);

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

            DataRow newrow = ProjectTypeTable.NewRow();    //多创建一空选项
            newrow["PTNo"] = 0;
            newrow["PTName"] = "";
            ProjectTypeTable.Rows.InsertAt(newrow, 0);

            this.ProjectTypeCBox.DataSource = ProjectTypeTable;
            this.ProjectTypeCBox.DisplayMember = "PTName";
            this.ProjectTypeCBox.ValueMember = "PTNo";
        }

        //重置页面
        private void Reset()
        {
            this.IdTxt.Text = String.Empty;
            this.NameTxt.Text = String.Empty;
            this.GroupTxt.Text = String.Empty;
            CollegeCBox.SelectedItem = null;
            FacultyCBox.SelectedItem = null;
            ProjectTypeCBox.SelectedItem = null;
            SubjectCBox.SelectedItem = null;
            return;
        }

        //判断字符串为正整数
        private bool IsPNumeric(string value)
        {
            return Regex.IsMatch(value, @"^[1-9]\d*$");
        }

    }
}

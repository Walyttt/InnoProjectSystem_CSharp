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
using CrystalDecisions.CrystalReports.Engine;

namespace InnoProjectSystem.src.view.Panel
{
    public partial class ProjectQueryAndAlter : UserControl
    {
        SqlDataAdapter ProjectAdapter;
        DataTable ProjectTable;
        public ProjectQueryAndAlter()
        {
            InitializeComponent();
        }

        /*查询事件处理*/
        private void QueryBtn_Click(object sender, EventArgs e)
        {
            //首先对输入的批次进行验证
            if (this.GroupTxt.Text != String.Empty && !this.IsPNumeric(this.GroupTxt.Text))
            {
                MessageBox.Show("请输入正确的项目批次");
                return;
            }

            this.DisplayData2View();
            return;
        }

        /*更改院系单位时，同时更新负责人下拉框*/
        private void CollegeCBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.FillFacultyCBox(CollegeCBox.SelectedValue.ToString());
            FacultyCBox.SelectedIndex = 0;
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
            string queryCmd = "Select PNo, PName, ColName, FName, PTName, SubName, PGroup " +
                "From Faculty, College, Project, ProjectType, Subject " +
                "Where Faculty.ColNo = College.ColNo " +
                "and Project.FNo = Faculty.FNo " +
                "and Project.PTNo = ProjectType.PTNo " +
                "and Project.SubNo = Subject.SubNo";
            if (this.NameTxt.Text != String.Empty)
            {
                queryCmd += (" and PName like '%" + this.NameTxt.Text + "%'");
            }
            if (this.IdTxt.Text != String.Empty)
            {
                queryCmd += (" and PNo like '%" + this.IdTxt.Text + "%'");
            }
            if(this.CollegeCBox.SelectedIndex != 0)
            {
                queryCmd += (" and Faculty.ColNo='" + this.CollegeCBox.SelectedValue.ToString() + "'");
            }
            if(this.FacultyCBox.SelectedIndex != 0)
            {
                queryCmd += (" and Project.FNo='" + this.FacultyCBox.SelectedValue.ToString() + "'");
            }
            if(this.ProjectTypeCBox.SelectedIndex != 0)
            {
                queryCmd += (" and Project.PTNo='" + this.ProjectTypeCBox.SelectedValue.ToString() + "'");
            }
            if(this.SubjectCBox.SelectedIndex != 0)
            {
                queryCmd += (" and Project.SubNo='" + this.SubjectCBox.SelectedValue.ToString() + "'");
            }
            if (this.GroupTxt.Text != String.Empty)
            {
                queryCmd += (" and PGroup=" + this.GroupTxt.Text);
            }

            SqlConnection sqlConnection = DbUtil.getConnection();
            this.ProjectAdapter = new SqlDataAdapter(queryCmd, sqlConnection);
            this.ProjectTable = new DataTable();
            this.ProjectAdapter.Fill(this.ProjectTable);
            this.ProjectView.DataSource = this.ProjectTable;

            string[] vs =
            {
                "项目号",
                "项目名",
                "院系单位",
                "负责人",
                "项目类型",
                "学科",
                "批次"
            };
            for (int i = 0; i < 7; i++)
            {
                this.ProjectView.Columns[i].HeaderText = vs[i];
            }

            return;
        }

        /*删除按钮事件*/
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            //判断是否选中
            if (this.ProjectView.SelectedRows.Count == 0)
            {
                MessageBox.Show("未选中");
                return;
            }

            if (MessageBox.Show("确认删除？", "提示", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                return;
            }

            //选中，提取项目编号，开始删除
            for (int i = 0; i < this.ProjectView.SelectedRows.Count; i++)
            {
                string pno = "";
                pno = ProjectView.SelectedRows[i].Cells[0].Value.ToString();
                Project.DeleteByPno(pno);
            }

            //重新加载ProjectView
            DisplayData2View();
            return;
        }

        /*修改按钮事件*/
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            //首先判断选中记录数目是否为1
            if (this.ProjectView.SelectedRows.Count != 1)
            {
                MessageBox.Show("请选中一条记录");
                return;
            }

            //构建faculty实体，传入修改界面
            Project project = new Project();
            project.PNo = ProjectView.SelectedRows[0].Cells[0].Value.ToString();
            project.PName = ProjectView.SelectedRows[0].Cells[1].Value.ToString();
            project.ColName = ProjectView.SelectedRows[0].Cells[2].Value.ToString();
            project.FName = ProjectView.SelectedRows[0].Cells[3].Value.ToString();
            project.PtName = ProjectView.SelectedRows[0].Cells[4].Value.ToString();
            project.SubName = ProjectView.SelectedRows[0].Cells[5].Value.ToString();
            project.PGroup = Convert.ToInt32(ProjectView.SelectedRows[0].Cells[6].Value);

            //以对话框形式打开修改窗口
            ProjectUpdateForm projectUpdateForm = new ProjectUpdateForm(project);
            projectUpdateForm.StartPosition = FormStartPosition.CenterScreen;
            projectUpdateForm.ShowDialog();

            //更新查询结果
            this.DisplayData2View();
            return;
        }

        /*导出按钮事件处理*/
        private void OutputBtn_Click(object sender, EventArgs e)
        {
            ReportDocument rd = new ReportDocument();
            //获取报表路径
            string reportPath = "D:\\大学资料\\Window编程\\InnoProjectSystem\\InnoProjectSystem\\src\\ProjectReport.rpt";
            rd.Load(reportPath);

            //绑定数据集，注意一个表用一个数据集。
            DataSet ReportDS = new DataSet();
            DataTable ReportTable = this.ProjectTable;
            ReportTable.TableName = "ReportTable";

            ReportDS.Tables.Add(ReportTable);
            rd.SetDataSource(ReportDS);

            ReportForm reportForm = new ReportForm(rd);
            reportForm.ShowDialog();

            rd.Close();

            
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
            CollegeCBox.SelectedIndex = 0;
            FacultyCBox.SelectedIndex = 0;
            ProjectTypeCBox.SelectedIndex = 0;
            SubjectCBox.SelectedIndex = 0;
            return;
        }

        //判断字符串为正整数
        private bool IsPNumeric(string value)
        {
            return Regex.IsMatch(value, @"^[1-9]\d*$");
        }


    }
}

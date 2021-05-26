
namespace InnoProjectSystem.src.view.Panel
{
    partial class ProjectQueryAndAlter
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.ProjectTypeCBox = new System.Windows.Forms.ComboBox();
            this.ProjectTypeLabel = new System.Windows.Forms.Label();
            this.SubjectCBox = new System.Windows.Forms.ComboBox();
            this.SubjectLabel = new System.Windows.Forms.Label();
            this.FacultyCBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CollegeCBox = new System.Windows.Forms.ComboBox();
            this.CollegeLabel = new System.Windows.Forms.Label();
            this.GroupTxt = new System.Windows.Forms.TextBox();
            this.GroupLabel = new System.Windows.Forms.Label();
            this.IdTxt = new System.Windows.Forms.TextBox();
            this.IdLabel = new System.Windows.Forms.Label();
            this.NameTxt = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.QueryBtn = new System.Windows.Forms.Button();
            this.ProjectView = new System.Windows.Forms.DataGridView();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectView)).BeginInit();
            this.SuspendLayout();
            // 
            // ProjectTypeCBox
            // 
            this.ProjectTypeCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProjectTypeCBox.FormattingEnabled = true;
            this.ProjectTypeCBox.Location = new System.Drawing.Point(624, 96);
            this.ProjectTypeCBox.Name = "ProjectTypeCBox";
            this.ProjectTypeCBox.Size = new System.Drawing.Size(161, 23);
            this.ProjectTypeCBox.TabIndex = 70;
            // 
            // ProjectTypeLabel
            // 
            this.ProjectTypeLabel.AutoSize = true;
            this.ProjectTypeLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ProjectTypeLabel.Location = new System.Drawing.Point(517, 99);
            this.ProjectTypeLabel.Name = "ProjectTypeLabel";
            this.ProjectTypeLabel.Size = new System.Drawing.Size(109, 20);
            this.ProjectTypeLabel.TabIndex = 69;
            this.ProjectTypeLabel.Text = "项目类型：";
            // 
            // SubjectCBox
            // 
            this.SubjectCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SubjectCBox.FormattingEnabled = true;
            this.SubjectCBox.Location = new System.Drawing.Point(269, 95);
            this.SubjectCBox.Name = "SubjectCBox";
            this.SubjectCBox.Size = new System.Drawing.Size(161, 23);
            this.SubjectCBox.TabIndex = 68;
            // 
            // SubjectLabel
            // 
            this.SubjectLabel.AutoSize = true;
            this.SubjectLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SubjectLabel.Location = new System.Drawing.Point(182, 99);
            this.SubjectLabel.Name = "SubjectLabel";
            this.SubjectLabel.Size = new System.Drawing.Size(89, 20);
            this.SubjectLabel.TabIndex = 67;
            this.SubjectLabel.Text = "学  科：";
            // 
            // FacultyCBox
            // 
            this.FacultyCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FacultyCBox.FormattingEnabled = true;
            this.FacultyCBox.Location = new System.Drawing.Point(624, 48);
            this.FacultyCBox.Name = "FacultyCBox";
            this.FacultyCBox.Size = new System.Drawing.Size(161, 23);
            this.FacultyCBox.TabIndex = 66;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(517, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 20);
            this.label5.TabIndex = 65;
            this.label5.Text = "负 责 人：";
            // 
            // CollegeCBox
            // 
            this.CollegeCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CollegeCBox.FormattingEnabled = true;
            this.CollegeCBox.Location = new System.Drawing.Point(269, 47);
            this.CollegeCBox.Name = "CollegeCBox";
            this.CollegeCBox.Size = new System.Drawing.Size(161, 23);
            this.CollegeCBox.TabIndex = 64;
            this.CollegeCBox.SelectionChangeCommitted += new System.EventHandler(this.CollegeCBox_SelectionChangeCommitted);
            // 
            // CollegeLabel
            // 
            this.CollegeLabel.AutoSize = true;
            this.CollegeLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CollegeLabel.Location = new System.Drawing.Point(162, 51);
            this.CollegeLabel.Name = "CollegeLabel";
            this.CollegeLabel.Size = new System.Drawing.Size(109, 20);
            this.CollegeLabel.TabIndex = 63;
            this.CollegeLabel.Text = "院系单位：";
            // 
            // GroupTxt
            // 
            this.GroupTxt.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GroupTxt.Location = new System.Drawing.Point(269, 140);
            this.GroupTxt.Name = "GroupTxt";
            this.GroupTxt.Size = new System.Drawing.Size(161, 28);
            this.GroupTxt.TabIndex = 62;
            // 
            // GroupLabel
            // 
            this.GroupLabel.AutoSize = true;
            this.GroupLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GroupLabel.Location = new System.Drawing.Point(162, 148);
            this.GroupLabel.Name = "GroupLabel";
            this.GroupLabel.Size = new System.Drawing.Size(109, 20);
            this.GroupLabel.TabIndex = 61;
            this.GroupLabel.Text = "项目批次：";
            // 
            // IdTxt
            // 
            this.IdTxt.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IdTxt.Location = new System.Drawing.Point(624, 140);
            this.IdTxt.Name = "IdTxt";
            this.IdTxt.Size = new System.Drawing.Size(161, 28);
            this.IdTxt.TabIndex = 60;
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IdLabel.Location = new System.Drawing.Point(517, 148);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(109, 20);
            this.IdLabel.TabIndex = 59;
            this.IdLabel.Text = "项目编号：";
            // 
            // NameTxt
            // 
            this.NameTxt.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NameTxt.Location = new System.Drawing.Point(269, 189);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(249, 28);
            this.NameTxt.TabIndex = 58;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NameLabel.Location = new System.Drawing.Point(162, 197);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(109, 20);
            this.NameLabel.TabIndex = 57;
            this.NameLabel.Text = "项 目 名：";
            // 
            // QueryBtn
            // 
            this.QueryBtn.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.QueryBtn.Location = new System.Drawing.Point(653, 186);
            this.QueryBtn.Name = "QueryBtn";
            this.QueryBtn.Size = new System.Drawing.Size(132, 29);
            this.QueryBtn.TabIndex = 71;
            this.QueryBtn.Text = "查 询";
            this.QueryBtn.UseVisualStyleBackColor = true;
            this.QueryBtn.Click += new System.EventHandler(this.QueryBtn_Click);
            // 
            // ProjectView
            // 
            this.ProjectView.AllowUserToAddRows = false;
            this.ProjectView.AllowUserToDeleteRows = false;
            this.ProjectView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProjectView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProjectView.Location = new System.Drawing.Point(101, 234);
            this.ProjectView.Name = "ProjectView";
            this.ProjectView.ReadOnly = true;
            this.ProjectView.RowHeadersWidth = 70;
            this.ProjectView.RowTemplate.Height = 27;
            this.ProjectView.Size = new System.Drawing.Size(784, 308);
            this.ProjectView.TabIndex = 72;
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.UpdateBtn.Location = new System.Drawing.Point(573, 548);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(132, 29);
            this.UpdateBtn.TabIndex = 74;
            this.UpdateBtn.Text = "修 改";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DeleteBtn.Location = new System.Drawing.Point(298, 548);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(132, 29);
            this.DeleteBtn.TabIndex = 73;
            this.DeleteBtn.Text = "删 除";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            // 
            // ProjectQueryAndAlter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.ProjectView);
            this.Controls.Add(this.QueryBtn);
            this.Controls.Add(this.ProjectTypeCBox);
            this.Controls.Add(this.ProjectTypeLabel);
            this.Controls.Add(this.SubjectCBox);
            this.Controls.Add(this.SubjectLabel);
            this.Controls.Add(this.FacultyCBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CollegeCBox);
            this.Controls.Add(this.CollegeLabel);
            this.Controls.Add(this.GroupTxt);
            this.Controls.Add(this.GroupLabel);
            this.Controls.Add(this.IdTxt);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.NameTxt);
            this.Controls.Add(this.NameLabel);
            this.Name = "ProjectQueryAndAlter";
            this.Size = new System.Drawing.Size(979, 584);
            this.Load += new System.EventHandler(this.ProjectQueryAndAlter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProjectView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ProjectTypeCBox;
        private System.Windows.Forms.Label ProjectTypeLabel;
        private System.Windows.Forms.ComboBox SubjectCBox;
        private System.Windows.Forms.Label SubjectLabel;
        private System.Windows.Forms.ComboBox FacultyCBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CollegeCBox;
        private System.Windows.Forms.Label CollegeLabel;
        private System.Windows.Forms.TextBox GroupTxt;
        private System.Windows.Forms.Label GroupLabel;
        private System.Windows.Forms.TextBox IdTxt;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.TextBox NameTxt;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Button QueryBtn;
        private System.Windows.Forms.DataGridView ProjectView;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button DeleteBtn;
    }
}

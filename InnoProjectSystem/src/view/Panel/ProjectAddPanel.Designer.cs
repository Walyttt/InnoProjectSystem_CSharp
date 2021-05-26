
namespace InnoProjectSystem.src.view.Panel
{
    partial class ProjectAddPanel
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
            this.RsBtn = new System.Windows.Forms.Button();
            this.AckBtn = new System.Windows.Forms.Button();
            this.IdTxt = new System.Windows.Forms.TextBox();
            this.IdLabel = new System.Windows.Forms.Label();
            this.NameTxt = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.GroupTxt = new System.Windows.Forms.TextBox();
            this.GroupLabel = new System.Windows.Forms.Label();
            this.CollegeLabel = new System.Windows.Forms.Label();
            this.CollegeCBox = new System.Windows.Forms.ComboBox();
            this.FacultyCBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SubjectCBox = new System.Windows.Forms.ComboBox();
            this.SubjectLabel = new System.Windows.Forms.Label();
            this.ProjectTypeCBox = new System.Windows.Forms.ComboBox();
            this.ProjectTypeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RsBtn
            // 
            this.RsBtn.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RsBtn.Location = new System.Drawing.Point(557, 489);
            this.RsBtn.Name = "RsBtn";
            this.RsBtn.Size = new System.Drawing.Size(107, 32);
            this.RsBtn.TabIndex = 43;
            this.RsBtn.Text = "重  置";
            this.RsBtn.UseVisualStyleBackColor = true;
            this.RsBtn.Click += new System.EventHandler(this.RsBtn_Click);
            // 
            // AckBtn
            // 
            this.AckBtn.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AckBtn.Location = new System.Drawing.Point(314, 489);
            this.AckBtn.Name = "AckBtn";
            this.AckBtn.Size = new System.Drawing.Size(107, 32);
            this.AckBtn.TabIndex = 42;
            this.AckBtn.Text = "添  加";
            this.AckBtn.UseVisualStyleBackColor = true;
            this.AckBtn.Click += new System.EventHandler(this.AckBtn_Click);
            // 
            // IdTxt
            // 
            this.IdTxt.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IdTxt.Location = new System.Drawing.Point(276, 133);
            this.IdTxt.Name = "IdTxt";
            this.IdTxt.Size = new System.Drawing.Size(178, 28);
            this.IdTxt.TabIndex = 39;
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IdLabel.Location = new System.Drawing.Point(169, 141);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(109, 20);
            this.IdLabel.TabIndex = 38;
            this.IdLabel.Text = "项目编号：";
            // 
            // NameTxt
            // 
            this.NameTxt.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NameTxt.Location = new System.Drawing.Point(276, 197);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(178, 28);
            this.NameTxt.TabIndex = 37;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NameLabel.Location = new System.Drawing.Point(169, 205);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(109, 20);
            this.NameLabel.TabIndex = 36;
            this.NameLabel.Text = "项 目 名：";
            // 
            // GroupTxt
            // 
            this.GroupTxt.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GroupTxt.Location = new System.Drawing.Point(276, 260);
            this.GroupTxt.Name = "GroupTxt";
            this.GroupTxt.Size = new System.Drawing.Size(178, 28);
            this.GroupTxt.TabIndex = 47;
            // 
            // GroupLabel
            // 
            this.GroupLabel.AutoSize = true;
            this.GroupLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GroupLabel.Location = new System.Drawing.Point(169, 268);
            this.GroupLabel.Name = "GroupLabel";
            this.GroupLabel.Size = new System.Drawing.Size(109, 20);
            this.GroupLabel.TabIndex = 46;
            this.GroupLabel.Text = "项目批次：";
            // 
            // CollegeLabel
            // 
            this.CollegeLabel.AutoSize = true;
            this.CollegeLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CollegeLabel.Location = new System.Drawing.Point(524, 139);
            this.CollegeLabel.Name = "CollegeLabel";
            this.CollegeLabel.Size = new System.Drawing.Size(109, 20);
            this.CollegeLabel.TabIndex = 49;
            this.CollegeLabel.Text = "院系单位：";
            // 
            // CollegeCBox
            // 
            this.CollegeCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CollegeCBox.FormattingEnabled = true;
            this.CollegeCBox.Location = new System.Drawing.Point(631, 135);
            this.CollegeCBox.Name = "CollegeCBox";
            this.CollegeCBox.Size = new System.Drawing.Size(161, 23);
            this.CollegeCBox.TabIndex = 50;
            this.CollegeCBox.SelectionChangeCommitted += new System.EventHandler(this.CollegeCBox_SelectionChangeCommitted);
            // 
            // FacultyCBox
            // 
            this.FacultyCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FacultyCBox.FormattingEnabled = true;
            this.FacultyCBox.Location = new System.Drawing.Point(631, 202);
            this.FacultyCBox.Name = "FacultyCBox";
            this.FacultyCBox.Size = new System.Drawing.Size(161, 23);
            this.FacultyCBox.TabIndex = 52;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(524, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 20);
            this.label5.TabIndex = 51;
            this.label5.Text = "负 责 人：";
            // 
            // SubjectCBox
            // 
            this.SubjectCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SubjectCBox.FormattingEnabled = true;
            this.SubjectCBox.Location = new System.Drawing.Point(631, 265);
            this.SubjectCBox.Name = "SubjectCBox";
            this.SubjectCBox.Size = new System.Drawing.Size(161, 23);
            this.SubjectCBox.TabIndex = 54;
            // 
            // SubjectLabel
            // 
            this.SubjectLabel.AutoSize = true;
            this.SubjectLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SubjectLabel.Location = new System.Drawing.Point(544, 269);
            this.SubjectLabel.Name = "SubjectLabel";
            this.SubjectLabel.Size = new System.Drawing.Size(89, 20);
            this.SubjectLabel.TabIndex = 53;
            this.SubjectLabel.Text = "学  科：";
            // 
            // ProjectTypeCBox
            // 
            this.ProjectTypeCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProjectTypeCBox.FormattingEnabled = true;
            this.ProjectTypeCBox.Location = new System.Drawing.Point(631, 329);
            this.ProjectTypeCBox.Name = "ProjectTypeCBox";
            this.ProjectTypeCBox.Size = new System.Drawing.Size(161, 23);
            this.ProjectTypeCBox.TabIndex = 56;
            // 
            // ProjectTypeLabel
            // 
            this.ProjectTypeLabel.AutoSize = true;
            this.ProjectTypeLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ProjectTypeLabel.Location = new System.Drawing.Point(524, 332);
            this.ProjectTypeLabel.Name = "ProjectTypeLabel";
            this.ProjectTypeLabel.Size = new System.Drawing.Size(109, 20);
            this.ProjectTypeLabel.TabIndex = 55;
            this.ProjectTypeLabel.Text = "项目类型：";
            // 
            // ProjectAddPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.Controls.Add(this.RsBtn);
            this.Controls.Add(this.AckBtn);
            this.Controls.Add(this.IdTxt);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.NameTxt);
            this.Controls.Add(this.NameLabel);
            this.Name = "ProjectAddPanel";
            this.Size = new System.Drawing.Size(979, 584);
            this.Load += new System.EventHandler(this.ProjectAddPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button RsBtn;
        private System.Windows.Forms.Button AckBtn;
        private System.Windows.Forms.TextBox IdTxt;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.TextBox NameTxt;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox GroupTxt;
        private System.Windows.Forms.Label GroupLabel;
        private System.Windows.Forms.Label CollegeLabel;
        private System.Windows.Forms.ComboBox CollegeCBox;
        private System.Windows.Forms.ComboBox FacultyCBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox SubjectCBox;
        private System.Windows.Forms.Label SubjectLabel;
        private System.Windows.Forms.ComboBox ProjectTypeCBox;
        private System.Windows.Forms.Label ProjectTypeLabel;
    }
}

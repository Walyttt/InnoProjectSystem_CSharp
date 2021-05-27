
namespace InnoProjectSystem.src.view.Panel
{
    partial class ProjectUpdateForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
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
            this.CancelBtn = new System.Windows.Forms.Button();
            this.AckBtn = new System.Windows.Forms.Button();
            this.IdTxt = new System.Windows.Forms.TextBox();
            this.IdLabel = new System.Windows.Forms.Label();
            this.NameTxt = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ProjectTypeCBox
            // 
            this.ProjectTypeCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProjectTypeCBox.FormattingEnabled = true;
            this.ProjectTypeCBox.Location = new System.Drawing.Point(509, 307);
            this.ProjectTypeCBox.Name = "ProjectTypeCBox";
            this.ProjectTypeCBox.Size = new System.Drawing.Size(161, 23);
            this.ProjectTypeCBox.TabIndex = 72;
            // 
            // ProjectTypeLabel
            // 
            this.ProjectTypeLabel.AutoSize = true;
            this.ProjectTypeLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ProjectTypeLabel.Location = new System.Drawing.Point(402, 310);
            this.ProjectTypeLabel.Name = "ProjectTypeLabel";
            this.ProjectTypeLabel.Size = new System.Drawing.Size(109, 20);
            this.ProjectTypeLabel.TabIndex = 71;
            this.ProjectTypeLabel.Text = "项目类型：";
            // 
            // SubjectCBox
            // 
            this.SubjectCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SubjectCBox.FormattingEnabled = true;
            this.SubjectCBox.Location = new System.Drawing.Point(509, 225);
            this.SubjectCBox.Name = "SubjectCBox";
            this.SubjectCBox.Size = new System.Drawing.Size(161, 23);
            this.SubjectCBox.TabIndex = 70;
            // 
            // SubjectLabel
            // 
            this.SubjectLabel.AutoSize = true;
            this.SubjectLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SubjectLabel.Location = new System.Drawing.Point(422, 229);
            this.SubjectLabel.Name = "SubjectLabel";
            this.SubjectLabel.Size = new System.Drawing.Size(89, 20);
            this.SubjectLabel.TabIndex = 69;
            this.SubjectLabel.Text = "学  科：";
            // 
            // FacultyCBox
            // 
            this.FacultyCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FacultyCBox.FormattingEnabled = true;
            this.FacultyCBox.Location = new System.Drawing.Point(509, 145);
            this.FacultyCBox.Name = "FacultyCBox";
            this.FacultyCBox.Size = new System.Drawing.Size(161, 23);
            this.FacultyCBox.TabIndex = 68;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(402, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 20);
            this.label5.TabIndex = 67;
            this.label5.Text = "负 责 人：";
            // 
            // CollegeCBox
            // 
            this.CollegeCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CollegeCBox.FormattingEnabled = true;
            this.CollegeCBox.Location = new System.Drawing.Point(509, 62);
            this.CollegeCBox.Name = "CollegeCBox";
            this.CollegeCBox.Size = new System.Drawing.Size(161, 23);
            this.CollegeCBox.TabIndex = 66;
            this.CollegeCBox.SelectionChangeCommitted += new System.EventHandler(this.CollegeCBox_SelectionChangeCommitted);
            // 
            // CollegeLabel
            // 
            this.CollegeLabel.AutoSize = true;
            this.CollegeLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CollegeLabel.Location = new System.Drawing.Point(402, 66);
            this.CollegeLabel.Name = "CollegeLabel";
            this.CollegeLabel.Size = new System.Drawing.Size(109, 20);
            this.CollegeLabel.TabIndex = 65;
            this.CollegeLabel.Text = "院系单位：";
            // 
            // GroupTxt
            // 
            this.GroupTxt.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GroupTxt.Location = new System.Drawing.Point(154, 220);
            this.GroupTxt.Name = "GroupTxt";
            this.GroupTxt.Size = new System.Drawing.Size(178, 28);
            this.GroupTxt.TabIndex = 64;
            // 
            // GroupLabel
            // 
            this.GroupLabel.AutoSize = true;
            this.GroupLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GroupLabel.Location = new System.Drawing.Point(47, 228);
            this.GroupLabel.Name = "GroupLabel";
            this.GroupLabel.Size = new System.Drawing.Size(109, 20);
            this.GroupLabel.TabIndex = 63;
            this.GroupLabel.Text = "项目批次：";
            // 
            // CancelBtn
            // 
            this.CancelBtn.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CancelBtn.Location = new System.Drawing.Point(435, 416);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(107, 32);
            this.CancelBtn.TabIndex = 62;
            this.CancelBtn.Text = "取  消";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // AckBtn
            // 
            this.AckBtn.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AckBtn.Location = new System.Drawing.Point(192, 416);
            this.AckBtn.Name = "AckBtn";
            this.AckBtn.Size = new System.Drawing.Size(107, 32);
            this.AckBtn.TabIndex = 61;
            this.AckBtn.Text = "确  认";
            this.AckBtn.UseVisualStyleBackColor = true;
            this.AckBtn.Click += new System.EventHandler(this.AckBtn_Click);
            // 
            // IdTxt
            // 
            this.IdTxt.Enabled = false;
            this.IdTxt.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IdTxt.Location = new System.Drawing.Point(154, 60);
            this.IdTxt.Name = "IdTxt";
            this.IdTxt.Size = new System.Drawing.Size(178, 28);
            this.IdTxt.TabIndex = 60;
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IdLabel.Location = new System.Drawing.Point(47, 68);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(109, 20);
            this.IdLabel.TabIndex = 59;
            this.IdLabel.Text = "项目编号：";
            // 
            // NameTxt
            // 
            this.NameTxt.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NameTxt.Location = new System.Drawing.Point(154, 140);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(178, 28);
            this.NameTxt.TabIndex = 58;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NameLabel.Location = new System.Drawing.Point(47, 148);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(109, 20);
            this.NameLabel.TabIndex = 57;
            this.NameLabel.Text = "项 目 名：";
            // 
            // ProjectUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 508);
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
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.AckBtn);
            this.Controls.Add(this.IdTxt);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.NameTxt);
            this.Controls.Add(this.NameLabel);
            this.Name = "ProjectUpdateForm";
            this.Text = "ProjectUpdateForm";
            this.Load += new System.EventHandler(this.ProjectUpdateForm_Load);
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
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button AckBtn;
        private System.Windows.Forms.TextBox IdTxt;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.TextBox NameTxt;
        private System.Windows.Forms.Label NameLabel;
    }
}
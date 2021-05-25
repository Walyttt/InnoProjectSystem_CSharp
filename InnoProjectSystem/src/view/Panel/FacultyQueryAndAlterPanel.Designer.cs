
namespace InnoProjectSystem.src.view.Panel
{
    partial class FacultyQueryAndAlterPanel
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
            this.CollegeCBox = new System.Windows.Forms.ComboBox();
            this.CollegeLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.GenderCBox = new System.Windows.Forms.ComboBox();
            this.GenderLabel = new System.Windows.Forms.Label();
            this.TitleTxt = new System.Windows.Forms.TextBox();
            this.NameTxt = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.IdTxt = new System.Windows.Forms.TextBox();
            this.IdLabel = new System.Windows.Forms.Label();
            this.QueryBtn = new System.Windows.Forms.Button();
            this.FacultyView = new System.Windows.Forms.DataGridView();
            this.DeleteBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FacultyView)).BeginInit();
            this.SuspendLayout();
            // 
            // CollegeCBox
            // 
            this.CollegeCBox.DisplayMember = "ColNo";
            this.CollegeCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CollegeCBox.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CollegeCBox.FormattingEnabled = true;
            this.CollegeCBox.Location = new System.Drawing.Point(261, 49);
            this.CollegeCBox.Name = "CollegeCBox";
            this.CollegeCBox.Size = new System.Drawing.Size(161, 26);
            this.CollegeCBox.TabIndex = 3;
            this.CollegeCBox.ValueMember = "ColNo";
            // 
            // CollegeLabel
            // 
            this.CollegeLabel.AutoSize = true;
            this.CollegeLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CollegeLabel.Location = new System.Drawing.Point(156, 52);
            this.CollegeLabel.Name = "CollegeLabel";
            this.CollegeLabel.Size = new System.Drawing.Size(99, 20);
            this.CollegeLabel.TabIndex = 2;
            this.CollegeLabel.Text = "学   院：";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TitleLabel.Location = new System.Drawing.Point(156, 119);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(99, 20);
            this.TitleLabel.TabIndex = 6;
            this.TitleLabel.Text = "职   称：";
            // 
            // GenderCBox
            // 
            this.GenderCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GenderCBox.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GenderCBox.FormattingEnabled = true;
            this.GenderCBox.Items.AddRange(new object[] {
            "",
            "男",
            "女"});
            this.GenderCBox.Location = new System.Drawing.Point(635, 49);
            this.GenderCBox.Name = "GenderCBox";
            this.GenderCBox.Size = new System.Drawing.Size(161, 26);
            this.GenderCBox.TabIndex = 5;
            // 
            // GenderLabel
            // 
            this.GenderLabel.AutoSize = true;
            this.GenderLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GenderLabel.Location = new System.Drawing.Point(530, 52);
            this.GenderLabel.Name = "GenderLabel";
            this.GenderLabel.Size = new System.Drawing.Size(99, 20);
            this.GenderLabel.TabIndex = 4;
            this.GenderLabel.Text = "性   别：";
            // 
            // TitleTxt
            // 
            this.TitleTxt.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TitleTxt.Location = new System.Drawing.Point(261, 114);
            this.TitleTxt.Name = "TitleTxt";
            this.TitleTxt.Size = new System.Drawing.Size(161, 28);
            this.TitleTxt.TabIndex = 7;
            // 
            // NameTxt
            // 
            this.NameTxt.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NameTxt.Location = new System.Drawing.Point(635, 114);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(161, 28);
            this.NameTxt.TabIndex = 9;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NameLabel.Location = new System.Drawing.Point(530, 119);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(99, 20);
            this.NameLabel.TabIndex = 8;
            this.NameLabel.Text = "姓   名：";
            // 
            // IdTxt
            // 
            this.IdTxt.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IdTxt.Location = new System.Drawing.Point(261, 179);
            this.IdTxt.Name = "IdTxt";
            this.IdTxt.Size = new System.Drawing.Size(161, 28);
            this.IdTxt.TabIndex = 11;
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IdLabel.Location = new System.Drawing.Point(156, 184);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(109, 20);
            this.IdLabel.TabIndex = 10;
            this.IdLabel.Text = "职 工 号：";
            // 
            // QueryBtn
            // 
            this.QueryBtn.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.QueryBtn.Location = new System.Drawing.Point(534, 180);
            this.QueryBtn.Name = "QueryBtn";
            this.QueryBtn.Size = new System.Drawing.Size(132, 29);
            this.QueryBtn.TabIndex = 12;
            this.QueryBtn.Text = "查 询";
            this.QueryBtn.UseVisualStyleBackColor = true;
            this.QueryBtn.Click += new System.EventHandler(this.QueryBtn_Click);
            // 
            // FacultyView
            // 
            this.FacultyView.AllowUserToAddRows = false;
            this.FacultyView.AllowUserToDeleteRows = false;
            this.FacultyView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.FacultyView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FacultyView.Location = new System.Drawing.Point(114, 240);
            this.FacultyView.Name = "FacultyView";
            this.FacultyView.ReadOnly = true;
            this.FacultyView.RowHeadersWidth = 70;
            this.FacultyView.RowTemplate.Height = 27;
            this.FacultyView.Size = new System.Drawing.Size(784, 308);
            this.FacultyView.TabIndex = 13;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DeleteBtn.Location = new System.Drawing.Point(734, 180);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(132, 29);
            this.DeleteBtn.TabIndex = 14;
            this.DeleteBtn.Text = "删 除";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // FacultyQueryAndAlterPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.FacultyView);
            this.Controls.Add(this.QueryBtn);
            this.Controls.Add(this.IdTxt);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.NameTxt);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.TitleTxt);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.GenderCBox);
            this.Controls.Add(this.GenderLabel);
            this.Controls.Add(this.CollegeCBox);
            this.Controls.Add(this.CollegeLabel);
            this.Name = "FacultyQueryAndAlterPanel";
            this.Size = new System.Drawing.Size(979, 584);
            this.Load += new System.EventHandler(this.FacultyQueryAndAlterPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FacultyView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox CollegeCBox;
        private System.Windows.Forms.Label CollegeLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.ComboBox GenderCBox;
        private System.Windows.Forms.Label GenderLabel;
        private System.Windows.Forms.TextBox TitleTxt;
        private System.Windows.Forms.TextBox NameTxt;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox IdTxt;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Button QueryBtn;
        private System.Windows.Forms.DataGridView FacultyView;
        private System.Windows.Forms.Button DeleteBtn;
    }
}

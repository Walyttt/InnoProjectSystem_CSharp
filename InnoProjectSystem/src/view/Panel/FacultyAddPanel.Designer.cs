
namespace InnoProjectSystem.src.view.Panel
{
    partial class FacultyAddPanel
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
            this.IdTxt = new System.Windows.Forms.TextBox();
            this.IdLabel = new System.Windows.Forms.Label();
            this.NameTxt = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.TitleTxt = new System.Windows.Forms.TextBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.GenderCBox = new System.Windows.Forms.ComboBox();
            this.GenderLabel = new System.Windows.Forms.Label();
            this.CollegeCBox = new System.Windows.Forms.ComboBox();
            this.CollegeLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AckBtn = new System.Windows.Forms.Button();
            this.RsBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IdTxt
            // 
            this.IdTxt.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IdTxt.Location = new System.Drawing.Point(432, 31);
            this.IdTxt.Name = "IdTxt";
            this.IdTxt.Size = new System.Drawing.Size(161, 28);
            this.IdTxt.TabIndex = 21;
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IdLabel.Location = new System.Drawing.Point(327, 36);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(109, 20);
            this.IdLabel.TabIndex = 20;
            this.IdLabel.Text = "职 工 号：";
            // 
            // NameTxt
            // 
            this.NameTxt.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NameTxt.Location = new System.Drawing.Point(432, 95);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(161, 28);
            this.NameTxt.TabIndex = 19;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NameLabel.Location = new System.Drawing.Point(327, 100);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(99, 20);
            this.NameLabel.TabIndex = 18;
            this.NameLabel.Text = "姓   名：";
            // 
            // TitleTxt
            // 
            this.TitleTxt.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TitleTxt.Location = new System.Drawing.Point(432, 290);
            this.TitleTxt.Name = "TitleTxt";
            this.TitleTxt.Size = new System.Drawing.Size(161, 28);
            this.TitleTxt.TabIndex = 17;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TitleLabel.Location = new System.Drawing.Point(327, 295);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(99, 20);
            this.TitleLabel.TabIndex = 16;
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
            this.GenderCBox.Location = new System.Drawing.Point(432, 162);
            this.GenderCBox.Name = "GenderCBox";
            this.GenderCBox.Size = new System.Drawing.Size(161, 26);
            this.GenderCBox.TabIndex = 15;
            // 
            // GenderLabel
            // 
            this.GenderLabel.AutoSize = true;
            this.GenderLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GenderLabel.Location = new System.Drawing.Point(327, 165);
            this.GenderLabel.Name = "GenderLabel";
            this.GenderLabel.Size = new System.Drawing.Size(99, 20);
            this.GenderLabel.TabIndex = 14;
            this.GenderLabel.Text = "性   别：";
            // 
            // CollegeCBox
            // 
            this.CollegeCBox.DisplayMember = "ColNo";
            this.CollegeCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CollegeCBox.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CollegeCBox.FormattingEnabled = true;
            this.CollegeCBox.Location = new System.Drawing.Point(432, 225);
            this.CollegeCBox.Name = "CollegeCBox";
            this.CollegeCBox.Size = new System.Drawing.Size(161, 26);
            this.CollegeCBox.TabIndex = 13;
            this.CollegeCBox.ValueMember = "ColNo";
            // 
            // CollegeLabel
            // 
            this.CollegeLabel.AutoSize = true;
            this.CollegeLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CollegeLabel.Location = new System.Drawing.Point(327, 228);
            this.CollegeLabel.Name = "CollegeLabel";
            this.CollegeLabel.Size = new System.Drawing.Size(99, 20);
            this.CollegeLabel.TabIndex = 12;
            this.CollegeLabel.Text = "学   院：";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(432, 355);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(292, 28);
            this.textBox1.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(327, 360);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "电子邮箱：";
            // 
            // AckBtn
            // 
            this.AckBtn.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AckBtn.Location = new System.Drawing.Point(329, 456);
            this.AckBtn.Name = "AckBtn";
            this.AckBtn.Size = new System.Drawing.Size(107, 32);
            this.AckBtn.TabIndex = 24;
            this.AckBtn.Text = "添  加";
            this.AckBtn.UseVisualStyleBackColor = true;
            // 
            // RsBtn
            // 
            this.RsBtn.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RsBtn.Location = new System.Drawing.Point(572, 456);
            this.RsBtn.Name = "RsBtn";
            this.RsBtn.Size = new System.Drawing.Size(107, 32);
            this.RsBtn.TabIndex = 25;
            this.RsBtn.Text = "重  置";
            this.RsBtn.UseVisualStyleBackColor = true;
            // 
            // FacultyAddPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RsBtn);
            this.Controls.Add(this.AckBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
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
            this.Name = "FacultyAddPanel";
            this.Size = new System.Drawing.Size(979, 584);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IdTxt;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.TextBox NameTxt;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox TitleTxt;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.ComboBox GenderCBox;
        private System.Windows.Forms.Label GenderLabel;
        private System.Windows.Forms.ComboBox CollegeCBox;
        private System.Windows.Forms.Label CollegeLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AckBtn;
        private System.Windows.Forms.Button RsBtn;
    }
}

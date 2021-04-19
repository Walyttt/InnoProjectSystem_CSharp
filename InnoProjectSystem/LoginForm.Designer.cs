namespace InnoProjectSystem
{
    partial class LoginForm
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
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PwdLabel = new System.Windows.Forms.Label();
            this.UsernameTxt = new System.Windows.Forms.TextBox();
            this.PwdTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AckBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("仿宋", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.UsernameLabel.Location = new System.Drawing.Point(145, 179);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(94, 20);
            this.UsernameLabel.TabIndex = 0;
            this.UsernameLabel.Text = "账  号：";
            // 
            // PwdLabel
            // 
            this.PwdLabel.AutoSize = true;
            this.PwdLabel.Font = new System.Drawing.Font("仿宋", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PwdLabel.Location = new System.Drawing.Point(145, 233);
            this.PwdLabel.Name = "PwdLabel";
            this.PwdLabel.Size = new System.Drawing.Size(94, 20);
            this.PwdLabel.TabIndex = 1;
            this.PwdLabel.Text = "密  码：";
            // 
            // UsernameTxt
            // 
            this.UsernameTxt.Location = new System.Drawing.Point(245, 171);
            this.UsernameTxt.Name = "UsernameTxt";
            this.UsernameTxt.Size = new System.Drawing.Size(171, 28);
            this.UsernameTxt.TabIndex = 2;
            // 
            // PwdTxt
            // 
            this.PwdTxt.Location = new System.Drawing.Point(245, 225);
            this.PwdTxt.Name = "PwdTxt";
            this.PwdTxt.PasswordChar = '·';
            this.PwdTxt.Size = new System.Drawing.Size(171, 28);
            this.PwdTxt.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("仿宋", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(133, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "创新项目管理系统";
            // 
            // AckBtn
            // 
            this.AckBtn.Font = new System.Drawing.Font("仿宋", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AckBtn.Location = new System.Drawing.Point(140, 300);
            this.AckBtn.Name = "AckBtn";
            this.AckBtn.Size = new System.Drawing.Size(97, 31);
            this.AckBtn.TabIndex = 5;
            this.AckBtn.Text = "登  录";
            this.AckBtn.UseVisualStyleBackColor = true;
            // 
            // CancelBtn
            // 
            this.CancelBtn.Font = new System.Drawing.Font("仿宋", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CancelBtn.Location = new System.Drawing.Point(365, 300);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(97, 31);
            this.CancelBtn.TabIndex = 6;
            this.CancelBtn.Text = "取  消";
            this.CancelBtn.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            this.AcceptButton = this.AckBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(589, 417);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.AckBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PwdTxt);
            this.Controls.Add(this.UsernameTxt);
            this.Controls.Add(this.PwdLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Font = new System.Drawing.Font("仿宋", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.Text = "登   录";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label PwdLabel;
        private System.Windows.Forms.TextBox UsernameTxt;
        private System.Windows.Forms.TextBox PwdTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AckBtn;
        private System.Windows.Forms.Button CancelBtn;
    }
}

namespace InnoProjectSystem.src.view
{
    partial class PersonInfoPanel
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
            this.IdLabel = new System.Windows.Forms.Label();
            this.IdTxt = new System.Windows.Forms.TextBox();
            this.NameTxt = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.RNewpwdTxt = new System.Windows.Forms.TextBox();
            this.RNewpwdLabel = new System.Windows.Forms.Label();
            this.NewpwdTxt = new System.Windows.Forms.TextBox();
            this.NewpwdLabel = new System.Windows.Forms.Label();
            this.AckBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IdLabel.Location = new System.Drawing.Point(316, 194);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(99, 20);
            this.IdLabel.TabIndex = 0;
            this.IdLabel.Text = "账   号：";
            // 
            // IdTxt
            // 
            this.IdTxt.Enabled = false;
            this.IdTxt.Location = new System.Drawing.Point(421, 189);
            this.IdTxt.Name = "IdTxt";
            this.IdTxt.Size = new System.Drawing.Size(179, 25);
            this.IdTxt.TabIndex = 1;
            // 
            // NameTxt
            // 
            this.NameTxt.Enabled = false;
            this.NameTxt.Location = new System.Drawing.Point(421, 239);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(179, 25);
            this.NameTxt.TabIndex = 3;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NameLabel.Location = new System.Drawing.Point(316, 244);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(99, 20);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "姓   名：";
            // 
            // RNewpwdTxt
            // 
            this.RNewpwdTxt.Location = new System.Drawing.Point(421, 360);
            this.RNewpwdTxt.Name = "RNewpwdTxt";
            this.RNewpwdTxt.PasswordChar = '·';
            this.RNewpwdTxt.Size = new System.Drawing.Size(179, 25);
            this.RNewpwdTxt.TabIndex = 7;
            // 
            // RNewpwdLabel
            // 
            this.RNewpwdLabel.AutoSize = true;
            this.RNewpwdLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RNewpwdLabel.Location = new System.Drawing.Point(296, 365);
            this.RNewpwdLabel.Name = "RNewpwdLabel";
            this.RNewpwdLabel.Size = new System.Drawing.Size(129, 20);
            this.RNewpwdLabel.TabIndex = 6;
            this.RNewpwdLabel.Text = "新密码验证：";
            // 
            // NewpwdTxt
            // 
            this.NewpwdTxt.Location = new System.Drawing.Point(421, 310);
            this.NewpwdTxt.Name = "NewpwdTxt";
            this.NewpwdTxt.PasswordChar = '·';
            this.NewpwdTxt.Size = new System.Drawing.Size(179, 25);
            this.NewpwdTxt.TabIndex = 5;
            // 
            // NewpwdLabel
            // 
            this.NewpwdLabel.AutoSize = true;
            this.NewpwdLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NewpwdLabel.Location = new System.Drawing.Point(316, 315);
            this.NewpwdLabel.Name = "NewpwdLabel";
            this.NewpwdLabel.Size = new System.Drawing.Size(109, 20);
            this.NewpwdLabel.TabIndex = 4;
            this.NewpwdLabel.Text = "新 密 码：";
            // 
            // AckBtn
            // 
            this.AckBtn.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AckBtn.Location = new System.Drawing.Point(421, 430);
            this.AckBtn.Name = "AckBtn";
            this.AckBtn.Size = new System.Drawing.Size(125, 34);
            this.AckBtn.TabIndex = 8;
            this.AckBtn.Text = "确认修改";
            this.AckBtn.UseVisualStyleBackColor = true;
            // 
            // PersonInfoPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AckBtn);
            this.Controls.Add(this.RNewpwdTxt);
            this.Controls.Add(this.RNewpwdLabel);
            this.Controls.Add(this.NewpwdTxt);
            this.Controls.Add(this.NewpwdLabel);
            this.Controls.Add(this.NameTxt);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.IdTxt);
            this.Controls.Add(this.IdLabel);
            this.Name = "PersonInfoPanel";
            this.Size = new System.Drawing.Size(979, 584);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.TextBox IdTxt;
        private System.Windows.Forms.TextBox NameTxt;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox RNewpwdTxt;
        private System.Windows.Forms.Label RNewpwdLabel;
        private System.Windows.Forms.TextBox NewpwdTxt;
        private System.Windows.Forms.Label NewpwdLabel;
        private System.Windows.Forms.Button AckBtn;
    }
}

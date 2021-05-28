
namespace InnoProjectSystem.src.view.Panel
{
    partial class ProjectTypeAlterForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.AckBtn = new System.Windows.Forms.Button();
            this.PTDescTxt = new System.Windows.Forms.TextBox();
            this.PTNameTxt = new System.Windows.Forms.TextBox();
            this.PTDescLabel = new System.Windows.Forms.Label();
            this.PTNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(383, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "*";
            // 
            // AckBtn
            // 
            this.AckBtn.Location = new System.Drawing.Point(199, 347);
            this.AckBtn.Name = "AckBtn";
            this.AckBtn.Size = new System.Drawing.Size(75, 23);
            this.AckBtn.TabIndex = 10;
            this.AckBtn.Text = "确  认";
            this.AckBtn.UseVisualStyleBackColor = true;
            this.AckBtn.Click += new System.EventHandler(this.AckBtn_Click);
            // 
            // PTDescTxt
            // 
            this.PTDescTxt.Location = new System.Drawing.Point(161, 127);
            this.PTDescTxt.Multiline = true;
            this.PTDescTxt.Name = "PTDescTxt";
            this.PTDescTxt.Size = new System.Drawing.Size(216, 180);
            this.PTDescTxt.TabIndex = 9;
            // 
            // PTNameTxt
            // 
            this.PTNameTxt.Location = new System.Drawing.Point(161, 72);
            this.PTNameTxt.Name = "PTNameTxt";
            this.PTNameTxt.Size = new System.Drawing.Size(216, 25);
            this.PTNameTxt.TabIndex = 8;
            // 
            // PTDescLabel
            // 
            this.PTDescLabel.AutoSize = true;
            this.PTDescLabel.Location = new System.Drawing.Point(73, 130);
            this.PTDescLabel.Name = "PTDescLabel";
            this.PTDescLabel.Size = new System.Drawing.Size(82, 15);
            this.PTDescLabel.TabIndex = 7;
            this.PTDescLabel.Text = "类型描述：";
            // 
            // PTNameLabel
            // 
            this.PTNameLabel.AutoSize = true;
            this.PTNameLabel.Location = new System.Drawing.Point(88, 79);
            this.PTNameLabel.Name = "PTNameLabel";
            this.PTNameLabel.Size = new System.Drawing.Size(67, 15);
            this.PTNameLabel.TabIndex = 6;
            this.PTNameLabel.Text = "类型名：";
            // 
            // ProjectTypeAlterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 428);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AckBtn);
            this.Controls.Add(this.PTDescTxt);
            this.Controls.Add(this.PTNameTxt);
            this.Controls.Add(this.PTDescLabel);
            this.Controls.Add(this.PTNameLabel);
            this.Name = "ProjectTypeAlterForm";
            this.Text = "ProjectTypeAlterForm";
            this.Load += new System.EventHandler(this.ProjectTypeAlterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AckBtn;
        private System.Windows.Forms.TextBox PTDescTxt;
        private System.Windows.Forms.TextBox PTNameTxt;
        private System.Windows.Forms.Label PTDescLabel;
        private System.Windows.Forms.Label PTNameLabel;
    }
}
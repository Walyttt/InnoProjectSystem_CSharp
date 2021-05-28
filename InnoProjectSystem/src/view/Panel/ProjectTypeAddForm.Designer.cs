
namespace InnoProjectSystem.src.view.Panel
{
    partial class ProjectTypeAddForm
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
            this.PTNameLabel = new System.Windows.Forms.Label();
            this.PTDescLabel = new System.Windows.Forms.Label();
            this.PTNameTxt = new System.Windows.Forms.TextBox();
            this.PTDescTxt = new System.Windows.Forms.TextBox();
            this.AckBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PTNameLabel
            // 
            this.PTNameLabel.AutoSize = true;
            this.PTNameLabel.Location = new System.Drawing.Point(95, 97);
            this.PTNameLabel.Name = "PTNameLabel";
            this.PTNameLabel.Size = new System.Drawing.Size(67, 15);
            this.PTNameLabel.TabIndex = 0;
            this.PTNameLabel.Text = "类型名：";
            // 
            // PTDescLabel
            // 
            this.PTDescLabel.AutoSize = true;
            this.PTDescLabel.Location = new System.Drawing.Point(80, 148);
            this.PTDescLabel.Name = "PTDescLabel";
            this.PTDescLabel.Size = new System.Drawing.Size(82, 15);
            this.PTDescLabel.TabIndex = 1;
            this.PTDescLabel.Text = "类型描述：";
            // 
            // PTNameTxt
            // 
            this.PTNameTxt.Location = new System.Drawing.Point(168, 90);
            this.PTNameTxt.Name = "PTNameTxt";
            this.PTNameTxt.Size = new System.Drawing.Size(216, 25);
            this.PTNameTxt.TabIndex = 2;
            // 
            // PTDescTxt
            // 
            this.PTDescTxt.Location = new System.Drawing.Point(168, 145);
            this.PTDescTxt.Multiline = true;
            this.PTDescTxt.Name = "PTDescTxt";
            this.PTDescTxt.Size = new System.Drawing.Size(216, 180);
            this.PTDescTxt.TabIndex = 3;
            // 
            // AckBtn
            // 
            this.AckBtn.Location = new System.Drawing.Point(206, 365);
            this.AckBtn.Name = "AckBtn";
            this.AckBtn.Size = new System.Drawing.Size(75, 23);
            this.AckBtn.TabIndex = 4;
            this.AckBtn.Text = "添  加";
            this.AckBtn.UseVisualStyleBackColor = true;
            this.AckBtn.Click += new System.EventHandler(this.AckBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(390, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "*";
            // 
            // ProjectTypeAddForm
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
            this.Name = "ProjectTypeAddForm";
            this.Text = "ProjectTypeAddForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PTNameLabel;
        private System.Windows.Forms.Label PTDescLabel;
        private System.Windows.Forms.TextBox PTNameTxt;
        private System.Windows.Forms.TextBox PTDescTxt;
        private System.Windows.Forms.Button AckBtn;
        private System.Windows.Forms.Label label1;
    }
}
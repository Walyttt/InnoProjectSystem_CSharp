
namespace InnoProjectSystem.src.view.Panel
{
    partial class ProjectTypePanel
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
            this.PTNameLBox = new System.Windows.Forms.ListBox();
            this.PTDescTxt = new System.Windows.Forms.TextBox();
            this.AddBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.PTDescLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PTNameLBox
            // 
            this.PTNameLBox.FormattingEnabled = true;
            this.PTNameLBox.ItemHeight = 15;
            this.PTNameLBox.Location = new System.Drawing.Point(153, 184);
            this.PTNameLBox.Name = "PTNameLBox";
            this.PTNameLBox.Size = new System.Drawing.Size(223, 199);
            this.PTNameLBox.TabIndex = 0;
            this.PTNameLBox.SelectedIndexChanged += new System.EventHandler(this.PTNameLBox_SelectedIndexChanged);
            // 
            // PTDescTxt
            // 
            this.PTDescTxt.Enabled = false;
            this.PTDescTxt.Location = new System.Drawing.Point(474, 145);
            this.PTDescTxt.Multiline = true;
            this.PTDescTxt.Name = "PTDescTxt";
            this.PTDescTxt.Size = new System.Drawing.Size(310, 268);
            this.PTDescTxt.TabIndex = 1;
            // 
            // AddBtn
            // 
            this.AddBtn.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AddBtn.Location = new System.Drawing.Point(192, 481);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(104, 34);
            this.AddBtn.TabIndex = 2;
            this.AddBtn.Text = "添  加";
            this.AddBtn.UseVisualStyleBackColor = true;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DeleteBtn.Location = new System.Drawing.Point(434, 481);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(104, 34);
            this.DeleteBtn.TabIndex = 3;
            this.DeleteBtn.Text = "删  除";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.UpdateBtn.Location = new System.Drawing.Point(676, 481);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(104, 34);
            this.UpdateBtn.TabIndex = 4;
            this.UpdateBtn.Text = "修  改";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            // 
            // PTDescLabel
            // 
            this.PTDescLabel.AutoSize = true;
            this.PTDescLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PTDescLabel.Location = new System.Drawing.Point(470, 102);
            this.PTDescLabel.Name = "PTDescLabel";
            this.PTDescLabel.Size = new System.Drawing.Size(69, 20);
            this.PTDescLabel.TabIndex = 5;
            this.PTDescLabel.Text = "描述：";
            // 
            // ProjectTypePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PTDescLabel);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.PTDescTxt);
            this.Controls.Add(this.PTNameLBox);
            this.Name = "ProjectTypePanel";
            this.Size = new System.Drawing.Size(979, 584);
            this.Load += new System.EventHandler(this.ProjectTypePanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox PTNameLBox;
        private System.Windows.Forms.TextBox PTDescTxt;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Label PTDescLabel;
    }
}

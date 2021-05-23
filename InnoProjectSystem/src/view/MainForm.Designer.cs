
namespace InnoProjectSystem.src.view
{
    partial class MainForm
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
            this.Mainmenu = new System.Windows.Forms.MenuStrip();
            this.PersonInfoItem = new System.Windows.Forms.ToolStripMenuItem();
            this.项目管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProjectQandCItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProjectAddItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProjectTypeItem = new System.Windows.Forms.ToolStripMenuItem();
            this.人员管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PeopleQandCItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PeopleAddItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.Mainmenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Mainmenu
            // 
            this.Mainmenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Mainmenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PersonInfoItem,
            this.项目管理ToolStripMenuItem,
            this.人员管理ToolStripMenuItem});
            this.Mainmenu.Location = new System.Drawing.Point(0, 0);
            this.Mainmenu.Name = "Mainmenu";
            this.Mainmenu.Size = new System.Drawing.Size(979, 28);
            this.Mainmenu.TabIndex = 0;
            this.Mainmenu.Text = "menuStrip1";
            // 
            // PersonInfoItem
            // 
            this.PersonInfoItem.Name = "PersonInfoItem";
            this.PersonInfoItem.Size = new System.Drawing.Size(83, 24);
            this.PersonInfoItem.Text = "个人信息";
            this.PersonInfoItem.Click += new System.EventHandler(this.PersonInfoItem_Click);
            // 
            // 项目管理ToolStripMenuItem
            // 
            this.项目管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProjectQandCItem,
            this.ProjectAddItem,
            this.ProjectTypeItem});
            this.项目管理ToolStripMenuItem.Name = "项目管理ToolStripMenuItem";
            this.项目管理ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.项目管理ToolStripMenuItem.Text = "项目管理";
            // 
            // ProjectQandCItem
            // 
            this.ProjectQandCItem.Name = "ProjectQandCItem";
            this.ProjectQandCItem.Size = new System.Drawing.Size(188, 26);
            this.ProjectQandCItem.Text = "项目查询/修改";
            // 
            // ProjectAddItem
            // 
            this.ProjectAddItem.Name = "ProjectAddItem";
            this.ProjectAddItem.Size = new System.Drawing.Size(188, 26);
            this.ProjectAddItem.Text = "项目添加";
            // 
            // ProjectTypeItem
            // 
            this.ProjectTypeItem.Name = "ProjectTypeItem";
            this.ProjectTypeItem.Size = new System.Drawing.Size(188, 26);
            this.ProjectTypeItem.Text = "项目类型管理";
            // 
            // 人员管理ToolStripMenuItem
            // 
            this.人员管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PeopleQandCItem,
            this.PeopleAddItem});
            this.人员管理ToolStripMenuItem.Name = "人员管理ToolStripMenuItem";
            this.人员管理ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.人员管理ToolStripMenuItem.Text = "人员管理";
            // 
            // PeopleQandCItem
            // 
            this.PeopleQandCItem.Name = "PeopleQandCItem";
            this.PeopleQandCItem.Size = new System.Drawing.Size(224, 26);
            this.PeopleQandCItem.Text = "人员查询/修改";
            this.PeopleQandCItem.Click += new System.EventHandler(this.PeopleQandCItem_Click);
            // 
            // PeopleAddItem
            // 
            this.PeopleAddItem.Name = "PeopleAddItem";
            this.PeopleAddItem.Size = new System.Drawing.Size(224, 26);
            this.PeopleAddItem.Text = "人员添加";
            // 
            // MainPanel
            // 
            this.MainPanel.Location = new System.Drawing.Point(0, 23);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(979, 584);
            this.MainPanel.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 607);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.Mainmenu);
            this.MainMenuStrip = this.Mainmenu;
            this.Name = "MainForm";
            this.Text = "创新工程管理";
            this.Mainmenu.ResumeLayout(false);
            this.Mainmenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Mainmenu;
        private System.Windows.Forms.ToolStripMenuItem PersonInfoItem;
        private System.Windows.Forms.ToolStripMenuItem 项目管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 人员管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProjectQandCItem;
        private System.Windows.Forms.ToolStripMenuItem ProjectAddItem;
        private System.Windows.Forms.ToolStripMenuItem ProjectTypeItem;
        private System.Windows.Forms.ToolStripMenuItem PeopleQandCItem;
        private System.Windows.Forms.ToolStripMenuItem PeopleAddItem;
        private System.Windows.Forms.Panel MainPanel;
    }
}
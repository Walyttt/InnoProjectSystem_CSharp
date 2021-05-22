using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InnoProjectSystem.src.models;

namespace InnoProjectSystem.src.view
{
    public partial class MainForm : Form
    {
        public User user;
        public MainForm(User u)
        {
            InitializeComponent();
            this.user = u;
        }

        private void PersonInfoItem_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(new PersonInfoPanel(this.user));
        }
    }
}

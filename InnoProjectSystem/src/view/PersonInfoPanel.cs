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
    public partial class PersonInfoPanel : UserControl
    {
        public User user;
        public PersonInfoPanel(User u)
        {
            InitializeComponent();

            this.user = u;
            IdTxt.Text = this.user.Id;
            NameTxt.Text = this.user.Name;
        }

        private void AckBtn_Click(object sender, EventArgs e)
        {
            if (!NewpwdTxt.Text.Equals(RNewpwdTxt.Text))
            {
                MessageBox.Show("新密码不一致");
                return;
            }


        }
    }
}

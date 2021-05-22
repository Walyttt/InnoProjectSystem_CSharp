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
        public PersonInfoPanel(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void AckBtn_Click(object sender, EventArgs e)
        {

        }
    }
}

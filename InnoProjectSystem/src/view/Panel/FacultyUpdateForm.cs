using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using InnoProjectSystem.src.Util;
using InnoProjectSystem.src.models;

namespace InnoProjectSystem.src.view.Panel
{
    public partial class FacultyUpdateForm : Form
    {
        private Faculty f;

        public FacultyUpdateForm(Faculty faculty)
        {
            InitializeComponent();
            this.f = faculty;
        }
    }
}

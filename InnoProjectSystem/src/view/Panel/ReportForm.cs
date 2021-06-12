using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace InnoProjectSystem.src.view.Panel
{

    public partial class ReportForm : Form
    {
        public ReportDocument rd;

        public ReportForm(ReportDocument reportDocument)
        {
            InitializeComponent();
            this.rd = reportDocument;
            this.crystalReportViewer1.ReportSource = this.rd;
            
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simael.Reportes
{
    public partial class FrmReporteBaja : Form
    {
        private ReporteBaja reporte;
        public FrmReporteBaja(ReporteBaja reporte)
        {
            InitializeComponent();
            this.reporte = reporte;
        }

        private void FrmReporteBaja_Load(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource = reporte;
        }
    }
}

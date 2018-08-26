using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Simael.Reportes;
namespace Simael.Reportes
{
    public partial class FrmReporte : Form
    {
        private Reporte reporte;
        public FrmReporte(Reporte reporte)
        {
            InitializeComponent();
            this.reporte = reporte;
        }

        private void FrmReporte_Load(object sender, EventArgs e)
        {
           crystalReportViewer1.ReportSource = reporte;
        }
    }
}

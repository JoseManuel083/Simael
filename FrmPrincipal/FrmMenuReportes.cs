using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simael
{
    public partial class FrmMenuReportes : UserControl
    {
        private FrmAgregarReportes objRep;
        private FrmHistorialReportes objHisRepor;
        public FrmMenuReportes()
        {
            InitializeComponent();
            agregarReporte();
        }

        private void FrmMenuReportes_Load(object sender, EventArgs e)
        {
            menuStrip1.ForeColor = Color.White;
        }

        private void nuevoReporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            agregarReporte();
        }

        private void agregarReporte() 
        {
            objRep = new FrmAgregarReportes();
            panelMenuReporte.Controls.Clear();
            panelMenuReporte.Controls.Add(objRep);
            panelMenuReporte.AutoScroll = true;
        }

        private void historialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            objHisRepor = new FrmHistorialReportes();
            panelMenuReporte.Controls.Clear();
            panelMenuReporte.Controls.Add(objHisRepor);
            panelMenuReporte.AutoScroll = false;
        }

        private void panelMenuReporte_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

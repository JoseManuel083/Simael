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
    public partial class Menu_reportes : UserControl
    {
        private Agregar_reporte objRep;
        private Historial_reportes objHisRepor;
        public Menu_reportes()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
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
            objRep = new Agregar_reporte();
            panelMenuReporte.Controls.Clear();
            panelMenuReporte.Controls.Add(objRep);
            panelMenuReporte.AutoScroll = true;
        }

        private void historialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            objHisRepor = new Historial_reportes();
            panelMenuReporte.Controls.Clear();
            panelMenuReporte.Controls.Add(objHisRepor);
            panelMenuReporte.AutoScroll = false;
        }

        private void panelMenuReporte_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

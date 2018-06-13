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
    public partial class FrmMenuBuscar : UserControl
    {
        private FrmBuscar objBuscar;
        private FrmAgregarRegistroInv objInv;
        private FrmBusquedaAvanzada objBusqA;

        public FrmMenuBuscar()
        {
            InitializeComponent();
            mostrarFormBuscar();
        }

        private void panelBusqueda_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mostrarFormBuscar() 
        {
            objBuscar = new FrmBuscar();
            panelBusqueda.Controls.Clear();
            panelBusqueda.Controls.Add(objBuscar);
        }
        private void FrmBusqueda_Load(object sender, EventArgs e)
        {
            menuStrip1.ForeColor = Color.White;
        }

        private void nuevoRegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            objInv = new FrmAgregarRegistroInv();
            panelBusqueda.Controls.Clear();
            panelBusqueda.Controls.Add(objInv);
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mostrarFormBuscar();
        }

        private void busquedaPersonalizadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            busquedaAvanzada();
        }

        private void busquedaAvanzada() 
        {
            mostrarFormBuscar();
            objBusqA = new FrmBusquedaAvanzada(objBuscar);
            objBusqA.ShowDialog();
        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void FrmBusqueda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode == Keys.C)
            {
                //busquedaAvanzada();
                MessageBox.Show("comando aceptado");
            }
        }

        private void FrmBusqueda_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.Control == true && e.KeyCode == Keys.C)
            {
                MessageBox.Show("comando aceptado");
            }
        }

        private void exportarAExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            objBuscar = new FrmBuscar();
        }

        private void exportarDataGridExcel(DataGrid dgv) 
        {
            SaveFileDialog fichero = new SaveFileDialog();
        }
     
    }
}

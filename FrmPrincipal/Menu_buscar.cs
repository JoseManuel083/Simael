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
    public partial class Menu_buscar : UserControl
    {
        private Buscar_principal objBuscar;
        private Agregar_registros_inventario objInv;
        private Busqueda_avanzada objBusqA;

        public Menu_buscar()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            mostrarFormBuscar();
        }

        private void panelBusqueda_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mostrarFormBuscar() 
        {
            objBuscar = new Buscar_principal();
            panelBusqueda.Controls.Clear();
            panelBusqueda.Controls.Add(objBuscar);
        }
        private void FrmBusqueda_Load(object sender, EventArgs e)
        {
            menuStrip1.ForeColor = Color.White;
        }

        private void nuevoRegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            objInv = new Agregar_registros_inventario();
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
            objBusqA = new Busqueda_avanzada(objBuscar);
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
            objBuscar = new Buscar_principal();
        }

        private void exportarDataGridExcel(DataGrid dgv) 
        {
            SaveFileDialog fichero = new SaveFileDialog();
        }
     
    }
}

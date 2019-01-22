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
    public partial class Principal_bitacora : UserControl
    {
        private Agregar_registro_bitacora objAddB;
        private Historial_bitacora objEditB;
        public Principal_bitacora()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            //mostrarFormAgregarBit();
            mostrarHistorialBitacora();
        }

        private void FrmBitacora_Load(object sender, EventArgs e)
        {
            menuStrip1.ForeColor = Color.White;
        }

        public void mostrarHistorialBitacora() 
        {
            objEditB = new Historial_bitacora();
            objEditB.llenarTablaRegistros();
            panelBitacora.Controls.Clear();
            panelBitacora.Controls.Add(objEditB);
        }

        public void mostrarFormAgregarBit() 
        {
            objAddB = new Agregar_registro_bitacora();
            panelBitacora.Controls.Clear();
            panelBitacora.Controls.Add(objAddB);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            mostrarFormAgregarBit();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            mostrarHistorialBitacora();
        }

        //Boton aceptar del menu strip, efectua la busqueda de un equipo en especifico y muestra,
        //el resultado en el datagrid del form bitacora
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            iniciarBusquedaEquipo();
        }

        private void iniciarBusquedaEquipo() 
        {
            if (txtBuscar.Text.Trim() != String.Empty)
            {
                buscarRegistro();
            }
            else
            {
                MessageBox.Show("Por favor ingrese datos del equipo a buscar", "Simael - Bitacora", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buscarRegistro() 
        {
            string param = txtBuscar.Text.Trim();
            objEditB = new Historial_bitacora();
            objEditB.busquedaDataGV(param);
            panelBitacora.Controls.Clear();
            panelBitacora.Controls.Add(objEditB);
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            //if(e.KeyCode == Keys.Enter)
            //{
            //    iniciarBusquedaEquipo();
            //}
        }

        private void panelBitacora_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            buscarRegistro();
        }

        private void txtBuscar_Click(object sender, EventArgs e)
        {

        }

    }
}

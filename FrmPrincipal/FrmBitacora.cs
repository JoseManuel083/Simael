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
    public partial class FrmBitacora : UserControl
    {
        private FrmAgregarRegistroBit objAddB;
        private FrmEditarElimBit objEditB;
        public FrmBitacora()
        {
            InitializeComponent();
            //mostrarFormAgregarBit();
            mostrarHistorialBitacora();
        }

        private void FrmBitacora_Load(object sender, EventArgs e)
        {
            menuStrip1.ForeColor = Color.White;
        }

        public void mostrarHistorialBitacora() 
        {
            objEditB = new FrmEditarElimBit();
            objEditB.llenarTablaRegistros();
            panelBitacora.Controls.Clear();
            panelBitacora.Controls.Add(objEditB);
        }

        public void mostrarFormAgregarBit() 
        {
            objAddB = new FrmAgregarRegistroBit();
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
            buscarRegistro();
        }

        private void buscarRegistro() 
        {
            string param = txtBuscar.Text;
            objEditB = new FrmEditarElimBit();
            objEditB.busquedaDataGV(param);
            panelBitacora.Controls.Clear();
            panelBitacora.Controls.Add(objEditB);
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                buscarRegistro();
            }
        }

        private void txtBuscar_Click(object sender, EventArgs e)
        {

        }

        private void panelBitacora_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

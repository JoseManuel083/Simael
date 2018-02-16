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
            mostrarHistorialBitacora();
        }

        private void FrmBitacora_Load(object sender, EventArgs e)
        {
            menuStrip1.ForeColor = Color.White;
        }

        public void mostrarHistorialBitacora() 
        {
            objEditB = new FrmEditarElimBit();
            panelBitacora.Controls.Clear();
            panelBitacora.Controls.Add(objEditB);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            objAddB = new FrmAgregarRegistroBit();
            panelBitacora.Controls.Clear();
            panelBitacora.Controls.Add(objAddB);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            mostrarHistorialBitacora();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            buscarRegistro();
        }

        private void buscarRegistro() 
        {
            string param = txtBuscar.Text;
            objEditB = new FrmEditarElimBit(param);
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
    }
}

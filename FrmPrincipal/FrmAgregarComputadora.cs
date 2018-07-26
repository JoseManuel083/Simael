using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Simael.BaseDatos;

namespace Simael
{
    public partial class FrmAgregarComputadora : UserControl
    {
        private BaseDatoBit objBD;
        public FrmAgregarComputadora()
        {
            InitializeComponent();
        }

        private void FrmAgregarComputadora_Load(object sender, EventArgs e)
        {

        }

        private void agregarPcInventario() 
        {
            objBD = new BaseDatoBit();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls) 
            {
                if (control is TextBox) 
                {
                    ((TextBox)control).Text = "";
                }
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (validarCamposVacios())
            {
            }
            else 
            {
                MessageBox.Show("No se permiten campos vacios, por favor ingrese datos","SIMAEL - Agregar Periferico",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private bool validarCamposVacios() 
        {
            foreach (Control control in this.Controls) 
            {
                if (control is TextBox) 
                {
                    if (((TextBox)control).Text == "")
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private void agregarPCInventario() 
        {
            objBD = new BaseDatoBit();
            
        }
    }
}

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
    public partial class FrmAgregarPerifericoInventario : UserControl
    {
        private BaseDatoBit objBD;
        public FrmAgregarPerifericoInventario()
        {
            InitializeComponent();
        }

        private void FrmAgregarPerifericoInventario_Load(object sender, EventArgs e)
        {

        }

        private void agregarPeriferico() 
        {
            string sicipo = txtSicipo.Text.Trim();
            string categoria = txtCategoria.Text.Trim();
            string tipo = txtTipo.Text.Trim();
            string marca = txtMarca.Text.Trim();
            string modelo = txtModelo.Text.Trim();
            string noserie = txtNoSerie.Text.Trim();
            string color = txtColor.Text.Trim();
            string composicion = txtComposicion.Text.Trim();
            string estadoFisico = txtEstadoFisico.Text.Trim();
            string precio = txtPrecio.Text.Trim();
            string resguardante = txtResguardante.Text.Trim();
            string inventario = txtInventario.Text.Trim() + " " + txtArea.Text.Trim() + " " + txtFolio.Text.Trim();

            objBD = new BaseDatoBit();
            bool estado;
            estado = objBD.agregarPerifericoInventario(sicipo, categoria, tipo, marca, modelo, noserie, color,
                                              composicion, estadoFisico, precio, resguardante, inventario);

            if (estado)
            {
                MessageBox.Show("El equipo ha sido agregado correctamente","Agregar Periferico",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else 
            {
                MessageBox.Show("Error al agregar el equipo", "Agregar Periferico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (validarDatos())
            {
                agregarPeriferico(); 
            }
            else 
            {
                MessageBox.Show("Existen campos vacios, por favor ingrese datos en los campos", "SIMAEL - Agregar Periferico", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool validarDatos() 
        {
            if (txtSicipo.Text.Equals(String.Empty) || txtCategoria.Text.Equals(String.Empty) || txtTipo.Text.Equals(String.Empty))
            {
                return false;
            }
            else if (txtMarca.Text.Equals(String.Empty) || txtModelo.Text.Equals(String.Empty) || txtNoSerie.Text.Equals(String.Empty))
            {
                return false;
            }
            else if (txtColor.Text.Equals(String.Empty) || txtComposicion.Text.Equals(String.Empty) || txtEstadoFisico.Text.Equals(String.Empty))
            {
                return false;
            }
            return true;
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
    }
}

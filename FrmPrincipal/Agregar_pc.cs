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
    public partial class Agregar_pc : UserControl
    {
        private BaseDatoBit objBD;
        public Agregar_pc()
        {
            InitializeComponent();
        }

        private void FrmAgregarComputadora_Load(object sender, EventArgs e)
        {
            txtCategoria.Text = "PC";
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
            objBD = new BaseDatoBit();
            DataTable tabla;
           

            if (validarCamposVacios())
            {
                tabla = objBD.registrosPerifericos(txtSicipo.Text.Trim());
                if (tabla.Rows.Count == 0)
                {
                    agregarComputadora();
                }
                else 
                {
                    MessageBox.Show("Sicipo repetido, por favor ingrese un sicipo unico","SIMAEL - Agregar computadora",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                
            }
            else 
            {
                MessageBox.Show("No se permiten campos vacios, por favor ingrese datos","SIMAEL - Agregar Periferico",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }


        private void agregarComputadora() 
        {
            objBD = new BaseDatoBit();
            bool estado = objBD.agregarComputadoraInventario(txtSicipo.Text.Trim(),txtFolio.Text.Trim(), txtCategoria.Text.Trim(), txtTipo.Text.Trim(), txtMarca.Text.Trim(), txtNoSerie.Text.Trim(), 
                                                    txtModelo.Text.Trim(), txtRam.Text.Trim(), txtTipoProcesador.Text.Trim(), txtVelocidadProcesador.Text.Trim(), txtNoHdd.Text.Trim(), txtCapHdd.Text.Trim(),
                                                    txtSO.Text.Trim(), txtVersionSO.Text.Trim(), txtEstadoFisico.Text.Trim(), txtPrecio.Text.Trim(), txtResguardante.Text.Trim(), 
                                                    txtInventario.Text.Trim(),txtComposicion.Text.Trim());
            if (estado)
            {
                MessageBox.Show("Equipo agregado correctamente", "SIMAEL - Agregar computadora", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else 
            {
                MessageBox.Show("Ha ocurrido un error al registrar el equipo, contacte con el administrador", "SIMAEL - Agregar computadora", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

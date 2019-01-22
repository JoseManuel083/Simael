using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Simael.BaseDatos;
namespace Simael
{
    public partial class Editar_pc : Form
    {
        private BaseDatoBit objBD;
        private Buscar_principal objBuscar;
        public Editar_pc(List<string> equipo,Buscar_principal objB)
        {
            InitializeComponent();
            txtSicipo.Text = equipo.ElementAt(0).ToString();
            txtFolio.Text = equipo.ElementAt(1).ToString();
            txtCategoria.Text = equipo.ElementAt(2).ToString();
            txtTipo.Text = equipo.ElementAt(3).ToString();
            txtMarca.Text = equipo.ElementAt(4).ToString();
            txtNoSerie.Text = equipo.ElementAt(5).ToString();
            txtModelo.Text = equipo.ElementAt(6).ToString();
            txtRam.Text = equipo.ElementAt(7).ToString();
            txtTipoProcesador.Text = equipo.ElementAt(8).ToString();
            txtVelocidadProcesador.Text = equipo.ElementAt(9).ToString();
            txtNoHDD.Text = equipo.ElementAt(10).ToString();
            txtCapacidadHDD.Text = equipo.ElementAt(11).ToString();
            txtSO.Text = equipo.ElementAt(12).ToString();
            txtVersionSO.Text = equipo.ElementAt(13).ToString();
            txtEstadoFisico.Text = equipo.ElementAt(14).ToString();
            txtPrecio.Text = equipo.ElementAt(15).ToString();
            txtResguardante.Text = equipo.ElementAt(16).ToString();
            txtInventario.Text = equipo.ElementAt(17).ToString();
            objBuscar = objB;
        }

        private void FormDetalleRegistroPC_Load(object sender, EventArgs e)
        {
            bloquearEdicionTextBox();
        }

        private void bloquearEdicionTextBox() 
        {
            foreach (Control control in panel1.Controls) 
            {
                if (control is TextBox) 
                {
                    ((TextBox)control).ReadOnly = true;
                }
            }
            btnAceptar.Enabled = false;
        }
        private void activarEdicion() 
        {
            foreach (Control control in panel1.Controls) 
            {
                if (control is TextBox) 
                {
                    ((TextBox)control).ReadOnly = false;
                }
            }
            txtSicipo.Focus();
            btnAceptar.Enabled = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            activarEdicion();
        }

        private void eliminarRegistro() 
        {
            objBD = new BaseDatoBit();
            bool estado = objBD.eliminarPCInventario(txtSicipo.Text.Trim());

            if (estado)
            {
                MessageBox.Show("El equipo ha sido eliminado de la base de datos correctamente", "Detalle registro",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Close();
                objBuscar.llenarDatagridPerifericos();
            }
            else 
            {
                MessageBox.Show("Ocurrio un error al intentar eliminar el equipo, por favor consulte con el administrador", "Detalle equipo", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Esta seguro que desea editar los datos del equipo?", "Detalle registro", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes) 
            {
                editarRegistro();
            }    
               
        }

        private void editarRegistro() 
        {
            objBD = new BaseDatoBit();
            bool estado = objBD.editarPCInventario(txtSicipo.Text.Trim(),txtFolio.Text.Trim(), txtCategoria.Text.Trim(), txtTipo.Text.Trim(), txtMarca.Text.Trim(),
                                                   txtNoSerie.Text.Trim(), txtModelo.Text.Trim(), txtRam.Text.Trim(),txtTipoProcesador.Text.Trim(),
                                                   txtVelocidadProcesador.Text.Trim(), txtNoHDD.Text.Trim(), txtCapacidadHDD.Text.Trim(),
                                                   txtSO.Text.Trim(), txtVersionSO.Text.Trim(), txtEstadoFisico.Text.Trim(),
                                                   txtPrecio.Text.Trim(), txtResguardante.Text.Trim(), txtInventario.Text.Trim());

            if (estado)
            {
                DialogResult respuesta = MessageBox.Show("Los datos del equipo han sido actualizados", "Detalle equipo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (respuesta == DialogResult.OK) 
                {
                    this.Close();
                    objBuscar.llenarDatagridPerifericos();
                }
                    
            }
            else 
            {
                MessageBox.Show("Ha ocurrido un error al intentar actualizar los datos del equipo, por favor consulte con el administrador", "Detalle equipo",
                                MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Esta seguro que desea eliminar los datos del equipo?", "Detalle registro", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                eliminarRegistro();
            }
        }

    }
}

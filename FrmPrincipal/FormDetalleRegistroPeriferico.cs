using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simael
{
    public partial class FormDetalleRegistroPeriferico : Form
    {
        private BaseDatos.BaseDatoBit objBD;
        public FormDetalleRegistroPeriferico(List<string> equipo)
        {
            InitializeComponent();
            txtSicipo.Text = equipo.ElementAt(0).ToString();
            txtCategoria.Text = equipo.ElementAt(1).ToString();
            txtTipo.Text = equipo.ElementAt(2).ToString();
            txtMarca.Text = equipo.ElementAt(3).ToString();
            txtModelo.Text = equipo.ElementAt(4).ToString();
            txtNoSerie.Text = equipo.ElementAt(5).ToString();
            txtColor.Text = equipo.ElementAt(6).ToString();
            txtComposicion.Text = equipo.ElementAt(7).ToString();
            txtEstadoFisico.Text = equipo.ElementAt(8).ToString();
            txtPrecio.Text = equipo.ElementAt(9).ToString();
            txtResguardante.Text = equipo.ElementAt(10).ToString();
            txtInventario.Text = equipo.ElementAt(11).ToString();
        }

        
        private void FormDetalleRegistro_Load(object sender, EventArgs e)
        {
            btnGuardar.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            habilitarTextBoxes();
        }

        private void habilitarTextBoxes() 
        {
            foreach(Control control in this.Controls)
            {
                if (control is TextBox) 
                {
                    ((TextBox)control).ReadOnly = false;
                }
            }
            txtSicipo.Focus();
            btnGuardar.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea guardar los cambios efectuados?", "Editar registro",
                                     MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question);
           if (resultado == DialogResult.Yes)
           {
               editarPeriferico();
           }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Esta seguro que desea eliminar los datos de este equipo?", "Editar registro",
                                     MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes) 
            {
                eliminarPeriferico();
            }
            this.Close();
        }

        private void eliminarPeriferico() 
        {
            objBD = new BaseDatos.BaseDatoBit();
            bool estado = objBD.eliminarPerifericoInventario(txtSicipo.Text.Trim());

            if (estado)
            {
                MessageBox.Show("Equipo eliminado de la base de datos", "Editar registro", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else 
            {
                MessageBox.Show("Ha ocurrido un error, consulte con el administrador", "Editar registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void editarPeriferico() 
        {
            objBD = new BaseDatos.BaseDatoBit();
            bool estado = objBD.editarPerifericoInventario(txtSicipo.Text.Trim(),txtCategoria.Text.Trim(),txtTipo.Text.Trim(),txtMarca.Text.Trim(),
                          txtModelo.Text.Trim(),txtNoSerie.Text.Trim(),txtColor.Text.Trim(),txtComposicion.Text.Trim(),txtEstadoFisico.Text.Trim(),
                          txtPrecio.Text.Trim(),txtResguardante.Text.Trim(),txtInventario.Text.Trim());
            if (estado)
            {
                DialogResult respuesta = MessageBox.Show("Los datos del equipo han sido actualizados","Editar registro", MessageBoxButtons.OK,MessageBoxIcon.Information);

                if (respuesta == DialogResult.OK)
                    this.Close();
            }
            else 
            {
                MessageBox.Show("Ha ocurrido un error al intentar actualizar los datos del equipo, por favor contacte con el administrador",
                                "Editar registro",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        
    }
}

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
    /*
     * Autor : José Manuel Gómez Alavez
     * Fecha: 30/01/2018
     * Descripcón: Form para agregar agregar los registros a la base de datos
     */
    
    public partial class Agregar_registro_bitacora : UserControl
    {
        private BaseDatoBit objBD;
       
        public Agregar_registro_bitacora()
        {
            InitializeComponent();
        }

        private bool validarCampos() 
        {
            foreach (Control control in this.Controls)
            {
                if (control.GetType().Equals(typeof(TextBox)))
                {
                    if (control.Text.Equals(""))
                    {
                        MessageBox.Show("Existen campos sin datos , por favor ingrese datos", "Agregar registro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }

            }

            int numero;
            bool esNumero = int.TryParse(txtSicipo.Text.Trim(), out numero);
            bool esCadena = int.TryParse(txtFolio.Text.Trim(),out numero);

            if (!esNumero) 
            {
                MessageBox.Show("Sicipo inválido, por favor ingrese solo números en este campo", "Agregar registro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if(esCadena)
            {
                MessageBox.Show("Folio inválido, el folio debe de estar constituido por las Letras EC seguido por un guion y números", "Agregar registro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }else if(txtFolio.Text.Length > 10)
            {
                MessageBox.Show("Folio demasiado largo, por favor ingrese un folio no mayor a 10 caracteres","Agregar registro",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void limpiarCampos() 
        {
            //Recorre cada uno de los controles tipo texbox dentro del form
            foreach (Control control in this.Controls)
            {
                if (control.GetType().Equals(typeof(TextBox)))
                {
                    control.Text = string.Empty;
                }

            }
        }
        private void agregarRegistro() 
        {
            string folio = txtFolio.Text;
            string sicipo = txtSicipo.Text;
            string tipoEquipo = txtTipo.Text;
            string marca = txtMarca.Text;
            string modelo = txtModelo.Text;
            string noSerie = txtNoSerie.Text;
            string resguard = txtResguardante.Text;
            string area = txtArea.Text;
            string problema = txtProblema.Text;
            DateTime fecha = dateFecha.Value;
            bool estado;
            objBD = new BaseDatoBit();
            estado = objBD.agregarRegistroBitacora(folio,sicipo,tipoEquipo,marca,modelo,noSerie,resguard,area,problema,fecha);
            if(estado)
            {
                MessageBox.Show("Registro agregado correctamente","Agregar Registro",MessageBoxButtons.OK,MessageBoxIcon.Information);
                limpiarCampos();
            }else
            {
                MessageBox.Show("Error al agregar el registro, consulte con el administrador", "Agregar Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (buscarRegistrosRepetidos())
            {
                DialogResult resultado = MessageBox.Show("Registro duplicado, desea registrarlo de todas formas?","Agregar registro", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
               
                if(resultado == DialogResult.Yes)
                   agregarRegistro();
            }
            else 
            {
                if (validarCampos())
                    agregarRegistro();
            }
        }


        private bool buscarRegistrosRepetidos() 
        {
            objBD = new BaseDatoBit();
            DataTable resultado = objBD.buscarRegistroBit(txtSicipo.Text.Trim());
            if (resultado.Rows.Count>0)
            {
                return true;
            }
            return false;
        }

        private void buscarEquipo() 
        {
            if (String.Empty != txtSicipo.Text)
            {
                objBD = new BaseDatoBit();
                string[] registroPerifericos = objBD.obtenerRegistroBitacora(txtSicipo.Text.Trim());

                if (registroPerifericos[0] != null)
                {
                    llenarFormularioBitacora(registroPerifericos);
                }
                else
                {
                    MessageBox.Show("No existen registros con el folio ingresado", "Agregar registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("Ingrese un folio a buscar", "Agregar registro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscarEquipo();
        }

        private void llenarFormularioBitacora(string []datos) 
        {
            txtFolio.Text = datos[1];
            txtTipo.Text = datos[2];
            txtMarca.Text = datos[3];
            txtModelo.Text = datos[4];
            txtNoSerie.Text = datos[5];
            txtResguardante.Text = datos[6];
            txtArea.Text =  datos[7];
        }

        private void txtFolio_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                buscarEquipo();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }


        //Actualiza la hora del formulario mientras se ejecuta el programa, resuelve el problema de hora estatica
        private void timer1_Tick(object sender, EventArgs e)
        {
            dateFecha.Value = DateTime.Now;
        }

        private void txtFolio_TextChanged(object sender, EventArgs e)
        {

        }

    }
}

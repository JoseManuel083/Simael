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
    
    public partial class FrmAgregarRegistroBit : UserControl
    {
        private BaseDatoBit objBD;
        public FrmAgregarRegistroBit()
        {
            InitializeComponent();
        }

        private bool validarCamposVacios() 
        {
            foreach (Control control in this.Controls)
            {
                if (control.GetType().Equals(typeof(TextBox)))
                {
                    if (control.Text.Equals(""))
                    {
                        return false;
                    }
                }

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
            if (validarCamposVacios())
            {
                agregarRegistro();
            }
            else 
            {
                MessageBox.Show("Existen campos sin datos , por favor ingrese datos","Agregar registro",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            
        }

    }
}

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
    public partial class FrmEdicionRegistros : Form
    {
        private FrmEditarElimBit objEdit;
        private BaseDatoBit objBD;
        private string idBitacora;
        public FrmEdicionRegistros()
        {
            InitializeComponent();
        }

        private void FrmEdicionRegistros_Load(object sender, EventArgs e)
        {
            
        }

        public FrmEdicionRegistros(FrmEditarElimBit frm,string idBitacora,string tipo, string folio,string sicipo, string marca ,string modelo, string noserie,string resg,
                                     string area, string problema,DateTime fecha,int estado) 
        {
            InitializeComponent();
            txtTipo.Text = tipo;
            txtFolio.Text = folio;
            txtSicipo.Text = sicipo;
            txtMarca.Text = marca;
            txtModelo.Text = modelo;
            txtNoSerie.Text = noserie;
            txtResguardante.Text = resg;
            txtArea.Text = area;
            txtProblema.Text = problema;
            dateTimePicker1.Value = fecha;
            this.idBitacora = idBitacora;
            objEdit = frm;
            configurarComboBox(estado);
        }

        private bool validarCamposVacios()
        {
            foreach(Control control in this.Controls)
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

        private void configurarComboBox(int estado) 
        {
            comboEstado.Items.Add("No revisado");
            comboEstado.Items.Add("Revisado");
            comboEstado.SelectedIndex = estado;
            comboEstado.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void guardarCambios()
        {
            string tipo = txtTipo.Text;
            string folio = txtFolio.Text;
            string sicipo = txtSicipo.Text;
            string marca = txtMarca.Text;
            string modelo = txtModelo.Text;
            string noserie = txtNoSerie.Text;
            string resguardante = txtResguardante.Text;
            string area = txtArea.Text;
            string problema = txtProblema.Text;
            DateTime fecha = dateTimePicker1.Value;
            string valorEstado = comboEstado.SelectedIndex.ToString();
            
            objBD = new BaseDatoBit();
            bool estado = objBD.editaRegistroBit(idBitacora,folio,sicipo,tipo,marca,modelo,noserie,resguardante,area,problema,fecha,valorEstado);
            if(estado)
            {
                MessageBox.Show("Los datos han sido guardados correctamente", "Editar Registros", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else
            {
                MessageBox.Show("Error al guardar los cambios, por favor consulte con el administrador", "Editar Registros", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void eliminarRegistro() 
        {
            objBD = new BaseDatoBit();
            bool estado = objBD.eliminarRegistroBit(idBitacora);
            if (estado)
            {
                MessageBox.Show("Registro eliminado correctamente", "Editar Registros", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else 
            {
                MessageBox.Show("Error al eliminar el registro, por favor consulte con el administrador", "Editar Registros", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            guardarCambios();
            this.Close();
            objEdit.llenarTablaRegistros();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Esta seguro de que desea eliminar este registro?", "Eliminar Registro",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                eliminarRegistro();
                this.Close();
                objEdit.llenarTablaRegistros();
            }
        }
    }
}

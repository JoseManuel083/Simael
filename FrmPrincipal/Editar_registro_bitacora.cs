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
    public partial class Editar_registro_bitacora : Form
    {
        private Historial_bitacora objEdit;
        private BaseDatoBit objBD;
        private string idBitacora;
        private Button btnQuitar;
        DateTime tmpDate = new DateTime(1900, 10, 10, 10, 10, 10);
        public Editar_registro_bitacora()
        {
            InitializeComponent();
        }

        private void FrmEdicionRegistros_Load(object sender, EventArgs e)
        {
           
        }

        public Editar_registro_bitacora(Historial_bitacora frm,string idBitacora,string tipo, string folio,string sicipo, string marca ,string modelo, string noserie,string resg,
                                     string area, string problema,string solucion,DateTime fecha,string fecha2,int estado) 
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
            txtSolucion.Text = solucion;
            dateTimePicker1.Value = fecha;
            establecerFecha(fecha2);
            this.idBitacora = idBitacora;
            objEdit = frm;
            configurarComboBox(estado);
        }

        private void establecerFecha(string fecha2) 
        {
            if ((!String.IsNullOrEmpty(fecha2)) && (!fecha2.Equals(tmpDate.ToString())))
            {
                //btnAgregar.Visible = false;
                ocultarBotonAgregar();
                fechaSalida.Visible = true;
                fechaSalida.Location = new Point(221, 707);
                fechaSalida.Value = Convert.ToDateTime(fecha2);
            }
            else 
            {
                fechaSalida.Visible = false;
                fechaSalida.Value = tmpDate;
            }
            
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
            comboEstado.Items.Add("Baja");
            comboEstado.SelectedIndex = estado;
            comboEstado.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void guardarCambios()
        {
            string tipo = txtTipo.Text.Trim();
            string folio = txtFolio.Text.Trim();
            string sicipo = txtSicipo.Text.Trim();
            string marca = txtMarca.Text.Trim();
            string modelo = txtModelo.Text.Trim();
            string noserie = txtNoSerie.Text.Trim();
            string resguardante = txtResguardante.Text.Trim();
            string area = txtArea.Text.Trim();
            string problema = txtProblema.Text.Trim();
            string solucion = txtSolucion.Text.Trim();
            DateTime fecha = dateTimePicker1.Value;
            DateTime fecha2 = fechaSalida.Value;
            string valorEstado = comboEstado.SelectedIndex.ToString();
            
            objBD = new BaseDatoBit();
            bool estado = objBD.editaRegistroBit(idBitacora,folio,sicipo,tipo,marca,modelo,noserie,resguardante,area,problema,solucion,fecha,fecha2,valorEstado);
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

        private void ocultarBotonAgregar()
        {
            btnQuitar = new Button();
            btnQuitar.Text = "Quitar";
            btnQuitar.Size = new Size(43, 23);
            btnQuitar.Location = new Point(430, 704);
            btnQuitar.Click += new EventHandler(btnQuitar_Click);
            this.Controls.Add(btnQuitar);

            btnAgregar.Visible = false;
            fechaSalida.Visible = true;
            fechaSalida.Location = new Point(221, 707);
            fechaSalida.Value = DateTime.Now;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ocultarBotonAgregar();
        }

        private void btnQuitar_Click(Object sender , System.EventArgs e) {
            fechaSalida.Visible = false;
            fechaSalida.Value = tmpDate;
            btnQuitar.Visible = false;
            btnAgregar.Visible = true;
        }

    }
}

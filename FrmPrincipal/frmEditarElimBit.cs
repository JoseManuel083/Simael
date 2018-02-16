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
    public partial class FrmEditarElimBit : UserControl
    {
        private BaseDatoBit objBD;
        private FrmEdicionRegistros objEdit;
        private string equipoTipo;
        private string folioUmar;
        private string sicipo;
        private string marca;
        private string modelo;
        private string noSerie;
        private string resguardante;
        private string area;
        private string problema;
        private string idBitacora;
        private DateTime fecha;
        public FrmEditarElimBit()
        {
            InitializeComponent();
            establecerConfDgv();
            llenarTablaRegistros();
        }

        public FrmEditarElimBit(string param) 
        {
            InitializeComponent();
            establecerConfDgv();
            busquedaDataGV(param);
        }

        /*
         * Este metodo es para efectuar las busquedas desde el menustrip
         */
        public void busquedaDataGV(string param) 
        {
            objBD = new BaseDatoBit();
            dgvBitacora.DataSource = objBD.buscarRegistroBit(param);
 
        }
        // Llena el datagrid al entrar por primera vez al modulo de eliminacion edicion de registros
        private void llenarTablaRegistros() 
        {
            objBD = new BaseDatoBit();
            dgvBitacora.DataSource = objBD.obtenerRegistrosBit();
        }

        private void establecerConfDgv() 
        {
            dgvBitacora.AutoGenerateColumns = false;
            colEquipo.DataPropertyName = "equipotipo";
            colFolio.DataPropertyName = "folioumar";
            colSicipo.DataPropertyName = "sicipo";
            colMarca.DataPropertyName = "marca";
            colModelo.DataPropertyName = "modelo";
            colNoSerie.DataPropertyName = "noserie";
            colResguardante.DataPropertyName = "resguardante";
            colArea.DataPropertyName = "area";
            colProblema.DataPropertyName = "problema";
            colFecha.DataPropertyName = "fecha";
            colIdBitacora.DataPropertyName = "idbitacora";
        }

        private void obtenerDatos()
        {
            equipoTipo = dgvBitacora.CurrentRow.Cells[0].Value.ToString();
            folioUmar = dgvBitacora.CurrentRow.Cells[1].Value.ToString();
            sicipo = dgvBitacora.CurrentRow.Cells[2].Value.ToString();
            marca = dgvBitacora.CurrentRow.Cells[3].Value.ToString();
            modelo = dgvBitacora.CurrentRow.Cells[4].Value.ToString();
            noSerie = dgvBitacora.CurrentRow.Cells[5].Value.ToString();
            resguardante = dgvBitacora.CurrentRow.Cells[6].Value.ToString();
            area = dgvBitacora.CurrentRow.Cells[7].Value.ToString();
            problema = dgvBitacora.CurrentRow.Cells[8].Value.ToString();
            fecha = Convert.ToDateTime(dgvBitacora.CurrentRow.Cells[9].Value.ToString());
            idBitacora = dgvBitacora.CurrentRow.Cells[10].Value.ToString();
        }
        public void actualizarGridV() 
        {
            objBD = new BaseDatoBit();
            dgvBitacora.DataSource = objBD.obtenerRegistrosBit();
        }

        private void mostrarDatos() 
        {
            obtenerDatos();
            objEdit = new FrmEdicionRegistros(this, idBitacora, equipoTipo, folioUmar, sicipo, marca, modelo, noSerie, resguardante, area, problema, fecha);
            objEdit.ShowDialog();
        }
        private void frmEditarElimBit_Load(object sender, EventArgs e)
        {

        }
        private void dgvBitacora_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            mostrarDatos();
        }

        private void dgvBitacora_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                mostrarDatos();
            }
        }
    }
}

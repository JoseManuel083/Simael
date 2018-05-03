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
        private string tipoDGV;

        public string TipoDGV
        {
            get { return tipoDGV; }
            set { tipoDGV = value; }
        }
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
        private int estado;
        private DateTime fecha;
        public FrmEditarElimBit()
        {
            InitializeComponent();
            establecerConfDgv();
            //llenarTablaRegistros();
        }

        public FrmEditarElimBit(string param) 
        {
            InitializeComponent();
            establecerConfDgv();
            busquedaDataGV(param);
        }

        /*
         * Este metodo es para buscar un registro en especifico en la bitacora desde el menustrip
         */
        public void busquedaDataGV(string param) 
        {
            objBD = new BaseDatoBit();
            dgvBitacora.DataSource = objBD.buscarRegistroBit(param);
 
        }
        // Llena el datagrid mostrando el historial de equipos registrados en la bitacora

        public void llenarTablaRegistros() 
        {
            objBD = new BaseDatoBit();
            DataTable tabla = new DataTable();
            tabla = objBD.obtenerRegistrosBit();
            dgvBitacora.DataSource = tabla;

            for (int i = 0; i < dgvBitacora.Rows.Count; i++)
            {
                estado = Int32.Parse(tabla.Rows[i][11].ToString());
                if (estado == 0)
                    dgvBitacora.Rows[i].Cells[0].Style.BackColor = Color.Yellow;
                else
                    dgvBitacora.Rows[i].Cells[0].Style.BackColor = Color.Green;
            }
        }

        private void establecerConfDgv() 
        {
            dgvBitacora.AutoGenerateColumns = false;
            colValEstado.DataPropertyName = "estado";
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
            estado = Convert.ToInt32(dgvBitacora.CurrentRow.Cells[1].Value.ToString());
            equipoTipo = dgvBitacora.CurrentRow.Cells[2].Value.ToString();
            folioUmar = dgvBitacora.CurrentRow.Cells[3].Value.ToString();
            sicipo = dgvBitacora.CurrentRow.Cells[4].Value.ToString();
            marca = dgvBitacora.CurrentRow.Cells[5].Value.ToString();
            modelo = dgvBitacora.CurrentRow.Cells[6].Value.ToString();
            noSerie = dgvBitacora.CurrentRow.Cells[7].Value.ToString();
            resguardante = dgvBitacora.CurrentRow.Cells[8].Value.ToString();
            area = dgvBitacora.CurrentRow.Cells[9].Value.ToString();
            problema = dgvBitacora.CurrentRow.Cells[10].Value.ToString();
            fecha = Convert.ToDateTime(dgvBitacora.CurrentRow.Cells[11].Value.ToString());
            idBitacora = dgvBitacora.CurrentRow.Cells[12].Value.ToString();
        }
        //public void actualizarGridV() 
        //{
        //    objBD = new BaseDatoBit();
        //    dgvBitacora.DataSource = objBD.obtenerRegistrosBit();
        //}

        private void mostrarDatos() 
        {
            obtenerDatos();
            objEdit = new FrmEdicionRegistros(this, idBitacora, equipoTipo, folioUmar, sicipo, marca, modelo, noSerie, resguardante, area, problema, fecha,estado);
            objEdit.ShowDialog();
        }
        private void frmEditarElimBit_Load(object sender, EventArgs e)
        {
            llenarTablaRegistros();
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

        private void dgvBitacora_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}

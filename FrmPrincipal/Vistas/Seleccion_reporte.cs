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

namespace Simael.Vistas
{
    public partial class Seleccion_reporte : Form
    {
        private BaseDatoBit objBD;
        private Agregar_reporte objRepor;
        private string sicipoBitacora;

        public string SicipoBitacora
        {
            get { return sicipoBitacora; }
            set { sicipoBitacora = value; }
        }

        public Seleccion_reporte(string sicipo, Agregar_reporte objRepor)
        {
            InitializeComponent();
            this.objRepor = objRepor;
            llenardgvReporte(sicipo);
        }

        private void view_seleccion_reporte_Load(object sender, EventArgs e)
        {
            dgvReporte.Focus();
        }

        private void configurarDataGrid() 
        {
            dgvReporte.AutoGenerateColumns = false;
            colidBitacora.DataPropertyName = "idbitacora";
            colTipo.DataPropertyName = "equipotipo";
            colSicipo.DataPropertyName = "sicipo";
            colFolio.DataPropertyName = "folioumar";
            colMarca.DataPropertyName = "marca";
            colModelo.DataPropertyName = "modelo";
            colNoSerie.DataPropertyName = "noserie";
            colResguardante.DataPropertyName = "resguardante";
            colArea.DataPropertyName = "area";
            colProblema.DataPropertyName = "problema";
            colFecha.DataPropertyName = "fecha";
        }

        private void llenardgvReporte(string sicipo)
        {
            objBD  = new BaseDatoBit();
            configurarDataGrid();
            dgvReporte.DataSource = objBD.buscarRegistroBit(sicipo);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvReporte_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            obtenerSicipoBitacora();
        }

        private void obtenerSicipoBitacora()
        {
            SicipoBitacora = dgvReporte.CurrentRow.Cells[0].Value.ToString();
            objRepor.seleccionarEquipoReporte(SicipoBitacora);
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            obtenerSicipoBitacora();
        }
    }
}

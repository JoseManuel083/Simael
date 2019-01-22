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
using CrystalDecisions.Shared;
namespace Simael
{
    public partial class ReporteBaja : UserControl
    {
        private BaseDatoBit objBD;
        private DataTable tabla;
        private AgregarReporteBajas objBaja;
        public ReporteBaja()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            cargarRegistrosBajas();
        }

        private void ReporteBaja_Load(object sender, EventArgs e)
        {

        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            enumerarFilasDgv();
        }
        private void cargarRegistrosBajas() 
        {
            tabla = new DataTable();
            objBD = new BaseDatoBit();
            tabla = objBD.obtenerEquiposBajas();
            dgvBaja.AutoGenerateColumns = false;
            colFolio.DataPropertyName = "folioumar";
            colSicipo.DataPropertyName = "sicipo";
            colCategoria.DataPropertyName = "equipotipo";
            colMarca.DataPropertyName = "marca";
            colModelo.DataPropertyName = "modelo";
            colNoSerie.DataPropertyName = "noserie";
            colResguardante.DataPropertyName = "resguardante";
            colArea.DataPropertyName = "area";
            colProblema.DataPropertyName = "problema";
            colSolucion.DataPropertyName = "solucion";
            colFechaIngreso.DataPropertyName = "fecha";
            dgvBaja.DataSource = tabla;
            enumerarFilasDgv();
        }

        private void dgvBaja_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvBaja_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            mostrarReporte();
        }

        private void mostrarReporte() 
        {
            string sicipo = dgvBaja.CurrentRow.Cells[1].Value.ToString();
            string folio = dgvBaja.CurrentRow.Cells[2].Value.ToString();
            string tipo = dgvBaja.CurrentRow.Cells[3].Value.ToString();
            string marca = dgvBaja.CurrentRow.Cells[4].Value.ToString();
            string modelo = dgvBaja.CurrentRow.Cells[5].Value.ToString();
            string noserie = dgvBaja.CurrentRow.Cells[6].Value.ToString();
            string resguardante = dgvBaja.CurrentRow.Cells[7].Value.ToString();
            string area = dgvBaja.CurrentRow.Cells[8].Value.ToString();
            string problema = dgvBaja.CurrentRow.Cells[9].Value.ToString();

            objBaja = new AgregarReporteBajas(sicipo,folio,tipo,marca,modelo,noserie,resguardante,area,problema);
            objBaja.ShowDialog();
        }

        private void enumerarFilasDgv() 
        {
            for (int i = 0; i < dgvBaja.Rows.Count;i++ )
            {
                dgvBaja.Rows[i].Cells[0].Value = i + 1;
            }
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buscarEquipoBajas();
            }
        }

        private void buscarEquipoBajas() 
        {
            objBD = new BaseDatoBit();
            dgvBaja.DataSource = objBD.buscarEquipoBajas(txtBuscar.Text.Trim());
            enumerarFilasDgv();
        }

        private void picBuscar_Click(object sender, EventArgs e)
        {
            buscarEquipoBajas();
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            buscarEquipoBajas();
        }
       
    }
}

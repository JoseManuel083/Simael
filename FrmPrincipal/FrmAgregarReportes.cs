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
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using Simael.Plantillas_reportes;

namespace Simael
{
    public partial class FrmAgregarReportes : UserControl
    {
        private BaseDatoBit objBD;
        public FrmAgregarReportes()
        {
            InitializeComponent();
        }


        private void establecerDatosReporte(List<String> equipo) 
        {
            if (equipo.Count == 18)
            {
                txtID.Text = equipo.ElementAt(0);
                txtTipo.Text = equipo.ElementAt(1);
                txtMarca.Text = equipo.ElementAt(3);
                txtNoSerie.Text = equipo.ElementAt(4);
                txtModelo.Text = equipo.ElementAt(5);
                txtRam.Text = equipo.ElementAt(6);
                txtProcesador.Text = equipo.ElementAt(8);
                txtHdd.Text = equipo.ElementAt(11);
                
                txtSicipo.Text = equipo.ElementAt(0);
                txtCosto.Text = equipo.ElementAt(15);
                txtResguardante.Text = equipo.ElementAt(16);
                txtOtros.Text = equipo.ElementAt(17);
                
            }
            else if (equipo.Count == 12)
            {
                txtID.Text = equipo.ElementAt(0);
                txtTipo.Text = equipo.ElementAt(1);
                txtMarca.Text = equipo.ElementAt(3);
                txtModelo.Text = equipo.ElementAt(4);
                txtNoSerie.Text = equipo.ElementAt(5);
            
                txtSicipo.Text = equipo.ElementAt(0);
                txtCosto.Text = equipo.ElementAt(9);
                txtResguardante.Text = equipo.ElementAt(10);
                txtOtros.Text = equipo.ElementAt(11);
            }
            else
            {
                MessageBox.Show("No se han encontrado resultados para la busqueda, intente con otro ID", "Reportes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        
        private void generarReporte()
        {
            Form_Reporte reporte = new Form_Reporte();
            Reporte pReport = new Reporte();
            TextObject text = (TextObject)pReport.ReportDefinition.Sections["Section2"].ReportObjects["textArea"];
            text.Text = txtResguardante.Text;
            reporte.crystalReportViewer1.ReportSource = pReport;
            reporte.Show();

        }
        private void obtenerRegistroReport() 
        {
            objBD = new BaseDatoBit();
            List<String>  registro = objBD.obtenerRegistroReporte(txtID.Text.Trim());
            establecerDatosReporte(registro);
         
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            generarReporte();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            obtenerRegistroReport();
        }

        private void FrmAgregarReportes_Load(object sender, EventArgs e)
        {

        }

    }
}

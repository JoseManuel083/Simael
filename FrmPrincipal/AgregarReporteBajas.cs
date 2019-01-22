using CrystalDecisions.Shared;
using Simael.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Simael.Reportes;

namespace Simael
{
    public partial class AgregarReporteBajas : Form
    {
        public AgregarReporteBajas(string sicipo,string folio,string tipo,string marca,string modelo,string noserie,string resguardante,string area,string problema)
        {
            InitializeComponent();
            txtSicipo.Text = sicipo;
            txtFolio.Text = folio;
            txtNombre.Text = tipo;
            txtMarca.Text = marca;
            txtModelo.Text = modelo;
            txtNoSerie.Text = noserie;
            txtResguardante.Text = resguardante;
            txtArea.Text = area;
            txtCausaBaja.Text = problema;
        }

        private void AgregarReporteBajas_Load(object sender, EventArgs e)
        {

        }

        private void generarReporte()
        {
            Simael.Reportes.ReporteBaja reporte = new Simael.Reportes.ReporteBaja();
            ParameterFields parametros = new ParameterFields();
            ParameterField sicipo = new ParameterField();
            ParameterField folio = new ParameterField();
            ParameterField marca = new ParameterField();
            ParameterField modelo = new ParameterField();
            ParameterField tipo = new ParameterField();
            ParameterField noSerie = new ParameterField();
            ParameterField causaBaja = new ParameterField();
            ParameterField resguardante = new ParameterField();
            ParameterField area = new ParameterField();
            ParameterField diagnostico = new ParameterField();
            ParameterField fecha = new ParameterField();


            ParameterDiscreteValue dvsicipo = new ParameterDiscreteValue();
            ParameterDiscreteValue dvfolio = new ParameterDiscreteValue();
            ParameterDiscreteValue dvmarca = new ParameterDiscreteValue();
            ParameterDiscreteValue dvmodelo = new ParameterDiscreteValue();
            ParameterDiscreteValue dvtipo = new ParameterDiscreteValue();
            ParameterDiscreteValue dvnoserie = new ParameterDiscreteValue();
            ParameterDiscreteValue dvcausaBaja = new ParameterDiscreteValue();
            ParameterDiscreteValue dvresguardante = new ParameterDiscreteValue();
            ParameterDiscreteValue dvarea = new ParameterDiscreteValue();
            ParameterDiscreteValue dvdiagnostico = new ParameterDiscreteValue();
            ParameterDiscreteValue dvfecha = new ParameterDiscreteValue();
            

            sicipo.ParameterFieldName = "paramSicipo";
            folio.ParameterFieldName = "paramFolio";
            resguardante.ParameterFieldName = "paramResguardante";
            area.ParameterFieldName = "paramArea";
            causaBaja.ParameterFieldName = "paramCausaBaja";
            tipo.ParameterFieldName = "paramTipo";
            marca.ParameterFieldName = "paramMarca";
            modelo.ParameterFieldName = "paramModelo";
            noSerie.ParameterFieldName = "paramNoSerie";
            diagnostico.ParameterFieldName = "paramDiagnostico";
            fecha.ParameterFieldName = "paramFecha";

            dvsicipo.Value = txtSicipo.Text.Trim();
            sicipo.CurrentValues.Add(dvsicipo);
            dvfolio.Value = txtFolio.Text.Trim();
            folio.CurrentValues.Add(dvfolio);
            dvmarca.Value = txtMarca.Text.Trim();
            marca.CurrentValues.Add(dvmarca);
            dvmodelo.Value = txtModelo.Text.Trim();
            modelo.CurrentValues.Add(dvmodelo);
            dvnoserie.Value = txtNoSerie.Text.Trim();
            noSerie.CurrentValues.Add(dvnoserie);
            dvtipo.Value = txtNombre.Text.Trim();
            tipo.CurrentValues.Add(dvtipo);
            dvresguardante.Value = txtResguardante.Text.Trim();
            resguardante.CurrentValues.Add(dvresguardante);
            dvarea.Value = txtArea.Text.Trim();
            area.CurrentValues.Add(dvarea);
            dvdiagnostico.Value = txtDiagnostico.Text.Trim();
            diagnostico.CurrentValues.Add(dvdiagnostico);
            dvcausaBaja.Value = txtCausaBaja.Text.Trim();
            causaBaja.CurrentValues.Add(dvcausaBaja);
            dvfecha.Value = dtFecha.Value.ToShortDateString();
            fecha.CurrentValues.Add(dvfecha);

            parametros.Add(sicipo);
            parametros.Add(folio);
            parametros.Add(resguardante);
            parametros.Add(area);
            parametros.Add(causaBaja);
            parametros.Add(tipo);
            parametros.Add(marca);
            parametros.Add(modelo);
            parametros.Add(noSerie);
            parametros.Add(diagnostico);
            parametros.Add(fecha);

            FrmReporteBaja reporteB = new FrmReporteBaja(reporte);
            reporteB.crystalReportViewer1.ParameterFieldInfo = parametros;
            reporteB.ShowDialog();

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            generarReporte();
        }
    }
}

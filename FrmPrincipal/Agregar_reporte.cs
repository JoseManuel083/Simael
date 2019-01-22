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
using Simael.Reportes;
using Simael.Vistas;
namespace Simael
{
    public partial class Agregar_reporte : UserControl
    {
        private BaseDatoBit objBD;
        private Seleccion_reporte objR;
        private string varcantidadR1;
        private string varnumeropR1;
        private string varfabricanteR1;
        private string vardescripcionR1;
        private string varprecioR1;
        private string varcantidadR2;
        private string varnumeropR2;
        private string varfabricanteR2;
        private string vardescripcionR2;
        private string varprecioR2;
        private string reparacionEquipo;
        public Agregar_reporte()
        {
            InitializeComponent();
            inicializarRefacciones();
        }

        private void inicializarRefacciones() 
        {
        varcantidadR1 = "0";
        varnumeropR1 = "0";
        varfabricanteR1 = "ND";
        vardescripcionR1 = "ND";
        varprecioR1 = "0";
        varcantidadR2 = "0";
        varnumeropR2 = "0";
        varfabricanteR2 = "ND";
        vardescripcionR2 = "ND";
        varprecioR2 = "0";
        }
        private void establecerDatosReporte(List<String> equipo) 
        {
            if (equipo.Count == 20)//Si la cantidad de elementos arreglo es igual a 20, el registro de retorno es una pc 
            {
                txtSoi.Text = equipo.ElementAt(0); ;
                txtSicipo.Text = equipo.ElementAt(1);
                txtTipo.Text = equipo.ElementAt(2);
                txtMarca.Text = equipo.ElementAt(4);
                txtModelo.Text = equipo.ElementAt(5);
                txtNoSerie.Text = equipo.ElementAt(6);
                txtRam.Text = equipo.ElementAt(7);
                txtProcesador.Text = equipo.ElementAt(8);
                txtHdd.Text = equipo.ElementAt(12);
                txtCosto.Text = equipo.ElementAt(15);
                txtResguardante.Text = equipo.ElementAt(16);
                txtArea.Text = equipo.ElementAt(17); ;
                txtFalla.Text = equipo.ElementAt(18);
                txtSolucion.Text = equipo.ElementAt(19);
            }
            else if (equipo.Count == 15)//Si la cantidad de elementos del arreglo es igual a 14, el registro de retorno es un periferico
            {
                txtSoi.Text = equipo.ElementAt(0); ;
                txtSicipo.Text = equipo.ElementAt(1);
                txtTipo.Text = equipo.ElementAt(2);
                txtMarca.Text = equipo.ElementAt(4);
                txtModelo.Text = equipo.ElementAt(5);
                txtNoSerie.Text = equipo.ElementAt(6);
                txtCosto.Text = equipo.ElementAt(10);
                txtResguardante.Text = equipo.ElementAt(11);
                txtArea.Text = equipo.ElementAt(12); ;
                txtFalla.Text = equipo.ElementAt(13);
                txtRam.Text = "SIN DATOS";
                txtProcesador.Text = "SIN DATOS";
                txtHdd.Text = "SIN DATOS";
                txtSolucion.Text = equipo.ElementAt(14);
            }
            else
            {
                MessageBox.Show("No se han encontrado resultados para la busqueda, intente con otro ID", "Reportes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        


        private void agregarDatosReporte() 
        {
            Reporte reporte = new Reporte();
            ParameterFields parametros = new ParameterFields();
            ParameterField sicipo = new ParameterField();
            ParameterField folio = new ParameterField();
            ParameterField marca = new ParameterField();
            ParameterField modelo = new ParameterField();
            ParameterField equipo = new ParameterField();
            ParameterField noSerie = new ParameterField();
            ParameterField ram = new ParameterField();
            ParameterField procesador = new ParameterField();
            ParameterField discoduro = new ParameterField();
            ParameterField costo = new ParameterField();
            ParameterField resguardante = new ParameterField();
            ParameterField area = new ParameterField();
            ParameterField falla = new ParameterField();
            ParameterField precio = new ParameterField();
            ParameterField fechaAd = new ParameterField();
            ParameterField extension = new ParameterField();
            ParameterField email = new ParameterField();
            ParameterField diagnostico = new ParameterField();
            ParameterField causa = new ParameterField();
            ParameterField solucion = new ParameterField();
            ParameterField cantidadR1 = new ParameterField(); 
            ParameterField numeropR1 = new ParameterField(); 
            ParameterField fabricanteR1 = new ParameterField(); 
            ParameterField descripcionR1 = new ParameterField(); 
            ParameterField precioR1 = new ParameterField(); 
            ParameterField cantidadR2 = new ParameterField();
            ParameterField numeropR2 = new ParameterField(); 
            ParameterField fabricanteR2 = new ParameterField(); 
            ParameterField descripcionR2 = new ParameterField();
            ParameterField precioR2 = new ParameterField();
            ParameterField tipoServicio = new ParameterField();
            ParameterField descripcionServicio = new ParameterField();
            ParameterField reparacion = new ParameterField();
            ParameterField justificacionReparacion = new ParameterField();


            ParameterDiscreteValue dvsicipo = new ParameterDiscreteValue();
            ParameterDiscreteValue dvfolio = new ParameterDiscreteValue();
            ParameterDiscreteValue dvmarca = new ParameterDiscreteValue();
            ParameterDiscreteValue dvmodelo = new ParameterDiscreteValue();
            ParameterDiscreteValue dvequipo = new ParameterDiscreteValue();
            ParameterDiscreteValue dvnoserie = new ParameterDiscreteValue();
            ParameterDiscreteValue dvram = new ParameterDiscreteValue();
            ParameterDiscreteValue dvprocesador = new ParameterDiscreteValue();
            ParameterDiscreteValue dvdiscoduro = new ParameterDiscreteValue();
            ParameterDiscreteValue dvcosto = new ParameterDiscreteValue();
            ParameterDiscreteValue dvresguardante = new ParameterDiscreteValue();
            ParameterDiscreteValue dvarea = new ParameterDiscreteValue();
            ParameterDiscreteValue dvprecio = new ParameterDiscreteValue();
            ParameterDiscreteValue dvfechaAd = new ParameterDiscreteValue();
            ParameterDiscreteValue dvextension = new ParameterDiscreteValue();
            ParameterDiscreteValue dvemail = new ParameterDiscreteValue();
            ParameterDiscreteValue dvfalla = new ParameterDiscreteValue();
            ParameterDiscreteValue dvdiagnostico = new ParameterDiscreteValue();
            ParameterDiscreteValue dvcausa = new ParameterDiscreteValue();
            ParameterDiscreteValue dvsolucion = new ParameterDiscreteValue();
            ParameterDiscreteValue dvcantidadR1 = new ParameterDiscreteValue();
            ParameterDiscreteValue dvnumeropR1 = new ParameterDiscreteValue();
            ParameterDiscreteValue dvfabricanteR1 = new ParameterDiscreteValue();
            ParameterDiscreteValue dvdescripcionR1 = new ParameterDiscreteValue();
            ParameterDiscreteValue dvprecioR1 = new ParameterDiscreteValue();
            ParameterDiscreteValue dvcantidadR2 = new ParameterDiscreteValue();
            ParameterDiscreteValue dvnumeropR2 = new ParameterDiscreteValue();
            ParameterDiscreteValue dvfabricanteR2 = new ParameterDiscreteValue();
            ParameterDiscreteValue dvdescripcionR2 = new ParameterDiscreteValue();
            ParameterDiscreteValue dvprecioR2 = new ParameterDiscreteValue();
            ParameterDiscreteValue dvtipoServicio = new ParameterDiscreteValue();
            ParameterDiscreteValue dvdescripcionServicio = new ParameterDiscreteValue();
            ParameterDiscreteValue dvreparacion = new ParameterDiscreteValue();
            ParameterDiscreteValue dvjustificacionReparacion = new ParameterDiscreteValue();


            sicipo.ParameterFieldName = "paramsicipo";
            folio.ParameterFieldName = "paramfolio";
            resguardante.ParameterFieldName = "paramresguardante";
            area.ParameterFieldName = "paramarea";
            precio.ParameterFieldName = "paramprecio";
            fechaAd.ParameterFieldName = "paramfechaadquisicion";
            email.ParameterFieldName = "paramemail";
            extension.ParameterFieldName = "paramextension";
            procesador.ParameterFieldName = "paramprocesador";
            discoduro.ParameterFieldName = "paramdiscoduro";
            costo.ParameterFieldName = "paramprecio";
            ram.ParameterFieldName = "paramram";
            equipo.ParameterFieldName = "paramequipo";
            marca.ParameterFieldName = "parammarca";
            modelo.ParameterFieldName = "parammodelo";
            noSerie.ParameterFieldName = "paramnoserie";
            falla.ParameterFieldName = "paramfalla";
            diagnostico.ParameterFieldName = "paramdiagnostico";
            causa.ParameterFieldName = "paramcausa";
            solucion.ParameterFieldName = "paramsolucion";

            cantidadR1.ParameterFieldName = "paramRCantidad1";
            numeropR1.ParameterFieldName = "paramRNp1";
            fabricanteR1.ParameterFieldName = "paramRFabricante1";
            descripcionR1.ParameterFieldName = "paramRDescripcion1";
            precioR1.ParameterFieldName = "paramRPrecio1";
            cantidadR2.ParameterFieldName = "paramRCantidad2";
            numeropR2.ParameterFieldName = "paramRNp2";
            fabricanteR2.ParameterFieldName = "paramRFabricante2";
            descripcionR2.ParameterFieldName = "paramRDescripcion2";
            precioR2.ParameterFieldName = "paramRPrecio2";
            tipoServicio.ParameterFieldName = "paramtiposervicio";
            descripcionServicio.ParameterFieldName = "paramdescripcionservicio";
            reparacion.ParameterFieldName = "paramreparar";
            justificacionReparacion.ParameterFieldName = "paramrespuesta";


            dvsicipo.Value = txtSicipo.Text.Trim();
            sicipo.CurrentValues.Add(dvsicipo);
            dvfolio.Value = txtSoi.Text.Trim();
            folio.CurrentValues.Add(dvfolio);
            dvequipo.Value = txtTipo.Text.Trim();
            equipo.CurrentValues.Add(dvequipo);
            dvresguardante.Value = txtResguardante.Text.Trim();
            resguardante.CurrentValues.Add(dvresguardante);
            dvarea.Value = txtArea.Text.Trim();
            area.CurrentValues.Add(dvarea);
            dvprecio.Value = txtCosto.Text.Trim();
            precio.CurrentValues.Add(dvprecio);
            dvfechaAd.Value = pickerFecha.Value.ToShortDateString();
            fechaAd.CurrentValues.Add(dvfechaAd);
            dvemail.Value = txtEmail.Text.Trim();
            email.CurrentValues.Add(dvemail);
            dvextension.Value = txtTelefono.Text.Trim();
            extension.CurrentValues.Add(dvextension);
            dvprocesador.Value = txtProcesador.Text.Trim();
            procesador.CurrentValues.Add(dvprocesador);
            dvdiscoduro.Value = txtHdd.Text.Trim();
            discoduro.CurrentValues.Add(dvdiscoduro);
            dvram.Value = txtRam.Text.Trim();
            ram.CurrentValues.Add(dvram);
            dvmarca.Value = txtMarca.Text.Trim();
            marca.CurrentValues.Add(dvmarca);
            dvcosto.Value = txtCosto.Text.Trim();
            costo.CurrentValues.Add(dvcosto);
            dvmodelo.Value = txtModelo.Text.Trim();
            modelo.CurrentValues.Add(dvmodelo);
            dvnoserie.Value = txtNoSerie.Text.Trim();
            noSerie.CurrentValues.Add(dvnoserie);
            dvfalla.Value = txtFalla.Text.Trim();
            falla.CurrentValues.Add(dvfalla);
            dvdiagnostico.Value = txtDiagnostico.Text.Trim();
            diagnostico.CurrentValues.Add(dvdiagnostico);
            dvcausa.Value = txtCausa.Text.Trim();
            causa.CurrentValues.Add(dvcausa);
            dvsolucion.Value = txtSolucion.Text.Trim();
            solucion.CurrentValues.Add(dvsolucion);
            dvcantidadR1.Value = varcantidadR1;
            cantidadR1.CurrentValues.Add(dvcantidadR1);
            dvnumeropR1.Value = varnumeropR1;
            numeropR1.CurrentValues.Add(dvnumeropR1);
            dvfabricanteR1.Value = varfabricanteR1;
            fabricanteR1.CurrentValues.Add(dvfabricanteR1);
            dvdescripcionR1.Value = vardescripcionR1;
            descripcionR1.CurrentValues.Add(dvdescripcionR1);
            dvprecioR1.Value = "$" + varprecioR1;
            precioR1.CurrentValues.Add(dvprecioR1);

            dvcantidadR2.Value = varcantidadR2;
            cantidadR2.CurrentValues.Add(dvcantidadR2);
            dvnumeropR2.Value = varnumeropR2;
            numeropR2.CurrentValues.Add(dvnumeropR2);
            dvfabricanteR2.Value = varfabricanteR2;
            fabricanteR2.CurrentValues.Add(dvfabricanteR2);
            dvdescripcionR2.Value = vardescripcionR2;
            descripcionR2.CurrentValues.Add(dvdescripcionR2);
            dvprecioR2.Value = "$" + varprecioR2;
            precioR2.CurrentValues.Add(dvprecioR2);
            dvreparacion.Value = reparacionEquipo;
            reparacion.CurrentValues.Add(dvreparacion);
            dvjustificacionReparacion.Value = txtReparacion.Text.Trim();
            justificacionReparacion.CurrentValues.Add(dvjustificacionReparacion);
            dvtipoServicio.Value = txtTipoS.Text.Trim();
            tipoServicio.CurrentValues.Add(dvtipoServicio);
            dvdescripcionServicio.Value = txtDescripcionS.Text.Trim();
            descripcionServicio.CurrentValues.Add(dvdescripcionServicio);
            
            parametros.Add(sicipo);
            parametros.Add(folio);
            parametros.Add(equipo);
            parametros.Add(resguardante);
            parametros.Add(email);
            parametros.Add(area);
            parametros.Add(precio);
            parametros.Add(fechaAd);
            parametros.Add(email);
            parametros.Add(extension);
            parametros.Add(procesador);
            parametros.Add(discoduro);
            parametros.Add(ram);
            parametros.Add(marca);
            parametros.Add(modelo);
            parametros.Add(noSerie);
            parametros.Add(falla);
            parametros.Add(diagnostico);
            parametros.Add(causa);
            parametros.Add(solucion);
            
            parametros.Add(cantidadR1);
            parametros.Add(numeropR1);
            parametros.Add(fabricanteR1);
            parametros.Add(descripcionR1);
            parametros.Add(precioR1);
            parametros.Add(cantidadR2);
            parametros.Add(numeropR2);
            parametros.Add(fabricanteR2);
            parametros.Add(descripcionR2);
            parametros.Add(precioR2);
            parametros.Add(reparacion);
            parametros.Add(justificacionReparacion);
            parametros.Add(tipoServicio);
            parametros.Add(descripcionServicio);

            FrmReporte objR = new FrmReporte(reporte);
            objR.crystalReportViewer1.ParameterFieldInfo = parametros;
            objR.ShowDialog();
            
        }
        private void obtenerRegistroReport() 
        {
            //MessageBox.Show(txtID.Text); Hace la busqueda correctamente
            objBD = new BaseDatoBit();
            DataTable tabla = objBD.obtenerEquiposReporte(txtID.Text.Trim());

            if (tabla.Rows.Count == 1)
            {
                List<String> registro = objBD.obtenerRegistroReporte(txtID.Text.Trim(),"0");
                establecerDatosReporte(registro);
            }
            else if(tabla.Rows.Count > 1)
            {
                objR = new Seleccion_reporte(txtID.Text.Trim(),this);
                objR.ShowDialog();
            }else if(tabla.Rows.Count == 0)
            {
                MessageBox.Show("No se han encontrado resultados para la busqueda , pruebe con otro ID", "Reportes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
         
        }

        public void seleccionarEquipoReporte(string idbitacora) 
        {
            List<String> registro = objBD.obtenerRegistroReporte(txtID.Text.Trim(), idbitacora);
            establecerDatosReporte(registro);
        }
    
        private void obtenerRefaccionesNecesarias()
        {
            string cantidadR = "";
            string numeropR = "";
            string fabricanteR = "";
            string descripcionR = "";
            string precioR = "";

            for (int i = 0; i < dataGridView1.Rows.Count-1;i++)
            {
                cantidadR += dataGridView1.Rows[i].Cells[0].Value.ToString() + "\n";
                numeropR += dataGridView1.Rows[i].Cells[1].Value.ToString() + "\n";
                fabricanteR += dataGridView1.Rows[i].Cells[2].Value.ToString() + "\n";
                descripcionR += dataGridView1.Rows[i].Cells[3].Value.ToString() + "\n";
                precioR += dataGridView1.Rows[i].Cells[4].Value.ToString() + "\n";
            }
            varcantidadR1 = cantidadR;
            varnumeropR1 = numeropR;
            varfabricanteR1 = fabricanteR;
            vardescripcionR1 = descripcionR;
            varprecioR1 = precioR;

            
        }

        private void obtenerRefaccionesReutilizables() 
        {
            string cantidadR2 = "";
            string numeropR2 = "";
            string fabricanteR2 = "";
            string descripcionR2 = "";
            string precioR2 = "";

            for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
            {
                cantidadR2 += dataGridView2.Rows[i].Cells[0].Value.ToString() + "\n";
                numeropR2 += dataGridView2.Rows[i].Cells[1].Value.ToString() + "\n";
                fabricanteR2 += dataGridView2.Rows[i].Cells[2].Value.ToString() + "\n";
                descripcionR2 += dataGridView2.Rows[i].Cells[3].Value.ToString() + "\n";
                precioR2 += dataGridView2.Rows[i].Cells[4].Value.ToString() + "\n";
            }
            varcantidadR2 = cantidadR2;
            varnumeropR2 = numeropR2;
            varfabricanteR2 = fabricanteR2;
            vardescripcionR2 = descripcionR2;
            varprecioR2 = precioR2;
        }

        private bool validarRefacciones()
        {
            if (dataGridView1.Rows.Count > 1) 
            {
                if (validarDatosRefacciones(dataGridView1))
                {
                    obtenerRefaccionesNecesarias();
                }
                else 
                {
                    MessageBox.Show("Faltan datos en la tabla de refacciones 1");
                    return false;
                }
            }

            if(dataGridView2.Rows.Count > 1)
            {
                if (validarDatosRefacciones(dataGridView2))
                {
                    obtenerRefaccionesReutilizables();
                }
                else 
                {
                    MessageBox.Show("Faltan datos en la tabla de refacciones 2");
                    return false;
                }
            }
            return true;
        }
        private bool validarDatosRefacciones(DataGridView tablaDatos) 
        {
            bool estado = true;
            
            for (int i = 0; i < tablaDatos.Rows.Count -1;i++)
            {
                for (int j = 0; j < tablaDatos.ColumnCount; j++) 
                {
                    
                    if(String.IsNullOrEmpty(tablaDatos.Rows[i].Cells[j].Value as string))
                    {
                        estado = false;
                    }
                }
            }
            return estado;
        }

        private bool validarDatos() 
        {
            foreach (Control control in panel1.Controls)
            {
                if (control is TextBox) 
                {
                    if (((TextBox)control).Text == "")
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private void FrmAgregarReportes_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            if (validarID()) 
                obtenerRegistroReport();
        }

        private bool validarID() 
        {
            int numero;
            bool estado = Int32.TryParse(txtID.Text.Trim(),out numero);
            if(String.Empty == txtID.Text.Trim())
            {
                MessageBox.Show("Campo sicipo vacio, por favor ingrese un sicipo para efectuar la busqueda", "Simael - Reportes",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return false;
            }else if(!estado)
            {
                MessageBox.Show("sicipo no válido, por favor ingrese un sicipo válido para efectuar la busqueda", "Simael - Reportes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (validarDatos())
            {
                if (validarRefacciones())
                    agregarDatosReporte();
            }
            else
            {
                MessageBox.Show("Existen campos sin datos, por favor ingrese datos para continuar", "Reportes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void eliminarFilaDgv(DataGridView dgv) 
        {
            foreach(DataGridViewRow row in dgv.SelectedRows)
            {
                if (row.Index != dataGridView1.Rows.Count - 1) 
                {
                    dgv.Rows.RemoveAt(row.Index);
                }
            }
        }
        private void radioSi_Click(object sender, EventArgs e)
        {
            radioSi.Checked = true;
            radioNo.Checked = false;
            reparacionEquipo = "Si";
        }

        private void radioNo_Click(object sender, EventArgs e)
        {
            radioNo.Checked = true;
            radioSi.Checked = false;
            reparacionEquipo = "No";
        }

        private void FrmAgregarReportes_Load_1(object sender, EventArgs e)
        {
            radioNo.Checked = true;
            reparacionEquipo = "No";
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete) 
            {
                eliminarFilaDgv(dataGridView1);
            }
        }

        private void dataGridView2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                eliminarFilaDgv(dataGridView2);
            }
        }

        private void txtID_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (validarID())
                    obtenerRegistroReport();
            }
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }
    }
}

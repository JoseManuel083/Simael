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
        private int estado;
        private DateTime fecha;
        private DataTable tabla;
        private SaveFileDialog fichero;
        private DataTable tablaPerifericos;
        private DataTable tablaPc;
        private DateTime fechaInicio;
        private DateTime fechaFinal;
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
            tabla =  objBD.buscarRegistroBit(param);
            dgvBitacora.DataSource = tabla;
        }
        // Llena el datagrid mostrando el historial de equipos registrados en la bitacora

        public void llenarTablaRegistros() 
        {
            objBD = new BaseDatoBit();
            tabla = new DataTable();
            tabla = objBD.obtenerRegistrosBit();
            dgvBitacora.DataSource = tabla;
            pintarColoresCeldasGrid();
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

        private void mostrarDatos() 
        {
            obtenerDatos();
            objEdit = new FrmEdicionRegistros(this, idBitacora, equipoTipo, folioUmar, sicipo, marca, modelo, noSerie, resguardante, area, problema, fecha,estado);
            objEdit.ShowDialog();
        }
        private void frmEditarElimBit_Load(object sender, EventArgs e)
        {
            ocultalMostrarProgressBar(false);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            pintarColoresCeldasGrid();
        }

        private void ocultalMostrarProgressBar(bool estado) 
        {
            if (estado)
            {
                lblProgreso.Visible = estado;
                progresoExcel.Visible = estado;
            }
            else 
            {
                lblProgreso.Visible = estado;
                progresoExcel.Visible = estado;
            }
            

        }

        //Este metodo pinta la primera columna del datagrid en su respectivo color
        private void pintarColoresCeldasGrid() 
        {
            for (int i = 0; i < dgvBitacora.Rows.Count; i++)
            {
                estado = Int32.Parse(tabla.Rows[i][11].ToString());

                if (estado == 0)
                {
                    dgvBitacora.Rows[i].Cells[0].Style.BackColor = Color.Yellow;
                }

                else 
                {
                    dgvBitacora.Rows[i].Cells[0].Style.BackColor = Color.Green;
                }

                dgvBitacora.Rows[i].Cells[0].Value = i + 1;
            }
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


        
        private void exportarDatosExcel() 
        {
            try
            {
                fichero = new SaveFileDialog();
                fichero.Filter = "Excel (*.xls)|*.xls";

                if (fichero.ShowDialog() == DialogResult.OK)
                {
                    backgroundWorker1.RunWorkerAsync();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Exportar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application aplicacion;
            Microsoft.Office.Interop.Excel.Workbook libroExcel;
            Microsoft.Office.Interop.Excel.Worksheet hojaExcel;
            aplicacion = new Microsoft.Office.Interop.Excel.Application();
            libroExcel = aplicacion.Workbooks.Add();
            hojaExcel = (Microsoft.Office.Interop.Excel.Worksheet)libroExcel.Worksheets.get_Item(1);

            int contador = 0;
            
            for (int i = 0; i < dgvBitacora.Rows.Count; i++)
            {
                for (int j = 2; j < dgvBitacora.Columns.Count-1; j++)
                {
                    hojaExcel.Cells[1, j] = dgvBitacora.Columns[j].HeaderText.ToString();
                    hojaExcel.Cells[i + 2, j] = dgvBitacora.Rows[i].Cells[j].Value.ToString();
                }

                contador = ((i + 1) * 100 / dgvBitacora.Rows.Count);
                backgroundWorker1.ReportProgress(contador);
            }

            libroExcel.SaveAs(fichero.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
            libroExcel.Close(true);
            aplicacion.Quit();
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            ocultalMostrarProgressBar(true);
            progresoExcel.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                MessageBox.Show("La exportacion de datos ha sido cancelada", "SIMAEL - Inventario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (e.Error != null)
            {
                MessageBox.Show("Ha ocurrido un error al guardar los datos", "SIMAEL - Inventario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Datos guardados correctamente", "SIMAEL - Inventario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ocultalMostrarProgressBar(false);
            }
        }

        private void picExcel_Click(object sender, EventArgs e)
        {
            //exportarDatosExcel();
           //separarDatosPCPerifericos();
        }

        private void picExcel_MouseEnter(object sender, EventArgs e)
        {
            picExcel.Width = picExcel.Width + 3;
            picExcel.Height = picExcel.Height + 3;
        }

        private void picExcel_MouseLeave(object sender, EventArgs e)
        {
            picExcel.Width = picExcel.Width - 3;
            picExcel.Height = picExcel.Height - 3;
        }

        //Boton para iniciar la busqueda avanzada
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (dtFechaFinal.Value <= dtFechaInicial.Value)
            {
                MessageBox.Show("La fecha de inicio debe ser menor que la fecha final", "Simael - Bitacora",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else 
            {
                iniciarBusquedaAvanzada();
            }
        }

        private void iniciarBusquedaAvanzada() 
        {
            objBD = new BaseDatoBit();
            DateTime hora = DateTime.Parse("6:00:00 am");
            fechaInicio = new DateTime(dtFechaInicial.Value.Year,dtFechaInicial.Value.Month,dtFechaInicial.Value.Day,
                                          hora.Hour,hora.Minute,hora.Second);
            fechaFinal = dtFechaFinal.Value;
            DataTable tb = new DataTable();
            tb = objBD.busquedaAvanzadaBitacora(fechaInicio, fechaFinal);
            
            if (tb.Rows.Count > 0)
            {
                dgvBitacora.DataSource = tb;
                pintarColoresCeldasGrid();
            }
            else 
            {
                MessageBox.Show("No se encontraron resultados para la busqueda", "Simael - Bitacora", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

     
    }
}

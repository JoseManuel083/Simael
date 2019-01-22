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
    public partial class Historial_bitacora : UserControl
    {
        private BaseDatoBit objBD;
        private Editar_registro_bitacora objEdit;
        private string equipoTipo;
        private string folioUmar;
        private string sicipo;
        private string marca;
        private string modelo;
        private string noSerie;
        private string resguardante;
        private string area;
        private string problema;
        private string solucion;
        private string idBitacora;
        private int estado;
        private DateTime fecha;
        private string fecha2;
        private DataTable tabla;
        private SaveFileDialog fichero;
        private DateTime fechaInicio;
        private DateTime fechaFinal;

        public Historial_bitacora()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            establecerConfDgv();
            //llenarTablaRegistros();
        }

        public Historial_bitacora(string param) 
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
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
            colSolucion.DataPropertyName = "solucion";
            colFecha.DataPropertyName = "fecha";
            colFecha2.DataPropertyName = "fecha2";
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
            solucion = dgvBitacora.CurrentRow.Cells[11].Value.ToString();
            fecha = Convert.ToDateTime(dgvBitacora.CurrentRow.Cells[12].Value.ToString());
            fecha2 = dgvBitacora.CurrentRow.Cells[13].Value.ToString();
            idBitacora = dgvBitacora.CurrentRow.Cells[14].Value.ToString();
        }

        private void mostrarDatos() 
        {
            obtenerDatos();
            objEdit = new Editar_registro_bitacora(this, idBitacora, equipoTipo, folioUmar, sicipo, marca, modelo, noSerie, resguardante, area, problema,solucion, fecha,fecha2,estado);
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
                estado = Int32.Parse(dgvBitacora.Rows[i].Cells[1].Value.ToString());

                if (estado == 0)
                {
                    dgvBitacora.Rows[i].Cells[0].Style.BackColor = Color.Yellow;
                }

                else if (estado == 1)
                {
                    dgvBitacora.Rows[i].Cells[0].Style.BackColor = Color.Green;
                }
                else 
                {
                    dgvBitacora.Rows[i].Cells[0].Style.BackColor = Color.Red;
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
            if (dgvBitacora.Rows.Count > 0)
            {
                exportarDatosExcel();
            }
            else 
            {
                MessageBox.Show("No hay datos para exportar", "SIMAEL - Inventario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
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
     
        private void lblEqSinRevisar_Click(object sender, EventArgs e)
        {
            tabla.DefaultView.RowFilter = string.Format("estado LIKE '%{0}%'", "0");
            dgvBitacora.DataSource = tabla;
            pintarColoresCeldasGrid();
        }

        private void lblEqRevisados_Click(object sender, EventArgs e)
        {
            tabla.DefaultView.RowFilter = string.Format("estado LIKE '%{0}%'", "1");
            dgvBitacora.DataSource = tabla;
            pintarColoresCeldasGrid();
        }

        private void lblEquiposBaja_Click(object sender, EventArgs e)
        {
            tabla.DefaultView.RowFilter = string.Format("estado LIKE '%{0}%'", "2");
            dgvBitacora.DataSource = tabla;
            pintarColoresCeldasGrid();
        }

        private void lblEqRevisados_MouseEnter(object sender, EventArgs e)
        {
            lblEqRevisados.Font = new Font("Microsoft Sans Serif", 11);
        }

        private void lblEqRevisados_MouseLeave(object sender, EventArgs e)
        {
            lblEqRevisados.Font = new Font("Microsoft Sans Serif", 10);
        }

        private void lblEqSinRevisar_MouseEnter(object sender, EventArgs e)
        {
            lblEqSinRevisar.Font = new Font("Microsoft Sans Serif", 11);
        }

        private void lblEqSinRevisar_MouseLeave(object sender, EventArgs e)
        {
            lblEqSinRevisar.Font = new Font("Microsoft Sans Serif", 10);
        }

        private void lblEquiposBaja_MouseEnter(object sender, EventArgs e)
        {
            lblEquiposBaja.Font = new Font("Microsoft Sans Serif", 11);
        }

        private void lblEquiposBaja_MouseLeave(object sender, EventArgs e)
        {
            lblEquiposBaja.Font = new Font("Microsoft Sans Serif", 10);
        }

    }
}

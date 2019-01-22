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
    public partial class Buscar_principal : UserControl
    {
        private BaseDatoBit objBD;
        private Editar_periferico objDet;
        private Editar_pc objDetPc;
        private SaveFileDialog fichero;
        public Buscar_principal()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            confDgvPerifericos();
        }

        private void obtenerRegistrosPerifericos() 
        {
            objBD = new BaseDatoBit();
            dgvPerifericos.DataSource = objBD.todoRegistrosPerifericos();
        }

        private void confDgvPerifericos() 
        {
            dgvPerifericos.AutoGenerateColumns = false;
            colSicipo.DataPropertyName = "ID";
            colCategoria.DataPropertyName = "categoria";
            colTipo.DataPropertyName = "tipo";
            colMarca.DataPropertyName = "marca";
            colModelo.DataPropertyName = "modelo";
            colNoSerie.DataPropertyName = "noserie";
            colColor.DataPropertyName = "color";
            colComposicion.DataPropertyName = "composicion";
            colEstadoFisico.DataPropertyName = "estadofisico";
            colPrecio.DataPropertyName = "precio";
            colResguardante.DataPropertyName = "resguardante";
            colInventario.DataPropertyName = "inventario";
            objBD = new BaseDatoBit();
        }

        private void obtenerEquipoInventario()
        {
            string sicipo = dgvPerifericos.CurrentRow.Cells[1].Value.ToString();
            objBD = new BaseDatoBit();
            
            List<String> equipo = objBD.obtenerEquipos(sicipo);
            if (equipo.Count == 13)
            {
                objDet = new Editar_periferico(equipo,this);
                objDet.ShowDialog();
            }
            else 
            {
                objDetPc = new Editar_pc(equipo,this);
                objDetPc.ShowDialog();
            }
        }

        //Obtiene los datos de un registro en especifico (del que el usuario elije) del datagrid una vez que se ejecutó una busqueda.
        //Los datos de este registro son enviados a un formulario para mostrarlo al usuario.
        private void obtenerDatosCelda() 
        {
            string sicipo = dgvPerifericos.CurrentRow.Cells[1].Value.ToString();
            string categoria = dgvPerifericos.CurrentRow.Cells[2].Value.ToString();
            string tipo = dgvPerifericos.CurrentRow.Cells[3].Value.ToString();
            string marca = dgvPerifericos.CurrentRow.Cells[4].Value.ToString();
            string modelo = dgvPerifericos.CurrentRow.Cells[5].Value.ToString();
            string noSerie = dgvPerifericos.CurrentRow.Cells[6].Value.ToString();
            string color = dgvPerifericos.CurrentRow.Cells[7].Value.ToString();
            string composicion = dgvPerifericos.CurrentRow.Cells[8].Value.ToString();
            string estadoFisico = dgvPerifericos.CurrentRow.Cells[9].Value.ToString();
            string precio = dgvPerifericos.CurrentRow.Cells[10].Value.ToString();
            string resguardante = dgvPerifericos.CurrentRow.Cells[11].Value.ToString();
            string inventario = dgvPerifericos.CurrentRow.Cells[12].Value.ToString();
            objDet.ShowDialog();
        }

        //Enumera los resultados de las busquedas, para facilitar el conteo de resultados devueltos por la consulta.
        private void enumerarResultadosBusqueda() 
        {
            for (int i = 0; i < dgvPerifericos.Rows.Count; i++)
            {
                dgvPerifericos.Rows[i].Cells[0].Value = i + 1;
            }
        }

        public void llenarDatagridPerifericos() 
        {
            dgvPerifericos.DataSource = objBD.registrosPerifericos(txtBusquedaP.Text.Trim());
            
            if (dgvPerifericos.Rows.Count > 0) 
            {
                enumerarResultadosBusqueda();   
            }
           
        }

        public void llenarGridBusquedaAvanzada(DataTable tabla) 
        {
            dgvPerifericos.DataSource = tabla;
            enumerarResultadosBusqueda();
            dgvPerifericos.Focus();
        }
      

        private void button1_Click(object sender, EventArgs e)
        {
            dgvPerifericos.DataSource = objBD.registrosPerifericos(txtBusquedaP.Text.Trim());
        }

        private void txtBusquedaP_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter) 
            //{
               // llenarDatagridPerifericos();
            //}
        }

        //Muestra los resultados de la busqueda en el datagridview
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            llenarDatagridPerifericos();
        }

        //Muestra los datos de la fila seleccionada del datagridview al hacer doble clic sobre el registro
        private void dgvPerifericos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPerifericos.Rows.Count > 0) 
            {
                obtenerEquipoInventario();
            }
        }

        //Muestra los datos de la fila seleccionada del datagridview al presionar la tecla enter
        private void dgvPerifericos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (dgvPerifericos.Rows.Count > 0)
                {
                    obtenerEquipoInventario();
                }
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (dgvPerifericos.Rows.Count > 0)
            {
                exportarDataGridExcel(dgvPerifericos);
            }
            else 
            {
                MessageBox.Show("No hay datos para exportar","Búsqueda",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void exportarDataGridExcel(DataGridView dgv) 
        {
            try 
            {
                fichero = new SaveFileDialog();
                fichero.Filter = "Excel (*.xls)|*.xls";

                if(fichero.ShowDialog() ==  DialogResult.OK)
                {
                    backgroundWorker1.RunWorkerAsync();
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(),"Exportar",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void FrmBuscar_Load(object sender, EventArgs e)
        {
            ocultarBarraDeProgreso(true);
        }

        private void picExcel_Click(object sender, EventArgs e)
        {
            if (dgvPerifericos.Rows.Count > 0)
            {
                exportarDataGridExcel(dgvPerifericos);
            }
            else
            {
                MessageBox.Show("No hay datos para exportar", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application aplicacion;
            Microsoft.Office.Interop.Excel.Workbook libroExcel;
            Microsoft.Office.Interop.Excel.Worksheet hojaExcel;
            aplicacion = new Microsoft.Office.Interop.Excel.Application();
            libroExcel = aplicacion.Workbooks.Add();
            hojaExcel = (Microsoft.Office.Interop.Excel.Worksheet)libroExcel.Worksheets.get_Item(1);

            int contador = 0;
            for (int i = 0; i < dgvPerifericos.Rows.Count; i++)
            {
                for (int j = 0; j < dgvPerifericos.Columns.Count; j++)
                {
                    hojaExcel.Cells[1, j + 1] = dgvPerifericos.Columns[j].HeaderText.ToString();
                    hojaExcel.Cells[i + 2, j + 1] = dgvPerifericos.Rows[i].Cells[j].Value.ToString();
                }

                contador = ((i + 1)*100/ dgvPerifericos.Rows.Count);
                backgroundWorker1.ReportProgress(contador);
            }
            
            libroExcel.SaveAs(fichero.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
            libroExcel.Close(true);
            aplicacion.Quit();
        }

        private void ocultarBarraDeProgreso(bool estado) 
        {
            if (estado)
            {
                lblProgreso.Visible = false;
                progresoExcel.Visible = false;
            }
            else 
            {
                lblProgreso.Visible = true;
                progresoExcel.Visible = true;
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            ocultarBarraDeProgreso(false);
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
                ocultarBarraDeProgreso(true);
            }
        }

        private void dgvPerifericos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtBusquedaP_KeyUp(object sender, KeyEventArgs e)
        {
            llenarDatagridPerifericos();
        }

    }
}

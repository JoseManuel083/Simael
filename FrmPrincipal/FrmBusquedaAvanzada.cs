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
namespace Simael
{
    public partial class FrmBusquedaAvanzada : Form
    {
        private BaseDatoBit objBD;
        private FrmBuscar objBuscar;
        private string categoria = "";
        private DataTable tabla;

        public FrmBusquedaAvanzada(FrmBuscar frm)
        {
            InitializeComponent();
            objBuscar = frm;
        }

        private void generarBusqueda() 
        {
            objBD = new BaseDatoBit();
            tabla = new DataTable();
            tabla = objBD.busquedaAvanzada(categoria,txtPalabra.Text.Trim());
            //MessageBox.Show(tabla.Rows.Count.ToString());
            objBuscar.llenarGridBusquedaAvanzada(tabla);
            objBuscar.Refresh();
            
        }
        private void manejoChecksBox(string check,string categoria) 
        {
            this.Controls.OfType<CheckBox>().ToList().ForEach(t => { if (t.Name != check)  t.Checked = false; });
            this.categoria = categoria;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmBusquedaAvanzada_Load(object sender, EventArgs e)
        {

        }

        private void checkResguardante_CheckedChanged(object sender, EventArgs e)
        {
            manejoChecksBox(checkResguardante.Name.ToString(),"resguardante");
        }

        private void checkCategoria_CheckedChanged(object sender, EventArgs e)
        {
            manejoChecksBox(checkCategoria.Name.ToString(),"categoria");
        }

        private void checkModelo_CheckedChanged(object sender, EventArgs e)
        {
            manejoChecksBox(checkModelo.Name.ToString(),"modelo");
        }

        private void checkMarca_CheckedChanged(object sender, EventArgs e)
        {
            manejoChecksBox(checkMarca.Name.ToString(),"marca");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string palabra = txtPalabra.Text.Trim();
            if (!categoria.Equals(string.Empty) && !palabra.Equals(string.Empty))
                generarBusqueda();
            else
                MessageBox.Show("Por favor seleccione una casilla y escriba una palabra");
        }

    }
}

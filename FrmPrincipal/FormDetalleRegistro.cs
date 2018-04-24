using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simael
{
    public partial class FormDetalleRegistro : Form
    {
        public FormDetalleRegistro(string sicipo,string categoria, string tipo,string marca,string modelo, string noserie,
            string color,string composicion,string estadofisico,string precio,string resguardante,string inventario)
        {
            InitializeComponent();
            txtSicipo.Text = sicipo;
            txtCategoria.Text = categoria;
            txtTipo.Text = tipo;
            txtMarca.Text = marca;
            txtModelo.Text = modelo;
            txtNoSerie.Text = noserie;
            txtColor.Text = color;
            txtComposicion.Text = composicion;
            txtEstadoFisico.Text = estadofisico;
            txtPrecio.Text = precio;
            txtResguardante.Text = resguardante;
            txtInventario.Text = inventario;
        }

        
        private void FormDetalleRegistro_Load(object sender, EventArgs e)
        {

        }
    }
}

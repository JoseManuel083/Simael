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
    public partial class FormDetalleRegistroPC : Form
    {
        public FormDetalleRegistroPC(List<string> equipo)
        {
            InitializeComponent();
            txtSicipo.Text = equipo.ElementAt(0).ToString();
            txtCategoria.Text = equipo.ElementAt(1).ToString();
            txtTipo.Text = equipo.ElementAt(2).ToString();
            txtMarca.Text = equipo.ElementAt(3).ToString();
            txtNoSerie.Text = equipo.ElementAt(4).ToString();
            txtModelo.Text = equipo.ElementAt(5).ToString();
            txtRam.Text = equipo.ElementAt(6).ToString();
            txtNoProcesadores.Text = equipo.ElementAt(7).ToString();
            txtTipoProcesador.Text = equipo.ElementAt(8).ToString();
            txtVelocidadProcesador.Text = equipo.ElementAt(9).ToString();
            txtNoHDD.Text = equipo.ElementAt(10).ToString();
            txtCapacidadHDD.Text = equipo.ElementAt(11).ToString();
            txtSO.Text = equipo.ElementAt(12).ToString();
            txtVersionSO.Text = equipo.ElementAt(13).ToString();
            txtEstadoFisico.Text = equipo.ElementAt(14).ToString();
            txtPrecio.Text = equipo.ElementAt(15).ToString();
            txtResguardante.Text = equipo.ElementAt(16).ToString();
            txtInventario.Text = equipo.ElementAt(17).ToString();
        }

        private void FormDetalleRegistroPC_Load(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

    }
}

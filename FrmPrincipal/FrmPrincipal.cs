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
  
    public partial class frmPrincipal : Form
    {
        private FrmBitacora objBit;
        private BaseDatoBit objBD;
        private FormReportes objReport;
        public frmPrincipal()
        {
            InitializeComponent();
            llenarGridEqiuposRecientes();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if(!panelPrincipal.Controls.Contains(objBit))
            {
                objBit = new FrmBitacora();
                panelPrincipal.Controls.Clear();
                panelPrincipal.Controls.Add(objBit);
            }
        }

        private void frmBitacora1_Load(object sender, EventArgs e)
        {

        }

        private void llenarGridEqiuposRecientes()
        {
            confGridEqRecientes();
            objBD = new BaseDatoBit();
            dgvEquiposRecientes.DataSource = objBD.ultimosRegistros();

        }
        private void confGridEqRecientes()
        {
            dgvEquiposRecientes.Columns["colFolio"].DataPropertyName = "folioumar";
            dgvEquiposRecientes.Columns["colSicipo"].DataPropertyName = "sicipo";
            dgvEquiposRecientes.Columns["colTipoEquipo"].DataPropertyName = "equipotipo";
            dgvEquiposRecientes.Columns["colMarca"].DataPropertyName = "marca";
            dgvEquiposRecientes.Columns["colModelo"].DataPropertyName = "modelo";
            dgvEquiposRecientes.Columns["colArea"].DataPropertyName = "area";
            dgvEquiposRecientes.Columns["colFecha"].DataPropertyName = "fecha";
        }
        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            picBInicio.Height = picBInicio.Height + 3;
            picBInicio.Width = picBInicio.Width + 3;
            lblInventario.Font = new Font("Microsoft Sans Serif", 12);
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            picBInicio.Height = picBInicio.Height -3;
            picBInicio.Width = picBInicio.Width -3;
            lblInventario.Font = new Font("Microsoft Sans Serif", 10);
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            picModuloReportes.Height = picModuloReportes.Height + 3;
            picModuloReportes.Width = picModuloReportes.Width + 3;
            lblReportes.Font = new Font("Microsoft Sans Serif", 12);
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            picModuloReportes.Height = picModuloReportes.Height - 3;
            picModuloReportes.Width = picModuloReportes.Width - 3;
            lblReportes.Font = new Font("Microsoft Sans Serif", 10);
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox3.Height = pictureBox3.Height + 3;
            pictureBox3.Width = pictureBox3.Width + 3;
            lblBitacora.Font = new Font("Microsoft Sans Serif", 12);
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Height = pictureBox3.Height - 3;
            pictureBox3.Width = pictureBox3.Width - 3;
            lblBitacora.Font = new Font("Microsoft Sans Serif", 10);
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            pictureBox4.Height = pictureBox4.Height + 3;
            pictureBox4.Width = pictureBox4.Width + 3;
            lblBajas.Font = new Font("Microsoft Sans Serif", 12);
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Height = pictureBox4.Height - 3;
            pictureBox4.Width = pictureBox4.Width - 3;
            lblBajas.Font = new Font("Microsoft Sans Serif", 10);
        }

        private void picBInicio_Click(object sender, EventArgs e)
        {
            panelPrincipal.Controls.Clear();
            llenarGridEqiuposRecientes();
            panelPrincipal.Controls.Add(panelSubPrincipal);
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picModuloReportes_Click(object sender, EventArgs e)
        {
            panelPrincipal.Controls.Clear();
            objReport = new FormReportes();
            panelPrincipal.Controls.Add(objReport);
        }
    }
}

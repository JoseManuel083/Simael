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
    public partial class frmPrincipal : Form
    {
        private Principal_bitacora objBitacora;
        private Menu_buscar objBuscar;
        private Menu_reportes objReporte;
        private Inicio objInicio;
        private ReporteBaja objBaja;
        public frmPrincipal()
        {
            InitializeComponent();
            click_inicio();
        }

        private void picBInicio_Click(object sender, EventArgs e)
        {
            click_inicio();
        }
        private void click_inicio() 
        {
            click_btn_inicio();
        }
        private void picModuloReportes_Click(object sender, EventArgs e)
        {
            click_btn_reportes();
        }
        private void picBitacora_Click(object sender, EventArgs e)
        {
            click_btn_bitacora();
        }
        private void picBuscar_Click(object sender, EventArgs e)
        {
            click_btn_buscar();
        }
        private void picBajas_Click(object sender, EventArgs e)
        {
            click_btn_bajas();
        }

        private void click_btn_inicio()
        {
            panelPrincipal.Controls.Clear();
            objInicio = new Inicio();
            panelPrincipal.Controls.Add(objInicio);
            lblEncabezado.Text = "INICIO";
        }
        private void click_btn_reportes()
        {
            panelPrincipal.Controls.Clear();
            objReporte = new Menu_reportes();
            panelPrincipal.Controls.Add(objReporte);
            lblEncabezado.Text = "REPORTES";
        }
        private void click_btn_buscar()
        {
            panelPrincipal.Controls.Clear();
            objBuscar = new Menu_buscar();
            panelPrincipal.Controls.Add(objBuscar);
            lblEncabezado.Text = "INVENTARIO";
        }
        private void click_btn_bitacora()
        {
            panelPrincipal.Controls.Clear();
            objBitacora = new Principal_bitacora();
            panelPrincipal.Controls.Add(objBitacora);
            lblEncabezado.Text = "BITACORA";
        }

        private void click_btn_bajas() 
        {
            panelPrincipal.Controls.Clear();
            objBaja = new ReporteBaja();
            panelPrincipal.Controls.Add(objBaja);
            lblEncabezado.Text = "BAJAS";
        }

        private void picBInicio_MouseEnter(object sender, EventArgs e)
        {
            picBInicio.Width = picBInicio.Width + 5;
            picBInicio.Height = picBInicio.Height + 5;
            lblInicio.Font = new Font("Microsoft Sans Serif", 12);
        }

        private void picBInicio_MouseLeave(object sender, EventArgs e)
        {
            picBInicio.Width = picBInicio.Width - 5;
            picBInicio.Height = picBInicio.Height -5;
            lblInicio.Font = new Font("Microsoft Sans Serif", 10);
        }

        private void picBitacora_MouseEnter(object sender, EventArgs e)
        {
            picBitacora.Width = picBitacora.Width + 5;
            picBitacora.Height = picBitacora.Height + 5;
            lblBitacora.Font = new Font("Microsoft Sans Serif", 12);
        }

        private void picBitacora_MouseLeave(object sender, EventArgs e)
        {
            picBitacora.Width = picBitacora.Width - 5;
            picBitacora.Height = picBitacora.Height - 5;
            lblBitacora.Font = new Font("Microsoft Sans Serif", 10);
        }

        private void picBuscar_MouseEnter(object sender, EventArgs e)
        {
            picBuscar.Width = picBuscar.Width + 5;
            picBuscar.Height = picBuscar.Height + 5;
            lblBuscar.Font = new Font("Microsoft Sans Serif", 12);
        }

        private void picBuscar_MouseLeave(object sender, EventArgs e)
        {
            picBuscar.Width = picBuscar.Width - 5;
            picBuscar.Height = picBuscar.Height - 5;
            lblBuscar.Font = new Font("Microsoft Sans Serif", 10);
        }

        private void picModuloReportes_MouseEnter(object sender, EventArgs e)
        {
            picModuloReportes.Width = picModuloReportes.Width + 5;
            picModuloReportes.Height = picModuloReportes.Height + 5;
            lblReportes.Font = new Font("Microsoft Sans Serif", 12);
        }

        private void picModuloReportes_MouseLeave(object sender, EventArgs e)
        {
            picModuloReportes.Width = picModuloReportes.Width - 5;
            picModuloReportes.Height = picModuloReportes.Height - 5;
            lblReportes.Font = new Font("Microsoft Sans Serif", 10);
        }

        private void picBajas_MouseEnter(object sender, EventArgs e)
        {
            picBajas.Height = picBajas.Height + 5;
            picBajas.Width = picBajas.Width + 5;
        }

        private void picBajas_MouseLeave(object sender, EventArgs e)
        {
            picBajas.Height = picBajas.Height - 5;
            picBajas.Width = picBajas.Width - 5;
        }

        private void lblInicio_Click(object sender, EventArgs e)
        {
            click_btn_inicio();
        }

        private void lblBitacora_Click(object sender, EventArgs e)
        {
            click_btn_bitacora();
        }

        private void lblBuscar_Click(object sender, EventArgs e)
        {
            click_btn_buscar();
        }

        private void lblReportes_Click(object sender, EventArgs e)
        {
            click_btn_reportes();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void lblBajas_Click(object sender, EventArgs e)
        {
            click_btn_bajas();
        }


    }
}

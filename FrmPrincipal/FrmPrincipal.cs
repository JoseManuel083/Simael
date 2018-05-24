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
    /*
       * Autor: Jose Manuel Gomez Alavez
       * Fecha: 20 Enero 2018
       * Descripcion: Formulario principal de SIMAEL, desde este form se mandan a llamar a los controles de usuarios correspondientes
       */
    public partial class frmPrincipal : Form
    {
        private FrmBitacora objBit;
        private FrmMenuReportes objReport;
        private FrmBuscar objBuscar;
        private FrmMenuBuscar objBusc;
        private FrmInicio objInicio;
        public frmPrincipal()
        {
            InitializeComponent();
            panelInicioClick();
        }

        private void picBInicio_Click(object sender, EventArgs e)
        {
            panelInicioClick();
        }


        private void picBitacora_Click(object sender, EventArgs e)
        {
            panelBitacoraClick();
        }

        private void picModuloReportes_Click(object sender, EventArgs e)
        {
            panelReporteClick();
        }

        private void picBuscar_Click(object sender, EventArgs e)
        {
            panelBuscarClick();
        }

        private void frmBitacora1_Load(object sender, EventArgs e)
        {

        }

       
        private void picBInicio_MouseEnter(object sender, EventArgs e)
        {
            picBInicio.Height = picBInicio.Height + 3;
            picBInicio.Width = picBInicio.Width + 3;
            lblInicio.Font = new Font("Microsoft Sans Serif", 12);
        }

        private void picBInicio_MouseLeave(object sender, EventArgs e)
        {
            picBInicio.Height = picBInicio.Height -3;
            picBInicio.Width = picBInicio.Width -3;
            lblInicio.Font = new Font("Microsoft Sans Serif", 10);
        }

        private void picModuloReportes_MouseEnter(object sender, EventArgs e)
        {
            picModuloReportes.Height = picModuloReportes.Height + 3;
            picModuloReportes.Width = picModuloReportes.Width + 3;
            lblReportes.Font = new Font("Microsoft Sans Serif", 12);
        }

        private void picModuloReportes_MouseLeave(object sender, EventArgs e)
        {
            picModuloReportes.Height = picModuloReportes.Height - 3;
            picModuloReportes.Width = picModuloReportes.Width - 3;
            lblReportes.Font = new Font("Microsoft Sans Serif", 10);
        }

        private void picBitacora_MouseEnter(object sender, EventArgs e)
        {
            picBitacora.Height = picBitacora.Height + 3;
            picBitacora.Width = picBitacora.Width + 3;
            lblBitacora.Font = new Font("Microsoft Sans Serif", 12);
        }

        private void picBitacora_MouseLeave(object sender, EventArgs e)
        {
            picBitacora.Height = picBitacora.Height - 3;
            picBitacora.Width = picBitacora.Width - 3;
            lblBitacora.Font = new Font("Microsoft Sans Serif", 10);
        }

        private void picBuscar_MouseEnter(object sender, EventArgs e)
        {
            picBuscar.Height = picBuscar.Height + 3;
            picBuscar.Width = picBuscar.Width + 3;
            lblBuscar.Font = new Font("Microsoft Sans Serif", 12);
        }

        private void picBuscar_MouseLeave(object sender, EventArgs e)
        {
            picBuscar.Height = picBuscar.Height - 3;
            picBuscar.Width = picBuscar.Width - 3;
            lblBuscar.Font = new Font("Microsoft Sans Serif", 10);
        }

      

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelInicioClick()
        {
            panelPrincipal.Controls.Clear();
            objInicio = new FrmInicio();
            panelPrincipal.Controls.Add(objInicio);
            panelPrincipal.AutoScroll = false;
        }
        private void panelBitacoraClick()
        {
            if (!panelPrincipal.Controls.Contains(objBit))
            {
                objBit = new FrmBitacora();
                panelPrincipal.Controls.Clear();
                panelPrincipal.Controls.Add(objBit);
                panelPrincipal.AutoScroll = false;
            }
        }

        private void panelReporteClick() 
        {
            panelPrincipal.Controls.Clear();
            objReport = new FrmMenuReportes();
            panelPrincipal.Controls.Add(objReport);
        }

        private void panelBuscarClick() 
        {
            panelPrincipal.Controls.Clear();
            objBusc = new FrmMenuBuscar();
            panelPrincipal.Controls.Add(objBusc);
            panelPrincipal.AutoScroll = false;
        }
        private void lblInicio_Click(object sender, EventArgs e)
        {
            panelInicioClick();
        }

        private void lblReportes_Click(object sender, EventArgs e)
        {
            panelReporteClick();
        }

        private void lblBitacora_Click(object sender, EventArgs e)
        {
            panelBitacoraClick();
        }

        private void lblBuscar_Click(object sender, EventArgs e)
        {
            panelBuscarClick();
        }


    }
}

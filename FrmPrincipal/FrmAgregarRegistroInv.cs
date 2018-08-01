using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simael
{
    public partial class FrmAgregarRegistroInv : UserControl
    {
        private FrmAgregarPerifericoInventario objPeriferico;
        private FrmAgregarComputadora objComp;
        public FrmAgregarRegistroInv()
        {
            InitializeComponent();
        }

        private void FrmAgregarRegistroInv_Load(object sender, EventArgs e)
        {
        }

        private void removerFormularios() 
        {
            if (panelRegistroInventario.Controls.Contains(objPeriferico))
            {
                panelRegistroInventario.Controls.Remove(objPeriferico);

            }
            else if (panelRegistroInventario.Controls.Contains(objComp))
            {
                panelRegistroInventario.Controls.Remove(objComp);
            }
        }

        private void checkComputadora_CheckedChanged(object sender, EventArgs e)
        {
            if (checkComputadora.Checked) 
            {
                mostrarFormularioComputadora();
            }
        }

        private void mostrarFormularioComputadora() 
        {
            checkPeriferico.Checked = false;
            objComp = new FrmAgregarComputadora();
            removerFormularios();
            panelRegistroInventario.Controls.Add(objComp);
        }
        private void checkPeriferico_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPeriferico.Checked)
            {
                checkComputadora.Checked = false;
                objPeriferico = new FrmAgregarPerifericoInventario();
                removerFormularios();
                panelRegistroInventario.Controls.Add(objPeriferico);
            }
        }

        private void panelRegistroInventario_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}

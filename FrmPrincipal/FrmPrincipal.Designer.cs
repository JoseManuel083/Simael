namespace Simael
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.respaldosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.respaldarBDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaurarBDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bitacoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoRegistroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblInventario = new System.Windows.Forms.Label();
            this.lblReportes = new System.Windows.Forms.Label();
            this.lblBitacora = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblBajas = new System.Windows.Forms.Label();
            this.picBInicio = new System.Windows.Forms.PictureBox();
            this.picModuloReportes = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.panelSubPrincipal = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBInicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picModuloReportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.respaldosToolStripMenuItem,
            this.bitacoraToolStripMenuItem,
            this.ayudaToolStripMenuItem,
            this.salirToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1351, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(75, 25);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(126, 26);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(126, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(84, 25);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // respaldosToolStripMenuItem
            // 
            this.respaldosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.respaldarBDToolStripMenuItem,
            this.restaurarBDToolStripMenuItem});
            this.respaldosToolStripMenuItem.Image = global::Simael.Properties.Resources.backup;
            this.respaldosToolStripMenuItem.Name = "respaldosToolStripMenuItem";
            this.respaldosToolStripMenuItem.Size = new System.Drawing.Size(109, 25);
            this.respaldosToolStripMenuItem.Text = "Respaldos";
            // 
            // respaldarBDToolStripMenuItem
            // 
            this.respaldarBDToolStripMenuItem.Image = global::Simael.Properties.Resources.Blue_Backup;
            this.respaldarBDToolStripMenuItem.Name = "respaldarBDToolStripMenuItem";
            this.respaldarBDToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.respaldarBDToolStripMenuItem.Text = "Respaldar información";
            // 
            // restaurarBDToolStripMenuItem
            // 
            this.restaurarBDToolStripMenuItem.Name = "restaurarBDToolStripMenuItem";
            this.restaurarBDToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.restaurarBDToolStripMenuItem.Text = "Restaurar información";
            // 
            // bitacoraToolStripMenuItem
            // 
            this.bitacoraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoRegistroToolStripMenuItem,
            this.editarToolStripMenuItem});
            this.bitacoraToolStripMenuItem.Name = "bitacoraToolStripMenuItem";
            this.bitacoraToolStripMenuItem.Size = new System.Drawing.Size(78, 25);
            this.bitacoraToolStripMenuItem.Text = "Bitacora";
            // 
            // nuevoRegistroToolStripMenuItem
            // 
            this.nuevoRegistroToolStripMenuItem.Name = "nuevoRegistroToolStripMenuItem";
            this.nuevoRegistroToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.nuevoRegistroToolStripMenuItem.Text = "Nuevo registro";
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Image = global::Simael.Properties.Resources.help;
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(82, 25);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // salirToolStripMenuItem1
            // 
            this.salirToolStripMenuItem1.Image = global::Simael.Properties.Resources.eliminar;
            this.salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            this.salirToolStripMenuItem1.Size = new System.Drawing.Size(69, 25);
            this.salirToolStripMenuItem1.Text = "Salir";
            this.salirToolStripMenuItem1.Click += new System.EventHandler(this.salirToolStripMenuItem1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(168, 28);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(41, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Módulos";
            // 
            // lblInventario
            // 
            this.lblInventario.AutoSize = true;
            this.lblInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventario.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblInventario.Location = new System.Drawing.Point(77, 58);
            this.lblInventario.Name = "lblInventario";
            this.lblInventario.Size = new System.Drawing.Size(42, 18);
            this.lblInventario.TabIndex = 0;
            this.lblInventario.Text = "Inicio";
            // 
            // lblReportes
            // 
            this.lblReportes.AutoSize = true;
            this.lblReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportes.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblReportes.Location = new System.Drawing.Point(77, 157);
            this.lblReportes.Name = "lblReportes";
            this.lblReportes.Size = new System.Drawing.Size(69, 18);
            this.lblReportes.TabIndex = 1;
            this.lblReportes.Text = "Reportes";
            // 
            // lblBitacora
            // 
            this.lblBitacora.AutoSize = true;
            this.lblBitacora.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBitacora.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblBitacora.Location = new System.Drawing.Point(79, 253);
            this.lblBitacora.Name = "lblBitacora";
            this.lblBitacora.Size = new System.Drawing.Size(63, 18);
            this.lblBitacora.TabIndex = 2;
            this.lblBitacora.Text = "Bitacora";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label6.Location = new System.Drawing.Point(77, 453);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 18);
            this.label6.TabIndex = 4;
            this.label6.Text = "Pendientes";
            // 
            // lblBajas
            // 
            this.lblBajas.AutoSize = true;
            this.lblBajas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBajas.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblBajas.Location = new System.Drawing.Point(77, 355);
            this.lblBajas.Name = "lblBajas";
            this.lblBajas.Size = new System.Drawing.Size(55, 18);
            this.lblBajas.TabIndex = 5;
            this.lblBajas.Text = "Buscar";
            // 
            // picBInicio
            // 
            this.picBInicio.Image = global::Simael.Properties.Resources.home;
            this.picBInicio.Location = new System.Drawing.Point(12, 37);
            this.picBInicio.Name = "picBInicio";
            this.picBInicio.Size = new System.Drawing.Size(59, 54);
            this.picBInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBInicio.TabIndex = 0;
            this.picBInicio.TabStop = false;
            this.picBInicio.Click += new System.EventHandler(this.picBInicio_Click);
            this.picBInicio.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.picBInicio.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // picModuloReportes
            // 
            this.picModuloReportes.Image = global::Simael.Properties.Resources.Report;
            this.picModuloReportes.Location = new System.Drawing.Point(12, 134);
            this.picModuloReportes.Name = "picModuloReportes";
            this.picModuloReportes.Size = new System.Drawing.Size(59, 50);
            this.picModuloReportes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picModuloReportes.TabIndex = 6;
            this.picModuloReportes.TabStop = false;
            this.picModuloReportes.Click += new System.EventHandler(this.picModuloReportes_Click);
            this.picModuloReportes.MouseEnter += new System.EventHandler(this.pictureBox2_MouseEnter);
            this.picModuloReportes.MouseLeave += new System.EventHandler(this.pictureBox2_MouseLeave);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Simael.Properties.Resources.repair_pc_icon;
            this.pictureBox3.Location = new System.Drawing.Point(3, 232);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(71, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            this.pictureBox3.MouseEnter += new System.EventHandler(this.pictureBox3_MouseEnter);
            this.pictureBox3.MouseLeave += new System.EventHandler(this.pictureBox3_MouseLeave);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Simael.Properties.Resources.buscar;
            this.pictureBox4.Location = new System.Drawing.Point(12, 339);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(59, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            this.pictureBox4.MouseEnter += new System.EventHandler(this.pictureBox4_MouseEnter);
            this.pictureBox4.MouseLeave += new System.EventHandler(this.pictureBox4_MouseLeave);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Simael.Properties.Resources.pendiente;
            this.pictureBox5.Location = new System.Drawing.Point(12, 436);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(59, 50);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 9;
            this.pictureBox5.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.picModuloReportes);
            this.panel1.Controls.Add(this.picBInicio);
            this.panel1.Controls.Add(this.lblBajas);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lblBitacora);
            this.panel1.Controls.Add(this.lblReportes);
            this.panel1.Controls.Add(this.lblInventario);
            this.panel1.Location = new System.Drawing.Point(0, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(168, 661);
            this.panel1.TabIndex = 1;
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPrincipal.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelPrincipal.Controls.Add(this.panelSubPrincipal);
            this.panelPrincipal.Location = new System.Drawing.Point(168, 29);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(1183, 689);
            this.panelPrincipal.TabIndex = 3;
            this.panelPrincipal.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPrincipal_Paint);
            // 
            // panelSubPrincipal
            // 
            this.panelSubPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSubPrincipal.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelSubPrincipal.Location = new System.Drawing.Point(18, 16);
            this.panelSubPrincipal.Name = "panelSubPrincipal";
            this.panelSubPrincipal.Size = new System.Drawing.Size(1143, 646);
            this.panelSubPrincipal.TabIndex = 3;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1351, 720);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SIMAEL";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBInicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picModuloReportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelPrincipal.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem respaldosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem respaldarBDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restaurarBDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bitacoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoRegistroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblInventario;
        private System.Windows.Forms.Label lblReportes;
        private System.Windows.Forms.Label lblBitacora;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblBajas;
        private System.Windows.Forms.PictureBox picBInicio;
        private System.Windows.Forms.PictureBox picModuloReportes;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Panel panelSubPrincipal;

    }
}


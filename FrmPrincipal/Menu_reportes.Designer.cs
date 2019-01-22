namespace Simael
{
    partial class Menu_reportes
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nuevoReporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMenuReporte = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(107)))), ((int)(((byte)(152)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoReporteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1181, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nuevoReporteToolStripMenuItem
            // 
            this.nuevoReporteToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuevoReporteToolStripMenuItem.Image = global::Simael.Properties.Resources.add;
            this.nuevoReporteToolStripMenuItem.Name = "nuevoReporteToolStripMenuItem";
            this.nuevoReporteToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
            this.nuevoReporteToolStripMenuItem.Text = "Nuevo Reporte";
            this.nuevoReporteToolStripMenuItem.Click += new System.EventHandler(this.nuevoReporteToolStripMenuItem_Click);
            // 
            // panelMenuReporte
            // 
            this.panelMenuReporte.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMenuReporte.Location = new System.Drawing.Point(0, 51);
            this.panelMenuReporte.Name = "panelMenuReporte";
            this.panelMenuReporte.Size = new System.Drawing.Size(1178, 629);
            this.panelMenuReporte.TabIndex = 1;
            this.panelMenuReporte.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenuReporte_Paint);
            // 
            // Menu_reportes
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.panelMenuReporte);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Menu_reportes";
            this.Size = new System.Drawing.Size(1181, 683);
            this.Load += new System.EventHandler(this.FrmMenuReportes_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nuevoReporteToolStripMenuItem;
        private System.Windows.Forms.Panel panelMenuReporte;
    }
}

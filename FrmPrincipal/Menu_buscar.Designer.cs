namespace Simael
{
    partial class Menu_buscar
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
            this.nuevoRegistroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.busquedaPersonalizadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelBusqueda = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(107)))), ((int)(((byte)(152)))));
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoRegistroToolStripMenuItem,
            this.busquedaPersonalizadaToolStripMenuItem,
            this.buscarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1172, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // nuevoRegistroToolStripMenuItem
            // 
            this.nuevoRegistroToolStripMenuItem.Image = global::Simael.Properties.Resources.add;
            this.nuevoRegistroToolStripMenuItem.Name = "nuevoRegistroToolStripMenuItem";
            this.nuevoRegistroToolStripMenuItem.Size = new System.Drawing.Size(146, 24);
            this.nuevoRegistroToolStripMenuItem.Text = "Nuevo Registro";
            this.nuevoRegistroToolStripMenuItem.Click += new System.EventHandler(this.nuevoRegistroToolStripMenuItem_Click);
            // 
            // busquedaPersonalizadaToolStripMenuItem
            // 
            this.busquedaPersonalizadaToolStripMenuItem.Image = global::Simael.Properties.Resources.tools;
            this.busquedaPersonalizadaToolStripMenuItem.Name = "busquedaPersonalizadaToolStripMenuItem";
            this.busquedaPersonalizadaToolStripMenuItem.Size = new System.Drawing.Size(206, 24);
            this.busquedaPersonalizadaToolStripMenuItem.Text = "Busqueda personalizada";
            this.busquedaPersonalizadaToolStripMenuItem.Click += new System.EventHandler(this.busquedaPersonalizadaToolStripMenuItem_Click);
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.Image = global::Simael.Properties.Resources.inventario3;
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            this.buscarToolStripMenuItem.Text = "Inventario";
            this.buscarToolStripMenuItem.Click += new System.EventHandler(this.buscarToolStripMenuItem_Click);
            // 
            // panelBusqueda
            // 
            this.panelBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBusqueda.AutoSize = true;
            this.panelBusqueda.Location = new System.Drawing.Point(3, 46);
            this.panelBusqueda.Name = "panelBusqueda";
            this.panelBusqueda.Size = new System.Drawing.Size(1169, 634);
            this.panelBusqueda.TabIndex = 1;
            this.panelBusqueda.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBusqueda_Paint);
            // 
            // Menu_buscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelBusqueda);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Menu_buscar";
            this.Size = new System.Drawing.Size(1172, 683);
            this.Load += new System.EventHandler(this.FrmBusqueda_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmBusqueda_KeyDown);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.FrmBusqueda_PreviewKeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nuevoRegistroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem busquedaPersonalizadaToolStripMenuItem;
        private System.Windows.Forms.Panel panelBusqueda;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
    }
}

namespace Simael
{
    partial class FrmAgregarRegistroInv
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
            this.gBoxEquipo = new System.Windows.Forms.GroupBox();
            this.checkPeriferico = new System.Windows.Forms.CheckBox();
            this.checkComputadora = new System.Windows.Forms.CheckBox();
            this.panelRegistroInventario = new System.Windows.Forms.Panel();
            this.gBoxEquipo.SuspendLayout();
            this.panelRegistroInventario.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBoxEquipo
            // 
            this.gBoxEquipo.Controls.Add(this.checkPeriferico);
            this.gBoxEquipo.Controls.Add(this.checkComputadora);
            this.gBoxEquipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxEquipo.Location = new System.Drawing.Point(399, 15);
            this.gBoxEquipo.Name = "gBoxEquipo";
            this.gBoxEquipo.Size = new System.Drawing.Size(392, 70);
            this.gBoxEquipo.TabIndex = 1;
            this.gBoxEquipo.TabStop = false;
            this.gBoxEquipo.Text = "Agregar equipo";
            // 
            // checkPeriferico
            // 
            this.checkPeriferico.AutoSize = true;
            this.checkPeriferico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkPeriferico.Location = new System.Drawing.Point(221, 28);
            this.checkPeriferico.Name = "checkPeriferico";
            this.checkPeriferico.Size = new System.Drawing.Size(84, 20);
            this.checkPeriferico.TabIndex = 3;
            this.checkPeriferico.Text = "Periferico";
            this.checkPeriferico.UseVisualStyleBackColor = true;
            this.checkPeriferico.CheckedChanged += new System.EventHandler(this.checkPeriferico_CheckedChanged);
            // 
            // checkComputadora
            // 
            this.checkComputadora.AutoSize = true;
            this.checkComputadora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkComputadora.Location = new System.Drawing.Point(71, 28);
            this.checkComputadora.Name = "checkComputadora";
            this.checkComputadora.Size = new System.Drawing.Size(109, 20);
            this.checkComputadora.TabIndex = 2;
            this.checkComputadora.Text = "Computadora";
            this.checkComputadora.UseVisualStyleBackColor = true;
            this.checkComputadora.CheckedChanged += new System.EventHandler(this.checkComputadora_CheckedChanged);
            // 
            // panelRegistroInventario
            // 
            this.panelRegistroInventario.AutoScroll = true;
            this.panelRegistroInventario.Controls.Add(this.gBoxEquipo);
            this.panelRegistroInventario.Location = new System.Drawing.Point(0, 3);
            this.panelRegistroInventario.Name = "panelRegistroInventario";
            this.panelRegistroInventario.Size = new System.Drawing.Size(1175, 635);
            this.panelRegistroInventario.TabIndex = 2;
            this.panelRegistroInventario.Paint += new System.Windows.Forms.PaintEventHandler(this.panelRegistroInventario_Paint);
            // 
            // FrmAgregarRegistroInv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelRegistroInventario);
            this.Name = "FrmAgregarRegistroInv";
            this.Size = new System.Drawing.Size(1178, 645);
            this.Load += new System.EventHandler(this.FrmAgregarRegistroInv_Load);
            this.gBoxEquipo.ResumeLayout(false);
            this.gBoxEquipo.PerformLayout();
            this.panelRegistroInventario.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxEquipo;
        private System.Windows.Forms.CheckBox checkPeriferico;
        private System.Windows.Forms.CheckBox checkComputadora;
        private System.Windows.Forms.Panel panelRegistroInventario;

    }
}

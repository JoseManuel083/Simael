namespace Simael
{
    partial class ReporteBaja
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvBaja = new System.Windows.Forms.DataGridView();
            this.colCheck = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSicipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFolio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNoSerie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colResguardante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProblema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSolucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.picBuscar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBaja
            // 
            this.dgvBaja.AllowUserToAddRows = false;
            this.dgvBaja.AllowUserToResizeRows = false;
            this.dgvBaja.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBaja.BackgroundColor = System.Drawing.Color.White;
            this.dgvBaja.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBaja.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvBaja.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(107)))), ((int)(((byte)(152)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBaja.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBaja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaja.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCheck,
            this.colSicipo,
            this.colFolio,
            this.colCategoria,
            this.colMarca,
            this.colModelo,
            this.colNoSerie,
            this.colResguardante,
            this.colArea,
            this.colProblema,
            this.colSolucion,
            this.colFechaIngreso});
            this.dgvBaja.EnableHeadersVisualStyles = false;
            this.dgvBaja.Location = new System.Drawing.Point(32, 79);
            this.dgvBaja.Name = "dgvBaja";
            this.dgvBaja.ReadOnly = true;
            this.dgvBaja.RowHeadersVisible = false;
            this.dgvBaja.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBaja.Size = new System.Drawing.Size(1321, 499);
            this.dgvBaja.TabIndex = 0;
            this.dgvBaja.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBaja_CellContentClick);
            this.dgvBaja.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBaja_CellDoubleClick);
            // 
            // colCheck
            // 
            this.colCheck.HeaderText = "";
            this.colCheck.Name = "colCheck";
            this.colCheck.ReadOnly = true;
            this.colCheck.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colCheck.Width = 50;
            // 
            // colSicipo
            // 
            this.colSicipo.HeaderText = "Sicipo";
            this.colSicipo.Name = "colSicipo";
            this.colSicipo.ReadOnly = true;
            // 
            // colFolio
            // 
            this.colFolio.HeaderText = "Folio";
            this.colFolio.Name = "colFolio";
            this.colFolio.ReadOnly = true;
            // 
            // colCategoria
            // 
            this.colCategoria.HeaderText = "Categoria";
            this.colCategoria.Name = "colCategoria";
            this.colCategoria.ReadOnly = true;
            // 
            // colMarca
            // 
            this.colMarca.HeaderText = "Marca";
            this.colMarca.Name = "colMarca";
            this.colMarca.ReadOnly = true;
            // 
            // colModelo
            // 
            this.colModelo.HeaderText = "Modelo";
            this.colModelo.Name = "colModelo";
            this.colModelo.ReadOnly = true;
            // 
            // colNoSerie
            // 
            this.colNoSerie.HeaderText = "No Serie";
            this.colNoSerie.Name = "colNoSerie";
            this.colNoSerie.ReadOnly = true;
            // 
            // colResguardante
            // 
            this.colResguardante.HeaderText = "Resguardante";
            this.colResguardante.Name = "colResguardante";
            this.colResguardante.ReadOnly = true;
            this.colResguardante.Width = 300;
            // 
            // colArea
            // 
            this.colArea.HeaderText = "Area";
            this.colArea.Name = "colArea";
            this.colArea.ReadOnly = true;
            this.colArea.Width = 250;
            // 
            // colProblema
            // 
            this.colProblema.HeaderText = "Problema";
            this.colProblema.Name = "colProblema";
            this.colProblema.ReadOnly = true;
            this.colProblema.Width = 250;
            // 
            // colSolucion
            // 
            this.colSolucion.HeaderText = "Solucion";
            this.colSolucion.Name = "colSolucion";
            this.colSolucion.ReadOnly = true;
            this.colSolucion.Width = 300;
            // 
            // colFechaIngreso
            // 
            this.colFechaIngreso.HeaderText = "Fecha de Ingreso";
            this.colFechaIngreso.Name = "colFechaIngreso";
            this.colFechaIngreso.ReadOnly = true;
            this.colFechaIngreso.Width = 150;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(642, 31);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(179, 22);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyDown);
            this.txtBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyUp);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(558, 32);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(50, 16);
            this.lblBuscar.TabIndex = 2;
            this.lblBuscar.Text = "Buscar";
            // 
            // picBuscar
            // 
            this.picBuscar.Image = global::Simael.Properties.Resources.buscar1;
            this.picBuscar.Location = new System.Drawing.Point(820, 31);
            this.picBuscar.Name = "picBuscar";
            this.picBuscar.Size = new System.Drawing.Size(34, 22);
            this.picBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBuscar.TabIndex = 3;
            this.picBuscar.TabStop = false;
            this.picBuscar.Click += new System.EventHandler(this.picBuscar_Click);
            // 
            // ReporteBaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.picBuscar);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.dgvBaja);
            this.Name = "ReporteBaja";
            this.Size = new System.Drawing.Size(1389, 615);
            this.Load += new System.EventHandler(this.ReporteBaja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBaja;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSicipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFolio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn colModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNoSerie;
        private System.Windows.Forms.DataGridViewTextBoxColumn colResguardante;
        private System.Windows.Forms.DataGridViewTextBoxColumn colArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProblema;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSolucion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaIngreso;
        private System.Windows.Forms.PictureBox picBuscar;
    }
}

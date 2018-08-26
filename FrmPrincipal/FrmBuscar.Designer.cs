namespace Simael
{
    partial class FrmBuscar
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBuscar));
            this.dgvPerifericos = new System.Windows.Forms.DataGridView();
            this.ColNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSicipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNoSerie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colComposicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstadoFisico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colResguardante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInventario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBusquedaP = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.picExcel = new System.Windows.Forms.PictureBox();
            this.progresoExcel = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblProgreso = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerifericos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExcel)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPerifericos
            // 
            this.dgvPerifericos.AllowUserToAddRows = false;
            this.dgvPerifericos.AllowUserToDeleteRows = false;
            this.dgvPerifericos.AllowUserToResizeRows = false;
            this.dgvPerifericos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPerifericos.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SpringGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPerifericos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPerifericos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPerifericos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColNumero,
            this.colSicipo,
            this.colCategoria,
            this.colTipo,
            this.colMarca,
            this.colModelo,
            this.colNoSerie,
            this.colColor,
            this.colComposicion,
            this.colEstadoFisico,
            this.colPrecio,
            this.colResguardante,
            this.colInventario});
            this.dgvPerifericos.EnableHeadersVisualStyles = false;
            this.dgvPerifericos.Location = new System.Drawing.Point(13, 99);
            this.dgvPerifericos.Name = "dgvPerifericos";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPerifericos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPerifericos.RowHeadersVisible = false;
            this.dgvPerifericos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPerifericos.Size = new System.Drawing.Size(1152, 514);
            this.dgvPerifericos.TabIndex = 0;
            this.dgvPerifericos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPerifericos_CellContentClick);
            this.dgvPerifericos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPerifericos_CellDoubleClick);
            this.dgvPerifericos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvPerifericos_KeyDown);
            // 
            // ColNumero
            // 
            this.ColNumero.HeaderText = "No";
            this.ColNumero.Name = "ColNumero";
            this.ColNumero.Width = 40;
            // 
            // colSicipo
            // 
            this.colSicipo.HeaderText = "Sicipo";
            this.colSicipo.Name = "colSicipo";
            // 
            // colCategoria
            // 
            this.colCategoria.HeaderText = "Categoria";
            this.colCategoria.Name = "colCategoria";
            // 
            // colTipo
            // 
            this.colTipo.HeaderText = "Tipo";
            this.colTipo.Name = "colTipo";
            // 
            // colMarca
            // 
            this.colMarca.HeaderText = "Marca";
            this.colMarca.Name = "colMarca";
            // 
            // colModelo
            // 
            this.colModelo.HeaderText = "Modelo";
            this.colModelo.Name = "colModelo";
            // 
            // colNoSerie
            // 
            this.colNoSerie.HeaderText = "No Serie";
            this.colNoSerie.Name = "colNoSerie";
            // 
            // colColor
            // 
            this.colColor.HeaderText = "Color";
            this.colColor.Name = "colColor";
            // 
            // colComposicion
            // 
            this.colComposicion.HeaderText = "Composicion";
            this.colComposicion.Name = "colComposicion";
            // 
            // colEstadoFisico
            // 
            this.colEstadoFisico.HeaderText = "Estado Fisico";
            this.colEstadoFisico.Name = "colEstadoFisico";
            this.colEstadoFisico.Width = 130;
            // 
            // colPrecio
            // 
            this.colPrecio.HeaderText = "Precio";
            this.colPrecio.Name = "colPrecio";
            // 
            // colResguardante
            // 
            this.colResguardante.HeaderText = "Resguardante";
            this.colResguardante.Name = "colResguardante";
            this.colResguardante.Width = 200;
            // 
            // colInventario
            // 
            this.colInventario.HeaderText = "Inventario";
            this.colInventario.Name = "colInventario";
            this.colInventario.Width = 450;
            // 
            // txtBusquedaP
            // 
            this.txtBusquedaP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBusquedaP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusquedaP.Location = new System.Drawing.Point(453, 44);
            this.txtBusquedaP.Name = "txtBusquedaP";
            this.txtBusquedaP.Size = new System.Drawing.Size(241, 26);
            this.txtBusquedaP.TabIndex = 1;
            this.txtBusquedaP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBusquedaP_KeyDown);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::Simael.Properties.Resources.buscar1;
            this.btnBuscar.Location = new System.Drawing.Point(694, 44);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(32, 26);
            this.btnBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.TabStop = false;
            this.btnBuscar.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "excel.png");
            // 
            // picExcel
            // 
            this.picExcel.Image = ((System.Drawing.Image)(resources.GetObject("picExcel.Image")));
            this.picExcel.Location = new System.Drawing.Point(1121, 53);
            this.picExcel.Name = "picExcel";
            this.picExcel.Size = new System.Drawing.Size(44, 40);
            this.picExcel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picExcel.TabIndex = 5;
            this.picExcel.TabStop = false;
            this.picExcel.Click += new System.EventHandler(this.picExcel_Click);
            this.picExcel.MouseEnter += new System.EventHandler(this.picExcel_MouseEnter);
            this.picExcel.MouseLeave += new System.EventHandler(this.picExcel_MouseLeave);
            // 
            // progresoExcel
            // 
            this.progresoExcel.Location = new System.Drawing.Point(964, 63);
            this.progresoExcel.Name = "progresoExcel";
            this.progresoExcel.Size = new System.Drawing.Size(151, 23);
            this.progresoExcel.TabIndex = 6;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // lblProgreso
            // 
            this.lblProgreso.AutoSize = true;
            this.lblProgreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgreso.Location = new System.Drawing.Point(892, 66);
            this.lblProgreso.Name = "lblProgreso";
            this.lblProgreso.Size = new System.Drawing.Size(57, 15);
            this.lblProgreso.TabIndex = 7;
            this.lblProgreso.Text = "Progreso";
            // 
            // FrmBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblProgreso);
            this.Controls.Add(this.progresoExcel);
            this.Controls.Add(this.picExcel);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBusquedaP);
            this.Controls.Add(this.dgvPerifericos);
            this.DoubleBuffered = true;
            this.Name = "FrmBuscar";
            this.Size = new System.Drawing.Size(1178, 680);
            this.Load += new System.EventHandler(this.FrmBuscar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerifericos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExcel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPerifericos;
        private System.Windows.Forms.TextBox txtBusquedaP;
        private System.Windows.Forms.PictureBox btnBuscar;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox picExcel;
        private System.Windows.Forms.ProgressBar progresoExcel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblProgreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSicipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn colModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNoSerie;
        private System.Windows.Forms.DataGridViewTextBoxColumn colColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colComposicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstadoFisico;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colResguardante;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInventario;
    }
}

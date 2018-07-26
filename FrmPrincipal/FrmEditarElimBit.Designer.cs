namespace Simael
{
    partial class FrmEditarElimBit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditarElimBit));
            this.dgvBitacora = new System.Windows.Forms.DataGridView();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEquipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFolio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSicipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNoSerie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colResguardante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProblema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdBitacora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.picExcel = new System.Windows.Forms.PictureBox();
            this.lblProgreso = new System.Windows.Forms.Label();
            this.progresoExcel = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gBoxBusqueda = new System.Windows.Forms.GroupBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblInicio = new System.Windows.Forms.Label();
            this.dtFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.dtFechaInicial = new System.Windows.Forms.DateTimePicker();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBitacora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExcel)).BeginInit();
            this.gBoxBusqueda.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBitacora
            // 
            this.dgvBitacora.AllowUserToAddRows = false;
            this.dgvBitacora.AllowUserToDeleteRows = false;
            this.dgvBitacora.AllowUserToResizeRows = false;
            this.dgvBitacora.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SpringGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBitacora.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBitacora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBitacora.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colEstado,
            this.colValEstado,
            this.colEquipo,
            this.colFolio,
            this.colSicipo,
            this.colMarca,
            this.colModelo,
            this.colNoSerie,
            this.colResguardante,
            this.colArea,
            this.colProblema,
            this.colFecha,
            this.colIdBitacora});
            this.dgvBitacora.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvBitacora.EnableHeadersVisualStyles = false;
            this.dgvBitacora.Location = new System.Drawing.Point(13, 116);
            this.dgvBitacora.Name = "dgvBitacora";
            this.dgvBitacora.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBitacora.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBitacora.RowHeadersVisible = false;
            this.dgvBitacora.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBitacora.Size = new System.Drawing.Size(1152, 506);
            this.dgvBitacora.TabIndex = 0;
            this.dgvBitacora.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBitacora_CellContentClick);
            this.dgvBitacora.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBitacora_CellDoubleClick);
            this.dgvBitacora.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvBitacora_KeyDown);
            // 
            // colEstado
            // 
            this.colEstado.HeaderText = "Es";
            this.colEstado.Name = "colEstado";
            this.colEstado.ReadOnly = true;
            this.colEstado.Width = 30;
            // 
            // colValEstado
            // 
            this.colValEstado.HeaderText = "Estado";
            this.colValEstado.Name = "colValEstado";
            this.colValEstado.ReadOnly = true;
            this.colValEstado.Visible = false;
            // 
            // colEquipo
            // 
            this.colEquipo.HeaderText = "Tipo Equipo";
            this.colEquipo.Name = "colEquipo";
            this.colEquipo.ReadOnly = true;
            this.colEquipo.Width = 140;
            // 
            // colFolio
            // 
            this.colFolio.HeaderText = "Folio UMAR";
            this.colFolio.Name = "colFolio";
            this.colFolio.ReadOnly = true;
            this.colFolio.Width = 110;
            // 
            // colSicipo
            // 
            this.colSicipo.HeaderText = "SICIPO";
            this.colSicipo.Name = "colSicipo";
            this.colSicipo.ReadOnly = true;
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
            // 
            // colArea
            // 
            this.colArea.HeaderText = "Area";
            this.colArea.Name = "colArea";
            this.colArea.ReadOnly = true;
            // 
            // colProblema
            // 
            this.colProblema.HeaderText = "Problema";
            this.colProblema.Name = "colProblema";
            this.colProblema.ReadOnly = true;
            this.colProblema.Width = 300;
            // 
            // colFecha
            // 
            this.colFecha.HeaderText = "Fecha";
            this.colFecha.Name = "colFecha";
            this.colFecha.ReadOnly = true;
            // 
            // colIdBitacora
            // 
            this.colIdBitacora.HeaderText = "ID Bitacora";
            this.colIdBitacora.Name = "colIdBitacora";
            this.colIdBitacora.ReadOnly = true;
            this.colIdBitacora.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LimeGreen;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(31, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(26, 22);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Yellow;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(30, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(26, 22);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Equipos revisados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Equipos sin revisar";
            // 
            // picExcel
            // 
            this.picExcel.Image = ((System.Drawing.Image)(resources.GetObject("picExcel.Image")));
            this.picExcel.Location = new System.Drawing.Point(1119, 67);
            this.picExcel.Name = "picExcel";
            this.picExcel.Size = new System.Drawing.Size(44, 40);
            this.picExcel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picExcel.TabIndex = 6;
            this.picExcel.TabStop = false;
            this.toolTip1.SetToolTip(this.picExcel, "Exportar registros a excel");
            this.picExcel.Click += new System.EventHandler(this.picExcel_Click);
            this.picExcel.MouseEnter += new System.EventHandler(this.picExcel_MouseEnter);
            this.picExcel.MouseLeave += new System.EventHandler(this.picExcel_MouseLeave);
            // 
            // lblProgreso
            // 
            this.lblProgreso.AutoSize = true;
            this.lblProgreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgreso.Location = new System.Drawing.Point(890, 78);
            this.lblProgreso.Name = "lblProgreso";
            this.lblProgreso.Size = new System.Drawing.Size(57, 15);
            this.lblProgreso.TabIndex = 9;
            this.lblProgreso.Text = "Progreso";
            // 
            // progresoExcel
            // 
            this.progresoExcel.Location = new System.Drawing.Point(962, 75);
            this.progresoExcel.Name = "progresoExcel";
            this.progresoExcel.Size = new System.Drawing.Size(151, 23);
            this.progresoExcel.TabIndex = 8;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // gBoxBusqueda
            // 
            this.gBoxBusqueda.Controls.Add(this.btnAceptar);
            this.gBoxBusqueda.Controls.Add(this.label3);
            this.gBoxBusqueda.Controls.Add(this.lblInicio);
            this.gBoxBusqueda.Controls.Add(this.dtFechaFinal);
            this.gBoxBusqueda.Controls.Add(this.dtFechaInicial);
            this.gBoxBusqueda.Location = new System.Drawing.Point(311, 13);
            this.gBoxBusqueda.Name = "gBoxBusqueda";
            this.gBoxBusqueda.Size = new System.Drawing.Size(526, 91);
            this.gBoxBusqueda.TabIndex = 10;
            this.gBoxBusqueda.TabStop = false;
            this.gBoxBusqueda.Text = "Busqueda avanzada";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(246, 62);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(277, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "a";
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Location = new System.Drawing.Point(21, 32);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(21, 13);
            this.lblInicio.TabIndex = 2;
            this.lblInicio.Text = "De";
            // 
            // dtFechaFinal
            // 
            this.dtFechaFinal.Location = new System.Drawing.Point(311, 26);
            this.dtFechaFinal.Name = "dtFechaFinal";
            this.dtFechaFinal.Size = new System.Drawing.Size(200, 20);
            this.dtFechaFinal.TabIndex = 1;
            // 
            // dtFechaInicial
            // 
            this.dtFechaInicial.Location = new System.Drawing.Point(62, 26);
            this.dtFechaInicial.Name = "dtFechaInicial";
            this.dtFechaInicial.Size = new System.Drawing.Size(200, 20);
            this.dtFechaInicial.TabIndex = 0;
            // 
            // FrmEditarElimBit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.gBoxBusqueda);
            this.Controls.Add(this.lblProgreso);
            this.Controls.Add(this.progresoExcel);
            this.Controls.Add(this.picExcel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvBitacora);
            this.Name = "FrmEditarElimBit";
            this.Size = new System.Drawing.Size(1178, 653);
            this.Load += new System.EventHandler(this.frmEditarElimBit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBitacora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExcel)).EndInit();
            this.gBoxBusqueda.ResumeLayout(false);
            this.gBoxBusqueda.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBitacora;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEquipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFolio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSicipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn colModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNoSerie;
        private System.Windows.Forms.DataGridViewTextBoxColumn colResguardante;
        private System.Windows.Forms.DataGridViewTextBoxColumn colArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProblema;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdBitacora;
        private System.Windows.Forms.PictureBox picExcel;
        private System.Windows.Forms.Label lblProgreso;
        private System.Windows.Forms.ProgressBar progresoExcel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox gBoxBusqueda;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.DateTimePicker dtFechaFinal;
        private System.Windows.Forms.DateTimePicker dtFechaInicial;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

namespace Simael
{
    partial class Historial_bitacora
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Historial_bitacora));
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
            this.colSolucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecha2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdBitacora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblEqRevisados = new System.Windows.Forms.Label();
            this.lblEqSinRevisar = new System.Windows.Forms.Label();
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
            this.picExcel = new System.Windows.Forms.PictureBox();
            this.lblEquiposBaja = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBitacora)).BeginInit();
            this.gBoxBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExcel)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBitacora
            // 
            this.dgvBitacora.AllowUserToAddRows = false;
            this.dgvBitacora.AllowUserToDeleteRows = false;
            this.dgvBitacora.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvBitacora.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBitacora.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBitacora.BackgroundColor = System.Drawing.Color.White;
            this.dgvBitacora.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBitacora.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvBitacora.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(107)))), ((int)(((byte)(152)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBitacora.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
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
            this.colSolucion,
            this.colFecha,
            this.colFecha2,
            this.colIdBitacora});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBitacora.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBitacora.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvBitacora.EnableHeadersVisualStyles = false;
            this.dgvBitacora.Location = new System.Drawing.Point(11, 120);
            this.dgvBitacora.Name = "dgvBitacora";
            this.dgvBitacora.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBitacora.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBitacora.RowHeadersVisible = false;
            this.dgvBitacora.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBitacora.Size = new System.Drawing.Size(1118, 459);
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
            this.colEquipo.HeaderText = "Tipo";
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
            this.colSicipo.HeaderText = "Sicipo";
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
            this.colResguardante.Width = 150;
            // 
            // colArea
            // 
            this.colArea.HeaderText = "Area";
            this.colArea.Name = "colArea";
            this.colArea.ReadOnly = true;
            this.colArea.Width = 200;
            // 
            // colProblema
            // 
            this.colProblema.HeaderText = "Problema";
            this.colProblema.Name = "colProblema";
            this.colProblema.ReadOnly = true;
            this.colProblema.Width = 300;
            // 
            // colSolucion
            // 
            this.colSolucion.HeaderText = "Solucion";
            this.colSolucion.Name = "colSolucion";
            this.colSolucion.ReadOnly = true;
            this.colSolucion.Width = 300;
            // 
            // colFecha
            // 
            this.colFecha.HeaderText = "Fecha de entrada";
            this.colFecha.Name = "colFecha";
            this.colFecha.ReadOnly = true;
            this.colFecha.Width = 150;
            // 
            // colFecha2
            // 
            this.colFecha2.HeaderText = "Fecha de Salida";
            this.colFecha2.Name = "colFecha2";
            this.colFecha2.ReadOnly = true;
            this.colFecha2.Visible = false;
            this.colFecha2.Width = 150;
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
            this.panel1.Location = new System.Drawing.Point(30, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(26, 22);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Yellow;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(29, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(26, 22);
            this.panel2.TabIndex = 2;
            // 
            // lblEqRevisados
            // 
            this.lblEqRevisados.AutoSize = true;
            this.lblEqRevisados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEqRevisados.Location = new System.Drawing.Point(62, 11);
            this.lblEqRevisados.Name = "lblEqRevisados";
            this.lblEqRevisados.Size = new System.Drawing.Size(121, 16);
            this.lblEqRevisados.TabIndex = 3;
            this.lblEqRevisados.Text = "Equipos revisados";
            this.lblEqRevisados.Click += new System.EventHandler(this.lblEqRevisados_Click);
            this.lblEqRevisados.MouseEnter += new System.EventHandler(this.lblEqRevisados_MouseEnter);
            this.lblEqRevisados.MouseLeave += new System.EventHandler(this.lblEqRevisados_MouseLeave);
            // 
            // lblEqSinRevisar
            // 
            this.lblEqSinRevisar.AutoSize = true;
            this.lblEqSinRevisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEqSinRevisar.Location = new System.Drawing.Point(62, 49);
            this.lblEqSinRevisar.Name = "lblEqSinRevisar";
            this.lblEqSinRevisar.Size = new System.Drawing.Size(122, 16);
            this.lblEqSinRevisar.TabIndex = 4;
            this.lblEqSinRevisar.Text = "Equipos sin revisar";
            this.lblEqSinRevisar.Click += new System.EventHandler(this.lblEqSinRevisar_Click);
            this.lblEqSinRevisar.MouseEnter += new System.EventHandler(this.lblEqSinRevisar_MouseEnter);
            this.lblEqSinRevisar.MouseLeave += new System.EventHandler(this.lblEqSinRevisar_MouseLeave);
            // 
            // lblProgreso
            // 
            this.lblProgreso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProgreso.AutoSize = true;
            this.lblProgreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgreso.Location = new System.Drawing.Point(869, 70);
            this.lblProgreso.Name = "lblProgreso";
            this.lblProgreso.Size = new System.Drawing.Size(57, 15);
            this.lblProgreso.TabIndex = 9;
            this.lblProgreso.Text = "Progreso";
            // 
            // progresoExcel
            // 
            this.progresoExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.progresoExcel.Location = new System.Drawing.Point(941, 67);
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
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(246, 54);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 31);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
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
            // picExcel
            // 
            this.picExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picExcel.Image = ((System.Drawing.Image)(resources.GetObject("picExcel.Image")));
            this.picExcel.Location = new System.Drawing.Point(1098, 59);
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
            // lblEquiposBaja
            // 
            this.lblEquiposBaja.AutoSize = true;
            this.lblEquiposBaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquiposBaja.Location = new System.Drawing.Point(62, 85);
            this.lblEquiposBaja.Name = "lblEquiposBaja";
            this.lblEquiposBaja.Size = new System.Drawing.Size(149, 16);
            this.lblEquiposBaja.TabIndex = 12;
            this.lblEquiposBaja.Text = "Equipos dados de baja";
            this.lblEquiposBaja.Click += new System.EventHandler(this.lblEquiposBaja_Click);
            this.lblEquiposBaja.MouseEnter += new System.EventHandler(this.lblEquiposBaja_MouseEnter);
            this.lblEquiposBaja.MouseLeave += new System.EventHandler(this.lblEquiposBaja_MouseLeave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Red;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(29, 80);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(26, 22);
            this.panel3.TabIndex = 11;
            // 
            // Historial_bitacora
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.lblEquiposBaja);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.gBoxBusqueda);
            this.Controls.Add(this.lblProgreso);
            this.Controls.Add(this.progresoExcel);
            this.Controls.Add(this.picExcel);
            this.Controls.Add(this.lblEqSinRevisar);
            this.Controls.Add(this.lblEqRevisados);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvBitacora);
            this.Name = "Historial_bitacora";
            this.Size = new System.Drawing.Size(1145, 592);
            this.Load += new System.EventHandler(this.frmEditarElimBit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBitacora)).EndInit();
            this.gBoxBusqueda.ResumeLayout(false);
            this.gBoxBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExcel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBitacora;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblEqRevisados;
        private System.Windows.Forms.Label lblEqSinRevisar;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn colSolucion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdBitacora;
        private System.Windows.Forms.Label lblEquiposBaja;
        private System.Windows.Forms.Panel panel3;
    }
}

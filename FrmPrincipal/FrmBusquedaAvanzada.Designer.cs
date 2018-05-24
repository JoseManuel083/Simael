namespace Simael
{
    partial class FrmBusquedaAvanzada
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkResguardante = new System.Windows.Forms.CheckBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtPalabra = new System.Windows.Forms.TextBox();
            this.checkCategoria = new System.Windows.Forms.CheckBox();
            this.checkMarca = new System.Windows.Forms.CheckBox();
            this.checkModelo = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // checkResguardante
            // 
            this.checkResguardante.AutoSize = true;
            this.checkResguardante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkResguardante.Location = new System.Drawing.Point(82, 12);
            this.checkResguardante.Name = "checkResguardante";
            this.checkResguardante.Size = new System.Drawing.Size(120, 20);
            this.checkResguardante.TabIndex = 0;
            this.checkResguardante.Text = "Resguardantes";
            this.checkResguardante.UseVisualStyleBackColor = true;
            this.checkResguardante.CheckedChanged += new System.EventHandler(this.checkResguardante_CheckedChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(214, 166);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(82, 23);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Palabra exacta";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(323, 166);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtPalabra
            // 
            this.txtPalabra.Location = new System.Drawing.Point(214, 104);
            this.txtPalabra.Name = "txtPalabra";
            this.txtPalabra.Size = new System.Drawing.Size(197, 20);
            this.txtPalabra.TabIndex = 4;
            // 
            // checkCategoria
            // 
            this.checkCategoria.AutoSize = true;
            this.checkCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkCategoria.Location = new System.Drawing.Point(281, 12);
            this.checkCategoria.Name = "checkCategoria";
            this.checkCategoria.Size = new System.Drawing.Size(86, 20);
            this.checkCategoria.TabIndex = 5;
            this.checkCategoria.Text = "Categoria";
            this.checkCategoria.UseVisualStyleBackColor = true;
            this.checkCategoria.CheckedChanged += new System.EventHandler(this.checkCategoria_CheckedChanged);
            // 
            // checkMarca
            // 
            this.checkMarca.AutoSize = true;
            this.checkMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkMarca.Location = new System.Drawing.Point(281, 54);
            this.checkMarca.Name = "checkMarca";
            this.checkMarca.Size = new System.Drawing.Size(65, 20);
            this.checkMarca.TabIndex = 7;
            this.checkMarca.Text = "Marca";
            this.checkMarca.UseVisualStyleBackColor = true;
            this.checkMarca.CheckedChanged += new System.EventHandler(this.checkMarca_CheckedChanged);
            // 
            // checkModelo
            // 
            this.checkModelo.AutoSize = true;
            this.checkModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkModelo.Location = new System.Drawing.Point(82, 54);
            this.checkModelo.Name = "checkModelo";
            this.checkModelo.Size = new System.Drawing.Size(73, 20);
            this.checkModelo.TabIndex = 6;
            this.checkModelo.Text = "Modelo";
            this.checkModelo.UseVisualStyleBackColor = true;
            this.checkModelo.CheckedChanged += new System.EventHandler(this.checkModelo_CheckedChanged);
            // 
            // FrmBusquedaAvanzada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(496, 200);
            this.Controls.Add(this.checkMarca);
            this.Controls.Add(this.checkModelo);
            this.Controls.Add(this.checkCategoria);
            this.Controls.Add(this.txtPalabra);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.checkResguardante);
            this.MaximizeBox = false;
            this.Name = "FrmBusquedaAvanzada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBusquedaAvanzada";
            this.Load += new System.EventHandler(this.FrmBusquedaAvanzada_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkResguardante;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtPalabra;
        private System.Windows.Forms.CheckBox checkCategoria;
        private System.Windows.Forms.CheckBox checkMarca;
        private System.Windows.Forms.CheckBox checkModelo;
    }
}
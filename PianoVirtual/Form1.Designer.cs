namespace PianoVirtual
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.BtnLibre = new System.Windows.Forms.Button();
            this.BtnNotas = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnLibre
            // 
            this.BtnLibre.BackColor = System.Drawing.SystemColors.InfoText;
            this.BtnLibre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLibre.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnLibre.FlatAppearance.BorderSize = 0;
            this.BtnLibre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLibre.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLibre.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnLibre.Location = new System.Drawing.Point(175, 381);
            this.BtnLibre.Name = "BtnLibre";
            this.BtnLibre.Size = new System.Drawing.Size(102, 57);
            this.BtnLibre.TabIndex = 0;
            this.BtnLibre.TabStop = false;
            this.BtnLibre.Text = "MODO LIBRE";
            this.BtnLibre.UseVisualStyleBackColor = false;
            this.BtnLibre.Click += new System.EventHandler(this.BtnLibre_Click);
            // 
            // BtnNotas
            // 
            this.BtnNotas.BackColor = System.Drawing.SystemColors.Window;
            this.BtnNotas.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNotas.Location = new System.Drawing.Point(324, 381);
            this.BtnNotas.Name = "BtnNotas";
            this.BtnNotas.Size = new System.Drawing.Size(107, 57);
            this.BtnNotas.TabIndex = 1;
            this.BtnNotas.TabStop = false;
            this.BtnNotas.Text = "MODO INTRODUCE NOTAS";
            this.BtnNotas.UseVisualStyleBackColor = false;
            this.BtnNotas.Click += new System.EventHandler(this.BtnNotas_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.SystemColors.WindowText;
            this.BtnSalir.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnSalir.Location = new System.Drawing.Point(470, 381);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(92, 57);
            this.BtnSalir.TabIndex = 2;
            this.BtnSalir.TabStop = false;
            this.BtnSalir.Text = "SALIR";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PianoVirtual.Properties.Resources.Fondo;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnNotas);
            this.Controls.Add(this.BtnLibre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PIANO VIRTUAL";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnLibre;
        private System.Windows.Forms.Button BtnNotas;
        private System.Windows.Forms.Button BtnSalir;
    }
}


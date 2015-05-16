namespace InventarioProduccion
{
    partial class PrincipalUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalUsuario));
            this.btnInformacion = new System.Windows.Forms.Button();
            this.btnAdministrador = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            this.btnCentroAyuda = new System.Windows.Forms.Button();
            this.btnSesion = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInformacion
            // 
            this.btnInformacion.Location = new System.Drawing.Point(426, 57);
            this.btnInformacion.Name = "btnInformacion";
            this.btnInformacion.Size = new System.Drawing.Size(75, 37);
            this.btnInformacion.TabIndex = 2;
            this.btnInformacion.Text = "Información del Personal";
            this.btnInformacion.UseVisualStyleBackColor = true;
            this.btnInformacion.Click += new System.EventHandler(this.btnInformacion_Click);
            // 
            // btnAdministrador
            // 
            this.btnAdministrador.Location = new System.Drawing.Point(60, 316);
            this.btnAdministrador.Name = "btnAdministrador";
            this.btnAdministrador.Size = new System.Drawing.Size(87, 47);
            this.btnAdministrador.TabIndex = 3;
            this.btnAdministrador.Text = "Administrador\r\nde Usuarios";
            this.btnAdministrador.UseVisualStyleBackColor = true;
            this.btnAdministrador.Click += new System.EventHandler(this.btnAdministrador_Click);
            // 
            // btnReporte
            // 
            this.btnReporte.Location = new System.Drawing.Point(60, 46);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(75, 39);
            this.btnReporte.TabIndex = 4;
            this.btnReporte.Text = "Reporte de Producción";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // btnCentroAyuda
            // 
            this.btnCentroAyuda.Location = new System.Drawing.Point(426, 316);
            this.btnCentroAyuda.Name = "btnCentroAyuda";
            this.btnCentroAyuda.Size = new System.Drawing.Size(75, 51);
            this.btnCentroAyuda.TabIndex = 6;
            this.btnCentroAyuda.Text = "Centro de Ayuda al Usuario";
            this.btnCentroAyuda.UseVisualStyleBackColor = true;
            this.btnCentroAyuda.Click += new System.EventHandler(this.btnCentroAyuda_Click);
            // 
            // btnSesion
            // 
            this.btnSesion.Location = new System.Drawing.Point(416, 12);
            this.btnSesion.Name = "btnSesion";
            this.btnSesion.Size = new System.Drawing.Size(102, 23);
            this.btnSesion.TabIndex = 7;
            this.btnSesion.Text = "Cerrar Sesión";
            this.btnSesion.UseVisualStyleBackColor = true;
            this.btnSesion.Click += new System.EventHandler(this.btnSesion_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(103, 91);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(279, 202);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // PrincipalUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(545, 411);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSesion);
            this.Controls.Add(this.btnCentroAyuda);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.btnAdministrador);
            this.Controls.Add(this.btnInformacion);
            this.Name = "PrincipalUsuario";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInformacion;
        private System.Windows.Forms.Button btnAdministrador;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Button btnCentroAyuda;
        private System.Windows.Forms.Button btnSesion;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
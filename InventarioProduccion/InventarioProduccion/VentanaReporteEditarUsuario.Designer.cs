namespace InventarioProduccion
{
    partial class VentanaReporteEditarUsuario
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
            this.btnSesio = new System.Windows.Forms.Button();
            this.txtColorU = new System.Windows.Forms.ComboBox();
            this.txtFechaU = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCalibreU = new System.Windows.Forms.ComboBox();
            this.txtMedidaU = new System.Windows.Forms.ComboBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.CBoxTurnoU = new System.Windows.Forms.ComboBox();
            this.CBoxTipoU = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtCantidadU = new System.Windows.Forms.TextBox();
            this.txtOperadorU = new System.Windows.Forms.TextBox();
            this.lblCalibre = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblMedida = new System.Windows.Forms.Label();
            this.lblOperador = new System.Windows.Forms.Label();
            this.lblTurno = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSesio
            // 
            this.btnSesio.Location = new System.Drawing.Point(496, 12);
            this.btnSesio.Name = "btnSesio";
            this.btnSesio.Size = new System.Drawing.Size(116, 23);
            this.btnSesio.TabIndex = 34;
            this.btnSesio.Text = "Cerrar Sesión";
            this.btnSesio.UseVisualStyleBackColor = true;
            this.btnSesio.Click += new System.EventHandler(this.btnSesio_Click);
            // 
            // txtColorU
            // 
            this.txtColorU.FormattingEnabled = true;
            this.txtColorU.Items.AddRange(new object[] {
            "AMARILLO",
            "AZUL",
            "BLACO",
            "CAFE",
            "MORADO",
            "NARANJA",
            "NATURAL",
            "NEGRO",
            "ROJO",
            "ROSA",
            "TINTO",
            "VERDE",
            "VIOLETA",
            ""});
            this.txtColorU.Location = new System.Drawing.Point(17, 122);
            this.txtColorU.Name = "txtColorU";
            this.txtColorU.Size = new System.Drawing.Size(167, 21);
            this.txtColorU.TabIndex = 58;
            this.txtColorU.SelectedIndexChanged += new System.EventHandler(this.txtColor_SelectedIndexChanged);
            // 
            // txtFechaU
            // 
            this.txtFechaU.Location = new System.Drawing.Point(215, 201);
            this.txtFechaU.Name = "txtFechaU";
            this.txtFechaU.Size = new System.Drawing.Size(200, 20);
            this.txtFechaU.TabIndex = 57;
            this.txtFechaU.Value = new System.DateTime(2015, 3, 16, 20, 55, 38, 0);
            this.txtFechaU.ValueChanged += new System.EventHandler(this.txtFecha_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 56;
            this.label1.Text = "Fecha";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtCalibreU
            // 
            this.txtCalibreU.FormattingEnabled = true;
            this.txtCalibreU.Items.AddRange(new object[] {
            "100",
            "150",
            "200",
            "250",
            "300",
            "350",
            "400",
            "450",
            "500",
            "550",
            "600",
            "650",
            "700",
            "750",
            "800",
            "850",
            "900",
            "950",
            "100"});
            this.txtCalibreU.Location = new System.Drawing.Point(418, 122);
            this.txtCalibreU.Name = "txtCalibreU";
            this.txtCalibreU.Size = new System.Drawing.Size(167, 21);
            this.txtCalibreU.TabIndex = 55;
            this.txtCalibreU.SelectedIndexChanged += new System.EventHandler(this.txtCalibre_SelectedIndexChanged);
            // 
            // txtMedidaU
            // 
            this.txtMedidaU.FormattingEnabled = true;
            this.txtMedidaU.Items.AddRange(new object[] {
            "20x30",
            "40x60",
            "50x70",
            "60x90",
            "70x90",
            "70+30x120",
            "25+15x40",
            "25+15x50",
            "30+18x60",
            "40+20x70",
            "40+20x90"});
            this.txtMedidaU.Location = new System.Drawing.Point(418, 42);
            this.txtMedidaU.Name = "txtMedidaU";
            this.txtMedidaU.Size = new System.Drawing.Size(167, 21);
            this.txtMedidaU.TabIndex = 54;
            this.txtMedidaU.SelectedIndexChanged += new System.EventHandler(this.txtMedida_SelectedIndexChanged_1);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(563, 248);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 53;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click_1);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(441, 248);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 23);
            this.btnRegresar.TabIndex = 52;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click_1);
            // 
            // CBoxTurnoU
            // 
            this.CBoxTurnoU.FormattingEnabled = true;
            this.CBoxTurnoU.Items.AddRange(new object[] {
            "MATUTINO",
            "VESPERTINO",
            "NOCTURNO"});
            this.CBoxTurnoU.Location = new System.Drawing.Point(17, 40);
            this.CBoxTurnoU.Name = "CBoxTurnoU";
            this.CBoxTurnoU.Size = new System.Drawing.Size(167, 21);
            this.CBoxTurnoU.TabIndex = 51;
            this.CBoxTurnoU.SelectedIndexChanged += new System.EventHandler(this.CBoxTurno_SelectedIndexChanged);
            // 
            // CBoxTipoU
            // 
            this.CBoxTipoU.FormattingEnabled = true;
            this.CBoxTipoU.Items.AddRange(new object[] {
            "BOLSA PLANA",
            "BOLSA CAMISETA",
            "ROLLO"});
            this.CBoxTipoU.Location = new System.Drawing.Point(17, 200);
            this.CBoxTipoU.Name = "CBoxTipoU";
            this.CBoxTipoU.Size = new System.Drawing.Size(167, 21);
            this.CBoxTipoU.TabIndex = 50;
            this.CBoxTipoU.SelectedIndexChanged += new System.EventHandler(this.CBoxTipo_SelectedIndexChanged);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(14, 184);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(28, 13);
            this.lblTipo.TabIndex = 49;
            this.lblTipo.Text = "Tipo";
            this.lblTipo.Click += new System.EventHandler(this.lblTipo_Click);
            // 
            // txtCantidadU
            // 
            this.txtCantidadU.Location = new System.Drawing.Point(215, 122);
            this.txtCantidadU.Name = "txtCantidadU";
            this.txtCantidadU.Size = new System.Drawing.Size(167, 20);
            this.txtCantidadU.TabIndex = 48;
            this.txtCantidadU.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            // 
            // txtOperadorU
            // 
            this.txtOperadorU.Location = new System.Drawing.Point(215, 42);
            this.txtOperadorU.Name = "txtOperadorU";
            this.txtOperadorU.Size = new System.Drawing.Size(167, 20);
            this.txtOperadorU.TabIndex = 47;
            this.txtOperadorU.TextChanged += new System.EventHandler(this.txtOperador_TextChanged);
            // 
            // lblCalibre
            // 
            this.lblCalibre.AutoSize = true;
            this.lblCalibre.Location = new System.Drawing.Point(415, 106);
            this.lblCalibre.Name = "lblCalibre";
            this.lblCalibre.Size = new System.Drawing.Size(39, 13);
            this.lblCalibre.TabIndex = 46;
            this.lblCalibre.Text = "Calibre";
            this.lblCalibre.Click += new System.EventHandler(this.lblCalibre_Click);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(212, 106);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(49, 13);
            this.lblCantidad.TabIndex = 45;
            this.lblCantidad.Text = "Cantidad";
            this.lblCantidad.Click += new System.EventHandler(this.lblCantidad_Click);
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(14, 106);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(31, 13);
            this.lblColor.TabIndex = 44;
            this.lblColor.Text = "Color";
            this.lblColor.Click += new System.EventHandler(this.lblColor_Click);
            // 
            // lblMedida
            // 
            this.lblMedida.AutoSize = true;
            this.lblMedida.Location = new System.Drawing.Point(415, 26);
            this.lblMedida.Name = "lblMedida";
            this.lblMedida.Size = new System.Drawing.Size(42, 13);
            this.lblMedida.TabIndex = 43;
            this.lblMedida.Text = "Medida";
            this.lblMedida.Click += new System.EventHandler(this.lblMedida_Click);
            // 
            // lblOperador
            // 
            this.lblOperador.AutoSize = true;
            this.lblOperador.Location = new System.Drawing.Point(212, 26);
            this.lblOperador.Name = "lblOperador";
            this.lblOperador.Size = new System.Drawing.Size(108, 13);
            this.lblOperador.TabIndex = 42;
            this.lblOperador.Text = "Nombre del Operador";
            this.lblOperador.Click += new System.EventHandler(this.lblOperador_Click);
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Location = new System.Drawing.Point(14, 26);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(35, 13);
            this.lblTurno.TabIndex = 41;
            this.lblTurno.Text = "Turno";
            this.lblTurno.Click += new System.EventHandler(this.lblTurno_Click);
            // 
            // VentanaReporteEditarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(652, 296);
            this.Controls.Add(this.txtColorU);
            this.Controls.Add(this.txtFechaU);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCalibreU);
            this.Controls.Add(this.txtMedidaU);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.CBoxTurnoU);
            this.Controls.Add(this.CBoxTipoU);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.txtCantidadU);
            this.Controls.Add(this.txtOperadorU);
            this.Controls.Add(this.lblCalibre);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblMedida);
            this.Controls.Add(this.lblOperador);
            this.Controls.Add(this.lblTurno);
            this.Controls.Add(this.btnSesio);
            this.Name = "VentanaReporteEditarUsuario";
            this.Text = "VentanaReporteEditar";
            this.Load += new System.EventHandler(this.VentanaReporteEditarUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSesio;
        private System.Windows.Forms.ComboBox txtColorU;
        private System.Windows.Forms.DateTimePicker txtFechaU;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox txtCalibreU;
        private System.Windows.Forms.ComboBox txtMedidaU;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.ComboBox CBoxTurnoU;
        private System.Windows.Forms.ComboBox CBoxTipoU;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.TextBox txtCantidadU;
        private System.Windows.Forms.TextBox txtOperadorU;
        private System.Windows.Forms.Label lblCalibre;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblMedida;
        private System.Windows.Forms.Label lblOperador;
        private System.Windows.Forms.Label lblTurno;
    }
}
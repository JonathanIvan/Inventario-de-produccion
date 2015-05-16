namespace InventarioProduccion
{
    partial class VentanaReporteEditar
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
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.CBoxTurno = new System.Windows.Forms.ComboBox();
            this.CBoxTipo = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtOperador = new System.Windows.Forms.TextBox();
            this.lblCalibre = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblMedida = new System.Windows.Forms.Label();
            this.lblOperador = new System.Windows.Forms.Label();
            this.lblTurno = new System.Windows.Forms.Label();
            this.btnSesio = new System.Windows.Forms.Button();
            this.txtMedida = new System.Windows.Forms.ComboBox();
            this.txtCalibre = new System.Windows.Forms.ComboBox();
            this.txtFecha = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(590, 276);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 33;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(468, 276);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 23);
            this.btnRegresar.TabIndex = 32;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // CBoxTurno
            // 
            this.CBoxTurno.FormattingEnabled = true;
            this.CBoxTurno.Items.AddRange(new object[] {
            "MATUTINO",
            "VESPERTINO",
            "NOCTURNO"});
            this.CBoxTurno.Location = new System.Drawing.Point(44, 68);
            this.CBoxTurno.Name = "CBoxTurno";
            this.CBoxTurno.Size = new System.Drawing.Size(167, 21);
            this.CBoxTurno.TabIndex = 31;
            // 
            // CBoxTipo
            // 
            this.CBoxTipo.FormattingEnabled = true;
            this.CBoxTipo.Items.AddRange(new object[] {
            "BOLSA PLANA",
            "BOLSA CAMISETA",
            "ROLLO"});
            this.CBoxTipo.Location = new System.Drawing.Point(44, 228);
            this.CBoxTipo.Name = "CBoxTipo";
            this.CBoxTipo.Size = new System.Drawing.Size(167, 21);
            this.CBoxTipo.TabIndex = 30;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(41, 212);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(28, 13);
            this.lblTipo.TabIndex = 29;
            this.lblTipo.Text = "Tipo";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(242, 150);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(167, 20);
            this.txtCantidad.TabIndex = 27;
            // 
            // txtOperador
            // 
            this.txtOperador.Location = new System.Drawing.Point(242, 70);
            this.txtOperador.Name = "txtOperador";
            this.txtOperador.Size = new System.Drawing.Size(167, 20);
            this.txtOperador.TabIndex = 24;
            // 
            // lblCalibre
            // 
            this.lblCalibre.AutoSize = true;
            this.lblCalibre.Location = new System.Drawing.Point(442, 134);
            this.lblCalibre.Name = "lblCalibre";
            this.lblCalibre.Size = new System.Drawing.Size(39, 13);
            this.lblCalibre.TabIndex = 23;
            this.lblCalibre.Text = "Calibre";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(239, 134);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(49, 13);
            this.lblCantidad.TabIndex = 22;
            this.lblCantidad.Text = "Cantidad";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(41, 134);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(31, 13);
            this.lblColor.TabIndex = 21;
            this.lblColor.Text = "Color";
            // 
            // lblMedida
            // 
            this.lblMedida.AutoSize = true;
            this.lblMedida.Location = new System.Drawing.Point(442, 54);
            this.lblMedida.Name = "lblMedida";
            this.lblMedida.Size = new System.Drawing.Size(42, 13);
            this.lblMedida.TabIndex = 20;
            this.lblMedida.Text = "Medida";
            // 
            // lblOperador
            // 
            this.lblOperador.AutoSize = true;
            this.lblOperador.Location = new System.Drawing.Point(239, 54);
            this.lblOperador.Name = "lblOperador";
            this.lblOperador.Size = new System.Drawing.Size(108, 13);
            this.lblOperador.TabIndex = 19;
            this.lblOperador.Text = "Nombre del Operador";
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Location = new System.Drawing.Point(41, 54);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(35, 13);
            this.lblTurno.TabIndex = 18;
            this.lblTurno.Text = "Turno";
            // 
            // btnSesio
            // 
            this.btnSesio.Location = new System.Drawing.Point(549, 12);
            this.btnSesio.Name = "btnSesio";
            this.btnSesio.Size = new System.Drawing.Size(116, 23);
            this.btnSesio.TabIndex = 34;
            this.btnSesio.Text = "Cerrar Sesión";
            this.btnSesio.UseVisualStyleBackColor = true;
            this.btnSesio.Click += new System.EventHandler(this.btnSesio_Click);
            // 
            // txtMedida
            // 
            this.txtMedida.FormattingEnabled = true;
            this.txtMedida.Items.AddRange(new object[] {
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
            this.txtMedida.Location = new System.Drawing.Point(445, 70);
            this.txtMedida.Name = "txtMedida";
            this.txtMedida.Size = new System.Drawing.Size(167, 21);
            this.txtMedida.TabIndex = 35;
            // 
            // txtCalibre
            // 
            this.txtCalibre.FormattingEnabled = true;
            this.txtCalibre.Items.AddRange(new object[] {
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
            this.txtCalibre.Location = new System.Drawing.Point(445, 150);
            this.txtCalibre.Name = "txtCalibre";
            this.txtCalibre.Size = new System.Drawing.Size(167, 21);
            this.txtCalibre.TabIndex = 36;
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(242, 229);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(200, 20);
            this.txtFecha.TabIndex = 38;
            this.txtFecha.Value = new System.DateTime(2015, 3, 16, 20, 55, 38, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(239, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Fecha";
            // 
            // txtColor
            // 
            this.txtColor.FormattingEnabled = true;
            this.txtColor.Items.AddRange(new object[] {
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
            this.txtColor.Location = new System.Drawing.Point(44, 150);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(167, 21);
            this.txtColor.TabIndex = 40;
            // 
            // VentanaReporteEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(696, 326);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCalibre);
            this.Controls.Add(this.txtMedida);
            this.Controls.Add(this.btnSesio);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.CBoxTurno);
            this.Controls.Add(this.CBoxTipo);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtOperador);
            this.Controls.Add(this.lblCalibre);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblMedida);
            this.Controls.Add(this.lblOperador);
            this.Controls.Add(this.lblTurno);
            this.Name = "VentanaReporteEditar";
            this.Text = "VentanaReporteEditar";
            this.Load += new System.EventHandler(this.VentanaReporteEditar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.ComboBox CBoxTurno;
        private System.Windows.Forms.ComboBox CBoxTipo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtOperador;
        private System.Windows.Forms.Label lblCalibre;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblMedida;
        private System.Windows.Forms.Label lblOperador;
        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.Button btnSesio;
        private System.Windows.Forms.ComboBox txtMedida;
        private System.Windows.Forms.ComboBox txtCalibre;
        private System.Windows.Forms.DateTimePicker txtFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox txtColor;
    }
}
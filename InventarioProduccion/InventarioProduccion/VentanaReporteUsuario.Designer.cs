namespace InventarioProduccion
{
    partial class VentanaReporteUsuario
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
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.dataGridReporte = new System.Windows.Forms.DataGridView();
            this.txtturno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtoperador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtmedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtcolor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtcantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtcalibre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txttipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReporte)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSesio
            // 
            this.btnSesio.Location = new System.Drawing.Point(961, 25);
            this.btnSesio.Name = "btnSesio";
            this.btnSesio.Size = new System.Drawing.Size(116, 23);
            this.btnSesio.TabIndex = 40;
            this.btnSesio.Text = "Cerrar Sesión";
            this.btnSesio.UseVisualStyleBackColor = true;
            this.btnSesio.Click += new System.EventHandler(this.btnSesio_Click_1);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(873, 25);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 39;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click_1);
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(778, 25);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(75, 23);
            this.btnExportar.TabIndex = 38;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click_1);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(1002, 292);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 23);
            this.btnRegresar.TabIndex = 37;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click_2);
            // 
            // dataGridReporte
            // 
            this.dataGridReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridReporte.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtturno,
            this.txtoperador,
            this.txtmedida,
            this.txtcolor,
            this.txtcantidad,
            this.txtcalibre,
            this.txttipo,
            this.FechaU,
            this.btnEditar,
            this.btnEliminar});
            this.dataGridReporte.Location = new System.Drawing.Point(12, 86);
            this.dataGridReporte.Name = "dataGridReporte";
            this.dataGridReporte.Size = new System.Drawing.Size(1081, 150);
            this.dataGridReporte.TabIndex = 36;
            this.dataGridReporte.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridReporte_CellContentClick);
            // 
            // txtturno
            // 
            this.txtturno.HeaderText = "Turno";
            this.txtturno.Name = "txtturno";
            // 
            // txtoperador
            // 
            this.txtoperador.HeaderText = "Nombre Operador";
            this.txtoperador.Name = "txtoperador";
            // 
            // txtmedida
            // 
            this.txtmedida.HeaderText = "Medida";
            this.txtmedida.Name = "txtmedida";
            // 
            // txtcolor
            // 
            this.txtcolor.HeaderText = "Color";
            this.txtcolor.Name = "txtcolor";
            // 
            // txtcantidad
            // 
            this.txtcantidad.HeaderText = "Cantidad";
            this.txtcantidad.Name = "txtcantidad";
            // 
            // txtcalibre
            // 
            this.txtcalibre.HeaderText = "Calibre";
            this.txtcalibre.Name = "txtcalibre";
            // 
            // txttipo
            // 
            this.txttipo.HeaderText = "Tipo";
            this.txttipo.Name = "txttipo";
            // 
            // FechaU
            // 
            this.FechaU.HeaderText = "Fecha";
            this.FechaU.Name = "FechaU";
            // 
            // btnEditar
            // 
            this.btnEditar.HeaderText = "Editar";
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Text = "Editar";
            // 
            // btnEliminar
            // 
            this.btnEliminar.HeaderText = "Eliminar";
            this.btnEliminar.Name = "btnEliminar";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(653, 25);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 38);
            this.btnBuscar.TabIndex = 42;
            this.btnBuscar.Text = "Buscar Reporte";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // VentanaReporteUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1105, 347);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnSesio);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.dataGridReporte);
            this.Name = "VentanaReporteUsuario";
            this.Text = "VentanaReporteUsuario";
            this.Load += new System.EventHandler(this.VentanaReporteUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReporte)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSesio;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.DataGridView dataGridReporte;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtturno;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtoperador;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtmedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtcolor;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtcantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtcalibre;
        private System.Windows.Forms.DataGridViewTextBoxColumn txttipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaU;
        private System.Windows.Forms.DataGridViewButtonColumn btnEditar;
        private System.Windows.Forms.DataGridViewButtonColumn btnEliminar;
    }
}
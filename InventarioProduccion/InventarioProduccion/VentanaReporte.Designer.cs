namespace InventarioProduccion
{
    partial class VentanaReporte
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
            this.dataGridReporte = new System.Windows.Forms.DataGridView();
            this.txtturno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtoperador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtmedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtcolor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtcantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtcalibre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txttipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtfecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnSesio = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReporte)).BeginInit();
            this.SuspendLayout();
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
            this.txtfecha,
            this.btnEditar,
            this.btnEliminar});
            this.dataGridReporte.Location = new System.Drawing.Point(12, 75);
            this.dataGridReporte.Name = "dataGridReporte";
            this.dataGridReporte.Size = new System.Drawing.Size(1052, 150);
            this.dataGridReporte.TabIndex = 0;
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
            // txtfecha
            // 
            this.txtfecha.HeaderText = "Fecha";
            this.txtfecha.Name = "txtfecha";
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
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(963, 254);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 23);
            this.btnRegresar.TabIndex = 1;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(794, 23);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(75, 23);
            this.btnExportar.TabIndex = 4;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(875, 23);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 5;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnSesio
            // 
            this.btnSesio.Location = new System.Drawing.Point(956, 23);
            this.btnSesio.Name = "btnSesio";
            this.btnSesio.Size = new System.Drawing.Size(82, 23);
            this.btnSesio.TabIndex = 35;
            this.btnSesio.Text = "Cerrar Sesión";
            this.btnSesio.UseVisualStyleBackColor = true;
            this.btnSesio.Click += new System.EventHandler(this.btnSesio_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(686, 23);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 35);
            this.btnBuscar.TabIndex = 43;
            this.btnBuscar.Text = "Buscar Reporte";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // VentanaReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1061, 302);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnSesio);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.dataGridReporte);
            this.Name = "VentanaReporte";
            this.Text = "VentanaReporte";
            this.Load += new System.EventHandler(this.VentanaReporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReporte)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridReporte;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnSesio;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtturno;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtoperador;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtmedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtcolor;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtcantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtcalibre;
        private System.Windows.Forms.DataGridViewTextBoxColumn txttipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtfecha;
        private System.Windows.Forms.DataGridViewButtonColumn btnEditar;
        private System.Windows.Forms.DataGridViewButtonColumn btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
    }
}
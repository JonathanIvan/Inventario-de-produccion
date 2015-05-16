namespace InventarioProduccion
{
    partial class VentanaReporteBuscarUsuario
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
            this.txtFechaBU = new System.Windows.Forms.DateTimePicker();
            this.dataGridReporteBU = new System.Windows.Forms.DataGridView();
            this.txtturno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtoperador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtmedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtcolor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtcantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtcalibre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txttipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtfecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnSesio = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnWord = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReporteBU)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFechaBU
            // 
            this.txtFechaBU.Location = new System.Drawing.Point(379, 38);
            this.txtFechaBU.Name = "txtFechaBU";
            this.txtFechaBU.Size = new System.Drawing.Size(200, 20);
            this.txtFechaBU.TabIndex = 42;
            this.txtFechaBU.Value = new System.DateTime(2015, 3, 16, 20, 55, 38, 0);
            // 
            // dataGridReporteBU
            // 
            this.dataGridReporteBU.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridReporteBU.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtturno,
            this.txtoperador,
            this.txtmedida,
            this.txtcolor,
            this.txtcantidad,
            this.txtcalibre,
            this.txttipo,
            this.txtfecha});
            this.dataGridReporteBU.Location = new System.Drawing.Point(12, 95);
            this.dataGridReporteBU.Name = "dataGridReporteBU";
            this.dataGridReporteBU.Size = new System.Drawing.Size(922, 150);
            this.dataGridReporteBU.TabIndex = 43;
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
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(596, 35);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 44;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnSesio
            // 
            this.btnSesio.Location = new System.Drawing.Point(883, 35);
            this.btnSesio.Name = "btnSesio";
            this.btnSesio.Size = new System.Drawing.Size(87, 23);
            this.btnSesio.TabIndex = 46;
            this.btnSesio.Text = "Cerrar Sesión";
            this.btnSesio.UseVisualStyleBackColor = true;
            this.btnSesio.Click += new System.EventHandler(this.btnSesio_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(802, 35);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(75, 38);
            this.btnExportar.TabIndex = 45;
            this.btnExportar.Text = "Exportar Excel";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(883, 315);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 23);
            this.btnRegresar.TabIndex = 47;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnWord
            // 
            this.btnWord.Location = new System.Drawing.Point(705, 29);
            this.btnWord.Name = "btnWord";
            this.btnWord.Size = new System.Drawing.Size(75, 50);
            this.btnWord.TabIndex = 48;
            this.btnWord.Text = "Exportar Reporte a Word";
            this.btnWord.UseVisualStyleBackColor = true;
            this.btnWord.Click += new System.EventHandler(this.btnWord_Click);
            // 
            // VentanaReporteBuscarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 374);
            this.Controls.Add(this.btnWord);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnSesio);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.dataGridReporteBU);
            this.Controls.Add(this.txtFechaBU);
            this.Name = "VentanaReporteBuscarUsuario";
            this.Text = "VentanaReporteBuscarUsuario";
            this.Load += new System.EventHandler(this.VentanaReporteBuscarUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReporteBU)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker txtFechaBU;
        private System.Windows.Forms.DataGridView dataGridReporteBU;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnSesio;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtturno;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtoperador;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtmedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtcolor;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtcantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtcalibre;
        private System.Windows.Forms.DataGridViewTextBoxColumn txttipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtfecha;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnWord;
    }
}
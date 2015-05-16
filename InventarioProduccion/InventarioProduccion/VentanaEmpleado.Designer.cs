namespace InventarioProduccion
{
    partial class VentanaEmpleado
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
            this.dataGridEmpleado = new System.Windows.Forms.DataGridView();
            this.txtNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtApp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtApm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnVer = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnSesion = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmpleado)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridEmpleado
            // 
            this.dataGridEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEmpleado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtNombre,
            this.txtApp,
            this.txtApm,
            this.txtNss,
            this.btnEditar,
            this.btnVer,
            this.btnEliminar});
            this.dataGridEmpleado.Location = new System.Drawing.Point(13, 70);
            this.dataGridEmpleado.Name = "dataGridEmpleado";
            this.dataGridEmpleado.Size = new System.Drawing.Size(746, 150);
            this.dataGridEmpleado.TabIndex = 0;
            this.dataGridEmpleado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridEmpleado_CellContentClick);
            // 
            // txtNombre
            // 
            this.txtNombre.HeaderText = "Nombre";
            this.txtNombre.Name = "txtNombre";
            // 
            // txtApp
            // 
            this.txtApp.HeaderText = "Apellido Paterno";
            this.txtApp.Name = "txtApp";
            // 
            // txtApm
            // 
            this.txtApm.HeaderText = "Apellido Materno";
            this.txtApm.Name = "txtApm";
            // 
            // txtNss
            // 
            this.txtNss.HeaderText = "Numero de Seguro Social";
            this.txtNss.Name = "txtNss";
            // 
            // btnEditar
            // 
            this.btnEditar.HeaderText = "Editar";
            this.btnEditar.Name = "btnEditar";
            // 
            // btnVer
            // 
            this.btnVer.HeaderText = "Ver";
            this.btnVer.Name = "btnVer";
            // 
            // btnEliminar
            // 
            this.btnEliminar.HeaderText = "Eliminar";
            this.btnEliminar.Name = "btnEliminar";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(684, 23);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 1;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(572, 23);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(75, 23);
            this.btnExportar.TabIndex = 5;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(684, 262);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 23);
            this.btnRegresar.TabIndex = 6;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnSesion
            // 
            this.btnSesion.Location = new System.Drawing.Point(572, 262);
            this.btnSesion.Name = "btnSesion";
            this.btnSesion.Size = new System.Drawing.Size(93, 23);
            this.btnSesion.TabIndex = 7;
            this.btnSesion.Text = "Cerrar Sesión";
            this.btnSesion.UseVisualStyleBackColor = true;
            this.btnSesion.Click += new System.EventHandler(this.btnSesion_Click);
            // 
            // VentanaEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(784, 310);
            this.Controls.Add(this.btnSesion);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dataGridEmpleado);
            this.Name = "VentanaEmpleado";
            this.Text = "VentanaEmpleado";
            this.Load += new System.EventHandler(this.VentanaEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmpleado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridEmpleado;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtApp;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtApm;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNss;
        private System.Windows.Forms.DataGridViewButtonColumn btnEditar;
        private System.Windows.Forms.DataGridViewButtonColumn btnVer;
        private System.Windows.Forms.DataGridViewButtonColumn btnEliminar;
        private System.Windows.Forms.Button btnSesion;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}
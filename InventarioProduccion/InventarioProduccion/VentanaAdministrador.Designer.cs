namespace InventarioProduccion
{
    partial class VentanaAdministrador
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
            this.dataGridAdministrador = new System.Windows.Forms.DataGridView();
            this.txtUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnSesion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAdministrador)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridAdministrador
            // 
            this.dataGridAdministrador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAdministrador.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtUsuario,
            this.btnEditar});
            this.dataGridAdministrador.Location = new System.Drawing.Point(30, 52);
            this.dataGridAdministrador.Name = "dataGridAdministrador";
            this.dataGridAdministrador.Size = new System.Drawing.Size(246, 207);
            this.dataGridAdministrador.TabIndex = 0;
            this.dataGridAdministrador.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridAdministrador_CellContentClick);
            // 
            // txtUsuario
            // 
            this.txtUsuario.HeaderText = "Usuario";
            this.txtUsuario.Name = "txtUsuario";
            // 
            // btnEditar
            // 
            this.btnEditar.HeaderText = "Editar";
            this.btnEditar.Name = "btnEditar";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(346, 97);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 39);
            this.btnNuevo.TabIndex = 1;
            this.btnNuevo.Text = "Nuevo Usuario";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(346, 255);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 23);
            this.btnRegresar.TabIndex = 3;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnSesion
            // 
            this.btnSesion.Location = new System.Drawing.Point(333, 12);
            this.btnSesion.Name = "btnSesion";
            this.btnSesion.Size = new System.Drawing.Size(116, 23);
            this.btnSesion.TabIndex = 36;
            this.btnSesion.Text = "Cerrar Sesión";
            this.btnSesion.UseVisualStyleBackColor = true;
            this.btnSesion.Click += new System.EventHandler(this.btnSesion_Click);
            // 
            // VentanaAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(461, 290);
            this.Controls.Add(this.btnSesion);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dataGridAdministrador);
            this.Name = "VentanaAdministrador";
            this.Text = "VentanaAdministrador";
            this.Load += new System.EventHandler(this.VentanaAdministrador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAdministrador)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridAdministrador;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtUsuario;
        private System.Windows.Forms.DataGridViewButtonColumn btnEditar;
        private System.Windows.Forms.Button btnSesion;
    }
}
namespace InventarioProduccion
{
    partial class VentanaAdministradorNuevo
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtVPassword = new System.Windows.Forms.TextBox();
            this.lblContrasena = new System.Windows.Forms.Label();
            this.lblVContrasena = new System.Windows.Forms.Label();
            this.btnSesion = new System.Windows.Forms.Button();
            this.txtTipoUsuario = new System.Windows.Forms.ComboBox();
            this.lblTipoUsuario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(282, 306);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(164, 306);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 23);
            this.btnRegresar.TabIndex = 1;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(68, 52);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(50, 13);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "Usuario:*";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(71, 68);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(150, 20);
            this.txtUsuario.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(71, 125);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(150, 20);
            this.txtPassword.TabIndex = 4;
            // 
            // txtVPassword
            // 
            this.txtVPassword.Location = new System.Drawing.Point(71, 180);
            this.txtVPassword.Name = "txtVPassword";
            this.txtVPassword.PasswordChar = '*';
            this.txtVPassword.Size = new System.Drawing.Size(150, 20);
            this.txtVPassword.TabIndex = 5;
            // 
            // lblContrasena
            // 
            this.lblContrasena.AutoSize = true;
            this.lblContrasena.Location = new System.Drawing.Point(68, 109);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.Size = new System.Drawing.Size(68, 13);
            this.lblContrasena.TabIndex = 6;
            this.lblContrasena.Text = "Contraseña:*";
            // 
            // lblVContrasena
            // 
            this.lblVContrasena.AutoSize = true;
            this.lblVContrasena.Location = new System.Drawing.Point(68, 164);
            this.lblVContrasena.Name = "lblVContrasena";
            this.lblVContrasena.Size = new System.Drawing.Size(109, 13);
            this.lblVContrasena.TabIndex = 7;
            this.lblVContrasena.Text = "Verificar Contraseña:*";
            // 
            // btnSesion
            // 
            this.btnSesion.Location = new System.Drawing.Point(241, 22);
            this.btnSesion.Name = "btnSesion";
            this.btnSesion.Size = new System.Drawing.Size(116, 23);
            this.btnSesion.TabIndex = 38;
            this.btnSesion.Text = "Cerrar Sesión";
            this.btnSesion.UseVisualStyleBackColor = true;
            this.btnSesion.Click += new System.EventHandler(this.btnSesion_Click);
            // 
            // txtTipoUsuario
            // 
            this.txtTipoUsuario.FormattingEnabled = true;
            this.txtTipoUsuario.Items.AddRange(new object[] {
            "Super Usuario",
            "Usuario"});
            this.txtTipoUsuario.Location = new System.Drawing.Point(71, 232);
            this.txtTipoUsuario.Name = "txtTipoUsuario";
            this.txtTipoUsuario.Size = new System.Drawing.Size(150, 21);
            this.txtTipoUsuario.TabIndex = 39;
            // 
            // lblTipoUsuario
            // 
            this.lblTipoUsuario.AutoSize = true;
            this.lblTipoUsuario.Location = new System.Drawing.Point(71, 213);
            this.lblTipoUsuario.Name = "lblTipoUsuario";
            this.lblTipoUsuario.Size = new System.Drawing.Size(82, 13);
            this.lblTipoUsuario.TabIndex = 40;
            this.lblTipoUsuario.Text = "Tipo de Usuario";
            // 
            // VentanaAdministradorNuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(369, 369);
            this.Controls.Add(this.lblTipoUsuario);
            this.Controls.Add(this.txtTipoUsuario);
            this.Controls.Add(this.btnSesion);
            this.Controls.Add(this.lblVContrasena);
            this.Controls.Add(this.lblContrasena);
            this.Controls.Add(this.txtVPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnAgregar);
            this.Name = "VentanaAdministradorNuevo";
            this.Text = "VentanaAdministradorNuevo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtVPassword;
        private System.Windows.Forms.Label lblContrasena;
        private System.Windows.Forms.Label lblVContrasena;
        private System.Windows.Forms.Button btnSesion;
        private System.Windows.Forms.ComboBox txtTipoUsuario;
        private System.Windows.Forms.Label lblTipoUsuario;
    }
}
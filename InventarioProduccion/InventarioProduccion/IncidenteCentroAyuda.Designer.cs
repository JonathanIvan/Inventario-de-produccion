namespace InventarioProduccion
{
    partial class IncidenteCentroAyuda
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
            this.label18 = new System.Windows.Forms.Label();
            this.programa = new System.Windows.Forms.ComboBox();
            this.version = new System.Windows.Forms.ComboBox();
            this.so = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtproblema = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.lblNombreP = new System.Windows.Forms.Label();
            this.lblVPrograma = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.problema = new System.Windows.Forms.ComboBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.fecha = new System.Windows.Forms.Label();
            this.hora = new System.Windows.Forms.Label();
            this.btnSesion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(108, -165);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(408, 39);
            this.label18.TabIndex = 68;
            this.label18.Text = "                                   Comunicación de errores o incidencias:\r\n\r\n Por" +
    " favor, facilite la información requerida para ayudarnos a comprender su consult" +
    "a:";
            // 
            // programa
            // 
            this.programa.FormattingEnabled = true;
            this.programa.Items.AddRange(new object[] {
            "",
            "Inventario de Produccion",
            "Invetario Empresarial",
            "Drop Sound",
            "Notpacks"});
            this.programa.Location = new System.Drawing.Point(25, 92);
            this.programa.Name = "programa";
            this.programa.Size = new System.Drawing.Size(201, 21);
            this.programa.TabIndex = 67;
            this.programa.SelectedIndexChanged += new System.EventHandler(this.comboNPrograma_SelectedIndexChanged);
            // 
            // version
            // 
            this.version.FormattingEnabled = true;
            this.version.Items.AddRange(new object[] {
            "",
            "V 1.0",
            "V 1.2",
            "V 1.3.1",
            "V 2.0",
            "V 2.1.1",
            "V 2.2",
            "V 3.0.1"});
            this.version.Location = new System.Drawing.Point(318, 92);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(202, 21);
            this.version.TabIndex = 66;
            // 
            // so
            // 
            this.so.FormattingEnabled = true;
            this.so.Items.AddRange(new object[] {
            "",
            "Windows 98",
            "Windows 2000",
            "Windows XP",
            "Windows Vista",
            "Windows 7",
            "Windows 8",
            "Ubuntu",
            "Debian",
            "Mac OX",
            "Solaris"});
            this.so.Location = new System.Drawing.Point(25, 146);
            this.so.Name = "so";
            this.so.Size = new System.Drawing.Size(199, 21);
            this.so.TabIndex = 58;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(22, 121);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(96, 13);
            this.label17.TabIndex = 57;
            this.label17.Text = "Sistema Operativo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 39);
            this.label7.TabIndex = 56;
            this.label7.Text = "3.¿Qué vio exactamente? \r\n(p. ej., algún texto con \r\nmensajes de error)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 26);
            this.label6.TabIndex = 55;
            this.label6.Text = "2,¿Qué hizo? (p. ej., menú \r\no botones que ha usado)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 13);
            this.label5.TabIndex = 54;
            this.label5.Text = "1.¿Qué intenta hacer?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(264, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 13);
            this.label4.TabIndex = 53;
            this.label4.Text = "Descripcion del Problema:";
            // 
            // txtproblema
            // 
            this.txtproblema.Location = new System.Drawing.Point(267, 222);
            this.txtproblema.Name = "txtproblema";
            this.txtproblema.Size = new System.Drawing.Size(307, 121);
            this.txtproblema.TabIndex = 52;
            this.txtproblema.Text = "";
            this.txtproblema.TextChanged += new System.EventHandler(this.richTextDescripcion_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 337);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 65);
            this.label8.TabIndex = 70;
            this.label8.Text = "4.Si repite los pasos, ¿vuelve \r\na suceder otra vez? Nos \r\nresulta mucho más fáci" +
    "l \r\nsolucionar el problema, \r\nsi existe una manera de repetirlo.";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(541, 385);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(91, 23);
            this.btnEnviar.TabIndex = 72;
            this.btnEnviar.Text = "Enviar Informe";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(453, 357);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(106, 13);
            this.label19.TabIndex = 71;
            this.label19.Text = "* = campo obligatorio";
            // 
            // lblNombreP
            // 
            this.lblNombreP.AutoSize = true;
            this.lblNombreP.Location = new System.Drawing.Point(25, 73);
            this.lblNombreP.Name = "lblNombreP";
            this.lblNombreP.Size = new System.Drawing.Size(109, 13);
            this.lblNombreP.TabIndex = 73;
            this.lblNombreP.Text = "Nombre del Programa";
            // 
            // lblVPrograma
            // 
            this.lblVPrograma.AutoSize = true;
            this.lblVPrograma.Location = new System.Drawing.Point(315, 73);
            this.lblVPrograma.Name = "lblVPrograma";
            this.lblVPrograma.Size = new System.Drawing.Size(110, 13);
            this.lblVPrograma.TabIndex = 74;
            this.lblVPrograma.Text = "Version del Programa:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(325, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 76;
            this.label1.Text = "Incidente o Problema:";
            // 
            // problema
            // 
            this.problema.FormattingEnabled = true;
            this.problema.Items.AddRange(new object[] {
            "",
            "No guarda los datos",
            "No carga la bases de datos",
            "Error el Reporte",
            "No imprime el reporte",
            "No muetra los empleados"});
            this.problema.Location = new System.Drawing.Point(318, 145);
            this.problema.Name = "problema";
            this.problema.Size = new System.Drawing.Size(202, 21);
            this.problema.TabIndex = 77;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(404, 385);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 23);
            this.btnRegresar.TabIndex = 78;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 79;
            this.label2.Text = "Nombre del Usuario";
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(25, 40);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(201, 20);
            this.nombre.TabIndex = 80;
            // 
            // fecha
            // 
            this.fecha.AutoSize = true;
            this.fecha.Location = new System.Drawing.Point(571, 22);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(34, 13);
            this.fecha.TabIndex = 81;
            this.fecha.Text = "fecha";
            // 
            // hora
            // 
            this.hora.AutoSize = true;
            this.hora.Location = new System.Drawing.Point(571, 9);
            this.hora.Name = "hora";
            this.hora.Size = new System.Drawing.Size(28, 13);
            this.hora.TabIndex = 82;
            this.hora.Text = "hora";
            // 
            // btnSesion
            // 
            this.btnSesion.Location = new System.Drawing.Point(439, 9);
            this.btnSesion.Name = "btnSesion";
            this.btnSesion.Size = new System.Drawing.Size(102, 23);
            this.btnSesion.TabIndex = 83;
            this.btnSesion.Text = "Cerrar Sesión";
            this.btnSesion.UseVisualStyleBackColor = true;
            this.btnSesion.Click += new System.EventHandler(this.btnSesion_Click);
            // 
            // IncidenteCentroAyuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(658, 420);
            this.Controls.Add(this.btnSesion);
            this.Controls.Add(this.hora);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.problema);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblVPrograma);
            this.Controls.Add(this.lblNombreP);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.programa);
            this.Controls.Add(this.version);
            this.Controls.Add(this.so);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtproblema);
            this.Name = "IncidenteCentroAyuda";
            this.Text = "Registro de Incidente";
            this.Load += new System.EventHandler(this.IncidenteCentroAyuda_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox programa;
        private System.Windows.Forms.ComboBox version;
        private System.Windows.Forms.ComboBox so;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox txtproblema;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblNombreP;
        private System.Windows.Forms.Label lblVPrograma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox problema;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Label fecha;
        private System.Windows.Forms.Label hora;
        private System.Windows.Forms.Button btnSesion;
    }
}
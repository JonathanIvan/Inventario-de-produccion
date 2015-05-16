using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace InventarioProduccion
{
    public partial class VentanaReporteNuevo : Form
    {
        public VentanaReporteNuevo()
        {
            InitializeComponent();
            txtFecha.Format = DateTimePickerFormat.Custom;
            txtFecha.CustomFormat = "yyyy-MM-dd";
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            VentanaReporte ventanareporte = new VentanaReporte();
            ventanareporte.Show();

            this.SetVisibleCore(false);
        }
        MySqlConnection miconexion = new MySqlConnection("Server=127.0.0.1; Database=inventarioproduccion; Uid=root; Password=208081433;");
        
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            MySqlCommand comando = new MySqlCommand("INSERT INTO reporte (medida, color,cantidad, turno, tipo, n_operador, calibre,fecha) VALUES (@MEDIDA, @COLOR,@CANTIDAD, @TURNO, @TIPO, @OPERADOR, @CALIBRE,@FECHA)", miconexion);
            
            comando.Parameters.AddWithValue("@MEDIDA", txtMedida.Text);
            comando.Parameters.AddWithValue("@COLOR", txtColor.Text);
            comando.Parameters.AddWithValue("@CALIBRE", txtCalibre.Text);
            comando.Parameters.AddWithValue("@CANTIDAD", txtCantidad.Text);
            comando.Parameters.AddWithValue("@OPERADOR", txtOperador.Text);
            comando.Parameters.AddWithValue("@TURNO", CBoxTurno.Text);
            comando.Parameters.AddWithValue("@TIPO", CBoxTipo.Text);
            comando.Parameters.AddWithValue("@FECHA", txtFecha.Text);

            miconexion.Open();
            comando.ExecuteNonQuery();
            miconexion.Close();
            MessageBox.Show("Agregado Correctamente");
        }

        private void btnSesio_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.SetVisibleCore(false);
        }

        private void VentanaReporteNuevo_Load(object sender, EventArgs e)
        {
            txtOperador.CharacterCasing = CharacterCasing.Upper;
        }
    }
}

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
    public partial class VentanaReporteEditarUsuario : Form
    {
        private MySqlConnection miconexion = new MySqlConnection("Server=127.0.0.1; Database=inventarioproduccion; Uid=root; Password=208081433;");
        private String id;
        private VentanaReporteUsuario padre;

        public VentanaReporteEditarUsuario(VentanaReporteUsuario padre, string id)
        {
            this.padre = padre;
            InitializeComponent();
            // TODO: Complete member initialization
            this.id = id;
            this.Text = "ID: " + id;
            carga_datos();
            txtFechaU.Format = DateTimePickerFormat.Custom;
            txtFechaU.CustomFormat = "yyyy-MM-dd";
        }
        public VentanaReporteEditarUsuario()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            
        }

       
        void carga_datos()
        {
            string sql = "SELECT *FROM reporte WHERE idreporte = '" + this.id + "'";
            MySqlCommand comando = new MySqlCommand(sql, miconexion);
            miconexion.Open();
            MySqlDataReader leer = comando.ExecuteReader();
            leer.Read();
            if (!leer.IsDBNull(1))
            {
                this.txtMedidaU.Text = leer.GetString(1);
            }
            else
            {
                this.txtMedidaU.Text = " ";
            } if (!leer.IsDBNull(2))
            {
                this.txtColorU.Text = leer.GetString(2);
            }
            else
            {
                this.txtColorU.Text = " ";
            } if (!leer.IsDBNull(7))
            {
                this.txtCalibreU.Text = leer.GetString(7);
            }
            else
            {
                this.txtCalibreU.Text = " ";
            } if (!leer.IsDBNull(3))
            {
                this.txtCantidadU.Text = leer.GetString(3);
            }
            else
            {
                this.txtCantidadU.Text = " ";
            } if (!leer.IsDBNull(5))
            {
                this.txtOperadorU.Text = leer.GetString(5);
            }
            else
            {
                this.txtOperadorU.Text = " ";
            } if (!leer.IsDBNull(4))
            {
                this.CBoxTurnoU.Text = leer.GetString(4);
            }
            else
            {
                this.CBoxTurnoU.Text = " ";
            } if (!leer.IsDBNull(6))
            {
                this.CBoxTipoU.Text = leer.GetString(6);
            }
            else
            {
                this.CBoxTipoU.Text = " ";
            } if (!leer.IsDBNull(8))
            {
                this.txtFechaU.Text = leer.GetString(8);
            }
            else
            {
                this.txtFechaU.Text = " ";
            }
            miconexion.Close();
        }

        private void btnSesio_Click(object sender, EventArgs e)
        {
            Login logi =new Login();
            logi.Show();
            this.SetVisibleCore(false);
        }

        private void txtMedida_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            MySqlCommand comando = new MySqlCommand("update reporte set medida=@MEDIDA, color=@COLOR, calibre=@CALIBRE,cantidad=@CANTIDAD, n_operador=@OPERADOR, turno=@TURNO, tipo=@TIPO,fecha=@FECHA where idreporte ='" + this.id + "'", miconexion);

            comando.Parameters.AddWithValue("@MEDIDA", txtMedidaU.Text);
            comando.Parameters.AddWithValue("@COLOR", txtColorU.Text);
            comando.Parameters.AddWithValue("@CALIBRE", txtCalibreU.Text);
            comando.Parameters.AddWithValue("@CANTIDAD", txtCantidadU.Text);
            comando.Parameters.AddWithValue("@OPERADOR", txtOperadorU.Text);
            comando.Parameters.AddWithValue("@TURNO", CBoxTurnoU.Text);
            comando.Parameters.AddWithValue("@TIPO", CBoxTipoU.Text);
            comando.Parameters.AddWithValue("@FECHA", txtFechaU.Text);

            miconexion.Open();
            comando.ExecuteNonQuery();
            miconexion.Close();
            MessageBox.Show("Reporte Editado");
            this.padre.carga_ReporteUsuario();
        }

        private void txtFecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtCalibre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtMedida_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void txtColor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click_1(object sender, EventArgs e)
        {
            VentanaReporteUsuario ventanareporteusuario = new VentanaReporteUsuario();
            ventanareporteusuario.Show();

            this.SetVisibleCore(false);
        }

        private void CBoxTurno_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CBoxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblTipo_Click(object sender, EventArgs e)
        {

        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtOperador_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCalibre_Click(object sender, EventArgs e)
        {

        }

        private void lblCantidad_Click(object sender, EventArgs e)
        {

        }

        private void lblColor_Click(object sender, EventArgs e)
        {

        }

        private void lblMedida_Click(object sender, EventArgs e)
        {

        }

        private void lblOperador_Click(object sender, EventArgs e)
        {

        }

        private void lblTurno_Click(object sender, EventArgs e)
        {

        }

        private void VentanaReporteEditarUsuario_Load(object sender, EventArgs e)
        {
            txtOperadorU.CharacterCasing = CharacterCasing.Upper;
        }
 
    }
}

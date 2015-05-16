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
    public partial class VentanaAdministradorEditar : Form
    {
        private MySqlConnection miconexion = new MySqlConnection("Server=127.0.0.1; Database=inventarioproduccion; Uid=root; Password=208081433;");
        private String id;
        private VentanaAdministrador padre;

        public VentanaAdministradorEditar(VentanaAdministrador padre, string id)
        {
            this.padre = padre;
            InitializeComponent();
            // TODO: Complete member initialization
            this.id = id;
            this.Text = "ID: " + id;
            carga_datos();
        }
        public VentanaAdministradorEditar()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            VentanaAdministrador ventanaadministrador = new VentanaAdministrador();
            ventanaadministrador.Show();

            this.SetVisibleCore(false);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Seguro De Que Quieres Editar El Usuario","AVISO",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question);
            if (resultado ==DialogResult.Yes) { 
            MySqlCommand comando = new MySqlCommand("update login set username=@USERNAME,password=@PASSWORD,tipo=@TIPO where idlogin ='" + this.id + "'", miconexion);
            comando.Parameters.AddWithValue("TIPO", txtTipoUsuario.Text);
            comando.Parameters.AddWithValue("USERNAME", txtUsuario.Text);
            if (txtPassword.Text == txtVPassword.Text)
            {
                comando.Parameters.AddWithValue("PASSWORD", txtPassword.Text);
                miconexion.Open();
                comando.ExecuteNonQuery();
                miconexion.Close();
            }
                MessageBox.Show("Usuario Editado Correctamente");
            }
            else {
                MessageBox.Show("Las contraseñas no son iguales");
                miconexion.Close();
            }
            this.padre.carga_Administrador();
        }
        void carga_datos()
        {
            string sql = "SELECT * FROM login WHERE idlogin = '" + this.id + "'";
            MySqlCommand comando = new MySqlCommand(sql, miconexion);
            miconexion.Open();
            MySqlDataReader leer = comando.ExecuteReader();
            leer.Read();
            if (!leer.IsDBNull(1))
            {
                this.txtUsuario.Text = leer.GetString(1);
            }
            else
            {
                this.txtUsuario.Text = " ";
            }

            if (!leer.IsDBNull(2))
            {
                this.txtPassword.Text = leer.GetString(2);
            }
            else
            {
                this.txtPassword.Text = " ";

            }
            if (!leer.IsDBNull(2))
            {
                this.txtVPassword.Text = leer.GetString(2);
            }
            else
            {
                this.txtVPassword.Text = " ";
            }
            if (!leer.IsDBNull(3))
            {
                this.txtTipoUsuario.Text = leer.GetString(3);
            }
            else
            {
                this.txtTipoUsuario.Text = " ";
            } 
            miconexion.Close();
        }

        private void btnSesion_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.SetVisibleCore(false);
        }
    }
}

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
    public partial class VentanaAdministradorNuevo : Form
    {
        public VentanaAdministradorNuevo()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            VentanaAdministrador ventanaadministrador = new VentanaAdministrador();
            ventanaadministrador.Show();

            this.SetVisibleCore(false);
        }
        MySqlConnection miconexion = new MySqlConnection("Server=127.0.0.1; Database=inventarioproduccion; Uid=root; Password=208081433;");
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            MySqlCommand comando = new MySqlCommand("INSERT INTO login (username, password,tipo) VALUES (@USERNAME, @PASSWORD,@TIPO)", miconexion);
            comando.Parameters.AddWithValue("@USERNAME", txtUsuario.Text);
            
            if (txtPassword.Text == txtVPassword.Text)
            {
                comando.Parameters.AddWithValue("@PASSWORD", txtPassword.Text);
                comando.Parameters.AddWithValue("@TIPO", txtTipoUsuario.Text);
                miconexion.Open();
                comando.ExecuteNonQuery();
                miconexion.Close();
                MessageBox.Show("Agregado Correctamente");
            }
            else {
                
                
                MessageBox.Show("Las contraseñas no son iguales");
                miconexion.Close();
            }
           
        }

        private void btnSesion_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.SetVisibleCore(false);
        }
    }
}

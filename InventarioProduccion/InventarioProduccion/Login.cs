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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        MySqlConnection miconexion = new MySqlConnection("Server=127.0.0.1; Database=inventarioproduccion; Uid=root; Password=208081433;");
        private void btnEntrar_Click(object sender, EventArgs e)
        {

            
                miconexion.Open(); //Abrimos la conexion creada.
                MySqlCommand comand = new MySqlCommand("SELECT * FROM login WHERE username=@USERNAME AND password=@PASSWORD AND tipo=@TIPO", miconexion); //Realizamos una selecion de la tabla usuarios.
                comand.Parameters.AddWithValue("@USERNAME", textUsuario.Text);
                comand.Parameters.AddWithValue("@PASSWORD", textPassword.Text);

                comand.Parameters.AddWithValue("@TIPO", txtTipo.Text);
                
                    MySqlDataReader leer = comand.ExecuteReader();
                    if (leer.Read()) //Si el usuario es correcto nos abrira la otra ventana.
                    {
                        if (txtTipo.Text == "Super Usuario")
                        {
                        this.Hide();
                        Principal principal = new Principal();

                        principal.Show();
                        this.SetVisibleCore(false);
                        }
                        else if (txtTipo.Text == "Usuario")
                        {
                            this.Hide();
                            PrincipalUsuario principalusuario = new PrincipalUsuario();

                            principalusuario.Show();
                            this.SetVisibleCore(false);

                        }
                    
                }
                
                else //Si no lo es mostrara este mensaje.
                    MessageBox.Show("Error - En Usuario o Contraseña");
                miconexion.Close(); //Cerramos la conexion.
            }
        

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void textUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
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
    public partial class VentanaAdministrador : Form
    {
        public VentanaAdministrador()
        {
            InitializeComponent();
        }
        MySqlConnection miconexion = new MySqlConnection("Server=127.0.0.1; Database=inventarioproduccion; Uid=root; Password=208081433;");

        public void carga_Administrador()
        {
            MySqlCommand comando = new MySqlCommand("select *from login", miconexion);
            miconexion.Open();
            MySqlDataReader leer = comando.ExecuteReader();
            dataGridAdministrador.Rows.Clear();

            int renglon = 0;

            while (leer.Read())
            {

                renglon = dataGridAdministrador.Rows.Add();
                dataGridAdministrador.Rows[renglon].Cells["txtUsuario"].Value = leer.GetString(1);

                DataGridViewButtonColumn btnEditar = new DataGridViewButtonColumn();
                btnEditar.Name = "editar_" + leer.GetString(0);
                dataGridAdministrador.Rows[renglon].Cells["btnEditar"].Value = btnEditar;
                
            }
            miconexion.Close();
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            VentanaAdministradorNuevo ventanaadministradornuevo = new VentanaAdministradorNuevo();
            ventanaadministradornuevo.Show();

            this.SetVisibleCore(false);
        }

      

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            principal.Show();
            this.SetVisibleCore(false);
        }

        private void dataGridAdministrador_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridAdministrador.Columns["btnEditar"].Index)
            {
                DataGridViewButtonColumn boton = (DataGridViewButtonColumn)dataGridAdministrador.Rows[e.RowIndex].Cells["btnEditar"].Value;
                String id = boton.Name.Replace("editar_", "");
                VentanaAdministradorEditar editar = new VentanaAdministradorEditar(this, id);
                editar.Show();
                this.SetVisibleCore(false);
            }
        }

        private void VentanaAdministrador_Load(object sender, EventArgs e)
        {
            carga_Administrador();
        }

        private void btnSesion_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.SetVisibleCore(false);
        }
    }
}

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
    public partial class RegistoCentroAyuda : Form
    {
        public RegistoCentroAyuda()
        {
            
            InitializeComponent();
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }
        MySqlConnection miconexion = new MySqlConnection("Server=127.0.0.1; Database=inventario; Uid=root; Password=208081433;");
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            
            MySqlCommand comando = new MySqlCommand("INSERT INTO registro (nombre, apellidos, empresa, domicilio, correo, localidad, telefono, celular, cp) VALUES (@NAME, @APP, @EMP, @DOMICILIOO, @COREOO, @LOCALIDAA, @TEL, @CEL, @CPP)", miconexion);
            comando.Parameters.AddWithValue("@NAME", textNombre.Text);
            comando.Parameters.AddWithValue("@APP", textApellidos.Text);
            comando.Parameters.AddWithValue("@EMP", textEmpresa.Text);
            comando.Parameters.AddWithValue("@DOMICILIOO", textDomicilio.Text);
            comando.Parameters.AddWithValue("@COREOO", textCorreo.Text);
            comando.Parameters.AddWithValue("@LOCALIDAA", textLocalidad.Text);
            comando.Parameters.AddWithValue("@TEL", textTelefono.Text);
            comando.Parameters.AddWithValue("@CEL", textCelular.Text);
            comando.Parameters.AddWithValue("@CPP", textCP.Text);
            
            miconexion.Open();
            comando.ExecuteNonQuery();
            miconexion.Close();
            MessageBox.Show("Agregado Correctamente");
            IncidenteCentroAyuda incidentecentroayuda = new IncidenteCentroAyuda();
            incidentecentroayuda.Show();
            this.SetVisibleCore(false);
        }

        private void RegistoCentroAyuda_Load(object sender, EventArgs e)
        {
            textNombre.CharacterCasing = CharacterCasing.Upper;
            textApellidos.CharacterCasing = CharacterCasing.Upper;
            textEmpresa.CharacterCasing = CharacterCasing.Upper;
            textDomicilio.CharacterCasing = CharacterCasing.Upper;
            textDomicilio.CharacterCasing = CharacterCasing.Upper;
        }

        private void btnSesion_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.SetVisibleCore(false);
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            CentroAyuda centroayuda = new CentroAyuda();
            centroayuda.Show();
            this.SetVisibleCore(false);
        }

        
    }
}

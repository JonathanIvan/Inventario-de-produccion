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
    public partial class VentanaEmpleadoNuevo : Form
    {
        public VentanaEmpleadoNuevo()
        {
            InitializeComponent();
        }
       
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            VentanaEmpleado ventanaempleado = new VentanaEmpleado();
            ventanaempleado.Show();
            this.SetVisibleCore(false);
        }

        MySqlConnection miconexion = new MySqlConnection("Server=127.0.0.1; Database=inventarioproduccion; Uid=root; Password=208081433;");
        
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            MySqlCommand comando = new MySqlCommand("INSERT INTO empleados (nombre, app, apm, domicilio, colonia, cp, fecha_nac, estado, nacionalidad, municipio, sexo, estado_civil, fecha_ingre, telefono, cel, puesto, nss) VALUES (@NOMBRE, @APP, @APM, @DOMICILIO, @COLONIA, @CP, @FECHA_NAC, @ESTADO, @NACIONALIDAD, @MUNICIPIO, @SEXO, @ESTADO_CIVIL, @FECHA_INGRE, @TELEFONO, @CEL, @PUESTO, @NSS)", miconexion);
            
            comando.Parameters.AddWithValue("@NOMBRE", txtNombre.Text);
            comando.Parameters.AddWithValue("@APP", txtApp.Text);
            comando.Parameters.AddWithValue("@APM", txtApm.Text);
            comando.Parameters.AddWithValue("@DOMICILIO", txtDomicilio.Text);
            comando.Parameters.AddWithValue("@COLONIA", txtColonia.Text);
            comando.Parameters.AddWithValue("@CP", txtCP.Text);
            comando.Parameters.AddWithValue("@FECHA_NAC", txtFN.Text);
            comando.Parameters.AddWithValue("@ESTADO", txtEstado.Text);
            comando.Parameters.AddWithValue("@NACIONALIDAD", CBoxNacionalidad.Text);
            comando.Parameters.AddWithValue("@MUNICIPIO", txtMunicipio.Text);
            comando.Parameters.AddWithValue("@SEXO", CBoxSexo.Text);
            comando.Parameters.AddWithValue("@ESTADO_CIVIL", CBoxEstadoCivil.Text);
            comando.Parameters.AddWithValue("@FECHA_INGRE", txtFI.Text);
            comando.Parameters.AddWithValue("@TELEFONO", txtTelefono.Text);
            comando.Parameters.AddWithValue("@CEL", txtCelular.Text);
            comando.Parameters.AddWithValue("@PUESTO", txtPuesto.Text);
            comando.Parameters.AddWithValue("@NSS", txtNss.Text);
            miconexion.Open();
            comando.ExecuteNonQuery();
            miconexion.Close();
            MessageBox.Show("Agregado Correctamente");

        }

        private void VentanaEmpleadoNuevo_Load(object sender, EventArgs e)
        {
            txtNombre.CharacterCasing = CharacterCasing.Upper;
            txtApp.CharacterCasing = CharacterCasing.Upper;
            txtApm.CharacterCasing = CharacterCasing.Upper;
            txtDomicilio.CharacterCasing = CharacterCasing.Upper;
            txtColonia.CharacterCasing =CharacterCasing.Upper;
            txtCP.CharacterCasing= CharacterCasing.Upper;
           
            txtEstado.CharacterCasing= CharacterCasing.Upper;
          
             txtMunicipio.CharacterCasing= CharacterCasing.Upper;
 
         
             
             txtPuesto.CharacterCasing= CharacterCasing.Upper;
            
        }
    }
}

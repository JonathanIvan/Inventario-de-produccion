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
    public partial class VentanaEmpleadoEditar : Form
    {
        private MySqlConnection miconexion = new MySqlConnection("Server=127.0.0.1; Database=inventarioproduccion; Uid=root; Password=208081433;");
        private String id;
        private VentanaEmpleado padre;
        public VentanaEmpleadoEditar(VentanaEmpleado padre, string id)
        {
            this.padre = padre;
            InitializeComponent();
            // TODO: Complete member initialization
            this.id = id;
            this.Text = "ID: " + id;
            carga_datos();
        }

       

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            VentanaEmpleado ventanaempleado = new VentanaEmpleado();
            ventanaempleado.Show();
            this.SetVisibleCore(false);

            
        }

        private void VentanaEmpleadoEditar_Load(object sender, EventArgs e)
        {
            
        }
       


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.SetVisibleCore(false);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            MySqlCommand comando = new MySqlCommand("update empleados set nombre=@NOMBRE,app=@APP,apm=@APM,domicilio=@DOMICILIO,colonia=@COLONIA,cp=@CP,fecha_nac=@FECHA_NAC,estado=@ESTADO,nacionalidad=@NACIONALIDAD,municipio=@MUNICIPIO,sexo=@SEXO,estado_civil=@ESTADO_CIVIL,fecha_ingre=@FECHA_INGRE,telefono=@TEL,cel=@CEL,puesto=@PUESTO,nss=@NSS where idempleados ='" + this.id + "'", miconexion);

            comando.Parameters.AddWithValue("@NOMBRE", txtNombre.Text);
            comando.Parameters.AddWithValue("@APP", txtApp.Text);
            comando.Parameters.AddWithValue("@APM", txtApm.Text);
            comando.Parameters.AddWithValue("@DOMICILIO", txtDomicilio.Text);
            comando.Parameters.AddWithValue("@COLONIA", txtColonia.Text);
            comando.Parameters.AddWithValue("@CP", txtCP.Text);
            comando.Parameters.AddWithValue("@FECHA_NAC", dateTimeFN.Text);
            comando.Parameters.AddWithValue("@ESTADO", txtEstado.Text);
            comando.Parameters.AddWithValue("@NACIONALIDAD", CBoxNacionalidad.Text);
            comando.Parameters.AddWithValue("@MUNICIPIO", txtMunicipio.Text);
            comando.Parameters.AddWithValue("@SEXO", CBoxSexo.Text);
            comando.Parameters.AddWithValue("@ESTADO_CIVIL", CBoxEstadoCivil.Text);
            comando.Parameters.AddWithValue("@FECHA_INGRE", dateTimeFI.Text);
            comando.Parameters.AddWithValue("@TEL", txtTelefono.Text);
            comando.Parameters.AddWithValue("@CEL", txtCelular.Text);
            comando.Parameters.AddWithValue("@PUESTO", txtPuesto.Text);
            comando.Parameters.AddWithValue("@NSS", txtNss.Text);

            miconexion.Open();
            comando.ExecuteNonQuery();
            miconexion.Close();
            MessageBox.Show("Reporte Editado");
            this.padre.carga_Empleado();
        }
        void carga_datos()
        {
            string sql = "SELECT * FROM empleados WHERE idempleados = '" + this.id + "'";
            MySqlCommand comando = new MySqlCommand(sql, miconexion);
            miconexion.Open();
            MySqlDataReader leer = comando.ExecuteReader();
            leer.Read();
            if (!leer.IsDBNull(1))
            {
                this.txtNombre.Text = leer.GetString(1);
            }
            else
            {
                this.txtNombre.Text = " ";
            } if (!leer.IsDBNull(2))
            {
                this.txtApp.Text = leer.GetString(2);
            }
            else
            {
                this.txtApp.Text = " ";
            } if (!leer.IsDBNull(3))
            {
                this.txtApm.Text = leer.GetString(3);
            }
            else
            {
                this.txtApm.Text = " ";
            } if (!leer.IsDBNull(4))
            {
                this.txtDomicilio.Text = leer.GetString(4);
            }
            else
            {
                this.txtDomicilio.Text = " ";
            } if (!leer.IsDBNull(5))
            {
                this.txtColonia.Text = leer.GetString(5);
            }
            else
            {
                this.txtColonia.Text = " ";
            } if (!leer.IsDBNull(6))
            {
                this.txtCP.Text = leer.GetString(6);
            }
            else
            {
                this.txtCP.Text = " ";
            } if (!leer.IsDBNull(7))
            {
                this.dateTimeFN.Text = leer.GetString(7);
            }
            else
            {
                this.dateTimeFN.Text = " ";
            } if (!leer.IsDBNull(8))
            {
                this.txtEstado.Text = leer.GetString(8);
            }
            else
            {
                this.txtEstado.Text = " ";
            } if (!leer.IsDBNull(9))
            {
                this.CBoxNacionalidad.Text = leer.GetString(9);
            }
            else
            {
                this.CBoxNacionalidad.Text = " ";
            } if (!leer.IsDBNull(10))
            {
                this.txtMunicipio.Text = leer.GetString(10);
            }
            else
            {
                this.txtMunicipio.Text = " ";
            } if (!leer.IsDBNull(11))
            {
                this.CBoxSexo.Text = leer.GetString(11);
            }
            else
            {
                this.CBoxSexo.Text = " ";
            } if (!leer.IsDBNull(12))
            {
                this.CBoxEstadoCivil.Text = leer.GetString(12);
            }
            else
            {
                this.CBoxEstadoCivil.Text = " ";
            } if (!leer.IsDBNull(13))
            {
                this.dateTimeFI.Text = leer.GetString(13);
            }
            else
            {
                this.dateTimeFI.Text = " ";
            } if (!leer.IsDBNull(14))
            {
                this.txtTelefono.Text = leer.GetString(14);
            }
            else
            {
                this.txtTelefono.Text = " ";
            } if (!leer.IsDBNull(15))
            {
                this.txtCelular.Text = leer.GetString(15);
            }
            else
            {
                this.txtCelular.Text = " ";
            } if (!leer.IsDBNull(16))
            {
                this.txtPuesto.Text = leer.GetString(16);
            }
            else
            {
                this.txtPuesto.Text = " ";
            } if (!leer.IsDBNull(17))
            {
                this.txtNss.Text = leer.GetString(17);
            }
            else
            {
                this.txtNss.Text = " ";
            }
            miconexion.Close();
        }
    }
}

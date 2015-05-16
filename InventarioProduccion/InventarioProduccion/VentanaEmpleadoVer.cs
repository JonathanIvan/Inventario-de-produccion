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
    public partial class VentanaEmpleadoVer : Form
    {
        private MySqlConnection miconexion = new MySqlConnection("Server=127.0.0.1; Database=inventarioproduccion; Uid=root; Password=208081433;");
        private String id;
        private VentanaEmpleado padre;
 
        public VentanaEmpleadoVer(VentanaEmpleado padre,string id)
        {
            this.padre = padre;
            InitializeComponent();
             this.id = id;
            this.carga_Empleado();
            this.Text = "ID: " + id;

        }

        //public VentanaEmpleadoVer(VentanaEmpleado ventanaEmpleado, string id)
       // {
            // TODO: Complete member initialization
            //this.ventanaEmpleado = ventanaEmpleado;
            //this.id = id;
        //}

         void carga_Empleado() 
        {

            string sql = "SELECT * FROM empleados WHERE idempleados = '" + this.id + "'";
            MySqlCommand comando = new MySqlCommand(sql, miconexion);
            miconexion.Open();
            MySqlDataReader leer = comando.ExecuteReader();
            leer.Read();
            if (!leer.IsDBNull(1))
            {
                this.lblNombree.Text = leer.GetString(1);
            }
            else
            {
                this.lblNombree.Text = "-";
            }
            if (!leer.IsDBNull(2))
            {
                this.lblAppp.Text = leer.GetString(2);
            }
            else {
                this.lblAppp.Text = "-";
            }
            if (!leer.IsDBNull(3))
            {
                this.lblApmm.Text = leer.GetString(3);
            }
            else {
                this.lblApmm.Text = "-";
            }
                if (!leer.IsDBNull(4))
                {
                    this.lblDomicilioo.Text = leer.GetString(4);
                }
                else {
                    this.lblDomicilioo.Text = "-";
                }
                if (!leer.IsDBNull(5))
                {
                    this.lblColoniaa.Text = leer.GetString(5);
                }
                else {
                    this.lblColoniaa.Text = "-";
                } if (!leer.IsDBNull(6))
                {
                    this.lblCpp.Text = leer.GetString(6);
                }
                else {
                    this.lblCpp.Text = "-";
                } if (!leer.IsDBNull(7))
                {
                    this.lblFN.Text = leer.GetString(7);
                }
                else {
                    this.lblFN.Text = "-";
                } if (!leer.IsDBNull(8))
                {
                    this.lblEstadoo.Text = leer.GetString(8);
                } else {
                    this.lblEstadoo.Text = "-";
                }if (!leer.IsDBNull(9))
                {
                    this.lblNacionalidadd.Text = leer.GetString(9);
                }
                else {
                    this.lblNacionalidadd.Text = "-";
                } if (!leer.IsDBNull(10))
                {
                    this.lblMunicipioo.Text = leer.GetString(10);
                }
                else {
                    this.lblMunicipioo.Text = "-";
                } if (!leer.IsDBNull(11))
                {
                    this.lblSexoo.Text = leer.GetString(11);
                }
                else {
                    this.lblSexoo.Text = "-";
                } if (!leer.IsDBNull(12))
                {
                    this.lblEstado_Civil.Text = leer.GetString(12);
                }
                else {
                    this.lblEstado_Civil.Text = "-";
                } if (!leer.IsDBNull(13))
                {
                    this.lblFI.Text = leer.GetString(13);
                }
                else {
                    this.lblFI.Text = "-";
                } if (!leer.IsDBNull(14))
                {
                    this.lblTel.Text = leer.GetString(14);
                }
                else {
                    this.lblTel.Text = "-";
                } if (!leer.IsDBNull(15))
                {
                    this.lblCel.Text = leer.GetString(15);
                }
                else {
                    this.lblCel.Text = "-";
                }if (!leer.IsDBNull(16))
                {
                    this.lblPuestoo.Text = leer.GetString(16);
                }
                else {
                    this.lblPuestoo.Text = "-";
                }if (!leer.IsDBNull(17))
                {
                    this.lblNsss.Text = leer.GetString(17);
                }
                else {
                    this.lblNsss.Text = "-";
                }
            miconexion.Close();
        }


        private void btnRegresar_Click(object sender, EventArgs e)
        {
            VentanaEmpleado ventanaempleado = new VentanaEmpleado();
            ventanaempleado.Show();
            this.SetVisibleCore(false);
        }

        private void btnSesion_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.SetVisibleCore(false);
        }

        
    }
}

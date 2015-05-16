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
    public partial class VentanaReporteEditar : Form
    {
        private MySqlConnection miconexion = new MySqlConnection("Server=127.0.0.1; Database=inventarioproduccion; Uid=root; Password=208081433;");
        private String id;
        private VentanaReporte padre;

        public VentanaReporteEditar(VentanaReporte padre, string id)
        {
            this.padre = padre;
            InitializeComponent();
            // TODO: Complete member initialization
            this.id = id;
            this.Text = "ID: " + id;
            carga_datos();
            txtFecha.Format = DateTimePickerFormat.Custom;
            txtFecha.CustomFormat = "yyyy-MM-dd";
        }
        public VentanaReporteEditar()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            VentanaReporte ventanareporte = new VentanaReporte();
            ventanareporte.Show();

            this.SetVisibleCore(false);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            
            MySqlCommand comando = new MySqlCommand("update reporte set medida=@MEDIDA, color=@COLOR, calibre=@CALIBRE,cantidad=@CANTIDAD, n_operador=@OPERADOR, turno=@TURNO, tipo=@TIPO,fecha=@FECHA where idreporte ='" + this.id + "'", miconexion);

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
            MessageBox.Show("Reporte Editado");
            this.padre.carga_Reporte();
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
                this.txtMedida.Text = leer.GetString(1);
            }
            else
            {
                this.txtMedida.Text = " ";
            } if (!leer.IsDBNull(2))
            {
                this.txtColor.Text = leer.GetString(2);
            }
            else
            {
                this.txtColor.Text = " ";
            } if (!leer.IsDBNull(7))
            {
                this.txtCalibre.Text = leer.GetString(7);
            }
            else
            {
                this.txtCalibre.Text = " ";
            } if (!leer.IsDBNull(3))
            {
                this.txtCantidad.Text = leer.GetString(3);
            }
            else
            {
                this.txtCantidad.Text = " ";
            } if (!leer.IsDBNull(5))
            {
                this.txtOperador.Text = leer.GetString(5);
            }
            else
            {
                this.txtOperador.Text = " ";
            } if (!leer.IsDBNull(4))
            {
                this.CBoxTurno.Text = leer.GetString(4);
            }
            else
            {
                this.CBoxTurno.Text = " ";
            } if (!leer.IsDBNull(6))
            {
                this.CBoxTipo.Text = leer.GetString(6);
            }
            else
            {
                this.CBoxTipo.Text = " ";
            }
            if (!leer.IsDBNull(8))
            {
                this.txtFecha.Text = leer.GetString(8);
            }
            else
            {
                this.CBoxTipo.Text = " ";
            }
            miconexion.Close();
        }

        private void btnSesio_Click(object sender, EventArgs e)
        {
            Login logi =new Login();
            logi.Show();
            this.SetVisibleCore(false);
        }

        private void VentanaReporteEditar_Load(object sender, EventArgs e)
        {
            txtOperador.CharacterCasing = CharacterCasing.Upper;
        }
 
    }
}

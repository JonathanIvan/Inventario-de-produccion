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
using System.Net;
using System.Net.Mail;
namespace InventarioProduccion
{
    public partial class IncidenteCentroAyuda : Form
    {
        public IncidenteCentroAyuda()
        {
            
            InitializeComponent();
        }

        private void comboNPrograma_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        MySqlConnection conexionn = new MySqlConnection("Server=127.0.0.1; Database=inventarioproduccion; Uid=root; Password=208081433;");
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            
            conexionn.Open();

            MySqlCommand cmd = new MySqlCommand("Select * From soporte WHERE nombre = '" + nombre.Text + "' AND problema ='" + problema.Text + "'", conexionn);
            MySqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                MessageBox.Show("Reporte enviadose, (Lo resolveremos lo antes posible) ");
                MySqlCommand update = new MySqlCommand("UPDATE soporte SET incidente = 'Urgencia ALTA'  WHERE nombre = '" + nombre.Text + "' AND problema = '" + problema.Text + "'", conexionn);

                dr.Close();
                cmd.ExecuteNonQuery();
                update.ExecuteNonQuery();
            }
            else
            {

                MessageBox.Show("Reporte Enviandose, en un momento nos pondremos en contacto con usted");

                // INSERTAR

                MySqlCommand insertar = new MySqlCommand("INSERT INTO soporte ( nombre, nom_progra, so, ver_progra, problema, txtproblema, incidente, fecha, hora)" +
                 " VALUES ('" + nombre.Text + "', '" + programa.Text + "', '" + so.Text + "', " +
                 " '" + version.Text + "', '" + problema.Text + "', '" + txtproblema.Text + "', 'Urgencia Normal', " +
                 " '" + fecha.Text + "', '" + hora.Text + "')", conexionn);

                dr.Close();
                cmd.ExecuteNonQuery();
                insertar.ExecuteNonQuery();
            }



            //Correo
            MailMessage _Correo = new MailMessage();
            _Correo.From = new MailAddress("correo.destinatario@gmail.com"); //txtto.text   destinatario

            _Correo.To.Add("jirp.djnavi@gmail.com"); //txt to
            _Correo.Subject = "Inventario de Produccion (REPORTE DE INCIDENTES)";  //txtasunto.txt
            _Correo.Body = "El usuario \n" + "Nombre del Usuario: \n " + nombre.Text + " \n \n " + "Tipo de Problema: \n " + problema.Text + " \n \n Caracteristicas  Del Problema: \n" + txtproblema.Text + " \n" +
                 " \n \n \t  Correo enviado las: " + hora.Text + "hrs El dia: " + fecha.Text;   //txt.cont  y asunto.txt
            _Correo.IsBodyHtml = false;
            _Correo.Priority = MailPriority.Normal;

            SmtpClient smtp = new SmtpClient();
            smtp.Credentials = new NetworkCredential("jirp.djnavi@gmail.com", "208081433");

            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;

            try
            {
                smtp.Send(_Correo);
                MessageBox.Show("El reporte se ha enviado, le atenderemos enseguida");
            }
            catch
            {
                MessageBox.Show("hubo un error al enviar el reporte via e-mail");
            }
            _Correo.Dispose();
            //correo

            // se cierra la conexion
            conexionn.Close();

            //y se cierra la ventana de Reportes volviendo al menu de soporte tecnico
            this.SetVisibleCore(false);
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            CentroAyuda centroayuda = new CentroAyuda();
            centroayuda.Show();
            this.SetVisibleCore(false);
        }

        private void IncidenteCentroAyuda_Load(object sender, EventArgs e)
        {
            nombre.CharacterCasing = CharacterCasing.Upper;
            fecha.Text = DateTime.Now.ToString("dd' de 'MMM' del 'yyyy");
            hora.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnSesion_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.SetVisibleCore(false);
        }

        private void richTextDescripcion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

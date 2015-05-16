using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventarioProduccion
{
    public partial class PrincipalUsuario : Form
    {
        public PrincipalUsuario()
        {
            
            InitializeComponent();
        }
        
        private void btnCentroAyuda_Click(object sender, EventArgs e)
        {
             CentroAyuda centroayuda = new CentroAyuda();

             centroayuda.Show();
             this.SetVisibleCore(false);
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
         VentanaReporteUsuario ventanareporteusuario = new VentanaReporteUsuario();
            ventanareporteusuario.Show();
            this.SetVisibleCore(false);
        }

        private void btnInformacion_Click(object sender, EventArgs e)
        {
            VentanaEmpleado ventanaempleado = new VentanaEmpleado();
            ventanaempleado.Show();
            this.SetVisibleCore(false);
        }
      
        private void btnAdministrador_Click(object sender, EventArgs e)
        {
            VentanaAdministrador ventanaadministrador = new VentanaAdministrador();
            ventanaadministrador.Show();
            this.SetVisibleCore(false);
        }

        private void btnSesion_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.SetVisibleCore(false);
        }

        private void Principal_Load(object sender, EventArgs e)
        {

            btnInformacion.Enabled = false;
            btnAdministrador.Enabled = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

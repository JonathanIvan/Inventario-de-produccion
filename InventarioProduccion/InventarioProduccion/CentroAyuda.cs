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
    public partial class CentroAyuda : Form
    {
        public CentroAyuda()
        {
            InitializeComponent();
        }

        private void CentroAyuda_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            RegistoCentroAyuda registocentroayuda = new RegistoCentroAyuda();

            registocentroayuda.Show();
            this.SetVisibleCore(false);
        }

        private void btnSesion_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.SetVisibleCore(false);
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            IncidenteCentroAyuda incidentecentroayuda = new IncidenteCentroAyuda();
            incidentecentroayuda.Show();
            this.SetVisibleCore(false);
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            principal.Show();
            this.SetVisibleCore(false);
        }
    }
}

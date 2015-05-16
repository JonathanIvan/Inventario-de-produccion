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
    class VentanaReporteEliminar
    {
        private MySqlConnection miconexion = new MySqlConnection("Server=127.0.0.1; Database=inventarioproduccion; Uid=root; Password=208081433;");
        private String id;
        private VentanaReporte padre;

        public VentanaReporteEliminar(VentanaReporte padre, string id)
        {
            this.padre = padre;
       
            this.id = id;

            DialogResult resultado = MessageBox.Show("¿Realmende desea Eliminar Reporte", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.No)
            {
                return;
            }
            this.carga_Contacto();
        }


        public void carga_Contacto()
        {
            
            MySqlCommand comando = new MySqlCommand("Delete FROM reporte where idreporte ='" + this.id + "'", miconexion);
            
            miconexion.Open();
            comando.ExecuteNonQuery();
            miconexion.Close();
           MessageBox.Show("Reporte Borrado Correctamente");
           this.padre.carga_Reporte();
    }
    }
}

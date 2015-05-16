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
using Microsoft.Office.Interop.Excel;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html;
using iTextSharp.text.html.simpleparser;




namespace InventarioProduccion
{
    public partial class VentanaReporteBuscarUsuario : Form
    {
        public VentanaReporteBuscarUsuario()
        {
            InitializeComponent();
        }
        MySqlConnection miconexion = new MySqlConnection("Server=127.0.0.1; Database=inventarioproduccion; Uid=root; Password=208081433;");

        private void VentanaReporteBuscarUsuario_Load(object sender, EventArgs e)
        {
            carga_ReporteUsuario();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            carga_ReporteUsuario();
        }
        public void carga_ReporteUsuario()
        {
            txtFechaBU.Format = DateTimePickerFormat.Custom;
            txtFechaBU.CustomFormat = "yyyy-MM-dd";
            MySqlCommand comando = new MySqlCommand("select *from reporte where fecha=@FECHA", miconexion);
            comando.Parameters.AddWithValue("@FECHA", txtFechaBU.Text);
            miconexion.Open();
            MySqlDataReader leer = comando.ExecuteReader();
            dataGridReporteBU.Rows.Clear();

            int renglon = 0;

            while (leer.Read())
            {

                renglon = dataGridReporteBU.Rows.Add();
                dataGridReporteBU.Rows[renglon].Cells["txtturno"].Value = leer.GetString(4);
                dataGridReporteBU.Rows[renglon].Cells["txtoperador"].Value = leer.GetString(5);
                dataGridReporteBU.Rows[renglon].Cells["txtmedida"].Value = leer.GetString(1);
                dataGridReporteBU.Rows[renglon].Cells["txtcolor"].Value = leer.GetString(2);
                dataGridReporteBU.Rows[renglon].Cells["txtcantidad"].Value = leer.GetString(3);
                dataGridReporteBU.Rows[renglon].Cells["txtcalibre"].Value = leer.GetString(7);
                dataGridReporteBU.Rows[renglon].Cells["txttipo"].Value = leer.GetString(6);
                dataGridReporteBU.Rows[renglon].Cells["txtfecha"].Value = leer.GetString(8);
               
            }
            miconexion.Close();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            SaveFileDialog fichero = new SaveFileDialog();
            fichero.Filter = "Excel (*.xls)|*.xls";
            if (fichero.ShowDialog() == DialogResult.OK)
            {
                Microsoft.Office.Interop.Excel.Application aplicacion;
                Microsoft.Office.Interop.Excel.Workbook libros_trabajo;
                Microsoft.Office.Interop.Excel.Worksheet hoja_trabajo;
                aplicacion = new Microsoft.Office.Interop.Excel.Application();
                libros_trabajo = aplicacion.Workbooks.Add();
                hoja_trabajo =
                    (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);

                //Recorremos el DataGridView rellenando la hoja de trabajo
                for (int i = 0; i < dataGridReporteBU.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dataGridReporteBU.Columns.Count; j++)
                    {
                        hoja_trabajo.Cells[i + 1, j + 1] = dataGridReporteBU.Rows[i].Cells[j].Value.ToString();
                    }
                }
                libros_trabajo.SaveAs(fichero.FileName,
                    Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                libros_trabajo.Close(true);
                aplicacion.Quit();
            }
        }

        private void btnSesio_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.SetVisibleCore(false);

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            VentanaReporteUsuario ventanareporteusuario = new VentanaReporteUsuario();
            ventanareporteusuario.Show();

            this.SetVisibleCore(false);
        }

        private void btnWord_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "Word Documents (*.doc)|*.doc";
            sfd.FileName = "export.doc";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                //ToCsV(dataGridView1, @"c:\export.xls");
                ToCsV(dataGridReporteBU, sfd.FileName); // Here dataGridview1 is your grid view name 
            }
        }

        private void ToCsV(DataGridView dataGridReporteBU, string filename)
        {
            string stOutput = " ";

            string stEmpre = "";
            stEmpre = stEmpre.ToString() + "\t\t\t" + "Agrofilm De Mexico S.A. de C.V." + "\t";
            stOutput += stEmpre + "\t\r\n";

            string stbarritas = "";
            stbarritas = stbarritas.ToString() + ("\n") + "________________________________________________________________________" + "\t";
            stOutput += stbarritas + "\t\r\n";

           string fecha="";
           fecha = fecha.ToString() + "\n\n\n" + "\t\t\t\t\t\t\t\t\t" + DateTime.Now.ToString(" dd' de 'MMMM' del 'yyyy");
           stOutput += fecha + "\t\r\n\n\n";

           string stAsun = "";
           stAsun = stAsun.ToString() + "\t" + "Reporte de producción:" + "\t";
           stOutput += stAsun + "\t\r\n";

            // Export titles:
            string sHeaders = "";
            for (int j = 0; j < dataGridReporteBU.Columns.Count; j++)
                sHeaders = sHeaders.ToString()+ Convert.ToString(dataGridReporteBU.Columns[j].HeaderText) + "\t";
            stOutput += sHeaders + "\r\n";

            // Export data.
            for (int i = 0; i < dataGridReporteBU.RowCount - 1; i++)
            {
                string stLine = "";
                for (int j = 0; j < dataGridReporteBU.Rows[i].Cells.Count; j++)
                    stLine = stLine.ToString() + Convert.ToString(dataGridReporteBU.Rows[i].Cells[j].Value) + "\t";
                stOutput += stLine + "\r\n";
            }

            string stUbicacion = "";
            stUbicacion = stUbicacion.ToString() + "\n\n\n\n\n\n\n\n\n\n" + "Av. Cinco de Febrero No. 53, Colonia Las Conchas,Guadalajara, Jalisco,México" + "\r" + "Teléfonos: (33) 3619 0074 y 3619 5757" + "\t";
            stOutput += stUbicacion + "\t\r\n";

            Encoding utf16 = Encoding.GetEncoding(1254);
            byte[] output = utf16.GetBytes(stOutput);
            FileStream fs = new FileStream(filename, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(output, 0, output.Length); //write the encoded file
            bw.Flush();
            bw.Close();
            fs.Close();
        }

        
    }
}

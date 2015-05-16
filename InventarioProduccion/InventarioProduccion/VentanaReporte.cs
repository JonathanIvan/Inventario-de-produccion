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

namespace InventarioProduccion
{
    public partial class VentanaReporte : Form
    {
        public VentanaReporte()
        {
            InitializeComponent();
        }
        MySqlConnection miconexion = new MySqlConnection("Server=127.0.0.1; Database=inventarioproduccion; Uid=root; Password=208081433;");
        
        public void carga_Reporte() {
            MySqlCommand comando = new MySqlCommand("select *from reporte", miconexion);
            miconexion.Open();
            MySqlDataReader leer = comando.ExecuteReader();
            dataGridReporte.Rows.Clear();

            int renglon = 0;

            while (leer.Read())
            {

              renglon = dataGridReporte.Rows.Add();
              dataGridReporte.Rows[renglon].Cells["txtturno"].Value = leer.GetString(4);
              dataGridReporte.Rows[renglon].Cells["txtoperador"].Value = leer.GetString(5);
              dataGridReporte.Rows[renglon].Cells["txtmedida"].Value = leer.GetString(1);
              dataGridReporte.Rows[renglon].Cells["txtcolor"].Value = leer.GetString(2);
              dataGridReporte.Rows[renglon].Cells["txtcantidad"].Value = leer.GetString(3);
              dataGridReporte.Rows[renglon].Cells["txtcalibre"].Value = leer.GetString(7);
              dataGridReporte.Rows[renglon].Cells["txttipo"].Value = leer.GetString(6);
              dataGridReporte.Rows[renglon].Cells["txtfecha"].Value = leer.GetString(8);

              DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn();
              btnEliminar.Name = "eliminar_" + leer.GetString(0);
              dataGridReporte.Rows[renglon].Cells["btnEliminar"].Value = btnEliminar;

              DataGridViewButtonColumn btnEditar = new DataGridViewButtonColumn();
              btnEditar.Name = "editar_" + leer.GetString(0);
              dataGridReporte.Rows[renglon].Cells["btnEditar"].Value = btnEditar;
          }
          miconexion.Close();
        }


        private void btnNuevo_Click(object sender, EventArgs e)
        {
            VentanaReporteNuevo ventanareportenuevo = new VentanaReporteNuevo();
            ventanareportenuevo.Show();
            this.SetVisibleCore(false);
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
                for (int i = 0; i < dataGridReporte.Rows.Count-1 ; i++)
                {
                    for (int j = 0; j < dataGridReporte.Columns.Count; j++)
                    {
                        hoja_trabajo.Cells[i + 1, j + 1] = dataGridReporte.Rows[i].Cells[j].Value.ToString();
                    }
                }
                libros_trabajo.SaveAs(fichero.FileName,
                    Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                libros_trabajo.Close(true);
                aplicacion.Quit();
            }
        }

        

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            principal.Show();

            this.SetVisibleCore(false);
        }

        private void VentanaReporte_Load(object sender, EventArgs e)
        {
             carga_Reporte();
        }

        private void dataGridReporte_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridReporte.Columns["btnEditar"].Index)
            {
                DataGridViewButtonColumn boton = (DataGridViewButtonColumn)dataGridReporte.Rows[e.RowIndex].Cells["btnEditar"].Value;
                String id = boton.Name.Replace("editar_", "");
                VentanaReporteEditar editar = new VentanaReporteEditar(this, id);
                editar.Show();
                this.SetVisibleCore(false);
            }else if (e.ColumnIndex == dataGridReporte.Columns["btnEliminar"].Index)
            {
                DataGridViewButtonColumn boton = (DataGridViewButtonColumn)dataGridReporte.Rows[e.RowIndex].Cells["btnEliminar"].Value;
                String id = boton.Name.Replace("eliminar_", "");
                VentanaReporteEliminar eliminar = new VentanaReporteEliminar(this, id);
            }
            
        }

        private void btnSesio_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.SetVisibleCore(false);

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            VentanaReporteBuscarUsuario ventana = new VentanaReporteBuscarUsuario();
            ventana.Show();
            this.SetVisibleCore(false);
        }
    }
}

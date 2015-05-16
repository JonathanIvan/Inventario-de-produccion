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
    public partial class VentanaEmpleado : Form
    {
        public VentanaEmpleado()
        {
            InitializeComponent();
        }

        MySqlConnection miconexion = new MySqlConnection("Server=127.0.0.1; Database=inventarioproduccion; Uid=root; Password=208081433;");

        public void carga_Empleado()
        {
            MySqlCommand comando = new MySqlCommand("select *from empleados", miconexion);
            miconexion.Open();
            MySqlDataReader leer = comando.ExecuteReader();
            dataGridEmpleado.Rows.Clear();

            int renglon = 0;

            while (leer.Read())
            {

                renglon = dataGridEmpleado.Rows.Add();
                dataGridEmpleado.Rows[renglon].Cells["txtNombre"].Value = leer.GetString(1);
                dataGridEmpleado.Rows[renglon].Cells["txtApp"].Value = leer.GetString(2);
                dataGridEmpleado.Rows[renglon].Cells["txtApm"].Value = leer.GetString(3);
                dataGridEmpleado.Rows[renglon].Cells["txtNss"].Value = leer.GetString(17);
                

                DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn();
                btnEliminar.Name = "eliminar_" + leer.GetString(0);
                dataGridEmpleado.Rows[renglon].Cells["btnEliminar"].Value = btnEliminar;

                DataGridViewButtonColumn btnEditar = new DataGridViewButtonColumn();
                btnEditar.Name = "editar_" + leer.GetString(0);
                dataGridEmpleado.Rows[renglon].Cells["btnEditar"].Value = btnEditar;

                DataGridViewButtonColumn btnVer = new DataGridViewButtonColumn();
                btnVer.Name = "ver_" + leer.GetString(0);
                dataGridEmpleado.Rows[renglon].Cells["btnVer"].Value = btnVer;
            }
            miconexion.Close();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            principal.Show();

            this.SetVisibleCore(false);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            VentanaEmpleadoNuevo ventanaempleadonuevo = new VentanaEmpleadoNuevo();
            ventanaempleadonuevo.Show();
            this.SetVisibleCore(false);
        }

        private void VentanaEmpleado_Load(object sender, EventArgs e)
        {
            carga_Empleado();
        }

        private void dataGridEmpleado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridEmpleado.Columns["btnEditar"].Index)
            {
                DataGridViewButtonColumn boton = (DataGridViewButtonColumn)dataGridEmpleado.Rows[e.RowIndex].Cells["btnEditar"].Value;
                String id = boton.Name.Replace("editar_", "");
                VentanaEmpleadoEditar editar = new VentanaEmpleadoEditar(this, id);
                editar.Show();
                this.SetVisibleCore(false);
            }
            else if (e.ColumnIndex == dataGridEmpleado.Columns["btnEliminar"].Index)
            {
                DataGridViewButtonColumn boton = (DataGridViewButtonColumn)dataGridEmpleado.Rows[e.RowIndex].Cells["btnEliminar"].Value;
                String id = boton.Name.Replace("eliminar_", "");
               VentanaEmpleadoEliminar eliminar = new VentanaEmpleadoEliminar(this, id);
            }
            else if (e.ColumnIndex == dataGridEmpleado.Columns["btnVer"].Index)
            {
                DataGridViewButtonColumn boton = (DataGridViewButtonColumn)dataGridEmpleado.Rows[e.RowIndex].Cells["btnVer"].Value;
                String id = boton.Name.Replace("ver_", "");
                VentanaEmpleadoVer ver = new VentanaEmpleadoVer(this, id);
                ver.Show();
                this.SetVisibleCore(false);
            }
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
                for (int i = 0; i < dataGridEmpleado.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dataGridEmpleado.Columns.Count; j++)
                    {
                        hoja_trabajo.Cells[i + 1, j + 1] = dataGridEmpleado.Rows[i].Cells[j].Value.ToString();
                    }
                }
                libros_trabajo.SaveAs(fichero.FileName,
                    Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                libros_trabajo.Close(true);
                aplicacion.Quit();
            }
        }

        private void btnSesion_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.SetVisibleCore(false);
        }
    }
}

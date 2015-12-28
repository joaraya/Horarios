using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Horarios.Logica;

namespace Horarios.Interfaz
{
    public partial class Choques : Form
    {
        public Choques()
        {
            InitializeComponent();
        }

        private void Choques_Load(object sender, EventArgs e)
        {
            try
            {
                dgvChoques.DataSource = Horarios.Logica.ManejoExcel.horario.Tables["CHOQUES"];
            }
            catch (Exception)
            {
                dgvChoques.Refresh();
                MessageBox.Show("Ha ocurrido un error al obtener los choques, favor procesar los datos primero para poder ver los choques.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExportarDataGridViewExcel(dgvChoques);
        }

        /// <summary>
        /// Método que exporta a un fichero Excel el contenido de un DataGridView
        /// </summary>
        /// <param name="grd">DataGridView que contiene los datos a exportar</param>
        static void ExportarDataGridViewExcel(DataGridView grd)
        {
            SaveFileDialog fichero = new SaveFileDialog();
            fichero.Filter = "Excel (*.xls)|*.xls";
            if (fichero.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Microsoft.Office.Interop.Excel.Application aplicacion;
                    Microsoft.Office.Interop.Excel.Workbook libros_trabajo;
                    Microsoft.Office.Interop.Excel.Worksheet hoja_trabajo;
                    aplicacion = new Microsoft.Office.Interop.Excel.Application();
                    libros_trabajo = aplicacion.Workbooks.Add();
                    hoja_trabajo =
                        (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);

                    /// agregamos los headers
                    int headerCount = 1;
                    foreach (DataGridViewColumn c in grd.Columns)
                    {
                        hoja_trabajo.Cells[1, headerCount] = c.HeaderText.ToString();
                        headerCount++;
                    }

                    //Recorremos el DataGridView rellenando la hoja de trabajo


                    /**/

                    //horario.Tables.Add(new DataTable("CHOQUES"));
                    //horario.Tables["CHOQUES"].Columns.Add("DIA");
                    //horario.Tables["CHOQUES"].Columns.Add("SECCION");
                    //horario.Tables["CHOQUES"].Columns.Add("LECCION");
                    //horario.Tables["CHOQUES"].Columns.Add("PROFESOR");


                    DataGridViewRow cachedRow = null;
                    String allSections = "";
                    int i = 0;
                    foreach (DataGridViewRow row in grd.Rows)
                    {
                        if (cachedRow == null || (row.Cells["DIA"].Value != null && row.Cells["DIA"].Value.Equals(cachedRow.Cells["DIA"].Value) && row.Cells["LECCION"].Value.Equals(cachedRow.Cells["LECCION"].Value)
                            && row.Cells["PROFESOR"].Value.Equals(cachedRow.Cells["PROFESOR"].Value)))
                        {
                            allSections += row.Cells["SECCION"].Value + " / ";
                        }
                        else
                        {
                            //cachedRow.Cells["SECCION"].Value = allSections;
                            hoja_trabajo.Cells[i + 2, 1] = cachedRow.Cells["DIA"].Value;
                            hoja_trabajo.Cells[i + 2, 2] = allSections;
                            hoja_trabajo.Cells[i + 2, 3] = cachedRow.Cells["LECCION"].Value;
                            hoja_trabajo.Cells[i + 2, 4] = cachedRow.Cells["PROFESOR"].Value;
                            allSections = row.Cells["SECCION"].Value + " / ";
                            i++;

                        }
                        cachedRow = row;// hace una copia no ref
                    }


                    /**/
 
                    //for (int i = 0; i < grd.Rows.Count - 1; i++)
                    //{
                    //    for (int j = 0; j < grd.Columns.Count; j++)
                    //    {
                    //        string textoActual = grd.Rows[i].Cells[j].FormattedValue.ToString();
                    //       hoja_trabajo.Cells[i + 2, j + 1] = textoActual.Contains("-") ? "  " + textoActual : textoActual;
                    //    }
                    //}


                    libros_trabajo.SaveAs(fichero.FileName,
                        Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                    libros_trabajo.Close(true);
                    aplicacion.Quit();
                    MessageBox.Show("Se han exportado satisfactoriamente los datos.");
                }
                catch(Exception ex){
                    MessageBox.Show("Ha ocurrido un error al exportar los datos.");
                }
            }
        }
    }
}

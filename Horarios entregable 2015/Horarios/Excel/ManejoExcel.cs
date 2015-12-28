using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace Horarios.Logica
{
    class ManejoExcel
    {
        public static DataSet horario {get;set;}

        private static void InicializarDataset()
        {
            horario = new DataSet();

            horario.Tables.Add(new System.Data.DataTable("LECCIONES"));
            horario.Tables["LECCIONES"].Columns.Add("DIA");
            horario.Tables["LECCIONES"].Columns.Add("SECCION");
            horario.Tables["LECCIONES"].Columns.Add("LECCION");
            horario.Tables["LECCIONES"].Columns.Add("PROFESOR");

            horario.Tables.Add(new System.Data.DataTable("CHOQUES"));
            horario.Tables["CHOQUES"].Columns.Add("DIA");
            horario.Tables["CHOQUES"].Columns.Add("SECCION");
            horario.Tables["CHOQUES"].Columns.Add("LECCION");
            horario.Tables["CHOQUES"].Columns.Add("PROFESOR");
        
        }
        private static string  generarLetras(int i)
        {
            if (i < 51)
            {   //// se inicia desde B por cuestiones de formato
                string[] letras = {"B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "AA", "AB", "AC", "AD", "AE", "AF", "AG", "AH", "AI", "AJ", "AK", "AL", "AM", "AN", "AO", "AP", "AQ", "AR", "AS", "AT", "AU", "AV", "AW", "AX", "AY", "AZ" };
                return letras[i];
            }
            else
                return "";           
        }

        public static void obtenerDatosExcel(string rutaArchivo, string nombreHoja, int[] cantDias,int cantSecciones)
        {
            InicializarDataset();

            int cantidaEntradas = 0;
            Microsoft.Office.Interop.Excel._Application xlApp;
            Microsoft.Office.Interop.Excel._Workbook xlLibro = null;
            Microsoft.Office.Interop.Excel._Worksheet xlHoja1 = null;
            Microsoft.Office.Interop.Excel.Sheets xlHojas = null;
            xlApp = new Microsoft.Office.Interop.Excel.Application();
            xlApp.Visible = false;
            try
            {
                xlLibro = xlApp.Workbooks.Open(rutaArchivo, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
                xlHojas = xlLibro.Sheets;
                xlHoja1 = (Microsoft.Office.Interop.Excel._Worksheet)xlHojas[nombreHoja];

                for (int seccionActual = 0; seccionActual < cantSecciones; seccionActual++)
                {
                    string dia = "";
                    string letraColExcel = generarLetras(seccionActual); // la letra de Excel para la seccion
                    string seccion = (string)xlHoja1.get_Range(letraColExcel + 1, Missing.Value).Text;

                    //// la cantidad de filas a recorrer son iguales a la suma de la cantidad de lecciones por dia 
                    /// mas 7 que son las celdas de los dias y la de la seccion y considerar el <
                    int cantFilas = cantDias[0] + cantDias[1] + cantDias[2] + cantDias[3] + cantDias[4] + 7;
                    int cantLecActual = cantDias[0]; // el # de lecciones por dia actual indica cuando se debe cambiar de dia y # de leccion actual
                    int diaActual = 0; //// representa el dia que se esta leyendo actualemente 0->Lunes 1->Martes...
                    //// el for inicia en 2 ya que se inicia con colunma X+2 para leer el Lunes ignorando la casilla de seccion
                    for (int i = 2; i < cantFilas; i++)
                    {
                        // si cambio de dia, no inserto nada 
                        if (cantLecActual == cantDias[diaActual])
                        {
                            dia = (string)xlHoja1.get_Range(letraColExcel + i, Missing.Value).Text; // se toma el dia correspondiente
                            cantLecActual = 0;   /// se reinicia el contador de lecciones
                            if (!(dia.ToLower().Equals("lunes"))) /// se mueve de dia excepto por el lunes al ser el primero
                                diaActual++;
                        }
                        // se inserta normalmente
                        else
                        {
                            cantLecActual++;
                            /// por cada entrada del excel se hace esto
                            object[] parametros = new object[4];
                           // parametros[0] = contadorCeldas;
                            parametros[0] = dia;
                            parametros[1] = seccion;
                            parametros[2] = cantLecActual;                         
                            parametros[3] = (string)xlHoja1.get_Range(letraColExcel + i, Missing.Value).Text;
                            string profesor = parametros[3].ToString();

                            /// AGREGO UNA NUEVA FILA(LECCION) AL DATASET
                            DataRow nuevaLeccion = horario.Tables["LECCIONES"].NewRow();
                            nuevaLeccion["DIA"] = dia;
                            nuevaLeccion["SECCION"] = seccion;
                            nuevaLeccion["LECCION"] = cantLecActual;
                            nuevaLeccion["PROFESOR"] = profesor;
                            horario.Tables["LECCIONES"].Rows.Add(nuevaLeccion);

                            var choques = from row in horario.Tables["LECCIONES"].AsEnumerable()
                                          where (
                                                  row.Field<string>("DIA").Equals(dia) && 
                                                  row.Field<string>("LECCION").Equals(cantLecActual.ToString())  &&
                                                  row.Field<string>("PROFESOR").Equals(profesor) && profesor != ""
                                                )
                                          select (row);
                            
                            if(choques.Count() > 1)
                            {
                                foreach (var choque in choques)
                                {
                                    DataRow nuevoChoque = horario.Tables["CHOQUES"].NewRow();
                                    nuevoChoque["DIA"] = choque.Field<string>("DIA");
                                    nuevoChoque["SECCION"] = choque.Field<string>("SECCION");
                                    nuevoChoque["LECCION"] = choque.Field<string>("LECCION");
                                    nuevoChoque["PROFESOR"] = choque.Field<string>("PROFESOR");
                                    horario.Tables["CHOQUES"].Rows.Add(nuevoChoque);
                                }
                            }
                            cantidaEntradas++;
                        }
                    }
                }
                MessageBox.Show("Se ha procesado exitosamente el horario, " + cantidaEntradas+ " entradas procesadas.", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (System.Runtime.InteropServices.COMException)
            {
                if(xlLibro == null)
                    MessageBox.Show("Por favor verifique que el archivo escogido aún existe en la carpeta seleccionada.", "ERROR DE LECTURA DE ARCHIVO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (xlHoja1 == null)
                    MessageBox.Show("Por favor verifique que el nombre de la hoja especificado en donde se encuentran los registros sea el correcto.", "ERROR DE LECTURA DE ARCHIVO", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al procesar el horario, favor revise que el formato sea el correcto.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (xlLibro != null)
                    xlLibro.Close(false, Missing.Value, Missing.Value);
                xlApp.Quit();
                
            }
        }
    }
}

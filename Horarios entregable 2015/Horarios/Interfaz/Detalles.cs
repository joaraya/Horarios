using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace Horarios.Interfaz
{
    public partial class Detalles : Form
    {
        public Detalles()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            obtenerHorario(dataGridView1,textBox1.Text,comboBox1.Text);
        }

        private static void obtenerHorario(DataGridView dg, string nombre, string tipo)
        {
            //OracleConnection conn = AbrirConexionOracle();
            //try
            //{
            //    OracleCommand cmd = new OracleCommand();
            //    OracleDataAdapter da = new OracleDataAdapter();
            //    cmd.Connection = conn;

            //    /// nombre y tipo de comando a ejecutar
            //    cmd.CommandText = "obtenerHorarioSeccion";
            //    if(tipo.Equals("Profesor"))
            //        cmd.CommandText = "obtenerHorarioProf";

            //    cmd.CommandType = CommandType.StoredProcedure;

            //    //// parametros de entrada
            //    cmd.Parameters.Add("nombre", OracleDbType.Varchar2).Value = nombre;
            //    cmd.Parameters.Add("c_resultados", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

            //     da.SelectCommand = cmd;
            //     DataSet ds = new DataSet();
            //     da.Fill(ds, "Lecciones");
            //     dg.DataSource = ds;
            //     dg.DataMember = "Lecciones";
            //     dg.Refresh();       

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //}
            //finally
            //{
            //    conn.Close();
            //}


            //horario.Tables["LECCIONES"].Rows.Add(nuevaLeccion);

            //var choques = from row in horario.Tables["LECCIONES"].AsEnumerable()
            //              where (
            //                      row.Field<string>("DIA").Equals(dia) &&
            //                      row.Field<string>("LECCION").Equals(cantLecActual.ToString()) &&
            //                      row.Field<string>("PROFESOR").Equals(profesor) && profesor != ""
            //                    )
            //              select (row);

            //if (choques.Count() > 1)
            //{
            //    foreach (var choque in choques)
            //    {
            //        DataRow nuevoChoque = horario.Tables["CHOQUES"].NewRow();
            //        nuevoChoque["DIA"] = choque.Field<string>("DIA");
            //        nuevoChoque["SECCION"] = choque.Field<string>("SECCION");
            //        nuevoChoque["LECCION"] = choque.Field<string>("LECCION");
            //        nuevoChoque["PROFESOR"] = choque.Field<string>("PROFESOR");
            //        horario.Tables["CHOQUES"].Rows.Add(nuevoChoque);
            //    }
            //}
        
        }
    }
}

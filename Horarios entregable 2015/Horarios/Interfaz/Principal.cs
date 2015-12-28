using Horarios.Interfaz;
using Horarios.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Horarios
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private int[] obtenerNumeroFilas()
        {
            int[] dias=new int[5];
            //dias[0] = (int)LeccionesLunes.Value;
            //dias[1] = (int)LeccionesMartes.Value;
            //dias[2] = (int)LeccionesMiercoles.Value;
            //dias[3] = (int)LeccionesJueves.Value;
            //dias[4] = (int)LeccionesViernes.Value;
            return dias;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // ManejoExcel.obtenerDatosExcel(label2.Text,txtNombreHoja.Text,obtenerNumeroFilas(),(int)totalSecciones.Value);
        }

     


        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Archivos Excel (*.xlsx)|*.xlsx*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                 label2.Text=openFileDialog1.FileName;
            }
        }


        private void button3_Click_1(object sender, EventArgs e)
        {
            Detalles v2 = new Detalles();
            v2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Choques ch = new Choques();
            ch.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            var checkBox = sender as CheckBox;
            lblTitNombreHoja.Visible=!checkBox.Checked;
            txtNombreHoja.Visible = !checkBox.Checked;    
        }

   
    }
}

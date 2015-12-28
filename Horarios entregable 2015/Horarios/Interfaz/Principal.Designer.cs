namespace Horarios
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnProcesarDatos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnSeleccionarArchivo = new System.Windows.Forms.Button();
            this.lblTitNombreHoja = new System.Windows.Forms.Label();
            this.txtNombreHoja = new System.Windows.Forms.TextBox();
            this.btnVerChoques = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTitPlantillaCole = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnProcesarDatos
            // 
            this.btnProcesarDatos.BackColor = System.Drawing.Color.Teal;
            this.btnProcesarDatos.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcesarDatos.ForeColor = System.Drawing.Color.White;
            this.btnProcesarDatos.Location = new System.Drawing.Point(130, 29);
            this.btnProcesarDatos.Name = "btnProcesarDatos";
            this.btnProcesarDatos.Size = new System.Drawing.Size(103, 62);
            this.btnProcesarDatos.TabIndex = 1;
            this.btnProcesarDatos.Text = "Procesar Datos";
            this.btnProcesarDatos.UseVisualStyleBackColor = false;
            this.btnProcesarDatos.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ruta del archivo";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(244, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(366, 21);
            this.label2.TabIndex = 4;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnSeleccionarArchivo
            // 
            this.btnSeleccionarArchivo.BackColor = System.Drawing.Color.Teal;
            this.btnSeleccionarArchivo.ForeColor = System.Drawing.Color.White;
            this.btnSeleccionarArchivo.Location = new System.Drawing.Point(616, 30);
            this.btnSeleccionarArchivo.Name = "btnSeleccionarArchivo";
            this.btnSeleccionarArchivo.Size = new System.Drawing.Size(36, 23);
            this.btnSeleccionarArchivo.TabIndex = 5;
            this.btnSeleccionarArchivo.Text = "...";
            this.btnSeleccionarArchivo.UseVisualStyleBackColor = false;
            this.btnSeleccionarArchivo.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblTitNombreHoja
            // 
            this.lblTitNombreHoja.AutoSize = true;
            this.lblTitNombreHoja.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblTitNombreHoja.ForeColor = System.Drawing.Color.White;
            this.lblTitNombreHoja.Location = new System.Drawing.Point(22, 166);
            this.lblTitNombreHoja.Name = "lblTitNombreHoja";
            this.lblTitNombreHoja.Size = new System.Drawing.Size(168, 22);
            this.lblTitNombreHoja.TabIndex = 21;
            this.lblTitNombreHoja.Text = "Nombre de la hoja";
            this.lblTitNombreHoja.Visible = false;
            // 
            // txtNombreHoja
            // 
            this.txtNombreHoja.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreHoja.ForeColor = System.Drawing.Color.Black;
            this.txtNombreHoja.Location = new System.Drawing.Point(244, 166);
            this.txtNombreHoja.Name = "txtNombreHoja";
            this.txtNombreHoja.Size = new System.Drawing.Size(408, 26);
            this.txtNombreHoja.TabIndex = 22;
            this.txtNombreHoja.Visible = false;
            // 
            // btnVerChoques
            // 
            this.btnVerChoques.BackColor = System.Drawing.Color.Teal;
            this.btnVerChoques.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.btnVerChoques.ForeColor = System.Drawing.Color.White;
            this.btnVerChoques.Location = new System.Drawing.Point(384, 29);
            this.btnVerChoques.Name = "btnVerChoques";
            this.btnVerChoques.Size = new System.Drawing.Size(103, 62);
            this.btnVerChoques.TabIndex = 23;
            this.btnVerChoques.Text = "Verificar Choques";
            this.btnVerChoques.UseVisualStyleBackColor = false;
            this.btnVerChoques.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnVerChoques);
            this.groupBox1.Controls.Add(this.btnProcesarDatos);
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(26, 208);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(626, 115);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            // 
            // lblTitPlantillaCole
            // 
            this.lblTitPlantillaCole.AutoSize = true;
            this.lblTitPlantillaCole.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblTitPlantillaCole.ForeColor = System.Drawing.Color.White;
            this.lblTitPlantillaCole.Location = new System.Drawing.Point(22, 84);
            this.lblTitPlantillaCole.Name = "lblTitPlantillaCole";
            this.lblTitPlantillaCole.Size = new System.Drawing.Size(182, 22);
            this.lblTitPlantillaCole.TabIndex = 25;
            this.lblTitPlantillaCole.Text = "Plantilla del colegio";
            // 
            // comboBox1
            // 
            this.comboBox1.ForeColor = System.Drawing.Color.Black;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(244, 88);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(408, 21);
            this.comboBox1.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(22, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 22);
            this.label4.TabIndex = 27;
            this.label4.Text = "Usar primera hoja";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(244, 135);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 28;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(694, 343);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblTitPlantillaCole);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtNombreHoja);
            this.Controls.Add(this.lblTitNombreHoja);
            this.Controls.Add(this.btnSeleccionarArchivo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmPrincipal";
            this.Text = "Control de Horarios";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProcesarDatos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnSeleccionarArchivo;
        private System.Windows.Forms.Label lblTitNombreHoja;
        private System.Windows.Forms.TextBox txtNombreHoja;
        private System.Windows.Forms.Button btnVerChoques;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTitPlantillaCole;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}


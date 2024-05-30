namespace Laboratoriofinal2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonPrueba = new System.Windows.Forms.Button();
            this.Buttoncargar = new System.Windows.Forms.Button();
            this.dataGridViewTabla_contenido = new System.Windows.Forms.DataGridView();
            this.Buttoninsertar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxNombrecon = new System.Windows.Forms.TextBox();
            this.textBoxCampañia = new System.Windows.Forms.TextBox();
            this.textBoxGeneracion = new System.Windows.Forms.TextBox();
            this.dateTimePickerAñolanzamiento = new System.Windows.Forms.DateTimePicker();
            this.buttonActualizar = new System.Windows.Forms.Button();
            this.buttonborrar = new System.Windows.Forms.Button();
            this.ButtonBuscarCompañia = new System.Windows.Forms.Button();
            this.textBoxbuscarcompañia = new System.Windows.Forms.TextBox();
            this.dataGridViewResultados = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTabla_contenido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonPrueba
            // 
            this.ButtonPrueba.Location = new System.Drawing.Point(12, 164);
            this.ButtonPrueba.Name = "ButtonPrueba";
            this.ButtonPrueba.Size = new System.Drawing.Size(133, 49);
            this.ButtonPrueba.TabIndex = 1;
            this.ButtonPrueba.Text = "PRUEBA";
            this.ButtonPrueba.UseVisualStyleBackColor = true;
            this.ButtonPrueba.Click += new System.EventHandler(this.ButtonPrueba_Click);
            // 
            // Buttoncargar
            // 
            this.Buttoncargar.Location = new System.Drawing.Point(151, 165);
            this.Buttoncargar.Name = "Buttoncargar";
            this.Buttoncargar.Size = new System.Drawing.Size(124, 46);
            this.Buttoncargar.TabIndex = 2;
            this.Buttoncargar.Text = "CARGAR";
            this.Buttoncargar.UseVisualStyleBackColor = true;
            this.Buttoncargar.Click += new System.EventHandler(this.Buttoncargar_Click);
            // 
            // dataGridViewTabla_contenido
            // 
            this.dataGridViewTabla_contenido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTabla_contenido.Location = new System.Drawing.Point(2, 219);
            this.dataGridViewTabla_contenido.Name = "dataGridViewTabla_contenido";
            this.dataGridViewTabla_contenido.Size = new System.Drawing.Size(776, 245);
            this.dataGridViewTabla_contenido.TabIndex = 3;
            // 
            // Buttoninsertar
            // 
            this.Buttoninsertar.Location = new System.Drawing.Point(292, 164);
            this.Buttoninsertar.Name = "Buttoninsertar";
            this.Buttoninsertar.Size = new System.Drawing.Size(126, 48);
            this.Buttoninsertar.TabIndex = 4;
            this.Buttoninsertar.Text = "INSERTAR";
            this.Buttoninsertar.UseVisualStyleBackColor = true;
            this.Buttoninsertar.Click += new System.EventHandler(this.Buttoninsertar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre de la consola";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Compañia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Año de Lanzamiento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Generación";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(75, 16);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(258, 20);
            this.textBoxId.TabIndex = 10;
            // 
            // textBoxNombrecon
            // 
            this.textBoxNombrecon.Location = new System.Drawing.Point(118, 47);
            this.textBoxNombrecon.Name = "textBoxNombrecon";
            this.textBoxNombrecon.Size = new System.Drawing.Size(258, 20);
            this.textBoxNombrecon.TabIndex = 11;
            // 
            // textBoxCampañia
            // 
            this.textBoxCampañia.Location = new System.Drawing.Point(75, 71);
            this.textBoxCampañia.Name = "textBoxCampañia";
            this.textBoxCampañia.Size = new System.Drawing.Size(258, 20);
            this.textBoxCampañia.TabIndex = 12;
            // 
            // textBoxGeneracion
            // 
            this.textBoxGeneracion.Location = new System.Drawing.Point(75, 124);
            this.textBoxGeneracion.Name = "textBoxGeneracion";
            this.textBoxGeneracion.Size = new System.Drawing.Size(258, 20);
            this.textBoxGeneracion.TabIndex = 14;
            // 
            // dateTimePickerAñolanzamiento
            // 
            this.dateTimePickerAñolanzamiento.Location = new System.Drawing.Point(122, 99);
            this.dateTimePickerAñolanzamiento.Name = "dateTimePickerAñolanzamiento";
            this.dateTimePickerAñolanzamiento.Size = new System.Drawing.Size(211, 20);
            this.dateTimePickerAñolanzamiento.TabIndex = 15;
            // 
            // buttonActualizar
            // 
            this.buttonActualizar.Location = new System.Drawing.Point(424, 165);
            this.buttonActualizar.Name = "buttonActualizar";
            this.buttonActualizar.Size = new System.Drawing.Size(139, 44);
            this.buttonActualizar.TabIndex = 16;
            this.buttonActualizar.Text = "ACTUALIZAR";
            this.buttonActualizar.UseVisualStyleBackColor = true;
            this.buttonActualizar.Click += new System.EventHandler(this.buttonActualizar_Click);
            // 
            // buttonborrar
            // 
            this.buttonborrar.Location = new System.Drawing.Point(583, 168);
            this.buttonborrar.Name = "buttonborrar";
            this.buttonborrar.Size = new System.Drawing.Size(118, 40);
            this.buttonborrar.TabIndex = 17;
            this.buttonborrar.Text = "BORRAR";
            this.buttonborrar.UseVisualStyleBackColor = true;
            // 
            // ButtonBuscarCompañia
            // 
            this.ButtonBuscarCompañia.Location = new System.Drawing.Point(446, 12);
            this.ButtonBuscarCompañia.Name = "ButtonBuscarCompañia";
            this.ButtonBuscarCompañia.Size = new System.Drawing.Size(144, 34);
            this.ButtonBuscarCompañia.TabIndex = 18;
            this.ButtonBuscarCompañia.Text = "BUSCAR COMPAÑIA";
            this.ButtonBuscarCompañia.UseVisualStyleBackColor = true;
            this.ButtonBuscarCompañia.Click += new System.EventHandler(this.ButtonBuscarCompañia_Click);
            // 
            // textBoxbuscarcompañia
            // 
            this.textBoxbuscarcompañia.Location = new System.Drawing.Point(446, 52);
            this.textBoxbuscarcompañia.Name = "textBoxbuscarcompañia";
            this.textBoxbuscarcompañia.Size = new System.Drawing.Size(163, 20);
            this.textBoxbuscarcompañia.TabIndex = 19;
            // 
            // dataGridViewResultados
            // 
            this.dataGridViewResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResultados.Location = new System.Drawing.Point(437, 78);
            this.dataGridViewResultados.Name = "dataGridViewResultados";
            this.dataGridViewResultados.Size = new System.Drawing.Size(351, 46);
            this.dataGridViewResultados.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(333, 475);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(445, 33);
            this.label6.TabIndex = 21;
            this.label6.Text = "KAREN YAMILETH JIMÉNEZ GALICIA 0905237626";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 517);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridViewResultados);
            this.Controls.Add(this.textBoxbuscarcompañia);
            this.Controls.Add(this.ButtonBuscarCompañia);
            this.Controls.Add(this.buttonborrar);
            this.Controls.Add(this.buttonActualizar);
            this.Controls.Add(this.dateTimePickerAñolanzamiento);
            this.Controls.Add(this.textBoxGeneracion);
            this.Controls.Add(this.textBoxCampañia);
            this.Controls.Add(this.textBoxNombrecon);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Buttoninsertar);
            this.Controls.Add(this.dataGridViewTabla_contenido);
            this.Controls.Add(this.Buttoncargar);
            this.Controls.Add(this.ButtonPrueba);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTabla_contenido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonPrueba;
        private System.Windows.Forms.Button Buttoncargar;
        private System.Windows.Forms.DataGridView dataGridViewTabla_contenido;
        private System.Windows.Forms.Button Buttoninsertar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxNombrecon;
        private System.Windows.Forms.TextBox textBoxCampañia;
        private System.Windows.Forms.TextBox textBoxGeneracion;
        private System.Windows.Forms.DateTimePicker dateTimePickerAñolanzamiento;
        private System.Windows.Forms.Button buttonActualizar;
        private System.Windows.Forms.Button buttonborrar;
        private System.Windows.Forms.Button ButtonBuscarCompañia;
        private System.Windows.Forms.TextBox textBoxbuscarcompañia;
        private System.Windows.Forms.DataGridView dataGridViewResultados;
        private System.Windows.Forms.Label label6;
    }
}


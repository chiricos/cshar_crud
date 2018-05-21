namespace crud.Vistas.Empleados
{
    partial class FormRegistrar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_apellidos = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_dni = new System.Windows.Forms.TextBox();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.cbo_genero = new System.Windows.Forms.ComboBox();
            this.cbo_estado_civil = new System.Windows.Forms.ComboBox();
            this.cbo_departamento = new System.Windows.Forms.ComboBox();
            this.cbo_provincia = new System.Windows.Forms.ComboBox();
            this.cbo_distrito = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbo_operador = new System.Windows.Forms.ComboBox();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.dgv_telefonos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.btn_registrar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_telefonos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbo_distrito);
            this.groupBox1.Controls.Add(this.cbo_provincia);
            this.groupBox1.Controls.Add(this.cbo_departamento);
            this.groupBox1.Controls.Add(this.cbo_estado_civil);
            this.groupBox1.Controls.Add(this.cbo_genero);
            this.groupBox1.Controls.Add(this.txt_direccion);
            this.groupBox1.Controls.Add(this.txt_dni);
            this.groupBox1.Controls.Add(this.txt_nombre);
            this.groupBox1.Controls.Add(this.txt_apellidos);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(490, 235);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del trabajador";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Apellidos (*)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(277, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre (*)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dni (*)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(163, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Genero (*)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(305, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Estado Civil (*)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Dirección (*)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Departamento (*)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(154, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Provincia (*)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(321, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Distrito";
            // 
            // txt_apellidos
            // 
            this.txt_apellidos.Location = new System.Drawing.Point(9, 44);
            this.txt_apellidos.Name = "txt_apellidos";
            this.txt_apellidos.Size = new System.Drawing.Size(251, 20);
            this.txt_apellidos.TabIndex = 2;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(280, 44);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(193, 20);
            this.txt_nombre.TabIndex = 9;
            // 
            // txt_dni
            // 
            this.txt_dni.Location = new System.Drawing.Point(9, 92);
            this.txt_dni.Name = "txt_dni";
            this.txt_dni.Size = new System.Drawing.Size(151, 20);
            this.txt_dni.TabIndex = 10;
            // 
            // txt_direccion
            // 
            this.txt_direccion.Location = new System.Drawing.Point(9, 141);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(464, 20);
            this.txt_direccion.TabIndex = 11;
            // 
            // cbo_genero
            // 
            this.cbo_genero.FormattingEnabled = true;
            this.cbo_genero.Items.AddRange(new object[] {
            "MASCULINO",
            "FEMENINO"});
            this.cbo_genero.Location = new System.Drawing.Point(166, 92);
            this.cbo_genero.Name = "cbo_genero";
            this.cbo_genero.Size = new System.Drawing.Size(136, 21);
            this.cbo_genero.TabIndex = 2;
            // 
            // cbo_estado_civil
            // 
            this.cbo_estado_civil.FormattingEnabled = true;
            this.cbo_estado_civil.Items.AddRange(new object[] {
            "CASADO",
            "SOLTERO"});
            this.cbo_estado_civil.Location = new System.Drawing.Point(308, 92);
            this.cbo_estado_civil.Name = "cbo_estado_civil";
            this.cbo_estado_civil.Size = new System.Drawing.Size(165, 21);
            this.cbo_estado_civil.TabIndex = 12;
            // 
            // cbo_departamento
            // 
            this.cbo_departamento.FormattingEnabled = true;
            this.cbo_departamento.Location = new System.Drawing.Point(9, 196);
            this.cbo_departamento.Name = "cbo_departamento";
            this.cbo_departamento.Size = new System.Drawing.Size(142, 21);
            this.cbo_departamento.TabIndex = 13;
            // 
            // cbo_provincia
            // 
            this.cbo_provincia.FormattingEnabled = true;
            this.cbo_provincia.Location = new System.Drawing.Point(157, 196);
            this.cbo_provincia.Name = "cbo_provincia";
            this.cbo_provincia.Size = new System.Drawing.Size(161, 21);
            this.cbo_provincia.TabIndex = 14;
            // 
            // cbo_distrito
            // 
            this.cbo_distrito.FormattingEnabled = true;
            this.cbo_distrito.Location = new System.Drawing.Point(324, 196);
            this.cbo_distrito.Name = "cbo_distrito";
            this.cbo_distrito.Size = new System.Drawing.Size(149, 21);
            this.cbo_distrito.TabIndex = 15;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_telefonos);
            this.groupBox2.Controls.Add(this.btn_agregar);
            this.groupBox2.Controls.Add(this.txt_numero);
            this.groupBox2.Controls.Add(this.cbo_operador);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(13, 254);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(489, 248);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Teléfonos";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Operador";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(162, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Número Teléfono";
            // 
            // cbo_operador
            // 
            this.cbo_operador.FormattingEnabled = true;
            this.cbo_operador.Items.AddRange(new object[] {
            "ENTEL",
            "CLARO",
            "TIGO",
            "MOVISTAR",
            "UFF",
            "VIRGIN"});
            this.cbo_operador.Location = new System.Drawing.Point(6, 43);
            this.cbo_operador.Name = "cbo_operador";
            this.cbo_operador.Size = new System.Drawing.Size(153, 21);
            this.cbo_operador.TabIndex = 16;
            // 
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(165, 44);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(194, 20);
            this.txt_numero.TabIndex = 16;
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(368, 43);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(104, 23);
            this.btn_agregar.TabIndex = 18;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            // 
            // dgv_telefonos
            // 
            this.dgv_telefonos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_telefonos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgv_telefonos.Location = new System.Drawing.Point(8, 71);
            this.dgv_telefonos.Name = "dgv_telefonos";
            this.dgv_telefonos.Size = new System.Drawing.Size(464, 150);
            this.dgv_telefonos.TabIndex = 19;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Operador";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "N° Teléfono";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Eliminar";
            this.Column3.Name = "Column3";
            // 
            // btn_registrar
            // 
            this.btn_registrar.Location = new System.Drawing.Point(131, 524);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(75, 23);
            this.btn_registrar.TabIndex = 3;
            this.btn_registrar.Text = "Registrar";
            this.btn_registrar.UseVisualStyleBackColor = true;
            this.btn_registrar.Click += new System.EventHandler(this.btn_registrar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(292, 524);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 4;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // FormRegistrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 567);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_registrar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormRegistrar";
            this.Text = "FormRegistrar";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_telefonos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbo_distrito;
        private System.Windows.Forms.ComboBox cbo_provincia;
        private System.Windows.Forms.ComboBox cbo_departamento;
        private System.Windows.Forms.ComboBox cbo_estado_civil;
        private System.Windows.Forms.ComboBox cbo_genero;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.TextBox txt_dni;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_apellidos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_telefonos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewLinkColumn Column3;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.ComboBox cbo_operador;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_registrar;
        private System.Windows.Forms.Button btn_cancelar;

    }
}
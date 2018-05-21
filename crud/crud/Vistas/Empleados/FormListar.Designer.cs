namespace crud.Vistas.Empleados
{
    partial class FormListar
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
            this.ll_nuevo_empleado = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.dgv_empleados = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_empleados)).BeginInit();
            this.SuspendLayout();
            // 
            // ll_nuevo_empleado
            // 
            this.ll_nuevo_empleado.AutoSize = true;
            this.ll_nuevo_empleado.Location = new System.Drawing.Point(31, 27);
            this.ll_nuevo_empleado.Name = "ll_nuevo_empleado";
            this.ll_nuevo_empleado.Size = new System.Drawing.Size(89, 13);
            this.ll_nuevo_empleado.TabIndex = 0;
            this.ll_nuevo_empleado.TabStop = true;
            this.ll_nuevo_empleado.Text = "Nuevo Empleado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(376, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar";
            // 
            // txt_buscar
            // 
            this.txt_buscar.Location = new System.Drawing.Point(379, 43);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(197, 20);
            this.txt_buscar.TabIndex = 2;
            this.txt_buscar.TextChanged += new System.EventHandler(this.txt_nombre_TextChanged);
            // 
            // dgv_empleados
            // 
            this.dgv_empleados.AllowUserToAddRows = false;
            this.dgv_empleados.AllowUserToDeleteRows = false;
            this.dgv_empleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_empleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgv_empleados.Location = new System.Drawing.Point(34, 95);
            this.dgv_empleados.Name = "dgv_empleados";
            this.dgv_empleados.ReadOnly = true;
            this.dgv_empleados.Size = new System.Drawing.Size(542, 237);
            this.dgv_empleados.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombres y apellidos";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Dni";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 30;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Genero";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 80;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Distrito";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Editar";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 80;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Eliminar";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 80;
            // 
            // FormListar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 344);
            this.Controls.Add(this.dgv_empleados);
            this.Controls.Add(this.txt_buscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ll_nuevo_empleado);
            this.Name = "FormListar";
            this.Text = "FormListar";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_empleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel ll_nuevo_empleado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.DataGridView dgv_empleados;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewLinkColumn Column5;
        private System.Windows.Forms.DataGridViewLinkColumn Column6;
    }
}
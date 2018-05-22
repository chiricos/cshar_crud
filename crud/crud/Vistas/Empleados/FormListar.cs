using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crud.Vistas.Empleados
{
    public partial class FormListar : Form
    {
        public FormListar()
        {
            InitializeComponent();
            if (_myForm == null)
            {
                _myForm = this;
            }
        }

        private static FormListar _myForm;

        public static FormListar MyForm
        {
            get 
            {
                if (_myForm == null)
                {
                    _myForm = new FormListar(); 
                }
                return FormListar._myForm; 
                
            }
            set { FormListar._myForm = value; }
        }

        private void txt_nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormListar_Load(object sender, EventArgs e)
        {
            var empleado = new Clases.Empleado();
            empleado.ListarEmpleadosDataGridView(dgv_empleados);
        }

        private void ll_nuevo_empleado_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRegistrar registrar = new FormRegistrar();
            registrar.Show();
        }

        
    }
}

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
    public partial class FormActualizar : Form
    {
        public FormActualizar()
        {
            InitializeComponent();
            if (_myForm == null)
            {
                _myForm = this;
            }
        }

        private static FormActualizar _myForm;

        public static FormActualizar MyForm
        {
            get
            {
                if (_myForm == null)
                {
                    _myForm = new FormActualizar();
                }
                return FormActualizar._myForm;

            }
            set { FormActualizar._myForm = value; }
        }

        private void FormActualizar_Load(object sender, EventArgs e)
        {
            dgv_telefonos.Rows.Clear();
            dgv_telefonos.Refresh();

            cbo_genero.SelectedIndex = 0;
            cbo_estado_civil.SelectedIndex = 0;
            cbo_operador.SelectedIndex = 0;

            var ubigeo = new Clases.Ubigeo();
            var tabla = ubigeo.ListarDepartamentos();
            if (tabla.Rows.Count > 0)
            {
                cbo_departamento.DataSource = tabla;
                cbo_departamento.DisplayMember = "NOMBRE_DEPARTAMENTO";
                cbo_departamento.ValueMember = "DEPARTAMENTO_ID";
            }
        }

        private void cbo_departamento_SelectedValueChanged(object sender, EventArgs e)
        {
            var ubigeo = new Clases.Ubigeo();
            var tabla = ubigeo.ListarDepartamentos();
            if (tabla.Rows.Count > 0)
            {
                cbo_departamento.DataSource = tabla;
                cbo_departamento.DisplayMember = "NOMBRE_DEPARTAMENTO";
                cbo_departamento.ValueMember = "DEPARTAMENTO_ID";
            }
        }

        private void cbo_departamento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            int numero_filas = dgv_telefonos.Rows.Count;
            if (dgv_telefonos.Rows.Count == 0)
            {
                AgregarTelefonos();
            }
            else
            {
                string numero = txt_numero.Text;
                bool existe = false;

                for (int i = 0; i < numero_filas; i++)
                {
                    if (numero.Equals(dgv_telefonos.Rows[i].Cells[1].Value.ToString()))
                    {
                        existe = true;
                        break;
                    }
                }
                if (existe)
                {
                    MessageBox.Show("Este telefono ya fue agregado ");
                }
                else
                {
                    AgregarTelefonos();
                }
            }
        }

        private void AgregarTelefonos()
        {
            string operador = cbo_operador.Text;
            string numero = txt_numero.Text;
            dgv_telefonos.Rows.Add(operador, numero, "Eliminar",0);
        }

        private void FormActualizar_FormClosed(object sender, FormClosedEventArgs e)
        {
            _myForm = null;
        }

    }
}

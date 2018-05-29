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

        public int empleadoId_TEMP = 0;

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
            var departamentoId = cbo_departamento.SelectedValue.ToString();
            var tabla = ubigeo.ListarProvinciasPorDepartamentoId(departamentoId);

            if (tabla.Rows.Count > 0)
            {
                cbo_provincia.DataSource = tabla;
                cbo_provincia.DisplayMember = "NOMBRE_PROVINCIA";
                cbo_provincia.ValueMember = "PROVINCIA_ID";
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

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            if (txt_apellidos.Text.Trim().Equals(""))
            {
                txt_apellidos.Focus();
                MessageBox.Show("Completar Apellidos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_nombre.Text.Trim().Equals(""))
            {
                txt_nombre.Focus();
                MessageBox.Show("Completar Nombre", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_dni.Text.Trim().Length != 8)
            {
                txt_dni.Focus();
                MessageBox.Show("Completar Dni de 8 digitos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_direccion.Text.Trim().Equals(""))
            {
                txt_direccion.Focus();
                MessageBox.Show("Completar Dirección", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (dgv_telefonos.Rows.Count == 0)
            {
                dgv_telefonos.Focus();
                MessageBox.Show("Ingresar al menos un teléfono", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var empleado = new Clases.Empleado(
                txt_apellidos.Text.Trim().ToUpper(),
                txt_nombre.Text.Trim().ToUpper(),
                txt_dni.Text.Trim(),
                cbo_genero.Text,
                cbo_estado_civil.Text,
                txt_direccion.Text.Trim(),
                cbo_distrito.SelectedValue.ToString(),
                empleadoId_TEMP
                );
                bool resultado_emp = empleado.Actualizar();
                if (resultado_emp)
                {
                    int numero_filas = dgv_telefonos.Rows.Count;
                    for (int i = 0; i < numero_filas; i++)
                    {
                        int id = int.Parse(dgv_telefonos.Rows[i].Cells[3].Value.ToString());
                        if (id == 0)
                        {
                            string operador = dgv_telefonos.Rows[i].Cells[0].Value.ToString();
                            string numero = dgv_telefonos.Rows[i].Cells[1].Value.ToString();
                            var telefono = new Clases.Telefono(operador, numero, empleadoId_TEMP.ToString());
                            var resultado = telefono.Registrar();
                            if (!resultado)
                            {
                                MessageBox.Show("Error al registar teléfono", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                       
                    }
                    MessageBox.Show("Empleado actualizado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    empleado.ListarEmpleadosDataGridView(Vistas.Empleados.FormListar.MyForm.dgv_empleados);
                }
                else
                {
                    MessageBox.Show("Error al actualizar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }


           
        }

        private void cbo_provincia_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cbo_provincia_RightToLeftChanged(object sender, EventArgs e)
        {
            
        }

        private void cbo_provincia_SelectedValueChanged(object sender, EventArgs e)
        {
            var ubigeo = new Clases.Ubigeo();
            var provinciaId = cbo_provincia.SelectedValue.ToString();
            var tabla = ubigeo.ListarDistritosPorProvinciaId(provinciaId);

            if (tabla.Rows.Count > 0)
            {
                cbo_distrito.DataSource = tabla;
                cbo_distrito.DisplayMember = "NOMBRE_DISTRITO";
                cbo_distrito.ValueMember = "DISTRITO_ID";
            }
        }

    }
}

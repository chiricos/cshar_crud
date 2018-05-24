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
            var empleado = new Clases.Empleado();
            if (txt_buscar.Text.Trim().Length >0)
            {
                empleado.BuscarEmpleadoLike(dgv_empleados, txt_buscar.Text.Trim());
            }else
            {
                empleado.ListarEmpleadosDataGridView(dgv_empleados);
            }
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

        private void dgv_empleados_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (dgv_empleados.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().Equals("Editar"))
                {
                    var f = new FormActualizar();
                    f.Show();
                    var empleado = new Clases.Empleado();
                    int empleado_id = int.Parse(dgv_empleados.Rows[e.RowIndex].Cells[6].Value.ToString());
                    var tabla_empleado = empleado.BuscarPorCodigo(empleado_id);
                    if (tabla_empleado.Rows.Count == 1)
                    {
                        FormActualizar.MyForm.txt_apellidos.Text = tabla_empleado.Rows[0]["APELLIDOS"].ToString();
                        FormActualizar.MyForm.txt_nombre.Text = tabla_empleado.Rows[0]["NOMBRE"].ToString();
                        FormActualizar.MyForm.txt_dni.Text = tabla_empleado.Rows[0]["DNI"].ToString();
                        FormActualizar.MyForm.cbo_genero.Text = tabla_empleado.Rows[0]["GENERO"].ToString();
                        FormActualizar.MyForm.cbo_estado_civil.Text = tabla_empleado.Rows[0]["ESTADO_CIVIL"].ToString();
                        FormActualizar.MyForm.txt_direccion.Text = tabla_empleado.Rows[0]["DIRECCION"].ToString();

                        FormActualizar.MyForm.cbo_departamento.SelectedValue = tabla_empleado.Rows[0]["DEPARTAMENTO_ID"].ToString();
                        FormActualizar.MyForm.cbo_provincia.SelectedValue = tabla_empleado.Rows[0]["PROVINCIA_ID"].ToString();
                        FormActualizar.MyForm.cbo_distrito.SelectedValue = tabla_empleado.Rows[0]["DISTRITO_ID"].ToString();

                        var telefono = new Clases.Telefono();
                        var tabla_telefonos = telefono.BuscarPorCodigo(empleado_id);

                        int numero_filas = tabla_telefonos.Rows.Count;
                        if (numero_filas > 0)
                        {
                           
                            for (int i = 0; i < numero_filas; i++)
                            {
                                string operador = tabla_telefonos.Rows[i][1].ToString();
                                string numero = tabla_telefonos.Rows[i][2].ToString();
                                FormActualizar.MyForm.dgv_telefonos.Rows.Add(
                                    operador, numero, "Eliminar",empleado_id
                                    );
                            }
                        }
                    }
                }
                if (dgv_empleados.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().Equals("Eliminar"))
                {
                    MessageBox.Show("Eliminar");
                }
                
            }
        }

        
    }
}

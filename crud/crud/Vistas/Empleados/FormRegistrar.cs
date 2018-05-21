using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crud.Vistas.Empleados
{
    public partial class FormRegistrar : Form
    {
        public FormRegistrar()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
           
            //Instanciar la clase SQLCONNECTION
            SqlConnection cn = new SqlConnection(
            ConfigurationManager.ConnectionStrings["cs_proyecto"].ConnectionString
            );
            try {
                cn.Open();
                MessageBox.Show("Conexion exitosa");
                cn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
           
        }

        private void FormRegistrar_Load(object sender, EventArgs e)
        {
            dgv_telefonos.Rows.Clear();
            dgv_telefonos.Refresh();


            cbo_genero.SelectedIndex = 0;
            cbo_estado_civil.SelectedIndex = 0;
            cbo_operador.SelectedIndex = 0;
            /*var ubigeo = new Clases.Ubigeo();
            var tabla = ubigeo.ListarDepartamentos();
            if (tabla.Rows.Count > 0)
            {
                cbo_departamento.DataSource = tabla;
                cbo_departamento.DisplayMember = "NOMBRE DEPARTAMENTO";
                cbo_departamento.ValueMember = "DEPARTAMENTO_ID";
            }*/
        }

        private void cbo_departamento_SelectedValueChanged(object sender, EventArgs e)
        {
           
            /*var ubigeo = new Clases.Ubigeo();
            var tabla = ubigeo.ListarDepartamentos();
            if (tabla.Rows.Count > 0)
            {
                cbo_departamento.DataSource = tabla;
                cbo_departamento.DisplayMember = "NOMBRE DEPARTAMENTO";
                cbo_departamento.ValueMember = "DEPARTAMENTO_ID";
            }*/
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            
            int numero_filas = dgv_telefonos.Rows.Count;
            if (dgv_telefonos.Rows.Count ==0)
            {
                AgregarTelefonos();
            }
            else
            {
                string numero = txt_numero.Text;
                bool existe = false;

                for (int i=0; i < numero_filas; i++)
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
            dgv_telefonos.Rows.Add(operador, numero, "Eliminar");
        }
    }
}

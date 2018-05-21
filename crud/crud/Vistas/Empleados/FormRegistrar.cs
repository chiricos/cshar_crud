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
    }
}

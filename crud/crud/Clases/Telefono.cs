using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crud.Clases
{
    class Telefono
    {
        SqlConnection cn = new SqlConnection(
           ConfigurationManager.ConnectionStrings["cs_proyecto"].ConnectionString
           );

        public int TelefonoId { get; set; }
        public string Operador { get; set; }
        public string Numero { get; set; }
        public string Empleado_id { get; set; }

        public Telefono()
        {
        }

        public Telefono(string _operador,string _numero,string _empleado_id)
        {
            this.Operador = _operador;
            this.Numero = _numero;
            this.Empleado_id = _empleado_id;
        }


        public Telefono(int _telefono_id)
        {
            this.TelefonoId = _telefono_id;
        }

        public bool Registrar()
        {
            try
            {
                using (var cmd = new SqlCommand("SP_REGISTAR_TELEFONOS", cn))
                {
                    cmd.Parameters.AddWithValue("@OPERADOR", this.Operador);
                    cmd.Parameters.AddWithValue("@NUMERO", this.Numero);
                    cmd.Parameters.AddWithValue("@EMPLEADO_ID", this.Empleado_id);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cn.Open();
                    int r = cmd.ExecuteNonQuery();
                    cn.Close();

                    if (r == 1)
                    {
                        return true;
                    }
                }
            }
            catch (SqlException e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
                return false;
            }
            finally
            {
                if ((cn.State == ConnectionState.Open))
                {
                    cn.Close();
                }

            }

            return false;
        }

        public DataTable BuscarPorCodigo(int id)
        {
            //instanciando a la clase datatable
            var tabla = new DataTable();
            try
            {
                //creando una instancia de la clase sqldataadapter
                using (var adaptador = new SqlDataAdapter("SP_BUSCAR_TELEFONOS_POR_EMPLEADO_ID", cn))
                {
                    adaptador.SelectCommand.Parameters.AddWithValue("@ID", id);
                    adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;
                    adaptador.Fill(tabla);
                }
            }
            catch (SqlException e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
                return tabla;
            }
            return tabla;
        }
      
    }

}

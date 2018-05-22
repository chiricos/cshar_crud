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
    class Ubigeo
    {
        SqlConnection cn = new SqlConnection(
           ConfigurationManager.ConnectionStrings["cs_proyecto"].ConnectionString
           );

        public DataTable ListarDepartamentos()
        {
            //instanciando a la clase datatable
            var tabla = new DataTable();
            try
            {
                //creando una instancia de la clase sqldataadapter
                using (var adaptador = new SqlDataAdapter("SP_LISTAR_DEPARTAMENTOS", cn))
                {
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

        public DataTable ListarProvinciasPorDepartamentoId(string departamentoId)
        {
            //instanciando a la clase datatable
            var tabla = new DataTable();
            try
            {
                //creando una instancia de la clase sqldataadapter
                using (var adaptador = new SqlDataAdapter("SP_LISTAR_PROVINCIAS", cn))
                {
                    adaptador.SelectCommand.Parameters.AddWithValue("@DEPARTAMENTO_ID",departamentoId);
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

        public DataTable ListarDistritosPorProvinciaId(string provinciaId)
        {
            //instanciando a la clase datatable
            var tabla = new DataTable();
            try
            {
                //creando una instancia de la clase sqldataadapter
                using (var adaptador = new SqlDataAdapter("SP_LISTAR_DISTRITOS", cn))
                {
                    adaptador.SelectCommand.Parameters.AddWithValue("@PROVINCIA_ID", provinciaId);
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

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crud.Clases
{
    class Empleado:Ifunciones
    {
        SqlConnection cn = new SqlConnection(
            ConfigurationManager.ConnectionStrings["cs_proyecto"].ConnectionString
            );

        public int EmpleadoId { get; set; }
        public string Apellidos { get; set; }
        public string Nombre { get; set; }
        public string Dni { get; set; }
        public string Genero { get; set; }
        public string EstadoCivil { get; set; }
        public string Direccion { get; set; }
        public string DistritoId { get; set; }

        public Empleado()
        { 
        }

        public Empleado(string _apellidos, string _nombre, string _dni,string _genero,
                string _estado_civil,string _direccion, string _distrito_id    
            )
        {
            this.Apellidos = _apellidos;
            this.Nombre = _nombre;
            this.Dni = _dni;
            this.Genero = _genero;
            this.EstadoCivil = _estado_civil;
            this.Direccion = _direccion;
            this.DistritoId = _distrito_id;
        }

        public Empleado(int _empleado_id)
        {
            this.EmpleadoId = _empleado_id;
        }

        public int Registrar()
        {
            int ultimo_id = 0;
            try
            {
                using (var cmd = new SqlCommand("SP_REGISTRAR_EMPLEADO", cn))
                {
                    cmd.Parameters.AddWithValue("@APELLIDOS", this.Apellidos);
                    cmd.Parameters.AddWithValue("@NOMBRE", this.Nombre);
                    cmd.Parameters.AddWithValue("@DNI", this.Dni);
                    cmd.Parameters.AddWithValue("@GENERO", this.Genero);
                    cmd.Parameters.AddWithValue("@ESTADO_CIVIL", this.EstadoCivil);
                    cmd.Parameters.AddWithValue("@DIRECCION", this.Direccion);
                    cmd.Parameters.AddWithValue("@DISTRITO_ID", this.DistritoId);
                    cmd.Parameters.AddWithValue("@ULTIMO_ID", SqlDbType.Int).Direction=ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    ultimo_id = Convert.ToInt32(cmd.Parameters["@ULTIMO_ID"].Value.ToString());
                    cn.Close();

                }
            }
            catch(SqlException e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
                return ultimo_id;
            }
            finally
            {
                if ((cn.State == ConnectionState.Open)) 
                {
                    cn.Close();
                }
                
            }

            return ultimo_id;
        }

        public bool Actualizar()
        {
            throw new NotImplementedException();
        }

        public bool Eliminar()
        {
            throw new NotImplementedException();
        }

        public DataTable Listar()
        {
            //instanciando a la clase datatable
            var tabla = new DataTable();
            try
            {
                //creando una instancia de la clase sqldataadapter
                using (var adaptador = new SqlDataAdapter("SP_LISTAR_EMPLEADOS", cn))
                {
                    adaptador.SelectCommand.CommandType = CommandType.Text;
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

        public DataTable BuscarEmpleadoPorNombre(string nombre)
        {
            //instanciando a la clase datatable
            var tabla = new DataTable();
            try
            {
                //creando una instancia de la clase sqldataadapter
                using (var adaptador = new SqlDataAdapter("PS_BUSCAR_EMPLEADO_LIKE", cn))
                {
                    adaptador.SelectCommand.Parameters.AddWithValue("@NOMBRE", nombre.Trim().ToUpper());
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

        public DataTable BuscarPorCodigo(int id)
        {
            //instanciando a la clase datatable
            var tabla = new DataTable();
            try
            {
                //creando una instancia de la clase sqldataadapter
                using (var adaptador = new SqlDataAdapter("SP_BUSCAR_EMPLEADO_POR_ID", cn))
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

        public void BuscarEmpleadoLike(DataGridView dgv,string nombre)
        {
            
            var tabla = this.BuscarEmpleadoPorNombre(nombre);
            this.ListarGrid(dgv, tabla);
        }

        public void ListarEmpleadosDataGridView(DataGridView dgv)
        {
            var tabla = this.Listar();
            this.ListarGrid(dgv, tabla);
        }

        private void ListarGrid(DataGridView dgv, DataTable tabla)
        {
            var numero_filas = tabla.Rows.Count;
            if (numero_filas > 0)
            {
                dgv.Rows.Clear();
                for (int i = 0; i < numero_filas; i++)
                {
                    string nombre_completo = tabla.Rows[i][2].ToString() + " " + tabla.Rows[i][1].ToString();
                    string dni = tabla.Rows[i][3].ToString();
                    string genero = tabla.Rows[i][4].ToString();
                    string distrito = tabla.Rows[i][5].ToString();
                    int empleadoId = int.Parse(tabla.Rows[i][0].ToString());
                    dgv.Rows.Add(
                            nombre_completo, dni, genero, distrito, "Editar", "Eliminar", empleadoId
                        );
                }
            }
        }
    }
}

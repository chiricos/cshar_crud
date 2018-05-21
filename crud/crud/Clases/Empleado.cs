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
            throw new NotImplementedException();
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

        public DataTable BuscarPorCodigo(int id)
        {
            throw new NotImplementedException();
        }

        public void ListarEmpleadosDataGridView(DataGridView dgv)
        {
            var tabla = this.Listar();
            var numero_filas = tabla.Rows.Count;
            if (numero_filas > 0)
            {
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

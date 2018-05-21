using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public System.Data.DataTable Listar()
        {
            throw new NotImplementedException();
        }

        public System.Data.DataTable BuscarPorCodigo(int id)
        {
            throw new NotImplementedException();
        }
    }
}

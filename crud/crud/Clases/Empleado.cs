using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crud.Clases
{
    class Empleado
    {
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
    }
}

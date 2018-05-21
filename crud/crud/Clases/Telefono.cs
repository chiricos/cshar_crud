using System;
using System.Collections.Generic;
using System.Configuration;
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
      
    }

}

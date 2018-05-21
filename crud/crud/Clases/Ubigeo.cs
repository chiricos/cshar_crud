using System;
using System.Collections.Generic;
using System.Configuration;
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

        public int ListarDepartamentos()
        {
            
            return 1;
        }
    }
}

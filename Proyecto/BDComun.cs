using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Proyecto
{
    public class BDComun
    {
        public static SqlConnection ObtenerCOnexion()
        {
            SqlConnection Conn = new SqlConnection("Data source = VOT; Initial Catalog = BD; User Id = sa; Password = 0411 ");
            Conn.Open();
            return Conn;
        }
    }
}

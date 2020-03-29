using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Capa_Conexion
{
    public class CLConexion
    {
        public SqlConnection connection = new SqlConnection("Data Source=DESKTOP-GF7M3J1\\SQLEXPRESS;Initial Catalog=Falta; Integrated Security=true");
    }
}

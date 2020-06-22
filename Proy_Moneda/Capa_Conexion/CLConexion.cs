using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Capa_Datos
{
    public class CLConexion
    {
        public SqlConnection connection = new SqlConnection("Data Source=LAPTOP-SVEONKKU;Initial Catalog=DBMoneda; Integrated Security=true");
    }
}

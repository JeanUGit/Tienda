using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Capa_Conexion;

namespace Capa_Datos
{
    public  class ClsBuscarProductoXnombre
    {
        private String nombre;
        private DataTable tabla = new DataTable();
        protected void Fnt_buscarProducto()
        {
            CLConexion conn = new CLConexion();
            SqlCommand com = new SqlCommand("SP_BuscarProductoxNombre", conn.connection);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@nombre", nombre);
            conn.connection.Open();
            SqlDataAdapter data = new SqlDataAdapter(com);
            data.Fill(tabla);
            conn.connection.Close();

        }

        public void Fnt_BuscarXNombre(String name) { nombre = name; Fnt_buscarProducto(); }

        public DataTable GetTable() { return tabla; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Capa_Conexion;
namespace Capa_Logica
{
    public class CLProductos
    {
        public String Codigo, Nombre, msn;
        public int Stock;
        public Double Precio;
        public void SP_FrmProductos_Guardar()
        {
            CLConexion Obj = new CLConexion();
            SqlDataReader Lectura;
            SqlCommand con = new SqlCommand("SP_FrmProductos_Buscar", Obj.connection);
            con.CommandType = CommandType.StoredProcedure;
            con.Parameters.AddWithValue("@Codigo", Codigo);
            Obj.connection.Open();
            con.ExecuteNonQuery();
            Lectura = con.ExecuteReader();
            if (Lectura.Read() == false)
            {
                Obj.connection.Close();
                con = new SqlCommand("SP_FrmProductos_Guardar", Obj.connection);
                con.CommandType = CommandType.StoredProcedure;
                con.Parameters.AddWithValue("@Codigo", Codigo);
                con.Parameters.AddWithValue("@Nombre", Nombre);
                con.Parameters.AddWithValue("@Precio", Precio);
                con.Parameters.AddWithValue("@Stock", Stock);
                con.Connection.Open();
                con.ExecuteNonQuery();
                con.Connection.Close();
                msn = "";
                return;
            }
            if (Lectura.Read() == true)
            {
                Obj.connection.Close();
            }
        }
        public void SP_FrmProductos_Buscar()
        {
            CLConexion objconect = new CLConexion();
            SqlCommand con; SqlDataReader Lectura;
            con = new SqlCommand("SP_FrmProductos_Buscar", objconect.connection);
            con.CommandType = CommandType.StoredProcedure;
            con.Parameters.AddWithValue("@Codigo", Codigo);
            objconect.connection.Open();
            con.ExecuteNonQuery();
            Lectura = con.ExecuteReader();
            if (Lectura.Read() == true)
            {
                Nombre = Convert.ToString(Lectura[0]);
                Precio = Convert.ToDouble(Lectura[1]);
                Stock = Convert.ToInt32(Lectura[2]);
                msn = "";
                objconect.connection.Close();
                return;
            }
            if (Lectura.Read() == false)
            {
                msn = "No hay Registro";
                objconect.connection.Close();
                return;
            }
        }
        public void SP_FrmProductos_Actualizar()
        {
            CLConexion objconect = new CLConexion();
            SqlCommand con; SqlDataReader Lectura;
            con = new SqlCommand("SP_FrmProductos_Actualizar", objconect.connection);
            con.CommandType = CommandType.StoredProcedure;
            con.Parameters.AddWithValue("@Codigo", Codigo);
            con.Parameters.AddWithValue("@Nombre", Nombre);
            con.Parameters.AddWithValue("@Precio", Precio);
            con.Parameters.AddWithValue("@Stock", Stock);
            con.Connection.Open();
            con.ExecuteNonQuery();
            Lectura = con.ExecuteReader();
            con.Connection.Close();
        }
    }
}

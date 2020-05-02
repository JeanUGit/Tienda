using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Capa_Conexion;
namespace Capa_Logica
{
    public class CLRecarga
    {
        public String RFID, msn;
        public double Saldo;
        public void SP_FrmRecargas_RecargarSaldo()
        {            
            CLConexion objconect = new CLConexion();
            SqlCommand con; SqlDataReader Lectura;
            con = new SqlCommand("SP_FrmRecargas_RecargarSaldo", objconect.connection);
            con.CommandType = CommandType.StoredProcedure;
            con.Parameters.AddWithValue("@Codigo", RFID);
            con.Parameters.AddWithValue("@Saldo", Saldo);
            con.Connection.Open();
            con.ExecuteNonQuery();
            Lectura = con.ExecuteReader();
            con.Connection.Close();
        }
        public void SP_FrmRecargas_Buscar()
        {
            CLConexion objconect = new CLConexion();
            SqlCommand con; SqlDataReader Lectura;
            con = new SqlCommand("SP_FrmRecargas_Buscar", objconect.connection);
            con.CommandType = CommandType.StoredProcedure;
            con.Parameters.AddWithValue("@Codigo", RFID);
            objconect.connection.Open();
            con.ExecuteNonQuery();
            Lectura = con.ExecuteReader();
            if (Lectura.Read() == true)
            {
                Saldo = Convert.ToDouble(Lectura[0]);
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
    }
}

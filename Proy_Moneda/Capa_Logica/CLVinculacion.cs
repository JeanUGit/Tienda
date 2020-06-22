using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Capa_Datos;
namespace Capa_Logica
{
    public class CLVinculacion
    {
        public String Documento, Nombre, Institucion, Correo, RFID, Contraseña, msn;
        public Double Saldo;

        public void SP_FrmRegistrarVinculo_GuardarPersona()
        {
            CLConexion Obj = new CLConexion();
            SqlDataReader Lectura;
            SqlCommand con = new SqlCommand("SP_FrmRegistrarVinculo_BuscarPersona", Obj.connection);
            con.CommandType = CommandType.StoredProcedure;
            con.Parameters.AddWithValue("@Documento", Documento);
            Obj.connection.Open();
            con.ExecuteNonQuery();
            Lectura = con.ExecuteReader();
            if (Lectura.Read() == false)
            {
                Obj.connection.Close();
                con = new SqlCommand("SP_FrmRegistrarVinculo_GuardarPersona", Obj.connection);
                con.CommandType = CommandType.StoredProcedure;
                con.Parameters.AddWithValue("@Documento", Documento);
                con.Parameters.AddWithValue("@Nombre", Nombre);
                con.Parameters.AddWithValue("@Institucion", Institucion);
                con.Parameters.AddWithValue("@Correo", Correo);
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
        public void SP_FrmRegistrarVinculo_RegistrarTarjeta()
        {
            CLConexion Obj = new CLConexion();
            SqlDataReader Lectura;
            SqlCommand con = new SqlCommand("SP_FrmRegistrarVinculo_BuscarTarjeta", Obj.connection);
            con.CommandType = CommandType.StoredProcedure;
            con.Parameters.AddWithValue("@RFDI",RFID);
            Obj.connection.Open();
            con.ExecuteNonQuery();
            Lectura = con.ExecuteReader();
            if (Lectura.Read() == false)
            {
                Obj.connection.Close();
                con = new SqlCommand("SP_FrmRegistrarVinculo_RegistrarTarjeta", Obj.connection);
                con.CommandType = CommandType.StoredProcedure;
                con.Parameters.AddWithValue("@RFID", RFID);
                con.Parameters.AddWithValue("@Contraseña", Contraseña);
                con.Parameters.AddWithValue("@Saldo", Saldo);
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

        public void SP_FrmRegistrarVinculo_BuscarPersona()
        {
            CLConexion objconect = new CLConexion();
            SqlCommand con; SqlDataReader Lectura;
            con = new SqlCommand("SP_FrmRegistrarVinculo_BuscarPersona", objconect.connection);
            con.CommandType = CommandType.StoredProcedure;
            con.Parameters.AddWithValue("@Documento", Documento);
            objconect.connection.Open();
            con.ExecuteNonQuery();
            Lectura = con.ExecuteReader();
            if (Lectura.Read() == true)
            {
                Nombre = Convert.ToString(Lectura[0]);
                Institucion = Convert.ToString(Lectura[1]);
                RFID = Convert.ToString(Lectura[2]);
                Saldo = Convert.ToDouble(Lectura[3]);
                Correo = Convert.ToString(Lectura[4]);
                Contraseña = Convert.ToString(Lectura[5]);
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
        public void SP_FrmRegistrarVinculo_BuscarTarjeta()
        {
            CLConexion objconect = new CLConexion();
            SqlCommand con; SqlDataReader Lectura;
            con = new SqlCommand("SP_FrmRegistrarVinculo_BuscarTarjeta", objconect.connection);
            con.CommandType = CommandType.StoredProcedure;
            con.Parameters.AddWithValue("@RFDI", RFID);
            objconect.connection.Open();
            con.ExecuteNonQuery();
            Lectura = con.ExecuteReader();
            if (Lectura.Read() == true)
            {
                Contraseña = Convert.ToString(Lectura[0]);
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
        public void SP_FrmRegistrarVinculo_Vincular()
        {
            CLConexion objconect = new CLConexion();
            SqlCommand con; 
            con = new SqlCommand("SP_FrmRegistrarVinculo_Vincular", objconect.connection);
            con.CommandType = CommandType.StoredProcedure;
            con.Parameters.AddWithValue("@Documento", Documento);
            con.Parameters.AddWithValue("@RFID", RFID);
            con.Connection.Open();
            con.ExecuteNonQuery();
            con.Connection.Close();
        }
        public void SP_FrmRegistrarVinculo_ActualizarContraseña()
        {
            CLConexion objconect = new CLConexion();
            SqlCommand con; SqlDataReader Lectura;
            con = new SqlCommand("SP_FrmRegistrarVinculo_ActualizarContraseña", objconect.connection);
            con.CommandType = CommandType.StoredProcedure;
            con.Parameters.AddWithValue("@RFID", RFID);
            con.Parameters.AddWithValue("@Contraseña", Contraseña);
            con.Connection.Open();
            con.ExecuteNonQuery();
            Lectura = con.ExecuteReader();
            con.Connection.Close();
        }
        public void SP_FrmRegistrarVinculo_ActualizarPersona()
        {
            CLConexion objconect = new CLConexion();
            SqlCommand con; SqlDataReader Lectura;
            con = new SqlCommand("SP_FrmRegistrarVinculo_ActualizarPersona", objconect.connection);
            con.CommandType = CommandType.StoredProcedure;
            con.Parameters.AddWithValue("@Documento", Documento);
            con.Parameters.AddWithValue("@Nombre", Nombre);
            con.Parameters.AddWithValue("@Institucion", Institucion);
            con.Parameters.AddWithValue("@Correo", Correo);          
            con.Connection.Open();
            con.ExecuteNonQuery();
            Lectura = con.ExecuteReader();
            con.Connection.Close();
        }
    }
}

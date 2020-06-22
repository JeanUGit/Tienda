using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Capa_Datos;

namespace Capa_Logica
{
    public class CLEmpleados
    {
        public String Documento, Nombre, Telefono, Correo, msn;
        public void SP_FrmEmpleado_GuardarEmpleado()
        {
            CLConexion Obj = new CLConexion();
            SqlDataReader Lectura;
            SqlCommand con = new SqlCommand("SP_FrmEmpleados_BuscarEmpleados", Obj.connection);
            con.CommandType = CommandType.StoredProcedure;
            con.Parameters.AddWithValue("@Documento", Documento);
            Obj.connection.Open();
            con.ExecuteNonQuery();
            Lectura = con.ExecuteReader();
            if (Lectura.Read() == false)
            {
                Obj.connection.Close();
                con = new SqlCommand("SP_FrmEmpleado_GuardarEmpleado", Obj.connection);
                con.CommandType = CommandType.StoredProcedure;
                con.Parameters.AddWithValue("@Documento", Documento);
                con.Parameters.AddWithValue("@Nombre", Nombre);
                con.Parameters.AddWithValue("@Telefono", Telefono);
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
        public void SP_FrmEmpleados_BuscarEmpleado()
        {
            CLConexion objconect = new CLConexion();
            SqlCommand con; SqlDataReader Lectura;
            con = new SqlCommand("SP_FrmEmpleados_BuscarEmpleados", objconect.connection);
            con.CommandType = CommandType.StoredProcedure;
            con.Parameters.AddWithValue("@Documento", Documento);
            objconect.connection.Open();
            con.ExecuteNonQuery();
            Lectura = con.ExecuteReader();
            if (Lectura.Read() == true)
            {
                Nombre = Convert.ToString(Lectura[0]);               
                Telefono = Convert.ToString(Lectura[1]);
                Correo = Convert.ToString(Lectura[2]);
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
        public void SP_FrmEmpleados_ActualizarEmpleados()
        {
            CLConexion objconect = new CLConexion();
            SqlCommand con; SqlDataReader Lectura;
            con = new SqlCommand("SP_FrmEmpleados_ActualizarEmpleados", objconect.connection);
            con.CommandType = CommandType.StoredProcedure;
            con.Parameters.AddWithValue("@Documento", Documento);
            con.Parameters.AddWithValue("@Nombre", Nombre);
            con.Parameters.AddWithValue("@Correo", Correo);
            con.Parameters.AddWithValue("@Telefono", Telefono);
            con.Connection.Open();
            con.ExecuteNonQuery();
            Lectura = con.ExecuteReader();
            con.Connection.Close();
        }
    }
}

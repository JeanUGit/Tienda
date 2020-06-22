using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Capa_Datos
{
    public class ClsVentaData
    {
        private String code;
        private int sw = 0;
        private String codigoCompra, cliente, nombre; 
        private float valor;
        private String [] tabla = new String[5];
        private DataGridView DTtabla = new DataGridView();

        protected void Fnt_buscarProducto()
        {
            CLConexion conn = new CLConexion();
            SqlCommand com = new SqlCommand("SP_BuscarXcodigo", conn.connection);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@code", code);
            conn.connection.Open();
            SqlDataReader lector = com.ExecuteReader();
            int conta = 0;
            if (lector.Read() == true)
            {
                sw = 1;
                while (conta < tabla.Length)
                {
                    tabla[conta] = Convert.ToString(lector[conta]);
                    conta++;
                }
            }
            else { sw = 0; }
            conn.connection.Close();

        }

        protected void Fnt_CargarClienteData()
        {
            CLConexion conn = new CLConexion();
            SqlCommand com = new SqlCommand("SP_CargarClientes",conn.connection);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@documento", cliente);
            conn.connection.Open();
            SqlDataReader lector = com.ExecuteReader();
            if (lector.Read() == true)
            {
                sw = 1;
                nombre = Convert.ToString(lector[0]);
            }
            else { sw = 0; }
            conn.connection.Close();

        }

        protected void Fnt_GuardarCompra()
        {
            CLConexion conn = new CLConexion();
            SqlCommand com = new SqlCommand("SP_NuevaCompra", conn.connection);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@Cliente",cliente);
            com.Parameters.AddWithValue("@valor",valor);
            com.Parameters.AddWithValue("@usuario","jean123");
            conn.connection.Open();
            SqlDataReader lector = com.ExecuteReader();
            if (lector.Read() == true)
            {
                codigoCompra = Convert.ToString(lector[0]);
            }
            conn.connection.Close();
            Fnt_GuardarDetalleVenta();
        }

        protected void Fnt_GuardarDetalleVenta()
        {
            CLConexion conn = new CLConexion();
            SqlCommand com = new SqlCommand("SP_DetalleVenta", conn.connection);
            com.CommandType = CommandType.StoredProcedure;
            conn.connection.Open();
            try
            {
                foreach (DataGridViewRow row in DTtabla.Rows)
                {
                    com.Parameters.Clear();
                    com.Parameters.AddWithValue("@codigoCompra", codigoCompra);
                    com.Parameters.AddWithValue("@producto", Convert.ToString(row.Cells["Codigo"].Value));
                    com.Parameters.AddWithValue("@precio", float.Parse(Convert.ToString(row.Cells["Precio"].Value)));
                    com.Parameters.AddWithValue("@cantidad",Convert.ToString(row.Cells["Cantidad"].Value));
                    com.ExecuteNonQuery();
                  
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(""+ex);
            }
            finally { 
                  conn.connection.Close();
            }
           
           
        }

        public void Fnt_BuscarXCodigo(String codigo) { this.code = codigo; Fnt_buscarProducto(); }

        public void Fnt_CargarCliente(String docu) { this.cliente = docu;Fnt_CargarClienteData(); }

        public void Fnt_GuardarCompraDetalle(String DocuCliente,float ValorTotal,DataGridView Gtabla) 
        {
            this.cliente = DocuCliente;
            this.valor = ValorTotal;
            this.DTtabla = Gtabla;
            Fnt_GuardarCompra();
        }

        public String[] GetTable() { return tabla; }

        public String Nombre() { return this.nombre; }

        public int SW() { return this.sw; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using System.Data;

namespace Capa_Logica
{
   public class ClsBuscarProductos
    {
        private String nombre,msj;
        private DataTable tabla = new DataTable();
        protected void Fnt_BuscarProductoxNombre()
        {
            if (nombre == "")
            {
                msj = "Debe Diligenciar un dato de busquedad";
            }
            else 
            {
                ClsBuscarProductoXnombre objBuscar = new ClsBuscarProductoXnombre();
                objBuscar.Fnt_BuscarXNombre(nombre);
                tabla =  objBuscar.GetTable();
            }
           
        }

        public void Fnt_BuscarXnombre(String name) { nombre = name;Fnt_BuscarProductoxNombre(); }

        public DataTable GetTable() { return tabla; }

        public String GetMessage() { return msj; }
    }
}

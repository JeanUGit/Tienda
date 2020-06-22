using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Capa_Datos;
using System.Windows.Forms;

namespace Capa_Logica
{
   public class ClsVentaInfo
    {
        private String code, msj;
        private int sw = 0;
        private String cliente, nombre;
        private float valor;
        private String [] tabla = new String[5];
        private DataGridView DTtabla = new DataGridView();
        protected void Fnt_BuscarProductoxCodigo()
        {
            if (code == "")
            {
                msj = "Debe Diligenciar un dato de busquedad";
            }
            else
            {
                ClsVentaData objVenta = new ClsVentaData();
                objVenta.Fnt_BuscarXCodigo(code);
                if (objVenta.SW() == 1)
                {
                    sw = 1;
                    tabla = objVenta.GetTable();
                }
                else {
                    sw = 0;
                    msj = "No se encontraron datos relacionados al codigo {"+code+"}";
                }
                
            }

        }

        protected void Fnt_GuardarCompraDet()
        {
            if (cliente == "" || valor <=0)
            {
                sw = 0;
                msj = "Debe Diligenciar Toda la información";
            }
            else {
                sw = 1;
                ClsVentaData objve = new ClsVentaData();
                objve.Fnt_GuardarCompraDetalle(cliente, valor, DTtabla);
                msj = "¡¡¡Venta Registrada Exitosamente!!!";
            }
          
        }

        protected void Fnt_CargarClienteData()
        {
            ClsVentaData objVe = new ClsVentaData();
            objVe.Fnt_CargarCliente(cliente);
            if (objVe.SW() == 1)
            {
                sw = 1;
                nombre = objVe.Nombre();
            }
            else if(objVe.SW() == 0 ) { sw = 0; msj = "Cliente no Encontrado!"; }
           
        }

        public void Fnt_BuscarXCodigo(String codigo) { code = codigo; Fnt_BuscarProductoxCodigo(); }

        public void Fnt_CargarCliente(String docu) { this.cliente = docu; Fnt_CargarClienteData(); }

        public void Fnt_GuardarCompraDetalle(String DocuCliente, float ValorTotal, DataGridView Gtabla)
        {
            this.cliente = DocuCliente;
            this.valor = ValorTotal;
            this.DTtabla = Gtabla;
            Fnt_GuardarCompraDet();
        }

        public String[] GetTable() { return tabla; }

        public String GetMessage() { return msj; }

        public String Nombre() { return this.nombre; }

        public int SW() { return this.sw; }

    }
}

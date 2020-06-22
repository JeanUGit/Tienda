using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Logica;

namespace Capa_Diseño
{
    public partial class FrmVenta : Form
    {
        public FrmVenta()
        {
            InitializeComponent();
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")] private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")] private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public void Func_NuevoTicket()
        {
            if(!(tabla.RowCount == 0))
            {
                DialogResult result = MessageBox.Show("Desea borrar toda la información del ticket llamado  " + TabControl.SelectedTab.Text.ToUpper() + " ", "¡¡Mensaje de Confirmación!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    ticket.Text = "TICKET 0";
                    lblTotal.Text = "$0";
                        while(tabla.RowCount >= 1)
                        { tabla.Rows.Remove(tabla.CurrentRow); }
                }

            }
        }

        protected void Fnt_CargarValor()
        {
            double saldo = 0;
            if (!(tabla.RowCount == 0))
            {
               
                for (int x = 0; x < tabla.RowCount; x++)
                {
                    saldo += Convert.ToDouble(tabla.Rows[x].Cells[2].Value) * Convert.ToDouble(tabla.Rows[x].Cells[4].Value);
                }

                lblTotal.Text = saldo.ToString("C");
            }
            else { lblTotal.Text = saldo.ToString("C"); }
            
                
        }

        protected void Fnt_Cliente()
        {
            ClsVentaInfo objVe = new ClsVentaInfo();
            objVe.Fnt_CargarCliente(txtDocumentoCliente.Text);
            if (objVe.SW() == 1)
            {
                lblNombreCliente.Text = objVe.Nombre();
                ticket.Text = objVe.Nombre().ToUpper();
            }
            else if(objVe.SW() == 0 ) { MessageBox.Show(objVe.GetMessage(), "¡¡¡Mensaje de Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            
        }

        private void btnNuevoTicket_Click(object sender, EventArgs e)
        {
            Func_NuevoTicket();
        }

        protected void Fnt_GuardarCompraDET()
        {
            ClsVentaInfo objVe = new ClsVentaInfo();
            objVe.Fnt_GuardarCompraDetalle(txtDocumentoCliente.Text,float.Parse(lblTotal.Text, System.Globalization.NumberStyles.Currency),tabla);
            if (objVe.SW() == 0)
            {
                MessageBox.Show(objVe.GetMessage(), "¡¡¡Mensaje de Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (objVe.SW() == 1) { MessageBox.Show(objVe.GetMessage(), "¡¡¡Mensaje de Información!!!", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void xToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea Cerrar La Pagina?", "Pagina de Cerrar Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnAgregarCajero_Click(object sender, EventArgs e)
        {

        }

        public void Fnt_BuscarProducto(String code) 
        {
            ClsVentaInfo objventa = new ClsVentaInfo();
            objventa.Fnt_BuscarXCodigo(code);
            if (objventa.SW() == 1)
            {
                tabla.Rows.Add(objventa.GetTable()[0], objventa.GetTable()[1], objventa.GetTable()[2], objventa.GetTable()[3], objventa.GetTable()[4]);
                Fnt_CargarValor();
            }
            else if (objventa.SW() == 0)
            {
                MessageBox.Show(objventa.GetMessage(), "¡¡¡Mensaje de Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FrmBuscar buscar = new FrmBuscar();
            buscar.StartPosition = FormStartPosition.CenterScreen;
            buscar.PassCode += new FrmBuscar.pasarCodigo(Fnt_BuscarProducto); //Estamos usando un evento que llama a un delegado
            buscar.ShowDialog();
        }

        private void txtCodigoProducto_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Fnt_BuscarProducto(txtCodigoProducto.Text);
            }
        }

        private void FrmVenta_KeyUp(object sender, KeyEventArgs e)
        {
            if (!(tabla.RowCount == 0))
            {
                if (e.KeyCode == Keys.OemMinus)
                {
                    if ((Convert.ToInt32(tabla.CurrentRow.Cells[4].Value) - 1) == 0)
                    {
                        DialogResult result = MessageBox.Show("No se puede Vender 0 cantidad de producto, si le da OK va a eliminar por completo este producto de está lista", "Mensaje de Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        if (result == DialogResult.OK)
                        {
                            tabla.Rows.Remove(tabla.CurrentRow);
                        }
                    }
                    else { tabla.CurrentRow.Cells[4].Value = Convert.ToInt32(tabla.CurrentRow.Cells[4].Value) - 1; }

                }
                if (e.KeyCode == Keys.Oemplus)
                {
                    if ((Convert.ToInt32(tabla.CurrentRow.Cells[4].Value) + 1) > (Convert.ToInt32(tabla.CurrentRow.Cells[3].Value)))
                    {
                        MessageBox.Show("No se puede Vender MAYOR cantidad de productos a los Existentes en el stock", "Mensaje de Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                    else { tabla.CurrentRow.Cells[4].Value = Convert.ToInt32(tabla.CurrentRow.Cells[4].Value) + 1; }

                }
                Fnt_CargarValor();
            }


            
        }

        private void txtDocumentoCliente_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Fnt_Cliente();
            }
        }

        private void btnCobrarVenta_Click(object sender, EventArgs e)
        {
            Fnt_GuardarCompraDET();
        }
    }
}

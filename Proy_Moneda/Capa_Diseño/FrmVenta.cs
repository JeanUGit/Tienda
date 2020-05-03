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

        public void Func_QuitarTicket()
        {
            int num = Convert.ToInt32(metroTabControl.TabPages.Count.ToString());
            if (num > 1)
            {
                metroTabControl.TabPages.Remove(metroTabControl.SelectedTab);
            }
            else
            {
                MessageBox.Show("No se puede eliminar el unico Ticket", "Advertencia!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void Func_NuevoTicket()
        {
            TabPage nuevo = new TabPage("Tiquete");
            nuevo.BackColor = Color.White;
            metroTabControl.TabPages.Add(nuevo);
        }
        private void btnNuevoTicket_Click(object sender, EventArgs e)
        {
            Func_NuevoTicket();
        }

        private void xToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea Cerrar La Pagina?", "Pagina de Cerrar Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void metroTabControl_DoubleClick(object sender, EventArgs e)
        {
            string texto = Interaction.InputBox(" Ingrese El Nuevo Nombre del tiquete!");
            if (!texto.Equals(""))
            {
                metroTabControl.SelectedTab.Text = texto;
            }
        }

        private void btnQuitarTicket_Click(object sender, EventArgs e)
        {
            Func_QuitarTicket();
        }

        private void btnAgregarCajero_Click(object sender, EventArgs e)
        {

        }

        private void recargasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRecargas ObjRecargas = new FrmRecargas();
            ObjRecargas.Show();
            Hide();
        }

        private void vinculaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegistroVinculos ObjVinculo = new FrmRegistroVinculos();
            ObjVinculo.Show();
            Hide();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVenta ObjVenta = new FrmVenta();
            ObjVenta.Show();
            Hide();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProductos ObjProductos = new FrmProductos();
            ObjProductos.Show();
            Hide();
        }

        private void registroEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEmpleados ObjEmpleados = new FrmEmpleados();
            ObjEmpleados.Show();
            Hide();
        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInventario ObjInventario = new FrmInventario();
            ObjInventario.Show();
            Hide();
        }

        private void FrmVenta_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Diseño
{
    public partial class FrmInventario : Form
    {
        public FrmInventario()
        {
            InitializeComponent();
        }

        private void btnAjustar_Click(object sender, EventArgs e)
        {

        }

        private void xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea Cerrar La Pagina?", "Pagina de Cerrar Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
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

        private void inventarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmInventario ObjInventario = new FrmInventario();
            ObjInventario.Show();
            Hide();
        }
    }
}

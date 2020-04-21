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
    public partial class FrmRegistroVinculos : Form
    {
        public FrmRegistroVinculos()
        {
            InitializeComponent();
            BtnRegistroTarjeta.Visible = true;
            BtnVincular.Visible = false;
        }

        private void BtnRegistroTarjeta_Click(object sender, EventArgs e)
        {
            BtnRegistroTarjeta.Visible = false;
            BtnVincular.Visible = true;
        }

        private void TmsVinculacion_Click(object sender, EventArgs e)
        {
            FrmRegistroVinculos ObjVinculo = new FrmRegistroVinculos();
            ObjVinculo.Show();
            Hide();
        }

        private void TsmRecargas_Click(object sender, EventArgs e)
        {
            FrmRecargas ObjRecargas = new FrmRecargas();
            ObjRecargas.Show();
            Hide();
        }

        private void TsmEmpleados_Click(object sender, EventArgs e)
        {
            FrmEmpleados ObjEmpleados = new FrmEmpleados();
            ObjEmpleados.Show();
            Hide();
        }

        private void TsmCerrar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea Cerrar La Pagina?", "Pagina de Cerrar Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void TmsVentas_Click(object sender, EventArgs e)
        {
            FrmVenta ObjVenta = new FrmVenta();
            ObjVenta.Show();
            Hide();
        }

        private void TmsProductos_Click(object sender, EventArgs e)
        {
            FrmProductos ObjProductos = new FrmProductos();
            ObjProductos.Show();
            Hide();
        }

        private void TmsInventario_Click(object sender, EventArgs e)
        {
            FrmInventario ObjInventario = new FrmInventario();
            ObjInventario.Show();
            Hide();
        }
    }
}

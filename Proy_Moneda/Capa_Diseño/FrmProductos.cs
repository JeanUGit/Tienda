using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Logica;
namespace Capa_Diseño
{
    public partial class FrmProductos : Form
    {
        public FrmProductos()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void TmsRecargas_Click(object sender, EventArgs e)
        {
            FrmRecargas ObjRecargas = new FrmRecargas();
            ObjRecargas.Show();
            Hide();
        }

        private void TmsVinculacion_Click(object sender, EventArgs e)
        {
            FrmRegistroVinculos ObjVinculo = new FrmRegistroVinculos();
            ObjVinculo.Show();
            Hide();
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

        private void TmsRegistroEmpleados_Click(object sender, EventArgs e)
        {
            FrmEmpleados ObjEmpleados = new FrmEmpleados();
            ObjEmpleados.Show();
            Hide();
        }

        private void TmsInventario_Click(object sender, EventArgs e)
        {
            FrmInventario ObjInventario = new FrmInventario();
            ObjInventario.Show();
            Hide();
        }

        private void xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea Cerrar La Pagina?", "Pagina de Cerrar Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        protected void ResetControl()
        {
            txtCodigo.Clear();
            txtCantidadActual.Clear();
            txtDescripcion.Clear();
            txtPrecioCosto.Clear();
        }
        protected void Func_FrmProductos_Guardar()
        {
            CLProductos ObjProducto = new CLProductos();
            ObjProducto.Codigo = txtCodigo.Text;
            ObjProducto.Nombre = txtDescripcion.Text;
            ObjProducto.Precio = Convert.ToDouble(txtPrecioCosto.Text);
            ObjProducto.Stock = Convert.ToInt32(txtCantidadActual.Text);
            ObjProducto.SP_FrmProductos_Guardar();
            if (ObjProducto.msn == "")
            {
                String message = "Guardo Exitosamente";
                String caption = "Registro de productos";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetControl();
            }
        }
        protected void Func_FrmProductos_Buscar()
        {
            CLProductos ObjProducto = new CLProductos();
            ObjProducto.Codigo = txtCodigo.Text;
            ObjProducto.SP_FrmProductos_Buscar();
            txtDescripcion.Text = ObjProducto.Nombre;
            txtPrecioCosto.Text = Convert.ToString(ObjProducto.Precio);
            txtCantidadActual.Text = Convert.ToString(ObjProducto.Stock);
            if(ObjProducto.msn == "")
            {

            }
            else
            {
                String message = "Producto no existente";
                String caption = "Registro de productos";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        protected void Func_FrmProductos_Actualizar()
        {
            CLProductos ObjProducto = new CLProductos();
            ObjProducto.Codigo = txtCodigo.Text;
            ObjProducto.Nombre = txtDescripcion.Text;
            ObjProducto.Precio = Convert.ToDouble(txtPrecioCosto.Text);
            ObjProducto.Stock = Convert.ToInt32(txtCantidadActual.Text);
            ObjProducto.SP_FrmProductos_Actualizar();
        }

        private void btnCatalogo_Click(object sender, EventArgs e)
        {
            ResetControl();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Func_FrmProductos_Guardar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Func_FrmProductos_Actualizar();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Func_FrmProductos_Buscar();
        }

        private void txtCodigo_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Func_FrmProductos_Buscar();
            }
        }
    }
}

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
    public partial class FrmEmpleados : Form
    {
        public FrmEmpleados()
        {
            InitializeComponent();
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
        protected void ResetControl()
        {
            TxtNombreEmpleado.Clear();
            TxtDocumentoEmpleado.Clear();
            TxtTelefonoEmpleado.Clear();
            TxtCorreoEmpleado.Clear();
        }

        protected void Func_FrmEmpleados_GuardarEmpleado()
        {
            CLEmpleados ObjEmpleado = new CLEmpleados();
            ObjEmpleado.Documento = TxtDocumentoEmpleado.Text;
            ObjEmpleado.Nombre = TxtNombreEmpleado.Text;
            ObjEmpleado.Telefono = TxtTelefonoEmpleado.Text;
            ObjEmpleado.Correo = TxtCorreoEmpleado.Text;
            ObjEmpleado.SP_FrmEmpleado_GuardarEmpleado();
            String message = "Guardo Exitosamente";
            String caption = "Registro de empleados";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            ResetControl();
        }
        protected void Func_FrmEmpleados_BuscarEmpleados()
        {
            CLEmpleados ObjEmpleados = new CLEmpleados();
            ObjEmpleados.Documento = TxtDocumentoEmpleado.Text;
            ObjEmpleados.SP_FrmEmpleados_BuscarEmpleado();
            TxtNombreEmpleado.Text = ObjEmpleados.Nombre;
            TxtTelefonoEmpleado.Text = ObjEmpleados.Telefono;
            TxtCorreoEmpleado.Text = ObjEmpleados.Correo;
            if(ObjEmpleados.msn == "")
            {

            }
            else
            {
                String message = "La persona no esta registrada";
                String caption = "Registro de empleados";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        protected void Func_FrmEmpleados_ActualizarEmpleados()
        {
            CLEmpleados ObjEmpleado = new CLEmpleados();
            ObjEmpleado.Documento = TxtDocumentoEmpleado.Text;
            ObjEmpleado.Nombre = TxtNombreEmpleado.Text;
            ObjEmpleado.Telefono = TxtTelefonoEmpleado.Text;
            ObjEmpleado.Correo = TxtCorreoEmpleado.Text;
            ObjEmpleado.SP_FrmEmpleados_ActualizarEmpleados();
            String message = "Actualizado Exitosamente";
            String caption = "Registro de empleados";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            Func_FrmEmpleados_GuardarEmpleado();
        }

        private void TxtDocumentoEmpleado_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Func_FrmEmpleados_BuscarEmpleados();
            }
        }

        private void FrmEmpleados_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                ResetControl();
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            Func_FrmEmpleados_ActualizarEmpleados();
        }
    }
}

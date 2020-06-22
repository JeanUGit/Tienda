using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
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

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")] private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")] private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

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

        private void FrmEmpleados_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void TxtNombreEmpleado_KeyUp(object sender, KeyEventArgs e)
        {
            TxtNombreEmpleado.CharacterCasing = CharacterCasing.Upper;
        }

        private void TxtDocumentoEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Solo ingresar datos numericos
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            //Utilizar la tecla backpace
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten números", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        public static bool ValidarEmail(string email)
        {
            string expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void TxtCorreoEmpleado_Leave(object sender, EventArgs e)
        {
            if (TxtCorreoEmpleado.Text == "")
            {

            }
            else
            {
                //Capturar el email
                if (ValidarEmail(TxtCorreoEmpleado.Text))
                {
                }
                else
                {
                    String message = "Dirección de correo no válida";
                    String caption = "Validación de email";
                    var result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TxtCorreoEmpleado.SelectAll();
                    TxtCorreoEmpleado.Focus();
                }
            }
        }

        private void TxtTelefonoEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Solo ingresar datos numericos
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            //Utilizar la tecla backpace
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten números", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}

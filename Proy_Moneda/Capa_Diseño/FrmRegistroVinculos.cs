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
    public partial class FrmRegistroVinculos : Form
    {
        public FrmRegistroVinculos()
        {
            InitializeComponent();
            BtnRegistroTarjeta.Visible = true;
            BtnVincular.Visible = false;
            BtnActContraseña.Visible = false;
            BtnRegistrar.Visible = true;
            BtnActualizar.Visible = false;
        }



        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")] private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")] private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BtnRegistroTarjeta_Click(object sender, EventArgs e)
        {
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
            TxtDocumento.Clear();
            TxtNombre.Clear();
            TxtInstituto.Clear();
            TxtCorreo.Clear();
            TxtSaldoInicial.Clear();
            TxtCodigo.Clear();
            TxtContraseña.Clear();
        }
        protected void Func_FrmRegistrarVinculo_GuardarPersona()
        {
            CLVinculacion ObjVinculo = new CLVinculacion();
            ObjVinculo.Documento = TxtDocumento.Text;
            ObjVinculo.Nombre = TxtNombre.Text;
            ObjVinculo.Institucion = TxtInstituto.Text;
            ObjVinculo.Correo = TxtCorreo.Text;
            ObjVinculo.SP_FrmRegistrarVinculo_GuardarPersona();
            String message = "Guardo Exitosamente";
            String caption = "Vinculación";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);            
        }
        protected void Func_FrmRegistrarVinculo_RegistrarTarjeta()
        {
            CLVinculacion ObjVinculo = new CLVinculacion();
            ObjVinculo.RFID = TxtCodigo.Text;
            ObjVinculo.Contraseña = TxtContraseña.Text;
            ObjVinculo.Saldo = Convert.ToDouble(TxtSaldoInicial.Text);
            ObjVinculo.SP_FrmRegistrarVinculo_RegistrarTarjeta();
            String message = "Guardo Exitosamente";
            String caption = "Vinculación";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        protected void Func_FrmRegistrarVinculo_BuscarPersona()
        {
            CLVinculacion ObjVinculo = new CLVinculacion();
            ObjVinculo.Documento = TxtDocumento.Text;
            ObjVinculo.SP_FrmRegistrarVinculo_BuscarPersona();
            TxtNombre.Text = ObjVinculo.Nombre;
            TxtInstituto.Text = ObjVinculo.Institucion;
            TxtCodigo.Text = ObjVinculo.RFID;
            TxtSaldoInicial.Text = Convert.ToString(ObjVinculo.Saldo);
            TxtCorreo.Text = ObjVinculo.Correo;
            TxtContraseña.Text = ObjVinculo.Contraseña;
            TxtContraseña.Enabled = false;
            if(ObjVinculo.msn == "")
            {
                BtnVincular.Visible = true;
                BtnRegistroTarjeta.Visible = false;
                BtnActualizar.Visible = true;
                BtnRegistrar.Visible = false;
            }
            else
            {
                String message = "Persona no registrada";
                String caption = "Vinculación";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                BtnVincular.Visible = false;
                BtnRegistroTarjeta.Visible = true;
                BtnActualizar.Visible = false;
                BtnRegistrar.Visible = true;
            }
        }
        protected void Func_FrmRegistrarVinculo_BuscarTarjeta()
        {
            CLVinculacion ObjVinculo = new CLVinculacion();
            ObjVinculo.RFID = TxtCodigo.Text;
            ObjVinculo.SP_FrmRegistrarVinculo_BuscarTarjeta();
            TxtContraseña.Text = ObjVinculo.Contraseña;
            if(TxtCodigo.Text == "" && TxtContraseña.Text == "")
            {
                BtnRegistroTarjeta.Visible = true;
                BtnVincular.Visible = false;
            }
            else
            {
                BtnRegistroTarjeta.Visible = false;
                BtnVincular.Visible = true;
                TxtContraseña.Enabled = false;
            }
        }
        protected void Func_FrmRegistrarVinculo_Vincular()
        {
            CLVinculacion ObjVinculo = new CLVinculacion();
            ObjVinculo.Documento = TxtDocumento.Text;
            ObjVinculo.RFID = TxtCodigo.Text;
            ObjVinculo.SP_FrmRegistrarVinculo_Vincular();
            String message = "Vinculación Exitosa";
            String caption = "Vinculación";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        protected void Func_FrmRegistrarVinculo_ActualizarContraseña()
        {
            CLVinculacion ObjVinculo = new CLVinculacion();
            ObjVinculo.RFID = TxtCodigo.Text;
            ObjVinculo.Contraseña = TxtContraseña.Text;
            ObjVinculo.SP_FrmRegistrarVinculo_ActualizarContraseña();
        }
        protected void Func_FrmRegistrarVinculo_ActualizarPersona()
        {
            CLVinculacion ObjVinculo = new CLVinculacion();
            ObjVinculo.Documento = TxtDocumento.Text;
            ObjVinculo.Nombre = TxtNombre.Text;
            ObjVinculo.Institucion = TxtInstituto.Text;
            ObjVinculo.Correo = TxtCorreo.Text;
            ObjVinculo.SP_FrmRegistrarVinculo_ActualizarPersona();
            String message = "Actualización Exitosa";
            String caption = "Vinculación";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {            
                TxtContraseña.Enabled = true;
                BtnActContraseña.Visible = true;          
        }

        private void linkLabel2_MouseHover(object sender, EventArgs e)
        {
            TxtContraseña.UseSystemPasswordChar = false;
        }

        private void linkLabel2_MouseLeave(object sender, EventArgs e)
        {
            TxtContraseña.UseSystemPasswordChar = true;
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            Func_FrmRegistrarVinculo_GuardarPersona();
        }

        private void BtnRegistroTarjeta_Click_1(object sender, EventArgs e)
        {
            Func_FrmRegistrarVinculo_RegistrarTarjeta();
            BtnRegistroTarjeta.Visible = false;
            BtnVincular.Visible = true;
        }

        private void BtnVincular_Click(object sender, EventArgs e)
        {
            Func_FrmRegistrarVinculo_Vincular();
        }

        private void BtnActContraseña_Click(object sender, EventArgs e)
        {
            Func_FrmRegistrarVinculo_ActualizarContraseña();
            BtnActContraseña.Visible = false;
        }

        private void TxtDocumento_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Func_FrmRegistrarVinculo_BuscarPersona();
            }
        }

        private void TxtCodigo_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Func_FrmRegistrarVinculo_BuscarTarjeta();
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            Func_FrmRegistrarVinculo_ActualizarPersona();
        }

        private void FrmRegistroVinculos_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                ResetControl();
            }
        }

        private void FrmRegistroVinculos_Load(object sender, EventArgs e)
        {
            
        }

        private void FrmRegistroVinculos_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}

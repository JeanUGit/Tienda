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
    public partial class FrmRecargas : Form
    {
        public FrmRecargas()
        {
            InitializeComponent();
        }

        private void FrmRecargas_Load(object sender, EventArgs e)
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

        private void TsmCerrar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea Cerrar La Pagina?", "Pagina de Cerrar Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void TsmEmpleados_Click_1(object sender, EventArgs e)
        {
            FrmEmpleados ObjEmpleados = new FrmEmpleados();
            ObjEmpleados.Show();
            Hide();
        }

        private void TmsVentas_Click(object sender, EventArgs e)
        {
            FrmVenta ObjVenta = new FrmVenta();
            ObjVenta.Show();
            Hide();
        }

        private void TmsInventario_Click(object sender, EventArgs e)
        {
            FrmInventario ObjInventario = new FrmInventario();
            ObjInventario.Show();
            Hide();
        }

        private void TmsProductos_Click(object sender, EventArgs e)
        {
            FrmProductos ObjProductos = new FrmProductos();
            ObjProductos.Show();
            Hide();
        }
        protected void Func_FrmRecargas_RecargarSaldo()
        {
            
            CLRecarga ObjRecarga = new CLRecarga();
            Double Total;
            Total = Convert.ToDouble(TxtRecargaSaldo.Text) + Convert.ToDouble(LblSaldo.Text);
            ObjRecarga.RFID = TxtCodigo.Text;
            ObjRecarga.Saldo = Total;
            ObjRecarga.SP_FrmRecargas_RecargarSaldo();
            String message = "Recarga Exitosa";
            String caption = "Recargas";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        protected void Func_FrmRecargas_Buscar()
        {
            CLRecarga ObjRecarga = new CLRecarga();
            ObjRecarga.RFID = TxtCodigo.Text;
            ObjRecarga.SP_FrmRecargas_Buscar();
            LblSaldo.Text = Convert.ToString(ObjRecarga.Saldo);
        }

        private void TxtCodigo_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Func_FrmRecargas_Buscar();
            }
        }

        private void BtnRecargar_Click(object sender, EventArgs e)
        {
            Func_FrmRecargas_RecargarSaldo();
            Func_FrmRecargas_Buscar();
            TxtRecargaSaldo.Clear();
        }
    }
}

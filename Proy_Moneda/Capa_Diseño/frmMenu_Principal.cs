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

    public partial class frmMenu_Principal : Form
    {
        public frmMenu_Principal()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")] private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (pnlMenu.Width == 220)
            { timerOcultarM.Enabled = true; }
            if (pnlMenu.Width == 80)
            { timerMostrarM.Enabled = true; }
        }

        private void timerOcultarM_Tick(object sender, EventArgs e)
        {
            if (pnlMenu.Width <= 80)
            { timerOcultarM.Enabled = false; }
            else
            { pnlMenu.Width -= 20; }
        }

        private void timerMostrarM_Tick(object sender, EventArgs e)
        {
            if (pnlMenu.Width >= 220)
            { timerMostrarM.Enabled = false; }
            else
            { pnlMenu.Width += 20; }
        }

        private void lblCerrar_Click(object sender, EventArgs e)
        {Application.Exit();}

        private void fnt_frmPn(object formHijo)
        {
            if (pnlContenedor.Controls.Count > 0)
                pnlContenedor.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            fh.FormBorderStyle = FormBorderStyle.None;
            this.pnlContenedor.Controls.Add(fh);
            this.pnlContenedor.Tag = fh;
            fh.Show();
        }

        private void btnRegEmple_Click(object sender, EventArgs e)
        { fnt_frmPn(new FrmEmpleados()); }

        private void btnRecargas_Click(object sender, EventArgs e)
        {fnt_frmPn(new FrmRecargas());}

        private void btnVinculaciones_Click(object sender, EventArgs e)
        {fnt_frmPn(new FrmRegistroVinculos());}

        private void button1_Click(object sender, EventArgs e)
        { fnt_frmPn(new FrmVenta()); }

        private void button2_Click(object sender, EventArgs e)
        { fnt_frmPn(new FrmInventario()); }

        private void button3_Click(object sender, EventArgs e)
        { fnt_frmPn(new FrmProductos()); }

        private void pnlCabecera_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pnlContenedor_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pnlMenu_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}

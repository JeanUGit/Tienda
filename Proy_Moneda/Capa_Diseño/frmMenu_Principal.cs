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
    public partial class frmMenu_Principal : Form
    {
        public frmMenu_Principal()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (pnlMenu.Width == 220)
            { timerOcultarM.Enabled = true; }
            if (pnlMenu.Width == 60)
            { timerMostrarM.Enabled = true; }
        }

        private void timerOcultarM_Tick(object sender, EventArgs e)
        {
            if (pnlMenu.Width <= 60)
            { timerOcultarM.Enabled = false; }
            else
            { pnlMenu.Width -= 20; }
        }

        private void timerMostrarM_Tick(object sender, EventArgs e)
        {
            if (pnlMenu.Width >= 220)
            { timerMostrarM.Enabled = false; }
            else
            { pnlMenu.Width += +20; }
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
    }
}

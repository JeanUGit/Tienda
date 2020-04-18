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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void TsmCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        protected void fnt_BtnEmpleado()
        {
            FrmEmpleados ObjEmpleados = new FrmEmpleados();
            ObjEmpleados.Show();
            Hide();
        }

        private void BtnEmpleados_Click(object sender, EventArgs e)
        { fnt_BtnEmpleado(); }

        protected void fnt_BtnRecargas()
        {
            FrmRecargas ObjRecargas = new FrmRecargas();
            ObjRecargas.Show();
            Hide();
        }

        private void BtnRecargas_Click(object sender, EventArgs e)
        { fnt_BtnRecargas(); }

        protected void fnt_BtnVinculacion()
        {
            FrmRegistroVinculos ObjVinculo = new FrmRegistroVinculos();
            ObjVinculo.Show();
            Hide();
        }
        private void label1_Click(object sender, EventArgs e)
        {fnt_BtnEmpleado();}

        private void label2_Click(object sender, EventArgs e)
        {fnt_BtnRecargas();}

        private void label3_Click(object sender, EventArgs e)
        { fnt_BtnVinculacion(); }

        private void button6_Click(object sender, EventArgs e)
        { fnt_BtnVinculacion(); }
    }
}

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
    public partial class FrmRecargas : Form
    {
        public FrmRecargas()
        {
            InitializeComponent();
        }

        private void FrmRecargas_Load(object sender, EventArgs e)
        {
          
         
        }

        private void TsmEmpleados_Click(object sender, EventArgs e)
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
            Application.Exit();
        }

        private void TsmEmpleados_Click_1(object sender, EventArgs e)
        {
            FrmEmpleados ObjEmpleados = new FrmEmpleados();
            ObjEmpleados.Show();
            Hide();
        }
    }
}

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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();          
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            FrmPrincipal ObjPrincipal = new FrmPrincipal();
            ObjPrincipal.Show();
            Hide();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            
        }
    }
}

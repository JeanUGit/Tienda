using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Logica;

namespace Capa_Diseño
{
    public partial class FrmBuscar : Form
    {
        public delegate void pasarCodigo(String codigo);
        public event pasarCodigo PassCode;
        public FrmBuscar()
        {
            InitializeComponent();
        }

        private void xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected void Fnt_BuscarXnombre()
        {
            ClsBuscarProductos objBuscar = new ClsBuscarProductos();
            objBuscar.Fnt_BuscarXnombre(txtNombre.Text);
            dgvTabla.DataSource = objBuscar.GetTable();
        }

        private void txtNombre_KeyUp(object sender, KeyEventArgs e)
        { 
           Fnt_BuscarXnombre();
            if (e.KeyCode == Keys.Enter)
            { Fnt_Datos(); }
        }


        protected void Fnt_Datos()
        {
            PassCode(dgvTabla.CurrentRow.Cells[0].Value.ToString());
            this.Close();
        }

        private void dgvTabla_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Fnt_Datos();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Fnt_Datos();
        }
    }
}

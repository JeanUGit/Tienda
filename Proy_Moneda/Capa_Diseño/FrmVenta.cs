using Microsoft.VisualBasic;
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
    public partial class FrmVenta : Form
    {
        public FrmVenta()
        {
            InitializeComponent();
        }

        public void Func_QuitarTicket()
        {
            int num = Convert.ToInt32(metroTabControl.TabPages.Count.ToString());
            if (num > 1)
            {
                metroTabControl.TabPages.Remove(metroTabControl.SelectedTab);
            }
            else
            {
                MessageBox.Show("No se puede eliminar el unico Ticket", "Advertencia!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        public void Func_NuevoTicket()
        {
            TabPage nuevo = new TabPage("Tiquete");
            nuevo.BackColor = Color.White;
            metroTabControl.TabPages.Add(nuevo);
        }
        private void btnNuevoTicket_Click(object sender, EventArgs e)
        {
            Func_NuevoTicket();
        }

        private void xToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea Cerrar La Pagina?", "Pagina de Cerrar Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void metroTabControl_DoubleClick(object sender, EventArgs e)
        {
            string texto = Interaction.InputBox(" Ingrese El Nuevo Nombre del tiquete!");
            if (!texto.Equals(""))
            {
                metroTabControl.SelectedTab.Text = texto;
            }
        }

        private void btnQuitarTicket_Click(object sender, EventArgs e)
        {
            Func_QuitarTicket();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win.Pizzeria
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formlogin = new FormLogin();
            formlogin.ShowDialog();
        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nuestrasPizzasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var FormNuestrasPizzas = new FormNuestrasPizzas();
            FormNuestrasPizzas.MdiParent = this;
            FormNuestrasPizzas.Show();

        }

        private void nuestrosPostresToolStripMenuItem_Click(object sender, EventArgs e)
        {
             
        }
    }
}

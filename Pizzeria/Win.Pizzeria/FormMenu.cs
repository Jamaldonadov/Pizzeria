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
            var FormNuestrosPostres = new FormNuestrosPostres();
            FormNuestrosPostres.MdiParent = this;
            FormNuestrosPostres.Show();
        }

        private void equipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var FormEquipo = new FormEquipo();
            FormEquipo.MdiParent = this;
            FormEquipo.Show();
        }

        private void bebidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var FormBebidas = new FormBebidas();
            FormBebidas.MdiParent = this;
            FormBebidas.Show();
        }

        private void tiposDePagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var FormPagos = new FormPagos();
            FormPagos.MdiParent = this;
            FormPagos.Show();
        }

        private void perecederoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var FormPerecederos = new FormPerecederos();
            FormPerecederos.MdiParent = this;
            FormPerecederos.Show();
        }
    }
}

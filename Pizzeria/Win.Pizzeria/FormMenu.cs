﻿using System;
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
           
            
            IsMdiContainer = true;
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
            FormNuestrasPizzas  formnuestrapizza = new FormNuestrasPizzas();
            formnuestrapizza.MdiParent = this;
           formnuestrapizza.Show();

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

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formFactura = new FormFactura();
            formFactura.MdiParent = this;
            formFactura.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formclientes = new FormClientes();
            formclientes.MdiParent = this;
            formclientes.Show();
        }

        private void reportesDeNuestrasPizzasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formReporteNuestrasPizzas = new FormReporteNuestrasPizzas();
            formReporteNuestrasPizzas.MdiParent = this;
            formReporteNuestrasPizzas.Show();
        }

        private void reporteDeFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formReporteFacturas = new FormReporteFacturas();
            formReporteFacturas.MdiParent = this;
            formReporteFacturas.Show();
        }
    }
}

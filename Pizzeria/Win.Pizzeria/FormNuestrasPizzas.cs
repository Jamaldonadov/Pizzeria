using BL.Pizzeria;
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
    public partial class FormNuestrasPizzas : Form
    {
        NuestrasPizzasBL _nuestraspizzas;

        public FormNuestrasPizzas()
        {
            InitializeComponent();

            _nuestraspizzas = new NuestrasPizzasBL();
            menuPizzasBindingSource.DataSource = _nuestraspizzas.ObtenerPedidos();
        }
    }
}

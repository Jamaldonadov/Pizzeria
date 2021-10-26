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
            ordenBindingSource.DataSource = _nuestraspizzas.Pedido();
        }

        private void ordenBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            ordenBindingSource.EndEdit();
            var nuestraspizzas = (NuestrasPizzas) ordenBindingSource.Current;

            var resultado = _nuestraspizzas.GuardarNuestrasPizzas(nuestraspizzas);

            if ( resultado.Exitoso == true)
            {
                ordenBindingSource.ResetBindings(false);
                DeshabilitarHabilitarBotones(true);
                MessageBox.Show("Pedido Guardado con exito");
            }
            else
            {
                MessageBox.Show(resultado.Mensaje);
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _nuestraspizzas.AgregarNuestrasPizzas();
            ordenBindingSource.MoveLast();

            DeshabilitarHabilitarBotones(false);
        }

        private void DeshabilitarHabilitarBotones(bool valor)
        {
            bindingNavigatorMoveFirstItem.Enabled = valor;
            bindingNavigatorMoveLastItem.Enabled = valor;
            bindingNavigatorMovePreviousItem.Enabled = valor;
            bindingNavigatorMoveNextItem.Enabled = valor;
            bindingNavigatorPositionItem.Enabled = valor;

            bindingNavigatorAddNewItem.Enabled = valor;
            bindingNavigatorDeleteItem.Enabled = valor;
            toolStripButtonCancelar.Visible = !valor;

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (pedidoTextBox.Text != "")
            {
                var resultado = MessageBox.Show("Desea  eliminar este registro?", "Eliminar", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    var pedido = Convert.ToInt32(pedidoTextBox.Text);
                    Eliminar(pedido);
                }
            }
        }

        private void Eliminar(int pedido)
        {
            
            var resultado = _nuestraspizzas.EliminarNuestrasPizzas(pedido);

            if (resultado == true)
            {
                ordenBindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Ocurrio un error al eliminar la pizza");
            }
        }

        private void toolStripButtonCancelar_Click(object sender, EventArgs e)
        {
            DeshabilitarHabilitarBotones(true);
            Eliminar(0); 
        }

        private void pedidoTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

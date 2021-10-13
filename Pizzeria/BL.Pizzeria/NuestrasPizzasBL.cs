using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Pizzeria
{
    public class NuestrasPizzasBL
    {
        public BindingList<NuestrasPizzas> MenuPizzas { get; set; }

        public NuestrasPizzasBL()
        {
            MenuPizzas = new BindingList<NuestrasPizzas>();

            var NuestrasPizzas1 = new NuestrasPizzas();
            NuestrasPizzas1.Pedido = 001;
            NuestrasPizzas1.Nombre = "Mozzarela";
            NuestrasPizzas1.Precio = 99;
            NuestrasPizzas1.Disponible = true;

            MenuPizzas.Add(NuestrasPizzas1);

            var NuestrasPizzas2 = new NuestrasPizzas();
            NuestrasPizzas2.Pedido = 002;
            NuestrasPizzas2.Nombre = "Mozzarela y Queso";
            NuestrasPizzas2.Precio = 110;
            NuestrasPizzas2.Disponible = true;

            MenuPizzas.Add(NuestrasPizzas2);

            var NuestrasPizzas3 = new NuestrasPizzas();
            NuestrasPizzas3.Pedido = 003;
            NuestrasPizzas3.Nombre = "Prosiuto";
            NuestrasPizzas3.Precio = 150;
            NuestrasPizzas3.Disponible = true;

            MenuPizzas.Add(NuestrasPizzas3);

            var NuestrasPizzas4 = new NuestrasPizzas();
            NuestrasPizzas4.Pedido = 004;
            NuestrasPizzas4.Nombre = "4 Estaciones";
            NuestrasPizzas4.Precio = 180;
            NuestrasPizzas4.Disponible = true;

            MenuPizzas.Add(NuestrasPizzas4);

            var NuestrasPizzas5 = new NuestrasPizzas();
            NuestrasPizzas5.Pedido = 005;
            NuestrasPizzas5.Nombre = "4 Quesos";
            NuestrasPizzas5.Precio = 195;
            NuestrasPizzas5.Disponible = true;

            MenuPizzas.Add(NuestrasPizzas5);
        }
        public BindingList<NuestrasPizzas> ObtenerPedidos()
        {
            return MenuPizzas;
        }
    }

    public class NuestrasPizzas
    {
        public int Pedido { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public bool Disponible { get; set; }
    }
}

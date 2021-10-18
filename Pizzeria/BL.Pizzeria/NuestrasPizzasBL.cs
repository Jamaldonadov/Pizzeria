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
        public BindingList<NuestrasPizzas> Orden { get; set; }

        public NuestrasPizzasBL()
        {
            Orden = new BindingList<NuestrasPizzas>();

            var nuestraspizzas1 = new NuestrasPizzas();
            nuestraspizzas1.Pedido = 1;
            nuestraspizzas1.Tipo = "Mozzarela";
            nuestraspizzas1.Precio = 100;
            nuestraspizzas1.Disponible = true;

            Orden.Add(nuestraspizzas1);

            var nuestraspizzas2 = new NuestrasPizzas();
            nuestraspizzas2.Pedido = 2;
            nuestraspizzas2.Tipo = "4 Estaciones";
            nuestraspizzas2.Precio = 120;
            nuestraspizzas2.Disponible = true;

            Orden.Add(nuestraspizzas2);

            var nuestraspizzas3 = new NuestrasPizzas();
            nuestraspizzas3.Pedido = 3;
            nuestraspizzas3.Tipo = "Hawaiillana";
            nuestraspizzas3.Precio = 150;
            nuestraspizzas3.Disponible = true;

            Orden.Add(nuestraspizzas3);

            var nuestraspizzas4 = new NuestrasPizzas();
            nuestraspizzas4.Pedido = 4;
            nuestraspizzas4.Tipo = "4 Quesos";
            nuestraspizzas4.Precio = 170;
            nuestraspizzas4.Disponible = true;

            Orden.Add(nuestraspizzas4);
        }

        public BindingList<NuestrasPizzas> Pedido()
        {
            return Orden;
        }

        public Resultado GuardarNuestrasPizzas(NuestrasPizzas nuestraspizzas)
        {
            var resultado = validar(nuestraspizzas);
            if (resultado.Exitoso == false)
            {
                return resultado;
            }

            if (nuestraspizzas.Pedido == 0)
            {
                nuestraspizzas.Pedido = Orden.Max(item => item.Pedido) + 1;
            }

            resultado.Exitoso = true;
            return resultado;
        }

        public void AgregarNuestrasPizzas()
        {
            var nuevaPizza = new NuestrasPizzas();
            Orden.Add(nuevaPizza);
        } 

        public bool EliminarNuestrasPizzas(int pedido)
        {
            foreach (var nuestraspizzas in Orden)
            {
                if (nuestraspizzas.Pedido == pedido)
                {
                    Orden.Remove(nuestraspizzas);
                    return true;
                }
            }

            return false;
        }

        private Resultado validar(NuestrasPizzas nuestraspizzas)
        {
            var resultado = new Resultado();
            resultado.Exitoso = true;

            if (string.IsNullOrEmpty(nuestraspizzas.Tipo) == true)
            {
                resultado.Mensaje = "Ingrese un tipo de pizza";
                resultado.Exitoso = false;
            }


            if (nuestraspizzas.Precio < 0)
            {
                resultado.Mensaje = "El Precio debe ser mayor que cero";
                resultado.Exitoso = false;
            }
            return resultado;
        }
    }

    public class NuestrasPizzas
    {
        public int Pedido { get; set; }
        public string Tipo  { get; set; }
        public double Precio { get; set; }
        public bool Disponible { get; set; }
    }

    public class Resultado
    {
        public bool Exitoso { get; set; }
        public string Mensaje { get; set; }
    }
}

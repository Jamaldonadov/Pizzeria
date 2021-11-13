using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Pizzeria
{
    
        public class NuestrasPizzasBL
        {
            Contexto _contexto;
            public BindingList<NuestrasPizzas> Orden { get; set; }

            public NuestrasPizzasBL()
            {
                _contexto = new Contexto();
                Orden = new BindingList<NuestrasPizzas>();


            }

            public BindingList<NuestrasPizzas> Pedido()
            {
                _contexto.Nuestrapizzas.Load();
                Orden = _contexto.Nuestrapizzas.Local.ToBindingList();

                return Orden;
            }

        public void CancelarCambios()
        {
            foreach (var item in _contexto.ChangeTracker.Entries())
            {
                item.State = EntityState.Unchanged;
                item.Reload();
            }

        }

            public Resultado GuardarNuestrasPizzas(NuestrasPizzas nuestraspizzas)
        {
            var resultado = validar(nuestraspizzas);
            if (resultado.Exitoso == false)
            {
                return resultado;
            }

            _contexto.SaveChanges();

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
                    _contexto.SaveChanges();
                    return true;
                }
            }

            return false;
        }

        private Resultado validar(NuestrasPizzas nuestraspizzas)
        {
            var resultado = new Resultado();
            resultado.Exitoso = true;


            if (nuestraspizzas.Precio < 0)
            {
                resultado.Mensaje = "El Precio debe ser mayor que cero";
                resultado.Exitoso = false;
            }

            if (nuestraspizzas.TipopizzaId == 0 )
            {
                resultado.Mensaje = "Seleccione un tipo de pizza";
                resultado.Exitoso = false;
            }


            if (nuestraspizzas.TipoId == 0)
            {
                resultado.Mensaje = "Seleccione un tamaño de pizza";
                resultado.Exitoso = false;
            }
            return resultado;
        }
    }


    public class NuestrasPizzas
    {

        [Key]
        public int Pedido { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public int TipopizzaId { get; set; }
        public Tipopizzas tipopizza { get; set; }
        public int TipoId { get; set; }
        public Tipo Tipo { get; set; }
        public bool Disponible { get; set; }
        public byte[] Foto { get; set; }



        public NuestrasPizzas()
        {
            Disponible = true;
        }
    }

    public class Resultado
    {
        public bool Exitoso { get; set; }
        public string Mensaje { get; set; }
    }
}

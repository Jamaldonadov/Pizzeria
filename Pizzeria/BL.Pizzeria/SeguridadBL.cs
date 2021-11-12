using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Pizzeria
{
    public class SeguridadBL
    {
        Contexto _contexto;

        public SeguridadBL()
        {
            _contexto = new Contexto();
        }

        public bool Autorizar(string usuario, string Contrasena)
        {
            var Usuarios = _contexto.Usuarios.ToList();
            foreach (var usuarioDB in Usuarios)
                    {

                         if ( usuario == usuarioDB.nombre &&  Contrasena == usuarioDB.Contrasena)
                         { 
                             return true;
                          }
            }

           

            return false;
        }
    }

    public class Usuario
    {

        public int Id { get; set; }
        public string nombre  { get; set; } 
        public string Contrasena { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Pizzeria
{
    public class SeguridadBL
    {
        Contexto _contexto;
        public BindingList<Usuario> ListaUsuarios { get; set; }

        public SeguridadBL()
        {
            _contexto = new Contexto();
            ListaUsuarios = new BindingList<Usuario>();
        }

        public BindingList<Usuario> ObtenerUsuario()
        {
            _contexto.Usuarios.Load();
            ListaUsuarios = _contexto.Usuarios.Local.ToBindingList();

            return ListaUsuarios;
        }

        public void CancelarCambios()
        {
            foreach (var item in _contexto.ChangeTracker.Entries())
            {
                item.State = EntityState.Unchanged;
                item.Reload();
            }
        }

        public Resultado GuardarUsuario(Usuario usuario)
        {
            var resultado = Validar(usuario);
            if (resultado.Exitoso == false)
            {
                return resultado;
            }

            _contexto.SaveChanges();
            resultado.Exitoso = true;
            return resultado;

        }

        public void AgregarUsuario()
        {
            var nuevoUsuario = new Usuario();
            _contexto.Usuarios.Add(nuevoUsuario);
        }

        public bool EliminarUsuario(int id)
        {
            foreach (var usuario in ListaUsuarios.ToList())
            {
                if (usuario.Id == id )
                {
                    ListaUsuarios.Remove(usuario);
                    _contexto.SaveChanges();
                    return true;
                }
            }

            return false;
        }

        private Resultado Validar(Usuario usuario)
        {
            var resultado = new Resultado();
            resultado.Exitoso = true;

            if (usuario == null)
            {
                resultado.Mensaje = "Agregue un usuario Valido";
                resultado.Exitoso = false;

                return resultado;
            }

            return resultado;
        }


        public Usuario Autorizar(string usuario, string Contrasena)
        {
            var Usuarios = _contexto.Usuarios.ToList();
            foreach (var usuarioDB in Usuarios)
                    {

                         if ( usuario == usuarioDB.nombre &&  Contrasena == usuarioDB.Contrasena)
                         { 
                             return usuarioDB;
                          }
            }

           

            return null;
        }
    }

    public class Usuario
    {

        public int Id { get; set; }
        public string nombre  { get; set; } 
        public string Contrasena { get; set; }
        public string TipoUsuario { get; set; }
    }
}

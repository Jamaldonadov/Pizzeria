using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Pizzeria
{
    public class SeguridadBL
    {
        public bool Autorizar(string usuario, string contraseña)
        {
            if (usuario == "Maldonado" && contraseña == "mal1234" || usuario == "Torres" && contraseña == "1234torres" || usuario == "Panchame" && contraseña == "1234panchame")
             {
                return true;
            } else
            {
                if (usuario == "user" && contraseña == "user456"  )
                    {

                    return true;
                }
            }

            return false;
        }
    }
}

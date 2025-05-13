using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace Logica
{
    public class Usuario
    {
        public bool CrearUsuario(string Usuario, string clave) 
        {
            return true;
        }
		public bool Loguearse(string Usuario, string clave, string rolSeleccionado)
        {
            if (Usuario == "admin" && clave == "1234" && rolSeleccionado == "Administrador")
            {
                return true;
            }

            if (Usuario == "bibliotecario" && clave == "1234" && rolSeleccionado == "Bibliotecario")
            {
                return true;
            }

            if (Usuario == "vendedor" && clave == "1234" && rolSeleccionado == "Vendedor")
            {
                return true;
            }

            if (Usuario == "gerente" && clave == "1234" && rolSeleccionado == "Gerente")
            {
                return true;
            }

            return false;
            //Persistencia.Usuario dalUsuario = new Persistencia.Usuario();

            //List<Entidades.Usuario> usuarios = dalUsuario.Listar();

            //         foreach (Entidades.Usuario unUsuario in usuarios) 
            //         {
            //             if (unUsuario.Clave == clave.Trim() && unUsuario.UserName == Usuario.Trim()) 
            //             {
            //                 return true;
            //             }
            //         }

            //         return false;
        }
    }
}

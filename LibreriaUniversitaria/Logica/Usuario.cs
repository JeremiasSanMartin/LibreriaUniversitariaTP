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
        public bool crearUsuario(string Usuario, string clave) 
        {
            return true;
        }
		public bool loguearse(string Usuario, string clave, string rolSeleccionado)
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
        }
    }
}

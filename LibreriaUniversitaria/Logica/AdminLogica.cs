using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Persistencia;

namespace Logica
{
    public class AdminLogica
    {
        private UsuarioDatos usuarioDatos = new UsuarioDatos();
        public bool crearUsuario(Usuario usuario) 
        {
            //Llamo al método de la capa de persistencia para insertar un nuevo usuario
            int resultado = usuarioDatos.insertarUsuario(usuario);

            if(resultado > 0)
            {
                return true; //Si se insertó correctamente, retorno true
            }
            else
            {
                return false; //Si no se insertó, retorno false
            }
        }

        public bool inactivarUsuario(Usuario usuario)
        {
            //Llamo al método de la capa de persistencia para inactivar un usuario
            int resultado = this.usuarioDatos.inactivarUsuario(usuario);
            return resultado > 0;
        }

        public DataTable buscarUsuario()
        {
            //Llamo al método de la capa de persistencia para obtener los datos del usuario
            return usuarioDatos.obtenerDatosUsuario();
        }

    }
}

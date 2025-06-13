using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia;

namespace Logica
{
    public class AdminLogica
    {
        Persistencia.UsuarioDatos usuario = new Persistencia.UsuarioDatos();
        public bool crearUsuario(string nombre, string apellido, string nombreUsuario, string contraseña, string dni, string rol) 
        {
            //Llamo al método de la capa de persistencia para insertar un nuevo usuario
            int resultado = usuario.InsertarUsuario(nombreUsuario, contraseña, nombre, apellido, rol, dni);

            if(resultado > 0)
            {
                return true; //Si se insertó correctamente, retorno true
            }
            else
            {
                return false; //Si no se insertó, retorno false
            }
        }

        public DataTable buscarUsuario()
        {
            //Llamo al método de la capa de persistencia para obtener los datos del usuario
            return usuario.ObtenerDatosUsuario();
        }

    }
}

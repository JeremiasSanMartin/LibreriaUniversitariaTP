using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia;

namespace Logica
{
    public class UsuarioLogica
    {
        Persistencia.UsuarioDatos unLogin = new Persistencia.UsuarioDatos();

        public bool loguearse(string nombreUsuario, string clave, out string rol) //El out string rol es para devolver el rol del usuario, como parametro de salida
        {
            DataTable dt = unLogin.ObtenerDatos();

            foreach (DataRow fila in dt.Rows)
            {
                if (fila["nombre_usuario"].ToString() == nombreUsuario && fila["contrasena"].ToString() == clave)
                {
                    // Devuelve el rol si la validación es correcta
                    rol = fila["rol"].ToString();
                    return true; // Retorna true si el usuario y la contraseña son correctos
                }
            }
            // Devuelve null si no se encontró el usuario o la contraseña
            rol = null;
            return false;
        }
    }
}

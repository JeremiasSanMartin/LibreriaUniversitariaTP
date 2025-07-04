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
    public class UsuarioLogica
    {
        private UsuarioDatos usuarioDatos = new UsuarioDatos();

        public bool loguearse(Usuario usuario) //El out string rol es para devolver el rol del usuario, como parametro de salida
        {
            DataTable dt = usuarioDatos.obtenerDatosUsuarioLogin(usuario);

            foreach (DataRow fila in dt.Rows)
            {
                if (fila["nombre_usuario"].ToString() == usuario.Nombre_usuario && fila["contrasena"].ToString() == usuario.Contraseña)
                {
                    // Devuelve el rol si la validación es correcta
                    usuario.Rol = fila["rol"].ToString();

                    usuario.ID = (int)fila["id"];

                    return true; // Retorna true si el usuario y la contraseña son correctos
                }
            }
            // Devuelve null si no se encontró el usuario o la contraseña

            usuario.Rol = null;

            usuario.ID = 0;

            return false;
        }
    }
}

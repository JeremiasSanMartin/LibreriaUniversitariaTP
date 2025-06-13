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
            int filasAfectadas = usuario.InsertarUsuario(nombreUsuario, contraseña, nombre, apellido, rol, dni);

            return filasAfectadas > 0; // Retorna true si se insertó correctamente, false en caso contrario
        }

        public DataTable buscarUsuario()
        {
            //Llamo al método de la capa de persistencia para obtener los datos del usuario
            return usuario.ObtenerDatosUsuario();
        }

    }
}

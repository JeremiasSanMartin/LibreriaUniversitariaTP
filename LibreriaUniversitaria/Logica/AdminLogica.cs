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
        public bool crearUsuario(string nombre, string apellido, string nombreUsuario, string contraseña, int idRol) 
        {
            //Llamo al método de la capa de persistencia para insertar un nuevo usuario
            int filasAfectadas = usuario.insertarUsuario(nombreUsuario, contraseña, nombre, apellido, idRol);

            return filasAfectadas > 0; // Retorna true si se insertó correctamente, false en caso contrario
        }

        public DataTable buscarUsuario()
        {
            //Llamo al método de la capa de persistencia para obtener los datos del usuario
            return usuario.obtenerDatosUsuario();
        }

    }
}

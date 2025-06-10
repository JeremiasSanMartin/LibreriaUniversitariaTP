using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Persistencia;
using DAL;

namespace Persistencia
{
    public class UsuarioDatos
    {
        public DataTable ObtenerDatos()
        {
            Conexion conexion = new Conexion();

            DataTable dt = conexion.LeerPorComando("SELECT u.nombre_usuario, u.contrasena, r.nombre AS rol " + "FROM [BibliotecaDB].[dbo].[Usuarios] u " + "INNER JOIN [BibliotecaDB].[dbo].[Roles] r ON u.id_rol = r.id");
            return dt;
        }
    }

}

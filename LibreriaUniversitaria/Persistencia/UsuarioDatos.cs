using DAL;
using Entidades;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class UsuarioDatos
    {
        public DataTable ObtenerDatosUsuarioLogin(string nombreUsuario, string contraseña)
        {
            Conexion conexion = new Conexion();
            SqlParameter[] parametros = new SqlParameter[]
            {
                conexion.crearParametro("@nombre_usuario", nombreUsuario),
                conexion.crearParametro("@contrasena", contraseña)
            };
            DataTable dt = conexion.leerPorStoreProcedure("obtenerUsuarioLogin", parametros);
            return dt;
        }

        public int InsertarUsuario(string nombreUsuario, string contraseña, string nombre, string apellido, int idRol)
        {
            Conexion conexion = new Conexion();
            SqlParameter[] parametros = new SqlParameter[]
            {
                conexion.crearParametro("@nombre_usuario", nombreUsuario),
                conexion.crearParametro("@contrasena", contraseña),
                conexion.crearParametro("@nombre", nombre),
                conexion.crearParametro("@apellido", apellido),
                conexion.crearParametro("@dni", ""),
                conexion.crearParametro("@id_rol", idRol),
                conexion.crearParametro("@activo", 1)//Si el usuario se crea, por defecto estará activo
            };

            int filasAfectadas = conexion.escribirPorStoreProcedure("insertarUsuario", parametros);
            return filasAfectadas;
        }

        public DataTable ObtenerDatosUsuario()
        {
            //RETORNAR UN DATATABLE CON LOS DATOS DEL USUARIO DEL SP obtenerUsuarios
            Conexion conexion = new Conexion();
            DataTable dt = conexion.leerPorStoreProcedure("obtenerUsuarios");
            return dt;
        }
    }

}

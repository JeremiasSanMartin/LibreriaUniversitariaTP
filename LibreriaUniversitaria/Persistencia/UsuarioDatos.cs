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
        public DataTable obtenerDatosUsuarioLogin(Usuario usuario)
        {
            Conexion conexion = new Conexion();
            SqlParameter[] parametros = new SqlParameter[]
            {
                conexion.crearParametro("@nombre_usuario", usuario.Nombre_usuario),
                conexion.crearParametro("@contrasena", usuario.Contraseña)
            };
            DataTable dt = conexion.LeerPorStoreProcedure("obtenerUsuarioLogin", parametros);
            return dt;
        }

        public int insertarUsuario(Usuario usuario)
        {
            Conexion conexion = new Conexion();

            //Crea el parámetro de salida para el resultado de la inserción
            SqlParameter resultadoParam = new SqlParameter("@resultado", SqlDbType.Int)
            {
                Direction = ParameterDirection.Output
            };

            SqlParameter[] parametros = new SqlParameter[]
            {
                conexion.crearParametro("@nombre_usuario", usuario.Nombre_usuario),
                conexion.crearParametro("@contrasena", usuario.Contraseña),
                conexion.crearParametro("@nombre", usuario.Nombre),
                conexion.crearParametro("@apellido", usuario.Apellido),
                conexion.crearParametro("@dni", usuario.DNI),
                conexion.crearParametro("@nombre_rol", usuario.Rol),
                conexion.crearParametro("@activo", 1),//Si el usuario se crea, por defecto estará activo
                resultadoParam
            };

            conexion.EscribirPorStoreProcedure("insertarUsuario", parametros);

            //Devuelve el parametro de salida que en este caso es el resultado de la inserción
            return (int)resultadoParam.Value;
        }

        public int inactivarUsuario(Usuario usuario)
        {
            //Inactivar un usuario por su ID
            Conexion conexion = new Conexion();
            SqlParameter[] parametros = new SqlParameter[]
            {
                conexion.crearParametro("@id_usuario", usuario.Id)
            };
            int resultado = conexion.EscribirPorStoreProcedure("inactivarUsuario", parametros);
            return resultado;
        }

        public DataTable obtenerDatosUsuario()
        {
            //RETORNAR UN DATATABLE CON LOS DATOS DEL USUARIO DEL SP obtenerUsuarios
            Conexion conexion = new Conexion();
            DataTable dt = conexion.LeerPorStoreProcedure("obtenerUsuarios");
            return dt;
        }
    }

}

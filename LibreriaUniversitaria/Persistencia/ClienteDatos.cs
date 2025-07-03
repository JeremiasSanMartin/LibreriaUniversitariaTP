using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entidades;

namespace Persistencia
{
    public class ClienteDatos
    {
        private Conexion conexion = new Conexion();

        public int insertarCliente(Cliente cliente)
        {
           

            SqlParameter[] parametros = new SqlParameter[]
            {
                  conexion.crearParametro("@nombre", cliente.Nombre),
                  conexion.crearParametro("@apellido", cliente.Apellido),
                  conexion.crearParametro("@dni", cliente.DNI),
                  conexion.crearParametro("@telefono", cliente.Telefono ?? string.Empty),
                  conexion.crearParametro("@direccion", cliente.Direccion ?? string.Empty),
                  conexion.crearParametro("@email", cliente.Email ?? string.Empty),
                  conexion.crearParametro("@rol_cliente_id", cliente.Tipo_ID),
                  conexion.crearParametro("@activo", cliente.Activo)
            };

            try
            {
                return conexion.escribirPorStoreProcedure("insertarCliente", parametros);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar el cliente en la base de datos.", ex);
            }
        }

        public DataTable obtenerClientePorNombre(string nombre)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
               conexion.crearParametro("@nombre", nombre)
            };

            return conexion.leerPorStoreProcedure("obtenerClientesPorNombre", parametros);
        }

        public Cliente obtenerClientePorDNI(string dni)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                 conexion.crearParametro("@dni", dni)
            };

            DataTable dt = conexion.leerPorStoreProcedure("obtenerClientePorDNI", parametros);

            if (dt.Rows.Count == 0)
                return null;

            DataRow row = dt.Rows[0];
            Cliente cliente = new Cliente
            {
                ID = Convert.ToInt32(row["id"]),
                Nombre = row["nombre"].ToString(),
                Apellido = row["apellido"].ToString(),
                DNI = row["dni"].ToString(),
                Telefono = row["telefono"].ToString(),
                Direccion = row["direccion"].ToString(),
                Email = row["email"].ToString(),
                Tipo = row["rol_nombre"].ToString(),
                Activo = Convert.ToBoolean(row["activo"]),
                Descuento = Convert.ToSingle(row["descuento"])
            };
            return cliente;


        }

        public int inactivarCliente(int idCliente)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
              conexion.crearParametro("@id", idCliente)
            };

            return conexion.escribirPorStoreProcedure("inactivarCliente", parametros);
        }

        public int editarCliente(Cliente cliente)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
        conexion.crearParametro("@id", cliente.ID),
        conexion.crearParametro("@nombre", cliente.Nombre),
        conexion.crearParametro("@apellido", cliente.Apellido),
        conexion.crearParametro("@telefono", cliente.Telefono ?? string.Empty),
        conexion.crearParametro("@direccion", cliente.Direccion ?? string.Empty),
        conexion.crearParametro("@email", cliente.Email ?? string.Empty),
        conexion.crearParametro("@rol_cliente_id", cliente.Tipo_ID)
            };

            return conexion.escribirPorStoreProcedure("editarCliente", parametros);
        }
    }


}

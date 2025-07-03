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

        public int Insertar(Cliente cliente)
        {
           

            SqlParameter[] parametros = new SqlParameter[]
            {
                  conexion.crearParametro("@nombre", cliente.Nombre),
                  conexion.crearParametro("@apellido", cliente.Apellido),
                  conexion.crearParametro("@dni", cliente.DNI),
                  conexion.crearParametro("@telefono", cliente.Telefono ?? string.Empty),
                  conexion.crearParametro("@direccion", cliente.Direccion ?? string.Empty),
                  conexion.crearParametro("@email", cliente.Email ?? string.Empty),
                  conexion.crearParametro("@rol_cliente_id", cliente.RolClienteId),
                  conexion.crearParametro("@activo", cliente.Activo)
            };

            try
            {
                return conexion.EscribirPorStoreProcedure("insertarCliente", parametros);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar el cliente en la base de datos.", ex);
            }
        }

        public DataTable BuscarClientesPorNombre(string nombre)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
               conexion.crearParametro("@nombre", nombre)
            };

            return conexion.LeerPorStoreProcedure("buscarClientesPorNombre", parametros);
        }

        public int Inactivar(int idCliente)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
              conexion.crearParametro("@id", idCliente)
            };

            return conexion.EscribirPorStoreProcedure("inactivarCliente", parametros);
        }

        public int Editar(Cliente cliente)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
        conexion.crearParametro("@id", cliente.ID),
        conexion.crearParametro("@nombre", cliente.Nombre),
        conexion.crearParametro("@apellido", cliente.Apellido),
        conexion.crearParametro("@telefono", cliente.Telefono ?? string.Empty),
        conexion.crearParametro("@direccion", cliente.Direccion ?? string.Empty),
        conexion.crearParametro("@email", cliente.Email ?? string.Empty),
        conexion.crearParametro("@rol_cliente_id", cliente.RolClienteId)
            };

            return conexion.EscribirPorStoreProcedure("editarCliente", parametros);
        }
    }


}

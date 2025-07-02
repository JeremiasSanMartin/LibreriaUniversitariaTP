using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entidades;

namespace Persistencia
{
    public class VentaDatos
    {
        private Conexion conexion = new Conexion();

        public bool insertarVenta(Venta venta)
        {
            List<SqlParameter> parametros = new List<SqlParameter>
            {
                conexion.crearParametro("@fecha", venta.Fecha),
                conexion.crearParametro("@precio_final", venta.Precio_Final),
                conexion.crearParametro("@dni_cliente", venta.Cliente_Asociado.DNI),
                conexion.crearParametro("@vendedor_id", venta.Vendedor_Asociado)
            };

            int filasAfectadas = conexion.escribirPorStoreProcedure("guardarVenta", parametros.ToArray());

            
            foreach (var detalle in venta.Detalles)
            {
                List<SqlParameter> parametrosDetalle = new List<SqlParameter>
                {
                    conexion.crearParametro("@titulo_libro", detalle.Libro.Titulo),
                    conexion.crearParametro("@cantidad", detalle.Cantidad),
                    conexion.crearParametro("@precio_unitario", detalle.Precio_Unitario)
                };

                conexion.escribirPorStoreProcedure("guardarDetalleVenta", parametrosDetalle.ToArray());
            }

            return filasAfectadas > 0;
        }
    }
}


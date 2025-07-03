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
                conexion.crearParametro("@cliente_id", venta.Cliente_Asociado.ID),
                conexion.crearParametro("@vendedor_id", venta.Vendedor_Asociado)
            };

            int ventaID = conexion.leerValorEscalar("insertarVenta", parametros.ToArray());

            if (ventaID <= 0)
                return false;

            foreach (var detalle in venta.Detalles)
            {
                List<SqlParameter> parametrosDetalle = new List<SqlParameter>
                {
                    conexion.crearParametro("@venta_id", ventaID),
                    conexion.crearParametro("@libro_id", detalle.Libro.ID),
                    conexion.crearParametro("@cantidad", detalle.Cantidad),
                    conexion.crearParametro("@precio_unitario", detalle.Precio_Unitario)
                };

                conexion.escribirPorStoreProcedure("insertarDetalleVenta", parametrosDetalle.ToArray());
            }

            return true;
        }
    }
}


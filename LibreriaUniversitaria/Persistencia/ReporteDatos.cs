using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class ReporteDatos
    {
        //recupera los reportes por vendedor o si no se pasa ningun parametro, recupera todos los reportes
        public List<ReporteDetalleVenta> RecuperarDetallesPorVendedor(string nombreVendedor = null)
        {
            List<ReporteDetalleVenta> lista = new List<ReporteDetalleVenta>();
            Conexion conexion = new Conexion();

            //si hay un parametro, usa crear parametro sobre esto
            List<SqlParameter> parametros = new List<SqlParameter>();
            if (!string.IsNullOrEmpty(nombreVendedor))
            {
                parametros.Add(conexion.crearParametro("@nombre_vendedor", nombreVendedor));
            }

            //prepara la consulta a la base de datos
            DataTable tabla = conexion.LeerPorStoreProcedure("obtenerVentasPorVendedor", parametros.ToArray());

            //lena la data table
            foreach (DataRow fila in tabla.Rows)
            {
                string vendedor = fila["vendedor"].ToString();
                string cliente = fila["cliente"].ToString();
                DateTime fecha = Convert.ToDateTime(fila["fecha"]);
                string producto = fila["producto"].ToString();
                int cantidad = Convert.ToInt32(fila["cantidad"]);
                decimal precio = Convert.ToDecimal(fila["precio_unitario"]);

                lista.Add(new ReporteDetalleVenta(vendedor, cliente, fecha, producto, cantidad, precio));
            }

            return lista;
        }
        public List<ReporteVendedor> RecuperarVentasPorFechas(DateTime fechaInicio, DateTime fechaFin)
        {
            List<ReporteVendedor> lista = new List<ReporteVendedor>();
            Conexion conexion = new Conexion();

            var parametros = new SqlParameter[]
            {
        conexion.crearParametro("@fecha_inicio", fechaInicio),
        conexion.crearParametro("@fecha_fin", fechaFin)
            };

            DataTable tabla = conexion.LeerPorStoreProcedure("obtenerVentasPorFecha", parametros);

            foreach (DataRow fila in tabla.Rows)
            {
                string vendedor = fila["vendedor"].ToString();
                string cliente = fila["cliente"].ToString();
                DateTime fecha = Convert.ToDateTime(fila["fecha"]);
                string producto = fila["producto"].ToString();
                int cantidad = Convert.ToInt32(fila["cantidad"]);
                decimal precioUnitario = Convert.ToDecimal(fila["precio_unitario"]);
                decimal subtotal = Convert.ToDecimal(fila["subtotal"]);

                lista.Add(new ReporteVendedor(vendedor, cliente, fecha, producto, cantidad, precioUnitario, subtotal));
            }

            return lista;
        }
    }
}

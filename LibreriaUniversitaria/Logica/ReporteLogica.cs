using Entidades;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ReporteLogica
    {
        private ReporteDatos _reporteDatos = new ReporteDatos();

        //permite null porque si no se pasa parametro obtiene todos los reportes, y si se pasa un vendedor, obtiene los reportes de ese vendedor   
        public List<ReporteDetalleVenta> recuperarDetalles(string vendedor = null)
        {
            try { 
                return _reporteDatos.recuperarDetallesPorVendedor(vendedor);
            }
            catch (Exception ex)
            {
                //maneja la exepcion diferenciando si se busco un reporte por vendedor o solo se queria recuperar todos los reportes
                string contexto = string.IsNullOrWhiteSpace(vendedor)
                    ? "al recuperar todos los reportes."
                    : $"al recuperar los reportes del vendedor \"{vendedor}\".";


                throw new Exception($"Error {contexto}", ex);
            }
        }

        //obtiene los reportes por fecha, desde y hasta
        public List<ReporteVendedor> recuperarPorFechas(DateTime desde, DateTime hasta)
        {
            try
            {
                ReporteDatos datos = new ReporteDatos();
                return datos.recuperarVentasPorFechas(desde, hasta);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al recuperar reportes por fecha.", ex);
            }
        }
    }
}

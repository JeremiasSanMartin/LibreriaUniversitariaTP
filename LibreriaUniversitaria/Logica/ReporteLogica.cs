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

        //permite null porque si no se pasa parametro obtiene todos los reportes   
        public List<ReporteDetalleVenta> RecuperarDetalles(string vendedor = null)
        {
            return _reporteDatos.RecuperarDetallesPorVendedor(vendedor);
        }
    }
}

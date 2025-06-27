using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Persistencia;

namespace Logica
{
    public class StockLibrosLogica
    {
        public Persistencia.StockLibrosDatos stockLibrosDatos = new Persistencia.StockLibrosDatos();

        public DataTable obtenerStockLibros()
        {
            // Llama al método de la capa de persistencia para obtener el stock de libros
            return stockLibrosDatos.ObtenerDatosStockLibros();
        }
    }
}

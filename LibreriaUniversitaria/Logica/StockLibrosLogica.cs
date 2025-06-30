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

        public DataTable obtenerLibrosStockBajo()
        {
            // Llama al método de la capa de persistencia para obtener los libros con stock bajo
            return stockLibrosDatos.ObtenerLibrosStockBajo();

        }

        public int agregarLibro(string titulo, string autor, int editorialId, int stockActual, int stockMinimo, float precio)
        {
            // Llama al método de la capa de persistencia para insertar un nuevo libro
            return stockLibrosDatos.InsertarLibro(titulo, autor, editorialId, stockActual, stockMinimo, precio);
        }
    }
}

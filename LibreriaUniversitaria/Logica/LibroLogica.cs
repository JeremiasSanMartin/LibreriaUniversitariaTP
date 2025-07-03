using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Persistencia;
using Entidades;

namespace Logica
{
    public class LibroLogica
    {
        public LibroDatos stockLibrosDatos = new LibroDatos();

        public List<Libro> obtenerDatosLibros()
        {
            // Llama al método de la capa de persistencia para obtener los datos de los libros
            return stockLibrosDatos.obtenerDatosLibros();
        }

        public DataTable obtenerDataTableLibros()
        {
            // Llama al método de la capa de persistencia para obtener los libros con stock bajo
            return stockLibrosDatos.obtenerDataTableLibros();

        }

        public DataTable obtenerLibrosStockBajo()
        {
            // Llama al método de la capa de persistencia para obtener los libros con stock bajo
            return stockLibrosDatos.obtenerLibrosStockBajo();

        }

        public int agregarLibro(Libro libro)
        {
            // Llama al método de la capa de persistencia para insertar un nuevo libro
            return stockLibrosDatos.insertarLibro(libro);
        }

        public int editarLibro(Libro libro)
        {
            // Llama al método de la capa de persistencia para editar un libro existente
            return stockLibrosDatos.editarLibro(libro);
        }
    }
}

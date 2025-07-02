using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class StockLibrosDatos
    {
        public DataTable obtenerDatosStockLibros()
        {
            //RETORNAR UN DATATABLE CON LOS DATOS DEL LIBRO DEL SP obtenerStockLibros
            Conexion conexion = new Conexion();
            DataTable dt = conexion.LeerPorStoreProcedure("obtenerStockLibros");
            return dt;
        }

        public DataTable obtenerLibrosStockBajo()
        {
            //RETORNAR UN DATATABLE CON LOS DATOS DEL LIBRO DEL SP obtenerLibrosStockBajo
            Conexion conexion = new Conexion();
            DataTable dt = conexion.LeerPorStoreProcedure("obtenerLibrosStockBajo");
            return dt;
        }

        public int insertarLibro(Libro libro)
        {
            Conexion conexion = new Conexion();
            SqlParameter[] parametros = new SqlParameter[]
            {
                conexion.crearParametro("@titulo", libro.Titulo),
                conexion.crearParametro("@autor", libro.Autor),
                conexion.crearParametro("@editorial_id", libro.Editorial.Id),
                conexion.crearParametro("@stock_actual", libro.Stock_actual),
                conexion.crearParametro("@stock_minimo", libro.Stock_minimo),
                conexion.crearParametro("@precio", libro.Precio)
            };

            int filasAfectadas = conexion.EscribirPorStoreProcedure("agregarLibro", parametros);
            return filasAfectadas;
        }

        public int editarLibro(int id, string titulo, string autor, int editorialId, int stockActual, int stockMinimo, float precio)
        {
            Conexion conexion = new Conexion();
            SqlParameter[] parametros = new SqlParameter[]
            {
                conexion.crearParametro("@id_libro", id),
                conexion.crearParametro("@titulo", titulo),
                conexion.crearParametro("@autor", autor),
                conexion.crearParametro("@editorial_id", editorialId),
                conexion.crearParametro("@stock_actual", stockActual),
                conexion.crearParametro("@stock_minimo", stockMinimo),
                conexion.crearParametro("@precio", precio)
            };
            int filasAfectadas = conexion.EscribirPorStoreProcedure("editarLibro", parametros);
            return filasAfectadas;
        }

    }
}

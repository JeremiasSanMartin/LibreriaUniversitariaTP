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
    public class LibroDatos
    {

        private Conexion conexion = new Conexion();


        public List<Libro> obtenerDatosLibros()
        {
            List<Libro> lista = new List<Libro>();

            DataTable dt = conexion.leerPorStoreProcedure("obtenerStockLibros");

            foreach (DataRow fila in dt.Rows)
            {
                var libro = new Libro
                {
                    ID = Convert.ToInt32(fila["id"]),
                    Titulo = fila["titulo"].ToString(),
                    Autor = fila["autor"].ToString(),
                    Stock_actual = Convert.ToInt32(fila["stock_actual"]),
                    Stock_minimo = Convert.ToInt32(fila["stock_minimo"]),
                    Precio = float.Parse(fila["precio"].ToString()),
                    Editorial = new Editorial { Nombre = fila["editorial"].ToString() }
                };

                lista.Add(libro);
            }

            return lista;
        }
        public int insertarLibro(Libro libro)
        {
           
            SqlParameter[] parametros = new SqlParameter[]
            {
                conexion.crearParametro("@id", libro.ID),
                conexion.crearParametro("@titulo", libro.Titulo),
                conexion.crearParametro("@autor", libro.Autor),
                conexion.crearParametro("@editorial_id", libro.Editorial.ID),
                conexion.crearParametro("@stock_actual", libro.Stock_actual),
                conexion.crearParametro("@stock_minimo", libro.Stock_minimo),
                conexion.crearParametro("@precio", libro.Precio)
            };

            int filasAfectadas = conexion.escribirPorStoreProcedure("agregarLibro", parametros);
            return filasAfectadas;
        }

        public bool actualizarStock(Libro libro)
        {
            List<SqlParameter> parametros = new List<SqlParameter>
            {
                conexion.crearParametro("@titulo", libro.Titulo),
                conexion.crearParametro("@editorial", libro.Editorial.Nombre),
                conexion.crearParametro("@stock_actualizado", libro.Stock_actual)
            };

            int resultado = conexion.escribirPorStoreProcedure("actualizarStock", parametros.ToArray());
            return resultado > 0;
        }

    }
}
    

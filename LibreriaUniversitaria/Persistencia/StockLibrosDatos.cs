using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class StockLibrosDatos
    {
        public DataTable ObtenerDatosStockLibros()
        {
            //RETORNAR UN DATATABLE CON LOS DATOS DEL LIBRO DEL SP obtenerStockLibros
            Conexion conexion = new Conexion();
            DataTable dt = conexion.LeerPorStoreProcedure("obtenerStockLibros");
            return dt;
        }

        public DataTable ObtenerLibrosStockBajo()
        {
            //RETORNAR UN DATATABLE CON LOS DATOS DEL LIBRO DEL SP obtenerLibrosStockBajo
            Conexion conexion = new Conexion();
            DataTable dt = conexion.LeerPorStoreProcedure("obtenerLibrosStockBajo");
            return dt;
        }
    }
}

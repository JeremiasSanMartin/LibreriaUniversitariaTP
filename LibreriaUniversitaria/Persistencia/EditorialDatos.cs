using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace Persistencia
{
    public class EditorialDatos
    {

        public DataTable obtenerDatosEditoriales()
        {
            // Llama al método de la capa de persistencia para obtener los datos de las editoriales
            Conexion conexion = new Conexion();
            DataTable dt = conexion.leerPorStoreProcedure("obtenerEditoriales");
            return dt;
        }
    }
}

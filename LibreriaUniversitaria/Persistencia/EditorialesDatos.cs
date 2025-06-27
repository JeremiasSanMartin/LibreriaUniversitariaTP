using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class EditorialesDatos
    {
        public DataTable ObtenerDatosEditoriales()
        {
            // Llama al método de la capa de persistencia para obtener los datos de las editoriales
            Conexion conexion = new Conexion();
            DataTable dt = conexion.LeerPorStoreProcedure("obtenerEditoriales");
            return dt;
        }
    }
}

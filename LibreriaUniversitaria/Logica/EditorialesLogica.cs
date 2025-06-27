using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class EditorialesLogica
    {
        public Persistencia.EditorialesDatos editorialesDatos = new Persistencia.EditorialesDatos();

        public DataTable obtenerEditoriales()
        {
            // Llama al método de la capa de persistencia para obtener los datos de las editoriales
            return editorialesDatos.ObtenerDatosEditoriales();
        }
    }
}

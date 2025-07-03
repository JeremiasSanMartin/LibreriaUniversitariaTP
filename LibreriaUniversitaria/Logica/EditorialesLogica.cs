using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia;

namespace Logica
{
    public class EditorialesLogica
    {
        public EditorialDatos editorialDatos = new Persistencia.EditorialDatos();

        public DataTable obtenerEditoriales()
        {
            // Llama al método de la capa de persistencia para obtener los datos de las editoriales
            return editorialDatos.obtenerDatosEditoriales();
        }
    }
}

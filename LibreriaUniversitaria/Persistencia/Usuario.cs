using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Persistencia;
using DAL;

namespace Persistencia
{
    public class Usuario
    {
        public List<Entidades.Usuario> Listar()
        {
            Conexion conexion = new Conexion();

            List<Entidades.Usuario> usuarios = new List<Entidades.Usuario>();

            DataTable datatable = conexion.LeerPorComando("COLOCAR PROCEDIMIENTO ALMACENADO");

            foreach (DataRow fila in datatable.Rows) 
            {
                Entidades.Usuario unUsuario = new Entidades.Usuario();

                unUsuario.Clave = fila["clave"].ToString();
                unUsuario.UserName = fila["usuario"].ToString();

                usuarios.Add(unUsuario);
            }

            return usuarios;
        }
    }

    
}

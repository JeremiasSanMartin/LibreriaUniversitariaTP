using Entidades;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ClienteLogica
    {
        private ClienteDatos manejoCliente = new ClienteDatos();

        public int agregarCliente(Cliente cliente)
        {
            // Validaciones básicas
            if (string.IsNullOrWhiteSpace(cliente.Nombre))
                throw new Exception("El nombre del cliente es obligatorio.");

            if (string.IsNullOrWhiteSpace(cliente.Apellido))
                throw new Exception("El apellido del cliente es obligatorio.");

            if (string.IsNullOrWhiteSpace(cliente.DNI))
                throw new Exception("El DNI del cliente es obligatorio.");

            // Validación opcional de email
            if (!string.IsNullOrWhiteSpace(cliente.Email) && !cliente.Email.Contains("@"))
                throw new Exception("El email ingresado no es válido.");

            // Si todo está bien, lo insertamos usando el SP a través de la DAL
            try
            {
                return manejoCliente.Insertar(cliente);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error al intentar agregar el cliente.", ex);
            }
        }

        public DataTable BuscarClientes(string nombre)
        {
            return manejoCliente.BuscarClientesPorNombre(nombre);
        }

        public int InactivarCliente(int idCliente)
        {
            if (idCliente <= 0)
                throw new ArgumentException("ID de cliente inválido.");

            return manejoCliente.Inactivar(idCliente);
        }

        public int EditarCliente(Cliente cliente)
        {
            if (cliente.ID <= 0)
                throw new ArgumentException("ID de cliente inválido.");

            if (string.IsNullOrWhiteSpace(cliente.Nombre) || string.IsNullOrWhiteSpace(cliente.Apellido))
                throw new Exception("Nombre y apellido son obligatorios.");

            return manejoCliente.Editar(cliente);
        }

    }
}

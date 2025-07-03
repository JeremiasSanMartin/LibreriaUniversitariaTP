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
        private ClienteDatos clienteDatos = new ClienteDatos();

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
                return clienteDatos.insertarCliente(cliente);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error al intentar agregar el cliente.", ex);
            }
        }

        public DataTable buscarClientePorNombre(string nombre)
        {
            return clienteDatos.obtenerClientePorNombre(nombre);
        }

        public Cliente buscarClientePorDNI(string dni)
        {
            if (string.IsNullOrWhiteSpace(dni))
                return null;

            return clienteDatos.obtenerClientePorDNI(dni);
        }

        public int inactivarCliente(int idCliente)
        {
            if (idCliente <= 0)
                throw new ArgumentException("ID de cliente inválido.");

            return clienteDatos.inactivarCliente(idCliente);
        }

        public int editarCliente(Cliente cliente)
        {
            if (cliente.ID <= 0)
                throw new ArgumentException("ID de cliente inválido.");

            if (string.IsNullOrWhiteSpace(cliente.Nombre) || string.IsNullOrWhiteSpace(cliente.Apellido))
                throw new Exception("Nombre y apellido son obligatorios.");

            return clienteDatos.editarCliente(cliente);
        }

    }
}

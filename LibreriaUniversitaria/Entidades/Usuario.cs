using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {
        private string nombre_usuario;

        public string Nombre_Usuario
        {
            get { return nombre_usuario; }
            set { nombre_usuario = value; }
        }

        private string contraseña;

        public string Contraseña
        {
            get { return contraseña; }
            set { contraseña = value; }
        }

        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private int apellido;

        public int Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        private int dni;

        public int DNI
        {
            get { return dni; }
            set { dni = value; }
        }

        private string tipo_usuario;

        public string Tipo_usuario
        {
            get { return tipo_usuario; }
            set { tipo_usuario = value; }
        }

        private bool activo;

        public bool Activo
        {
            get { return activo; }
            set { activo = value; }
        }

        private string direccion;

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        private int telefono;

        public int Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private string tipo_cliente;

        public string Tipo_cliente
        {
            get { return tipo_cliente; }
            set { tipo_cliente = value; }
        }

    }
}

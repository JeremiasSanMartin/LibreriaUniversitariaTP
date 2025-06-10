using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente
    {
        private bool activo;

        public bool Activo
        {
            get { return activo; }
            set { activo = value; }
        }

        private string nombre_cliente;

        public string Nombre_cliente
        {
            get { return nombre_cliente; }
            set { nombre_cliente = value; }
        }

        private string apellido_cliente;

        public string Apellido_cliente
        {
            get { return apellido_cliente; }
            set { apellido_cliente = value; }
        }

        private string dni_cliente;

        public string DNI_cliente
        {
            get { return dni_cliente; }
            set { dni_cliente = value; }
        }

        private string direccion_cliente;

        public string Direccion_cliente
        {
            get { return direccion_cliente; }
            set { direccion_cliente = value; }
        }

        private string telefono_cliente;

        public string Telefono_cliente
        {
            get { return telefono_cliente; }
            set { telefono_cliente = value; }
        }

        private string email_cliente;

        public string Email_cliente
        {
            get { return email_cliente; }
            set { email_cliente = value; }
        }

        private string tipo_cliente;

        public string Tipo_cliente
        {
            get { return tipo_cliente; }
            set { tipo_cliente = value; }
        }

        private float descuento_cliente;

        public float Descuento_cliente
        {
            get { return descuento_cliente; }
            set { descuento_cliente = value; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente
    {
        private int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        private bool activo;

        public bool Activo
        {
            get { return activo; }
            set { activo = value; }
        }

        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private string apellido;

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        private string dni;

        public string DNI
        {
            get { return dni; }
            set { dni = value; }
        }

        private string direccion;

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        private string telefono;

        public string Telefono
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

        private string tipo;

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        private float descuento;

        public float Descuento
        {
            get { return descuento; }
            set { descuento = value; }
        }


        private int tipo_id;

        public int Tipo_ID
        {
            get
            {
                switch (Tipo)
                {
                    case "Estudiante":
                        return 5;   
                    case "Profesor":
                        return 6;  
                    case "Personal":
                        return 7; 
                    default:
                        return 8; 

                }
            }
        }


    }
}

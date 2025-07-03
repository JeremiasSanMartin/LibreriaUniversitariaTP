using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DetalleVenta
    {

        private int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        private Libro libro;

		public Libro Libro
		{
			get { return libro; }
			set { libro = value; }
		}

		private string nombre_libro;

		public string NombreLibro
		{
			get { return Libro.Titulo; }
        }


		private int cantidad;

		public int Cantidad
        {
			get { return cantidad; }
			set { cantidad = value; }
		}

		private float precio_unitario;

		public float Precio_Unitario
		{
			get { return precio_unitario; }
			set { precio_unitario = value; }
		}

		private float subtotal;

		public float Subtotal
		{
			get { return Cantidad * Precio_Unitario; }
		}



	}
}

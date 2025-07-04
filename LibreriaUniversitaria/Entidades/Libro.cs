using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Libro
    {


        private int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }
		
		private string titulo;

		public string Titulo
		{
			get { return titulo; }
			set { titulo = value; }
		}

		private int stock_actual;

		public int Stock_actual
		{
			get { return stock_actual; }
			set { stock_actual = value; }
		}

		private string autor;

		public string Autor
		{
			get { return autor; }
			set { autor = value; }
		}

		private float precio;

		public float Precio
		{
			get { return precio; }
			set { precio = value; }
		}

		private int stock_minimo;

		public int Stock_minimo
        {
			get { return stock_minimo; }
			set { stock_minimo = value; }
		}

		private Editorial editorial;

		public Editorial Editorial
		{
			get { return editorial; }
			set { editorial = value; }
		}

		private string nombre_editorial;

		public string NombreEditorial
		{
			get { return Editorial.Nombre; }
		}

	}
}

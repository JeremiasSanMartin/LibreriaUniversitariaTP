using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Editorial
    {
		private int nombre_editorial;

		public int Nombre_editorial
		{
			get { return nombre_editorial; }
			set { nombre_editorial = value; }
		}

		private string contacto_editorial;

		public string Contacto_editorial
		{
			get { return contacto_editorial; }
			set { contacto_editorial = value; }
		}

	}
}

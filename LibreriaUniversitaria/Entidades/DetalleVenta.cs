using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DetalleVenta
    {
		private int cantidad;

		public int Cantidad
        {
			get { return cantidad; }
			set { cantidad = value; }
		}

		private float precio_unitario;

		public float Precio_unitario
		{
			get { return precio_unitario; }
			set { precio_unitario = value; }
		}

	}
}

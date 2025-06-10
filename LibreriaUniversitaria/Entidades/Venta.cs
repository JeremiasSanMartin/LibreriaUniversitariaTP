using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Venta
    {
		private DateTime fecha_venta;

		public DateTime Fecha_venta
		{
			get { return fecha_venta; }
			set { fecha_venta = value; }
		}

		private float precio_final;

		public float Precio_final
		{
			get { return precio_final; }
			set { precio_final = value; }
		}

		private int vendedor_asociado;

		public int Vendedor_asociado
		{
			get { return vendedor_asociado; }
			set { vendedor_asociado = value; }
		}


	}
}

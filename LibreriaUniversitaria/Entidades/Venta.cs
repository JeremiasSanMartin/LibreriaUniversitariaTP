using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Venta
    {

        private int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        private DateTime fecha;

		public DateTime Fecha
		{
			get { return fecha; }
			set { fecha = value; }
		}

		private float precio_final;

		public float Precio_Final
		{
			get { return precio_final; }
			set { precio_final = value; }
		}

		private int vendedor_asociado;

		public int Vendedor_Asociado
		{
			get { return vendedor_asociado; }
			set { vendedor_asociado = value; }
		}

		private Cliente cliente_asociado;

		public Cliente Cliente_Asociado
		{
			get { return cliente_asociado; }
			set { cliente_asociado = value; }
		}

		private List<DetalleVenta> detalles;

		public List<DetalleVenta> Detalles
		{
			get { return detalles; }
			set { detalles = value; }
		}


		


	}
}

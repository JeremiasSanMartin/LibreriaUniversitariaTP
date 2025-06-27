using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ReporteVendedor
    {
        private string _vendedor;
        private int _cantidadVentas;
        private decimal _totalVendido;

        public string Vendedor => _vendedor;
        public int CantidadVentas => _cantidadVentas;
        public decimal TotalVendido => _totalVendido;

        public ReporteVendedor(string vendedor, int cantidadVentas, decimal totalVendido)
        {
            _vendedor = vendedor;
            _cantidadVentas = cantidadVentas;
            _totalVendido = totalVendido;
        }
    }
}

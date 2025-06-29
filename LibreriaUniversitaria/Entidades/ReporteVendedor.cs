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
        private string _cliente;
        private DateTime _fecha;
        private string _producto;
        private int _cantidad;
        private decimal _precioUnitario;
        private decimal _subtotal;

        public string Vendedor => _vendedor;
        public string Cliente => _cliente;
        public DateTime Fecha => _fecha;
        public string Producto => _producto;
        public int Cantidad => _cantidad;
        public decimal PrecioUnitario => _precioUnitario;
        public decimal Subtotal => _subtotal;

        public ReporteVendedor(string vendedor, string cliente, DateTime fecha, string producto, int cantidad, decimal precioUnitario, decimal subtotal)
        {
            _vendedor = vendedor;
            _cliente = cliente;
            _fecha = fecha;
            _producto = producto;
            _cantidad = cantidad;
            _precioUnitario = precioUnitario;
            _subtotal = subtotal;
        }
    }
}

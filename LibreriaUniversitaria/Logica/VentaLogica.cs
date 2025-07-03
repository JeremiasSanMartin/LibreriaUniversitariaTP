using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Persistencia;

namespace Logica
{
    public class VentaLogica
    {
        private VentaDatos ventaDatos = new VentaDatos();
        private LibroDatos libroDatos = new LibroDatos();
        private ClienteDatos clienteDatos = new ClienteDatos(); 
        private int id_detalle_venta = 1;


   


        public string validarStock(List<DetalleVenta> detalles)
        {

            List<string> librosSinStock = new List<string>();

            foreach (var detalle in detalles)
            {
                if (detalle.Libro.Stock_actual < detalle.Cantidad)
                    librosSinStock.Add($"'{detalle.Libro.Titulo}' — stock disponible: {detalle.Libro.Stock_actual}, solicitado: {detalle.Cantidad}");
            }

            if (librosSinStock.Any())
            {
                return "Error: stock insuficiente para los siguientes libros:\n" + string.Join("\n", librosSinStock);
            }

            return null;
        }

        public void descontarStock(List<DetalleVenta> detalles)
        {

            foreach (var detalle in detalles)
            {
                
                detalle.Libro.Stock_actual -= detalle.Cantidad;
                libroDatos.actualizarStock(detalle.Libro);
            }

        }

       



        public void calcularPrecioFinal(Venta venta)
        {
            float subtotal = 0;
            float descuento = venta.Cliente_Asociado.Descuento;

            foreach (DetalleVenta detalle in venta.Detalles)
            {
                subtotal = subtotal + detalle.Subtotal;
            }

            venta.Precio_Final = subtotal - (subtotal * descuento);


        }


        public void agregarDetalle(Venta venta, Libro libro, int cantidad)
        {

            if (libro.Stock_actual < cantidad)
                throw new Exception($"Stock insuficiente para '{libro.Titulo}'");

            var detalle = new DetalleVenta
            {
                ID = id_detalle_venta++,
                Libro = libro,
                Cantidad = cantidad,
                Precio_Unitario = libro.Precio
            };

            venta.Detalles.Add(detalle);
        }

        public void reiniciarContadorDetalles()
        {
            id_detalle_venta = 1;
        }

        public string generarVenta(Cliente cliente, List<DetalleVenta> detalles, int idVendedor)
        {
            if (cliente == null)
                return "Error: el cliente es nulo.";

            if (!cliente.Activo)
                return "Error: el cliente está inactivo.";

            if (detalles == null || !detalles.Any())
                return "Error: no se puede generar una venta sin productos.";

            string error_stock = validarStock(detalles);
            if (error_stock != null)
                return error_stock;


            Venta venta = new Venta
            {
                Fecha = DateTime.Now,
                Vendedor_Asociado = idVendedor,
                Cliente_Asociado = cliente,
                Detalles = detalles
            };

            calcularPrecioFinal(venta);

            bool guardado = ventaDatos.insertarVenta(venta);

            if (guardado)
                descontarStock(detalles);

            return guardado
                ? "OK"
                : "Error al registrar la venta en la base de datos.";

        }
    }
}

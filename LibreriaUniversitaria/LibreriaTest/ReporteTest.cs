using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logica;
using Entidades;

namespace LibreriaTest
{
    [TestClass]
    public class ReporteTest
    {
        [TestMethod]
        public void RecuperarVendedorExistente()
        {
            //logica
            ReporteLogica logica = new ReporteLogica();
            string nombreVendedor = "Tomas"; //asegurarse que exista en la basae de datos y tenga ventas hechas
            List<ReporteDetalleVenta> resultados = logica.RecuperarDetalles(nombreVendedor);

            //resultado
            Assert.IsNotNull(resultados);
            Assert.IsTrue(resultados.Count > 0, "Se esperaban resultados para un vendedor existente.");
        }

        [TestMethod]
        public void RecuperarVendedorInexistente()
        {
            //vendedor imaginario
            ReporteLogica logica = new ReporteLogica();
            string nombreVendedor = "VendedorInexistente123";
            List<ReporteDetalleVenta> resultados = logica.RecuperarDetalles(nombreVendedor);

            //aseguramos que pueda detectar que el vendedor no existe
            Assert.IsNotNull(resultados);
            Assert.AreEqual(0, resultados.Count);
        }

        [TestMethod]
        public void RecuperarPorFechas()
        {
            //verificar que existan ventas de junio a julio de 2025 o cambiar el rango
            ReporteLogica logica = new ReporteLogica();
            DateTime inicio = new DateTime(2025, 6, 1);
            DateTime fin = new DateTime(2025, 7, 31);
            List<ReporteVendedor> resultados = logica.RecuperarPorFechas(inicio, fin);

            //aseguramos que haya resultados
            Assert.IsNotNull(resultados);
            Assert.IsTrue(resultados.Count > 0, "Debería haber al menos una venta en junio o julio");
        }

        [TestMethod]
        public void RecuperarPorFechasInexistentes()
        {
            //fecha imaginaria que no deberia retornar ventas
            ReporteLogica logica = new ReporteLogica();
            DateTime inicio = new DateTime(1999, 1, 1);
            DateTime fin = new DateTime(1999, 1, 31);
            List<ReporteVendedor> resultados = logica.RecuperarPorFechas(inicio, fin);

            //deberia devolver 0
            Assert.IsNotNull(resultados);
            Assert.AreEqual(0, resultados.Count);
        }
    }
}

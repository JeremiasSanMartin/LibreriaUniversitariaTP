using Logica;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;

namespace UnitTestProject1
{
    [TestClass]
    public class LoginTest
    {
        [TestMethod]
        public void TestAdmin()
        {
            var usuario = new UsuarioLogica();
            string resultado = usuario.loguearse("miardg", "1234");

            Debug.WriteLine(resultado);
            Assert.AreEqual("Administrador", resultado);
        }

        [TestMethod]
        public void TestBiblotecario()
        {
            var usuario = new UsuarioLogica();
            string resultado = usuario.loguearse("Bibliotecario", "1234");

            Debug.WriteLine(resultado);
            Assert.AreEqual("Bibliotecario", resultado);
        }

        [TestMethod]
        public void TestInvalido()
        {
            var usuario = new UsuarioLogica();
            string resultado = usuario.loguearse("fakeuser", "wrong");

            Debug.WriteLine(resultado);
            Assert.IsNull(resultado); // Si no existe, debe ser null
        }

        [TestMethod]
        public void TestRolErroneo()
        {
            var usuario = new UsuarioLogica();
            string resultado = usuario.loguearse("admin", "1234");

            Debug.WriteLine(resultado);
            Assert.IsNull(resultado);
        }
    }
}


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
            var usuario = new Usuario();
            bool resultado = usuario.loguearse("admin", "1234", "Administrador");

            Debug.WriteLine(resultado);
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void TestBiblotecario()
        {
            var usuario = new Usuario();
            bool resultado = usuario.loguearse("bibliotecario", "1234", "Bibliotecario");

            Debug.WriteLine(resultado);
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void TestInvalido()
        {
            var usuario = new Usuario();
            bool resultado = usuario.loguearse("fakeuser", "wrong", "Administrador");

            Debug.WriteLine(resultado);
            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void TestRolErroneo()
        {
            var usuario = new Usuario();
            bool resultado = usuario.loguearse("admin", "1234", "Gerente");

            Debug.WriteLine(resultado);
            Assert.IsFalse(resultado);
        }
    }
}


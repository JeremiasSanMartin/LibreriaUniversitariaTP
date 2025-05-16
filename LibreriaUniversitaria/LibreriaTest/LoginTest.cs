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
            bool resultado = usuario.Loguearse("admin", "1234", "Administrador");

            Debug.WriteLine(resultado);
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void TestBiblotecario()
        {
            var usuario = new Usuario();
            bool resultado = usuario.Loguearse("bibliotecario", "1234", "Bibliotecario");

            Debug.WriteLine(resultado);
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void TestInvalido()
        {
            var usuario = new Usuario();
            bool resultado = usuario.Loguearse("fakeuser", "wrong", "Administrador");

            Debug.WriteLine(resultado);
            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void TestRolErroneo()
        {
            var usuario = new Usuario();
            bool resultado = usuario.Loguearse("admin", "1234", "Gerente");

            Debug.WriteLine(resultado);
            Assert.IsFalse(resultado);
        }
    }
}


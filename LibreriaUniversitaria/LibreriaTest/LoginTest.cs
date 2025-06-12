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
            string rol;
            bool resultado = usuario.loguearse("miardg", "1234", out rol);

            Debug.WriteLine(rol);
            Assert.IsTrue(resultado);
            Assert.AreEqual("Administrador", rol);
        }

        [TestMethod]
        public void TestBiblotecario()
        {
            var usuario = new UsuarioLogica();
            string rol;
            bool resultado = usuario.loguearse("Bibliotecario", "1234", out rol);

            Debug.WriteLine(rol);
            Assert.IsTrue(resultado);
            Assert.AreEqual("Bibliotecario", rol);
        }

        [TestMethod]
        public void TestInvalido()
        {
            var usuario = new UsuarioLogica();
            string rol;
            bool resultado = usuario.loguearse("fakeuser", "wrong", out rol);

            Debug.WriteLine(rol);
            Assert.IsFalse(resultado);
            Assert.IsNull(rol); // Si no existe, debe ser null  
        }

        [TestMethod]
        public void TestRolErroneo()
        {
            var usuario = new UsuarioLogica();
            string rol;
            bool resultado = usuario.loguearse("admin", "1234", out rol);

            Debug.WriteLine(rol);
            Assert.IsFalse(resultado);
            Assert.IsNull(rol);
        }
    }
}


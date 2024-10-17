using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CalculadoraEjemplo3.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting.Logging;

namespace PruebaCalculadora
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double num1 = 10;
            double num2 = 5;
            double resultadoEsperado = 15;

            Calculadora calculadora = new Calculadora();

            double actual = calculadora.Sumar(num1, num2);

            Assert.AreEqual(resultadoEsperado, actual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string userTest = "admin";
            string userPass = "12345";
            bool resultadoEsperado = true; // Esperamos que el login sea exitoso

            Login login = new Login();

            bool actual = login.LoggerUser(userTest, userPass);

            Assert.AreEqual(resultadoEsperado, actual);
        }
    }
}

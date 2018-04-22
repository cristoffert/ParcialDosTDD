using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculadoraSimple;

namespace ParcialSimpleTest
{
    [TestClass]
    public class ParcialSimpleTest
    {
        [TestMethod]
        public void SumarDosDigitosNumericos()
        {
            Calculadora cal = new Calculadora();
            int resultado = cal.Sumar(2, 2);

            Assert.AreEqual(4, resultado);
        }
        [TestMethod]
        public void SumarDosDigitosCaracteres()
        {
            Calculadora cal = new Calculadora();
            int resultado = cal.Sumar("2", "2");

            Assert.AreEqual(4, resultado);
        }
        [TestMethod]
        public void SumarDosDigitosCadenaVacia()
        {
            Calculadora cal = new Calculadora();
            int resultado = cal.SumarCero("", "");

            Assert.AreEqual(0, resultado);
        }
        [TestMethod]
        public void RestarDosDigitosNumericos()
        {
            Calculadora cal = new Calculadora();
            int resultado = cal.Restar(3, 2);

            Assert.AreEqual(1, resultado);
        }
        [TestMethod]
        public void MultiplicarDosDigitosNumericos()
        {
            Calculadora cal = new Calculadora();
            int resultado = cal.Multiplicar(3, 2);

            Assert.AreEqual(6, resultado);
        }
        [TestMethod]
        public void MultiplicarPorCero()
        {
            Calculadora cal = new Calculadora();
            int resultado = cal.MultiplicarCero(0, 2);

            Assert.AreEqual(0, resultado);
        }
        [TestMethod]
        public void CalcularRaizCuadrada()
        {
            Calculadora cal = new Calculadora();
            double resultado = cal.Raiz(4);

            Assert.AreEqual(2, resultado);
        }
        [TestMethod]
        public void CalcularPotencia()
        {
            Calculadora cal = new Calculadora();
            double resultado = cal.Potencia(2,2);

            Assert.AreEqual(4, resultado);
        }
        [TestMethod]
        public void CalcularDivision()
        {
            Calculadora cal = new Calculadora();
            double resultado = cal.Division(4, 2);

            Assert.AreEqual(2, resultado);
        }
        [TestMethod]
        public void CalcularDivisionSinDecimal()
        {
            Calculadora cal = new Calculadora();
            decimal resultado = cal.DivisionSinDecimal(3, 2);

            Assert.AreEqual(1, resultado);
        }
        [TestMethod]
        public void ResiduoDeDivision()
        {
            Calculadora cal = new Calculadora();
            int resultado = cal.Residuo(3, 2);

            Assert.AreEqual(1, resultado);
        }
    }
}

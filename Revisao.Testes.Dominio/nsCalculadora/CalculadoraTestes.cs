using Microsoft.VisualStudio.TestTools.UnitTesting;
using Revisao.Dominio.nsCalculadora;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Testes.Dominio.nsCalculadora
{
    [TestClass]
    public class CalculadoraTestes
    {
        private const string _owner = "Juliano";
        private const string _category = "Calculadora";
        private readonly Calculadora _calculadora = new Calculadora();
        private const decimal _valor1 = 8.00m;
        private const decimal _valor2 = 2.00m;

        [TestMethod]
        [Owner(_owner)]
        [Category(_category)]
        public void Calculadora_Soma_ExpectedSucesso()
        {
            Assert.AreEqual(10.00m, _calculadora.Soma(_valor1, _valor2));
        }

        [TestMethod]
        [Owner(_owner)]
        [Category(_category)]
        public void Calculadora_Subtracao_ExpectedSucesso()
        {
            Assert.AreEqual(6.00m, _calculadora.Subtracao(_valor1, _valor2));
        }

        [TestMethod]
        [Owner(_owner)]
        [Category(_category)]
        public void Calculadora_Subtracao_ExpectedException()
        {
            Assert.AreEqual(6.00m, _calculadora.Subtracao(_valor1, _valor2));
        }

        [TestMethod]
        [Owner(_owner)]
        [Category(_category)]
        public void Calculadora_Multiplicacao_ExpectedSucesso()
        {
            Assert.AreEqual(16.00m, _calculadora.Multiplicacao(_valor1, _valor2));
        }

        [TestMethod]
        [Owner(_owner)]
        [Category(_category)]
        public void Calculadora_Divisao_ExpectedSucesso()
        {
            Assert.AreEqual(4.00m, _calculadora.Divisao(_valor1, _valor2));
        }

        [TestMethod]
        [Owner(_owner)]
        [Category(_category)]
        public void Calculadora_Mod_ExpectedSucesso()
        {
            Assert.AreEqual(0.00m, _calculadora.Mod(_valor1, _valor2));
        }
    }
}

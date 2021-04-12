using Microsoft.VisualStudio.TestTools.UnitTesting;
using Revisao.Dominio.nsFaixaEtaria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Testes.Dominio.nsFaixaEtaria
{
    [TestClass]
    public class FaixaEtariaTestes
    {
        private const string _owner = "Juliano";
        private const string _category = "FaixaEtaria";

        [TestMethod]
        [Owner(_owner)]
        [TestCategory(_category)]
        public void FaixaEtaria_IsAdulto_ExpectedSucesso()
        {
            var faixaEtaria = new FaixaEtaria(27, 1, 1989);
            Assert.IsTrue(faixaEtaria.IsAdulto);
        }

        [TestMethod]
        [Owner(_owner)]
        [TestCategory(_category)]
        public void FaixaEtaria_IsIdoso_ExpectedSucesso()
        {
            var faixaEtaria = new FaixaEtaria(27, 1, 1959);
            Assert.IsTrue(faixaEtaria.IsIdoso);
        }

        [TestMethod]
        [Owner(_owner)]
        [TestCategory(_category)]
        public void FaixaEtaria_IsJovem_ExpectedSucesso()
        {
            var faixaEtaria = new FaixaEtaria(27, 1, 2008);
            Assert.IsTrue(faixaEtaria.IsJovem);
        }
    }
}
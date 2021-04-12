using Microsoft.VisualStudio.TestTools.UnitTesting;
using Revisao.Dominio.nsLivro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Testes.Dominio.nsLivro
{
    [TestClass]
    public class LivroTestes
    {
        private const string _owner = "Juliano";
        private const string _category = "Livro";

        [TestMethod]
        [Owner(_owner)]
        [TestCategory(_category)]
        public void Livro_Titulo_ExpectedArgumentNullException()
        {
            Assert.ThrowsException<ArgumentNullException>(
                () => new Livro(null, "Juliano", 69.90m),
                "Não foi gerada exceção para propriedade Titulo quando valor for null! Verifique.");
        }

        [TestMethod]
        [Owner(_owner)]
        [TestCategory(_category)]
        public void Livro_Autor_ExpectedArgumentNullException()
        {
            Assert.ThrowsException<ArgumentNullException>(
                () => new Livro("Programação IV", null, 69.90m),
                "Não foi gerada exceção para propriedade Autor quando valor for null! Verifique.");
        }

        [TestMethod]
        [Owner(_owner)]
        [TestCategory(_category)]
        public void Livro_Valor_ExpectedArgumentOutOfRangeException()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(
                () => new Livro("Programação IV", "Juliano", 0.00m),
                "Não foi gerada exceção para propriedade Valor quando for menor ou igual a zero! Verifique.");
        }

        [TestMethod]
        [Owner(_owner)]
        [TestCategory(_category)]
        public void Livro_ToString_ExpectedSucesso()
        {
            //Arrange
            var livro = new Livro("Programação IV", "Juliano", 69.90m);

            //Act
            var resultado = livro.ToString();

            //Assert
            Assert.AreEqual("Título: Programação IV Autor: Juliano Valor: 69,90", resultado);
        }
    }
}
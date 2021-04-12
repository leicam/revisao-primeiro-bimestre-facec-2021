using Microsoft.VisualStudio.TestTools.UnitTesting;
using Revisao.Dominio.nsAluno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Testes.Dominio.nsAluno
{
    [TestClass]
    public class AlunoTestes
    {
        private const string _owner = "Juliano";
        private const string _category = "Aluno";

        [TestMethod]
        [Owner(_owner)]
        [TestCategory(_category)]
        public void Aluno_IsAlunoFicouParaExame_ExpectedFalse()
        {
            //Arrange
            var aluno = new Aluno(123456, "Juliano", 42, 7.5m, 8.5m);

            //Act
            //Assert
            Assert.IsFalse(aluno.IsAlunoFicouParaExame(),
                "Não foi calculada corretamente a média do aluno, sendo que o resultado deveria ser 8 e a média ser 7!");
        }

        [TestMethod]
        [Owner(_owner)]
        [TestCategory(_category)]
        public void Aluno_IsAlunoReprovadoPorFaltas_ExpectedFalse()
        {
            //Arrange
            var aluno = new Aluno(123456, "Juliano", 42, 7.5m, 8.5m);

            //Act
            //Assert
            Assert.IsFalse(aluno.IsAlunoReprovadoPorFaltas(),
                "Não foi calculada corretamente a proporção de faltas do aluno, sendo a frequência máxima 45 com limite de 9");
        }
    }
}
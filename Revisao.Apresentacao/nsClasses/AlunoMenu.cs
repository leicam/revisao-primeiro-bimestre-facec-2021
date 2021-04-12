using Revisao.Apresentacao.nsExtensions;
using Revisao.Dominio.nsAluno;
using Revisao.Dominio.nsInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Apresentacao.nsClasses
{
    public class AlunoMenu : IItemMenu
    {
        public void Executar()
        {
            var aluno = GetAluno();

            ValidarExame(aluno);
            ValidarFrequencia(aluno);
        }

        private void ValidarExame(Aluno aluno)
        {
            if(aluno.IsAlunoFicouParaExame())
            {
                Console.WriteLine($"Aluno {aluno.Nome} ficou para exame.");
                return;
            }

            Console.WriteLine($"Aluno {aluno.Nome} está aprovado.");
        }

        private void ValidarFrequencia(Aluno aluno)
        {
            if (aluno.IsAlunoReprovadoPorFaltas())
            {
                Console.WriteLine($"Aluno {aluno.Nome} reprovado por faltas.");
                return;
            }

            Console.WriteLine($"Aluno {aluno.Nome} contem a frequência necessária.");
        }

        private Aluno GetAluno()
        {
            return new Aluno(GetRegistroAcademico(), GetNome(), GetFrequencia(), GetNotaPrimeiroBimestre(), GetNotaSegundoBimestre());
        }

        private uint GetRegistroAcademico()
        {
            Console.WriteLine("Informe o registro acadêmico do aluno:");
            return Console.ReadLine().ToUInt();
        }

        private string GetNome()
        {
            Console.WriteLine("Informe o nome do aluno:");
            return Console.ReadLine();
        }

        private uint GetFrequencia()
        {
            Console.WriteLine("Informe a frequência do aluno:");
            return Console.ReadLine().ToUInt();
        }

        private decimal GetNotaPrimeiroBimestre()
        {
            Console.WriteLine("Informe a nota primeiro bimestre do aluno:");
            return Console.ReadLine().ToDecimal();
        }

        private decimal GetNotaSegundoBimestre()
        {
            Console.WriteLine("Informe a nota segundo bimestre do aluno:");
            return Console.ReadLine().ToDecimal();
        }
    }
}
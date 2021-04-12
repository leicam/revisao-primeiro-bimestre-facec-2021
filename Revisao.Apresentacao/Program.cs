using Revisao.Apresentacao.nsClasses;
using Revisao.Dominio.nsInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Apresentacao
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Escolha o programa que deseja executar:");
                Console.WriteLine("1 - Calculadora");
                Console.WriteLine("2 - Faixa etaria");
                Console.WriteLine("3 - Cadastro de Livro");
                Console.WriteLine("4 - Cadastro de Aluno");

                switch (Console.ReadLine())
                {
                    case "1":
                        Executar(new CalculadoraMenu());
                        break;
                    case "2":
                        Executar(new FaixaEtariaMenu());
                        break;
                    case "3":
                        Executar(new LivroMenu());
                        break;
                    case "4":
                        Executar(new AlunoMenu());
                        break;
                    default:
                        Console.WriteLine("Opção não é valida! Verifique");
                        break;
                }

                Console.WriteLine("Deseja executar novamente? S / N");

            } while (Console.ReadLine().Equals("S"));

            Console.WriteLine("Até uma próxima!");
            Console.ReadKey();
        }

        private static void Executar(IItemMenu itemMenu)
        {
            try
            {
                itemMenu.Executar();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
using Revisao.Dominio.nsCalculadora;
using Revisao.Dominio.nsInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Apresentacao.nsClasses
{
    public class CalculadoraMenu : IItemMenu
    {
        private readonly Calculadora _calculadora = new Calculadora();

        public void Executar()
        {
            do
            {
                Console.WriteLine("Qual operação matemática deseja realizar:");
                Console.WriteLine("Para soma digite: +");
                Console.WriteLine("Para subtração digite: -");
                Console.WriteLine("Para multiplicação digite: *");
                Console.WriteLine("Para divisão digite: /");
                Console.WriteLine("Para MOD (resto da divisão) digite: %");

                switch (Console.ReadLine())
                {
                    case "+":
                        Soma(CapturarPrimerioNumero(), CapturarSegundoNumero());
                        break;
                    case "-":
                        Subtracao(CapturarPrimerioNumero(), CapturarSegundoNumero());
                        break;
                    case "*":
                        Multiplicacao(CapturarPrimerioNumero(), CapturarSegundoNumero());
                        break;
                    case "/":
                        Divisao(CapturarPrimerioNumero(), CapturarSegundoNumero());
                        break;
                    case "%":
                        Mod(CapturarPrimerioNumero(), CapturarSegundoNumero());
                        break;
                    default:
                        Console.WriteLine("Opção selecionada é inválida!");
                        break;
                }

                Console.WriteLine("Deseja executar o programa novamente? S/N");
            } while (Console.ReadLine().Equals("S"));
        }

        private void Soma(decimal valorUm, decimal valorDois)
        {
            Console.WriteLine($"Resultado de {valorUm} + {valorDois} = {_calculadora.Soma(valorUm, valorDois)}");
        }

        private void Subtracao(decimal valorUm, decimal valorDois)
        {
            Console.WriteLine($"Resultado de {valorUm} - {valorDois} = {_calculadora.Subtracao(valorUm, valorDois)}");
        }

        private void Multiplicacao(decimal valorUm, decimal valorDois)
        {
            Console.WriteLine($"Resultado de {valorUm} * {valorDois} = {_calculadora.Multiplicacao(valorUm, valorDois)}");
        }

        private void Divisao(decimal valorUm, decimal valorDois)
        {
            Console.WriteLine($"Resultado de {valorUm} / {valorDois} = {_calculadora.Divisao(valorUm, valorDois)}");
        }

        private void Mod(decimal valorUm, decimal valorDois)
        {
            Console.WriteLine($"Resultado de {valorUm} % {valorDois} = {_calculadora.Mod(valorUm, valorDois)}");
        }

        private decimal CapturarPrimerioNumero()
        {
            Console.WriteLine("Informe o primeiro valor: ");
            return decimal.Parse(Console.ReadLine());
        }

        private decimal CapturarSegundoNumero()
        {
            Console.WriteLine("Informe o segundo valor: ");
            return decimal.Parse(Console.ReadLine());
        }
    }
}
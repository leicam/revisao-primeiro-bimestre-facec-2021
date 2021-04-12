using Revisao.Apresentacao.nsExtensions;
using Revisao.Dominio.nsFaixaEtaria;
using Revisao.Dominio.nsInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Apresentacao.nsClasses
{
    public class FaixaEtariaMenu : IItemMenu
    {
        public void Executar()
        {
            Console.WriteLine("Por favor, informe o dia de nascimento:");
            var dia = Console.ReadLine().ToInt();

            Console.WriteLine("Por favor, informe o mês de nascimento:");
            var mes = Console.ReadLine().ToInt();

            Console.WriteLine("Por favor, informe o ano de nascimento:");
            var ano = Console.ReadLine().ToInt();

            var faixaEtaria = new FaixaEtaria(dia, mes, ano);

            if(faixaEtaria.IsAdulto)
                Console.WriteLine($"Você é um adulto sua idade é {faixaEtaria.Idade}.");
            else if (faixaEtaria.IsIdoso)
                Console.WriteLine($"Você é um idoso sua idade é {faixaEtaria.Idade}.");
            else
                Console.WriteLine($"Você é um jovem sua idade é {faixaEtaria.Idade}.");
        }
    }
}
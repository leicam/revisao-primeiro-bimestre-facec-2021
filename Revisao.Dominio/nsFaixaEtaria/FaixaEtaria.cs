using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Dominio.nsFaixaEtaria
{
    public class FaixaEtaria
    {
        public DateTime DataDeNascimento { get; private set; }
        public int Idade { get; private set; }
        public bool IsJovem => Idade <= 19;
        public bool IsIdoso => Idade >= 60;
        public bool IsAdulto => !IsJovem && !IsIdoso;

        public FaixaEtaria(int dia, int mes, int ano)
        {
            ValidarDia(dia);
            ValidarMes(mes);
            ValidarAno(ano);

            DataDeNascimento = new DateTime(ano, mes, dia);
            Idade = DateTime.Today.Year - DataDeNascimento.Year;
        }

        private void ValidarAno(int ano)
        {
            if (ano < 0 || ano > DateTime.Today.Year)
                throw new ArgumentOutOfRangeException(nameof(ano));
        }

        private void ValidarMes(int mes)
        {
            if (mes < 0 || mes > 12)
                throw new ArgumentOutOfRangeException(nameof(mes));
        }

        private void ValidarDia(int dia)
        {
            if (dia < 0 || dia > 31)
                throw new ArgumentOutOfRangeException(nameof(dia));
        }
    }
}
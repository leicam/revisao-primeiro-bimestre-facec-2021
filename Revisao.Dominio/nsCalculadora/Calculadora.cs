using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Dominio.nsCalculadora
{
    public class Calculadora
    {
        public decimal Soma(decimal valorUm, decimal valorDois)
        {
            return valorUm + valorDois;
        }

        public decimal Subtracao(decimal valorUm, decimal valorDois)
        {
            if (valorDois > valorUm)
                throw new Exception("Valor dois não pode ser maior que o valor um!");

            return valorUm - valorDois;
        }

        public decimal Multiplicacao(decimal valorUm, decimal valorDois)
        {
            return valorUm * valorDois;
        }

        public decimal Divisao(decimal valorUm, decimal valorDois)
        {
            return valorUm / valorDois;
        }

        public decimal Mod(decimal valorUm, decimal valorDois)
        {
            return valorUm % valorDois;
        }
    }
}
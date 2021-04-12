using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Dominio.nsLivro
{
    public struct Livro
    {
        public string Titulo { get; private set; }
        public string Autor { get; private set; }
        public decimal Valor { get; private set; }

        public Livro(string titulo, string autor, decimal valor)
        {
            Titulo = titulo ?? throw new ArgumentNullException(nameof(Titulo));
            Autor = autor ?? throw new ArgumentNullException(nameof(Titulo));
            Valor = valor;

            ValidarValor();
        }

        public override string ToString()
        {
            return $"Título: {Titulo} Autor: {Autor} Valor: {Valor}";
        }

        private void ValidarValor()
        {
            if (Valor <= 0.00m)
                throw new ArgumentOutOfRangeException(nameof(Valor));
        }
    }
}
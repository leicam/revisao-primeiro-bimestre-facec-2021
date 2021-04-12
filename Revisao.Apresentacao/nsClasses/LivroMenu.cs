using Revisao.Apresentacao.nsExtensions;
using Revisao.Dominio.nsInterfaces;
using Revisao.Dominio.nsLivro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Apresentacao.nsClasses
{
    public class LivroMenu : IItemMenu
    {
        public void Executar()
        {
            Console.WriteLine(GetLivro().ToString());
        }

        private Livro GetLivro()
        {
            return new Livro(GetTitulo(), GetAutor(), GetValor());
        }

        private string GetTitulo()
        {
            Console.WriteLine("Informe o título do livro:");
            return Console.ReadLine();
        }

        private string GetAutor()
        {
            Console.WriteLine("Informe o autor do livro:");
            return Console.ReadLine();
        }

        private decimal GetValor()
        {
            Console.WriteLine("Informe o valor do livro:");
            return Console.ReadLine().ToDecimal();
        }
    }
}
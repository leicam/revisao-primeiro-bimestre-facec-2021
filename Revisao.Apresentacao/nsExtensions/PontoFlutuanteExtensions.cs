using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Apresentacao.nsExtensions
{
    public static class PontoFlutuanteExtensions
    {
        public static decimal ToDecimal(this object valor)
        {
            return Convert.ToDecimal(valor);
        }
    }
}
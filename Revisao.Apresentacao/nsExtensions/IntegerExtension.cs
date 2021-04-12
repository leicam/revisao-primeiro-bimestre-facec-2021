using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Apresentacao.nsExtensions
{
    internal static class IntegerExtension
    {
        public static int ToInt(this object valor)
        {
            return Convert.ToInt32(valor);
        }

        public static uint ToUInt(this object valor)
        {
            return Convert.ToUInt32(valor);
        }
    }
}
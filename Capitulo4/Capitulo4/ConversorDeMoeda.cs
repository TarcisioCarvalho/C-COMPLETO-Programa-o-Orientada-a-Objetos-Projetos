using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo4
{
    class ConversorDeMoeda
    {
        static Double Iof = 0.06;

       public static Double ConverteMoeda(Double cotacaoDolar,Double valorDolar)
        {
            return (cotacaoDolar*valorDolar + Iof*cotacaoDolar*valorDolar);
        }
    }
}

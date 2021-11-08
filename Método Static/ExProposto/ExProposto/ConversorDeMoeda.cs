using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExProposto
{
    class ConversorDeMoeda
    {
        public static double IOF = 6.0; 

        public static double ConverterMoeda(double dolar, double comprar)
        {
            double total = dolar * comprar;
            return total + total * IOF / 100.0;
        }
    }
}

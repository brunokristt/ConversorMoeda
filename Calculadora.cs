using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorMoeda
{
    class Calculadora
    {
        public static double Iof = 6.0;
        public static double Calc(double cotacao, double quantidade)
        {
            double total = cotacao * quantidade;
            return total = total + total * (Iof / 100);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Calculo
    {
        public Double Somar(Double n1, Double n2)
        {
            Double result = 0;
            result = n1 + n2;
            return result;

        }

        public Double Subtrair (Double n1, Double n2)
        {
            Double result = 0;
            result = n1 - n2;
            return result;
        }

        public Double Multiplicar(Double n1, Double n2)
        {
            Double result = 1;
            result = n1 * n2;
            return result;
        }
        public Double Dividir(Double n1, Double n2)
        {
            Double result = 0;
            result = n1 / n2;
            return result;

        }
    }
}

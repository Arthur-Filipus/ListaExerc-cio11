using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício10
{
    internal class CalculoTotal
    {
        public double CalculoMediaPonderada()
        {
            double nota1 = 5;
            double nota2 = 9;
            double peso1 = 2;
            double peso2 = 1;
            double media = (nota1 * peso1) + (nota2 * peso2);
            return media;
        }
    }
}

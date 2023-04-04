using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício7
{
    internal class TotalSalario
    {
        public double CalculoSalario()
        {
            double salario = 2000;
            double vendas = 10;
            double comissao = 15;
            double total = salario + (vendas * comissao);
            return total;
        }
    }
}

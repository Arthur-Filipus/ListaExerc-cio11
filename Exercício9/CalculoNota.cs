using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício9
{
    internal class CalculoNota
    {
        public double CalculoMediaHarmonica()
        {
            double quantidade = 4;
            double nota1 = 4;
            double nota2 = 7;
            double nota3 = 10;
            double nota4 = 6;
            double notatotal = nota1 + nota2 + nota3 + nota4;
            double media = quantidade / notatotal;
            return media;
        }
    }
}

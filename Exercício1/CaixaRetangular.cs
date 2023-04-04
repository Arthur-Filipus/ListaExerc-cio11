using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício1
{
    internal class CaixaRetangular
    {
        public int CalcularVolume()
        {
            int altura = 30;
            int comprimento = 20;
            int largura = 10;

            int volumecaixa = altura * comprimento * largura;
            return volumecaixa;
        }
    }
}

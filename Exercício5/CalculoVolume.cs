using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício5
{
    internal class CalculoVolume
    {
        public double CalculoVolumeEsfera()
        {
            double raio = 10;
            double volume = 4 * Math.PI * Math.Pow(raio, 3) / 3;
            return volume;
        }
    }
}

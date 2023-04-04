using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício3
{
    internal class CalculoVolume
    {
        public double CalculoVolumeCilindro()
        {
            double raio = 10;
            double altura = 5;
            double volume = Math.PI * Math.Pow(raio, 2) * altura;
            
            return volume;
        }
    }
}

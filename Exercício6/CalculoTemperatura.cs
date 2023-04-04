using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício6
{
    internal class CalculoTemperatura
    {
        public double CalculoTemperaturaFahrenheit()
        {
            double celcius = 25;
            double fahrenheit = celcius * 1.8 + 32;
            return fahrenheit;
        }
    }
}

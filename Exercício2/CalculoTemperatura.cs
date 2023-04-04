using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exercício2
{
    internal class CalculoTemperatura
    {
        public int CalculoTemperaturaCelcius()
        {
            
            int fahrenheit = 77;
            int celcius = (fahrenheit - 32) * 5 / 9;
            return celcius;
        }
    }
}

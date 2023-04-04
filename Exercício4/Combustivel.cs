using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício4
{
    internal class Combustivel
    {
        public double ConsumoCombustivel()
        {
            double kmfinal = 100;
            double kminicial = 10;
            double combustivelinicial = 50;
            double combustivelfinal = 5;
            double consumo = (kmfinal - kminicial) / (combustivelinicial - combustivelfinal);
            return consumo;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer04.Classes
{
    public class Circulo:IAreaCalculavel
    {
        public double Raio;
        public const double PI = 3.14;
        public double Area;
        public Circulo(double raio)
        {
            Raio = raio;
        }
        public double calculaArea()
        {
            Area = PI*(Raio*Raio);
            return Area;
        }
    }
}
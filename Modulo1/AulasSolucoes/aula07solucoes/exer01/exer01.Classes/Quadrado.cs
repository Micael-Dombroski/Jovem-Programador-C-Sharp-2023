using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer01.Classes
{
    public class Quadrado:IAreaCalculavel
    {
        public  double Lado;
        public double Area;
        public Quadrado(double lado)
        {
            Lado = lado;
        }
        public double calculaArea()
        {
            Area = Lado*Lado;
            return Area;
        }
    }
}
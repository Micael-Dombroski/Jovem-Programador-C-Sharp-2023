using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer02
{
    public class AreaQuadrado
    {
        public double Lado;
        public double Area;
        public double CalcularAreaQuadrado (double lado)
        {
            Area = lado * lado;
            return Area;
        }
    }
}
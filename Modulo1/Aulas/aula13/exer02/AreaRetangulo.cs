using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer02
{
    public class AreaRetangulo
    {
        public double Base;
        public double Altura;
        public double Area;
        public double CalcularAreaRetangulo (double baseR, double alturaR)
        {
            Area = baseR*alturaR;
            return Area;
        }
    }
}
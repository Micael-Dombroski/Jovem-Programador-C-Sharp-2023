using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer02
{
    public class AreaTriangulo
    {
        public double Base;
        public double Altura;
        public double Area;
        public double  CalcularAreaTriangulo (double baseT, double alturaT)
        {
            Area = baseT * alturaT;
            return Area;
        }
    }
}
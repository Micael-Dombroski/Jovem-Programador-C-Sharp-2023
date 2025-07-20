using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer01.Classes
{
    public class Retangulo:IAreaCalculavel
    {
        public double Base;
        public double Altura;
        public double Area;
        public Retangulo(double baase, double altura)
        {
            Base=baase;
            Altura=altura;
        }
        public double calculaArea()
        {
            Area = Base*Altura;
            return Area;
        }
    }
}
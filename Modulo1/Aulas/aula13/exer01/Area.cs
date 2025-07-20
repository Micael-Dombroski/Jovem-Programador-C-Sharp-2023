using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer01
{
    public class Area
    {
        public double Raio;
        public double Pi = 3.14;

        public double CalcularArea()
        {
            double area = Pi * (Raio*Raio);
            return area;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer03
{
    public class Calculadora
    {
        public double Num1;
        public double Num2;
        protected double Resultado;
        public Calculadora(double n1, double n2)
        {
            Num1 = n1;
            Num2 = n2;
        }
        public virtual double Operacao ()
        {
            return Resultado;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer02.Classes
{
    public class Subtracao:Calculadora
    {
        public Subtracao(double n1, double n2):base(n1,n2)
        {
            Num1 = n1;
            Num2 = n2;
        }
        public override double Operacao()
        {
            Resultado = Num1-Num2;
            return Resultado;
        }
    }
}
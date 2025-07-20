using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer04
{
    public class PotenciaBaseQualquer:Calculadora
    {
        public PotenciaBaseQualquer(double n1, double n2):base(n1,n2)
        {
            Num1 = n1;
            Num2 = n2;
        }
        public override double Operacao()
        {
            Resultado = Num1;
            for (int i = 1; i < Num2; i++)
            {
                Resultado = Resultado*Num1;
            }
            return Resultado;
        }
    }
}
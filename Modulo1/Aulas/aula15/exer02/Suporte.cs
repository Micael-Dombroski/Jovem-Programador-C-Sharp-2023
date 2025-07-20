using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer02
{
    public class Suporte:Funcionario
    {
        public override double SalarioFun(double salario)
        {
            return base.SalarioFun(salario+(salario*0.005));
        }
    }
}
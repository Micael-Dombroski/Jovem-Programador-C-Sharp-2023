using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer02
{
    public class Programador:Funcionario
    {
        public override double SalarioFun(double salario)
        {
            return base.SalarioFun(salario+(salario*0.01));
        }
    }
}
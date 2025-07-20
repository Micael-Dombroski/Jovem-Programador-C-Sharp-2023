using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer02
{
    public class Funcionario
    {
        public string CPF {get;set;}
        public string Nome {get;set;}
        public double Salario {get;set;}
        public virtual double SalarioFun(double salario)
        {
            return salario;
        }
    }
}
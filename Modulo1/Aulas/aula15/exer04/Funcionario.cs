using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer04
{
    public class Funcionario
    {
        public string Nome{get;set;}
        public string Cargo {get;set;}
        public double Salario{get;set;}
        public double Imposto {get;set;}
        protected double BaseDeImposto= 0.0;
        public double ImpostoDeRenda(double salario)
        {
            if (salario < 1903.98)
            {
                return salario*0;
            } else if (salario <= 2826.65)
            {
                return salario*0.075;
            } else if (salario <=  3751.05)
            {
                return salario*0.15;
            } else if (salario <= 4664.68)
            {
                return salario*0.225;
            } else
            {
                return salario*0.275;                
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer02
{
    public abstract class Funcionario
    {
        public string Cpf{get;set;}
        public string Nome{get;set;}
        public const double salarioMinimo = 1000.00;
        public double Salario;
        public string Funcao{get;protected set;}
        public Funcionario(string cpf,string nome)
        {
            Cpf=cpf;
            Nome=nome;
        }
        public virtual void SalarioFuncionario()
        {
            Salario = salarioMinimo;
        }
    }
}
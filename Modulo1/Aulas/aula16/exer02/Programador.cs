using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer02
{
    public class Programador:Funcionario
    {
        public Programador(string cpf, string nome):base(cpf,nome)
        {
            Cpf = cpf;
            Nome = nome;
        }
        public override void SalarioFuncionario()
        {
            Salario = salarioMinimo + (salarioMinimo*0.01);
        }
        public void FuncaoFuncionario()
        {
            Funcao = "Programador";
        }
    }
}
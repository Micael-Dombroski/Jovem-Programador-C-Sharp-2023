using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer02
{
    public class Diversos:Funcionario
    {
        public Diversos(string cpf, string nome):base(cpf,nome)
        {
            Cpf=cpf;
            Nome=nome;
        }
        public override void SalarioFuncionario()
        {
            Salario = salarioMinimo;
        }
        public void FuncaoFuncionario()
        {
            Funcao = "Diversos";
        }
    }
}
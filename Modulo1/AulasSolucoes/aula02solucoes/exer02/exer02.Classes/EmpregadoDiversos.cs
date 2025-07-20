using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer02.Classes
{
    public class EmpregadoDiversos:Empregado
    {
        public EmpregadoDiversos(string cpf, string nome, Endereco endereco):base(nome)
        {
            Cpf = cpf;
            Nome=nome;
            Endereco = endereco;
        }
        public override void SalarioFuncionario()
        {
            Salario = salarioMinimo;
        }
        public override void FuncaoFuncionario()
        {
            Funcao = "Diversos";
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer02.Classes
{
    public class EmpregadoProgramador:Empregado
    {
        public EmpregadoProgramador(string cpf, string nome, Endereco endereco):base(nome)
        {
            Cpf = cpf;
            Nome = nome;
            Endereco = endereco;
        }
        public override void SalarioFuncionario()
        {
            Salario = salarioMinimo + (salarioMinimo*0.01);
            if (Tipo == 2)
            {
                Salario += Salario*0.3;
            }
        }
        public override void FuncaoFuncionario()
        {
            Funcao = "Programador";
        }
    }
}
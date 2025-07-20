using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer03
{
    public class Suporte:Funcionario
    {
        public Suporte(string nome):base(nome)
        {
            Nome=nome;
        }
        public override void SalarioFuncionario()
        {
            Salario = salarioMinimo + (salarioMinimo*0.005);
            if (Tipo == 2)
            {
                Salario += Salario*0.3;
            }
        }
        public override void FuncaoFuncionario()
        {
            Funcao = "Suporte";
        }
    }
}
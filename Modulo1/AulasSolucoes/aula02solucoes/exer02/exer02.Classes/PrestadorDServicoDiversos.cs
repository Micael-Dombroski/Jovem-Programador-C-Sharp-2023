using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer02.Classes
{
    public class PrestadorDServicoDiversos:PrestadorDServico
    {
        public PrestadorDServicoDiversos(string nome, Endereco endereco):base(nome)
        {
            Nome=nome;
            Endereco = endereco;
        }
        public override void SalarioFuncionario()
        {
            Salario = salarioMinimo;
            Salario += Salario*0.3;
        }
        public override void FuncaoFuncionario()
        {
            Funcao = "Diversos";
        }
    }
}
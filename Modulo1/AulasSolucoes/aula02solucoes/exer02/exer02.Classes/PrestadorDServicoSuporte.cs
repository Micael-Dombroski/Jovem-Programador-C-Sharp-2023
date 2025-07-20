using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer02.Classes
{
    public class PrestadorDServicoSuporte:PrestadorDServico
    {
        public PrestadorDServicoSuporte(string nome, Endereco endereco):base(nome)
        {
            Nome=nome;
            Endereco = endereco;
        }
        public override void SalarioFuncionario()
        {
            Salario = salarioMinimo + (salarioMinimo*0.005);
            Salario += Salario*0.3;
        }
        public override void FuncaoFuncionario()
        {
            Funcao = "Suporte";
        }
    }
}
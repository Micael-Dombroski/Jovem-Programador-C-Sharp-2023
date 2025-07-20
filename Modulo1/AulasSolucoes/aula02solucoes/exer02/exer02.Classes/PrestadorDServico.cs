using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer02.Classes
{
    public class PrestadorDServico:Funcionario
    {
        public PrestadorDServico(string nome):base(nome)
        {
            Nome=nome;
        }
        public override void SalarioFuncionario()
        {

        }
        public override void FuncaoFuncionario()
        {
            Funcao = "Indefinido";
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer02.Classes
{
    public class Empregado:Funcionario
    {
        public Empregado(string nome):base(nome)
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
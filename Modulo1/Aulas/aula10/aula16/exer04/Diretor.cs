using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer04
{
    public class Diretor:Funcionario
    {
        public Diretor(string nome):base(nome)
        {
            Nome=nome;
        }
        public override void DefinirCargo()
        {
            Cargo = "Diretor";
        }
        public override void DefinirSalario()
        {
            Salario=SalarioMinimo*10;
        }
    }
}
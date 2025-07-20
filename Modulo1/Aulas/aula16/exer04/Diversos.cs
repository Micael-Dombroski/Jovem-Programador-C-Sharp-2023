using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer04
{
    public class Diversos:Funcionario
    {
        public Diversos(string nome):base(nome)
        {
            Nome=nome;
        }
        public override void DefinirCargo()
        {
            Cargo = "Diversos";
        }
        public override void DefinirSalario()
        {
            Salario = SalarioMinimo;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer03.Classes
{
    public class ContaInvestimento:Conta,ITributo
    {
        public ContaInvestimento(int agencia, Cliente correntista, double saldo)
        {
            Agencia = agencia;
            Correntista = correntista;
            Saldo = saldo;
        }
        public double CalcularTributo()
        {
            return (Saldo + (Saldo * 0.02)) * 0.1;
        }
        public double CalcularRendimento()
        {
            return Saldo*0.02;
        }
    }
}
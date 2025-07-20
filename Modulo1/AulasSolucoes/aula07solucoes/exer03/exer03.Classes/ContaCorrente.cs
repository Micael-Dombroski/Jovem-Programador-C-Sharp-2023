using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer03.Classes
{
    public class ContaCorrente:Conta,ITributo
    {
        public ContaCorrente(int agencia, Cliente correntista, double saldo)
        {
            Agencia = agencia;
            Correntista = correntista;
            Saldo = saldo;
        }
        public double CalcularTributo()
        {
            return Saldo*0.1;
        }
    }
}
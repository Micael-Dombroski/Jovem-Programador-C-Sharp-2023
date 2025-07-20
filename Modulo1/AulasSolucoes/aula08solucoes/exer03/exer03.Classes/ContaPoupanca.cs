using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer03.Classes
{
    public class ContaPoupanca:Conta
    {
        public ContaPoupanca(int agencia, Cliente correntista, double saldo)
        {
            Agencia = agencia;
            Correntista = correntista;
            Saldo = saldo;
        }
        public double CalcularRendimento()
        {
            return Saldo*0.005;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula10
{
    public class TotalizadorContas
    {
        public double Total {get; private set;}
        public void SomarSaldo(Conta conta)
        {
            if (conta is ContaPoupanca)
            {
                ContaPoupanca poupanca= (ContaPoupanca)conta;
                Total+= poupanca.RendimentoTotal(); 
            }
            Total+=conta.Saldo;
        }
    }
}
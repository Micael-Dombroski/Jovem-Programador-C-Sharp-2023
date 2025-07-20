using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolucaoBanco.Classes
{
    public class ContaCorrente : Conta
    {
        public override bool Sacar(double valor)
        {
            if (Saldo >= valor + 2 && valor > 0)
            {
                Saldo -= valor + 2;
                return true;
            }
            return false;
        }
    }
}
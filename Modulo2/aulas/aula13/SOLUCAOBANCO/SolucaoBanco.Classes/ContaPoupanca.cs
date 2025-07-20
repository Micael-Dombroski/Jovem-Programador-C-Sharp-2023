using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolucaoBanco.Classes
{
    public class ContaPoupanca : Conta
    {
        public override bool Sacar (double valor)
        {
            if (Saldo >= valor && valor > 0)
            {
                Saldo -= valor;
                return true;
            }
            return false;
        }
        public double RendimentoTotal()
        {
            return Saldo*0.05;
        }
        public double CalcularTributo()
        {
            return RendimentoTotal() * 0.1;
        }
    }
}
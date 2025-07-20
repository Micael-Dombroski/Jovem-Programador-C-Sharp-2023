using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolucaoBanco.Domain
{
    public class ContaCorrente: Conta, ITributo
    {
        public ContaCorrente():base()
        {
            DefinirTipoConta();
        }
        public override void Sacar(double valor)
        {
            if (valor <= Saldo && valor > 0)
            {
                Saldo -= valor;
            }
        }
        public double CalcularTributo()
        {
            return double.Parse((Saldo*0.1).ToString("F"));
        }
        public override void DefinirTipoConta()
        {
            TipoConta = 1;
        }
    }
}
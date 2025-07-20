using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BancoApiSoluction.WebAPIProjeto
{
    public class ContaInvestimento:Conta, ITributo
    {
        public ContaInvestimento():base()
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
            return double.Parse(Saldo.ToString("F"));
        }
        public override void DefinirTipoConta()
        {
            TipoConta = 2;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolucaoBanco.Domain
{
    public class ContaPoupanca: Conta
    {
        public ContaPoupanca():base()
        {
            DefinirTipoConta();
        }
        public void CalcularRendimento()
        {
            Console.WriteLine($"Seu Rendimento é R$ {double.Parse((Saldo*0.005).ToString("F"))}");
        }
        public override void Sacar(double valor)
        {
            if (valor <= Saldo && valor > 0)
            {
                Saldo -= valor;
            }
        }
        public override void DefinirTipoConta()
        {
            TipoConta = 3;
        }
    }
}
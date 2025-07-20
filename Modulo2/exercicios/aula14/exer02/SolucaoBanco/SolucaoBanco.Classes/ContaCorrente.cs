using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolucaoBanco.Classes
{
    public class ContaCorrente: Conta, ITributo
    {
        public ContaCorrente():base()
        {
            DefinirTipoConta();
        }
        public override void Sacar(double valor)
        {
            if (valor > Saldo && valor > 0)
            {
                Console.WriteLine("Não foi Possível Efetuar o Saque!");
            }
            else
            {
                Saldo -= valor;
                Console.WriteLine("Saque Bem Sucedido!");
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
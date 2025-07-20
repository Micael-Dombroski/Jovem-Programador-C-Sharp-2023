using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BancoSolution.Domain.Entidade
{
    public class ContaCorrente: Conta, ITributo
    {
        public ContaCorrente():base()
        {
            DefinirTipoConta();
        }
        public ContaCorrente(int agencia, int numero, Cliente correntista, int tipoConta):base(agencia, numero, correntista, tipoConta)
        {
            DefinirTipoConta();
            Agencia = agencia;
            Numero = numero;
            Correntista = correntista;
            Saldo = 0;
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
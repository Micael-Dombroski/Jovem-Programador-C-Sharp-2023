using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BancoSolution.Domain.Entidade
{
    public class ContaInvestimento: Conta, ITributo
    {
        public ContaInvestimento():base()
        {
            DefinirTipoConta();
        }
        public ContaInvestimento(int agencia, int numero, Cliente correntista, int tipoConta):base(agencia, numero, correntista, tipoConta)
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
            return double.Parse(Saldo.ToString("F"));
        }
        public override void DefinirTipoConta()
        {
            TipoConta = 2;
        }
    }
}
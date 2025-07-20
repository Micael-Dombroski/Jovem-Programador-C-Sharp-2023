using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula09
{
    public class ContaInvestimento : Conta, IRendimento, ITributavel
    {
        public ContaInvestimento(int agencia, int numero): base(agencia,numero)
        {
            Agencia = agencia;
            Numero = numero;
        }
        public override bool Sacar(double valor)
        {
            if (Saldo >= valor + 5 && valor > 0)
            {
                Saldo -= valor + 5;
                return true;
            }
            return false;
        }
        public double RendimentoTotal()
        {
            return Saldo*0.1;
        }
        public double CalcularTributo()
        {
            return RendimentoTotal() * 0.15;
        }
    }
}
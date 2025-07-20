using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula10
{
    public class ContaCorrente : Conta
    {
        public ContaCorrente(int agencia, int numero): base(agencia,numero)
        {
            Agencia = agencia;
            Numero = numero;
        }
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
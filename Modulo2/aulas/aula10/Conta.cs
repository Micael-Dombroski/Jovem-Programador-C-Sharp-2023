using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula10
{
    public abstract class Conta
    {
        public int Agencia {get; set;}
        public int Numero {get; set;}

        public Cliente Titular {get; set;}
        public double Saldo {get; protected set;}
        public Conta(int agencia, int numero)
        {
            Agencia = agencia;
            Numero = numero;
        }

        public abstract bool Sacar(double valor);
        public void Depositar(double valor)
        {
            if (valor >= 0)
            {
                Saldo += valor;
            }
            else
            {
                throw new DepositoNegativoException();
            }
        }
        public override bool Equals(object obj)
        {
            if (!(obj is Conta))
            {
                return false;
            }
            Conta conta = (Conta)obj;
            return ((Numero == conta.Numero) && (Agencia == conta.Agencia));
        }
        public override string ToString()
        {
            return $"Agência: {Agencia} - Número: {Numero} - Saldo: R$ {Saldo.ToString("F")}";
        }
    }
}
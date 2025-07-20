using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer01.Classes
{
    public abstract class Conta
    {
        public int Agencia {get;set;}
        public int Numero {get;set;}
        public Cliente Correntista {get;set;}
        public double Saldo {get;set;}
        protected static int QuantidadeDeContas = 0;
        public virtual bool Sacar (double saque)
        {
            if (saque <= Saldo && saque > 0.0)
            {
                Console.WriteLine("Saque Bem Sucedido!");
                Saldo -= saque;
                return true;
            } else
            {
                Console.WriteLine("Não foi Possível Efetuar o Saque...");
                return false;
            }
        }
        public bool Depositar(double deposito)
        {
            if (deposito > 0.0)
            {
                Console.WriteLine("Depósito Bem Sucedido!");
                Saldo += deposito;
                return true;
            } else
            {
                Console.WriteLine("Não foi Possível Efetuar o Depósito...");
                return false;
            }
        }
        public int QuantidadeDeContasAtual()
        {
            QuantidadeDeContas++;
            return QuantidadeDeContas;
        }
    }
}
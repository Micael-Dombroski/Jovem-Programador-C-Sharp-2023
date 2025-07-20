using System;
namespace exer01
{
    public abstract class Conta
    {
        public int Agencia {get;set;}
        public int Numero {get;set;}
        public string Correntista {get;set;}
        public double Saldo {get;set;}
        public Conta(int agencia, int numero, string correntista, double saldo)
        {
            Agencia = agencia;
            Numero = numero;
            Correntista = correntista;
            Saldo = saldo;
        }

        public abstract void Sacar(double valor);
        public void Depositar(double valor)
        {
            if (valor > 0)
            {
                Console.WriteLine("Não foi Possível Efetuar o Depósito!");
            }
            else
            {
                Saldo -= valor;
                Console.WriteLine("Depósito Bem Sucedido!");
            }
        }
    }
}
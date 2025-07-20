using System;

namespace exer02
{
    public class ContaPoupanca: Conta, IRendimento
    {
        public ContaPoupanca(int agencia, int numero, string correntista, double saldo):base(agencia, numero, correntista, saldo)
        {
            Agencia = agencia;
            Numero = numero;
            Correntista = correntista;
            Saldo = saldo;
        }
        public double CalcularRendimento()
        {
            return double.Parse((Saldo*0.005).ToString("F"));
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
    }
}
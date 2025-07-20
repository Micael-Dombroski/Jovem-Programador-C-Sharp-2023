using System;
namespace exer01
{
    public class ContaPoupanca: Conta
    {
        public ContaPoupanca(int agencia, int numero, string correntista, double saldo):base(agencia, numero, correntista, saldo)
        {
            Agencia = agencia;
            Numero = numero;
            Correntista = correntista;
            Saldo = saldo;
        }
        public void CalcularRendimento()
        {

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
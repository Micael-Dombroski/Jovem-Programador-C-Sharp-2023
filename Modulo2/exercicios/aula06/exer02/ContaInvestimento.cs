using System;

namespace exer02
{
    public class ContaInvestimento:Conta, IRendimento, ITributavel
    {
        public ContaInvestimento(int agencia, int numero, string correntista, double saldo):base(agencia, numero, correntista, saldo)
        {
            Agencia = agencia;
            Numero = numero;
            Correntista = correntista;
            Saldo = saldo;
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
            return double.Parse(((Saldo + CalcularRendimento())*0.10).ToString("F"));
        }
        public double CalcularRendimento()
        {
            return double.Parse((Saldo*0.02).ToString("F"));
        }
    }
}
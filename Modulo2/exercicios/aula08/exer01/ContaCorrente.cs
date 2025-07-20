using System;

namespace exer01
{
    public class ContaCorrente: Conta, ITributavel
    {
        public ContaCorrente(int agencia, string correntista):base(agencia, correntista)
        {
            Agencia = agencia;
            Correntista = correntista;
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
            return double.Parse((Saldo*0.1).ToString("F"));
        }
    }
}
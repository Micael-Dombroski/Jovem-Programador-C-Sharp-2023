using System;

namespace exer02
{
    public abstract class Conta
    {
        private static int NumeroConta {get;set;}
        public int Agencia {get;set;}
        public int Numero {get; private set;}
        public string Correntista {get; set;}
        public double Saldo {get; protected set;}
        public Conta(int agencia, string correntista)
        {
            NumeroConta++;
            Agencia = agencia;
            Numero = NumeroConta;
            Correntista = correntista;
        }

        public abstract void Sacar(double valor);
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
            return Numero == conta.Numero;
        }
        public override string ToString()
        {
            return $"{Agencia}|{Numero}|{Correntista}|{Saldo.ToString("F")}";
        }
    }
}
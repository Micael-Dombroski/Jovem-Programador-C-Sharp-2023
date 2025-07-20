using System;
namespace aula05
{
    public class Conta
    {
        public int numero;
        public Cliente titular;
        public double saldo;
        public Conta()
        {
            titular = new Cliente();
        }
        public bool Sacar(double saque)
        {
            if (saldo < saque)
            {
                return false;
            }
            saldo -= saque;
            return true;
        }
        public bool Depositar(double deposito)
        {
            if (0 >= deposito)
            {
                return false;
            }
            saldo += deposito;
            return true;
        }
    }
}
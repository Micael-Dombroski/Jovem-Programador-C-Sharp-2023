using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer01
{
    public class Conta
    {
        public int numero;
        public string correntista;
        public double saldo;
        

        public bool Sacar(double valorSaque)
        {
            if (valorSaque <= saldo && valorSaque > 0.0)
            {
                saldo -= valorSaque;
                return true;
            }
            return false;
        }
        public bool Depositar(double valorDeposito)
        {
            if (valorDeposito > 0.0)
            {
                saldo += valorDeposito;
                return true;
            }
            return false;
        }
        public bool Transferir (double valorTransferencia, ref double saldo2)
        {
            if (valorTransferencia <= saldo && valorTransferencia > 0.0)
            {
                saldo -= valorTransferencia;
                saldo2 += valorTransferencia;
                return true;
            }
            return false;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BancoApiSoluction.WebAPIProjeto
{
    public class Conta
    {
        protected int TipoConta {get;set;}
        public int Agencia {get;set;}
        public int Numero {get;set;}
        public Cliente Correntista {get;set;}
        public double Saldo {get; protected set;}

        public virtual void Sacar(double valor)
        {}
        public virtual void DefinirTipoConta()
        {}
        public void Depositar(double valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
            }
        }

        public override string ToString()
        {
            return $"{Agencia} | {Numero} | {Correntista.Nome} | {MostrarTipoConta()} | R$ {Saldo.ToString("F")}";
        }

        public string MostrarTipoConta()
        {
            if (TipoConta == 1) return "Conta Corrente";
            if (TipoConta == 2) return "Conta Investimento";
            if (TipoConta == 3) return "Conta Poupança";
            return "ERRO";
        }
        public int MostraTipo()
        {
            return TipoConta;
        }

        public override bool Equals(object obj)
        {
            if (obj is Conta)
            {
                Conta conta = (Conta)obj;
                if (conta.Agencia == Agencia && conta.Numero == Numero)
                {
                    return true;
                }
            }
             return false;
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
    }
}
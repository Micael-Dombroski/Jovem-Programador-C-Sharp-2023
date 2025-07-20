using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolucaoBanco.Domain
{
    public abstract class Conta
    {
        public Conta ()
        {
            DefinirTipoConta();
        }
        protected int TipoConta {get;set;}
        public int Agencia {get;set;}
        public int Numero {get;set;}
        public Cliente Correntista {get;set;}
        public double Saldo {get; protected set;}
        protected static int QuantidadeContas {get;set;}

        public abstract void Sacar(double valor);
        public abstract void DefinirTipoConta();
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

        public int QuantidadeContaAtual()
        {
            return QuantidadeContas;
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
    }
}
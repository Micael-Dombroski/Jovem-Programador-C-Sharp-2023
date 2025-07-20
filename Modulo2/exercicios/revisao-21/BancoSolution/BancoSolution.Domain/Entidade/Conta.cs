using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BancoSolution.Domain.Entidade
{
    public class Conta
    {
        public Conta ()
        {
            DefinirTipoConta();
        }
        public int TipoConta {get;set;}
        public int Agencia {get;set;}
        public int Numero {get;set;}
        public Cliente Correntista {get;set;}
        public double Saldo {get; protected set;}

        public Conta(int agencia, int numero, Cliente correntista, int tipoConta)
        {
            Agencia = agencia;
            Numero = numero;
            Correntista = correntista;
            TipoConta = tipoConta;
            Saldo = 0;
        }
        public virtual void Sacar(double valor)
        {

        }
        public virtual void DefinirTipoConta()
        {
        }
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
    }
}
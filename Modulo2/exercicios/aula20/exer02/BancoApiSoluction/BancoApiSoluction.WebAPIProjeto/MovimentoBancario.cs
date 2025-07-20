using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BancoApiSoluction.WebAPIProjeto
{
    public class MovimentoBancario
    {
        public int Id {get;set;}
        public Conta ContaUsada {get;set;}
        public string TipoMovimento {get;set;}
        public double ValorMovimentado {get;set;}

        public override string ToString()
        {
            return $"| {Id} | {ContaUsada.Agencia} | {ContaUsada.Numero} | {ContaUsada.MostrarTipoConta()} | {ContaUsada.Correntista.Nome} | {TipoMovimento} | R$ {ValorMovimentado.ToString("F")} |";
        }

        public override bool Equals(object obj)
        {
            if (obj is MovimentoBancario)
            {
                MovimentoBancario movimentoBancario = (MovimentoBancario)obj;
                if (movimentoBancario.Id == Id)
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
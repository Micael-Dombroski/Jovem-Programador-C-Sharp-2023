using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MerceariaApiSoluction.WebAPIProjeto
{
    public class Venda
    {
        public int IdVenda {get;set;}
        public Cliente ClienteVenda {get;set;}
        public Produto ProdutoVendido {get;set;}
        public double QuantidadeVendida {get;set;}
        public override string ToString()
        {
            double total = QuantidadeVendida * Convert.ToDouble(ProdutoVendido.PrecoUnitario.ToString("F"));
            return $"| {ClienteVenda.Nome} | {ProdutoVendido.Nome} | {QuantidadeVendida.ToString("F")} | R$ {ProdutoVendido.PrecoUnitario.ToString("F")} | R$ {total.ToString("F")}";
        }

        public override bool Equals(object obj)
        {
            if (obj is Venda)
            {
                Venda venda = (Venda)obj;
                if (venda.IdVenda == IdVenda)
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
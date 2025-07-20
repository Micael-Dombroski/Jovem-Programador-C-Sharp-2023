using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolucaoMercearia.Domain.Entidade
{
    public class Venda
    {
        public int Id {get;set;}
        public Cliente ClienteVenda {get;set;}
        public Produto ProdutoVendido {get;set;}
        public double QuantidadeVendida {get;set;}
        public override string ToString()
        {
            double total = QuantidadeVendida * Convert.ToDouble(ProdutoVendido.PrecoUnitario.ToString("F"));
            return $"| {ClienteVenda.Nome} | {ProdutoVendido.Nome} | {QuantidadeVendida.ToString("F")} | R$ {ProdutoVendido.PrecoUnitario.ToString("F")} | R$ {total.ToString("F")}";
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MerceariaApiSoluction.WebAPIProjeto
{
    public class Produto
    {
        public int Id {get;set;}
        public string Nome {get;set;}
        public string Marca {get;set;}
        public DateTime DataVencimento {get;set;}
        public double PrecoUnitario {get;set;}
        public string Unidade {get;set;}
        public double QtEstoque {get;set;}
        public override string ToString()
        {
            return $"Id: {Id} - Nome: {Nome} - Marca: {Marca} - DataVencimento: {DataVencimento.ToString("yyyy-MM-dd")} - Preço Unitário: R$ {PrecoUnitario.ToString("F")} - Unidade: {Unidade} - Quantidade em Estoque: {QtEstoque.ToString("F")}";
        }

        public override bool Equals(object obj)
        {
            if (obj is Produto)
            {
                Produto produto = (Produto)obj;
                if (produto.Id == Id)
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
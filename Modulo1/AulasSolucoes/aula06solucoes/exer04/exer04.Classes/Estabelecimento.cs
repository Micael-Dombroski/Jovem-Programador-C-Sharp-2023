using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace exer04.Classes
{
    public class Estabelecimento
    {
        public string NomeEstabelecimento{get;set;}
        public string NomeGerente{get;set;}
        public CrudProduto ProdutosCadastrados;
        public int Quantidade{get;set;}
        public Estabelecimento(string nomeEstabelecimento, string nomeGerente)
        {
            NomeEstabelecimento = nomeEstabelecimento;
            NomeGerente = nomeGerente;
            ProdutosCadastrados = new CrudProduto();
        }
    }
}
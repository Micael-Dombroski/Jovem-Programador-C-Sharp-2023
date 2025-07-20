using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer04.Classes
{
    public class Produto
    {
        public string Codigo{get;set;}
        public string Nome{get;set;}
        public double Preco{get;set;}
        public int Unidade{get;set;}
        public DateTime Validade{get;set;}
        public Produto(string codigo, string nome, double preco, int unidade, DateTime validade)
        {
            Codigo = codigo;
            Nome = nome;
            Preco = preco;
            Unidade = unidade;
            Validade = new DateTime(validade.Year, validade.Month, validade.Day);
        }
    }
}
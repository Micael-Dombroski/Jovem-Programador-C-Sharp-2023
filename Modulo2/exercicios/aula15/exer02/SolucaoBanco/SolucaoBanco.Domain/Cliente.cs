using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolucaoBanco.Domain
{
    public class Cliente
    {
        public string Nome {get;set;}
        public string CPF {get;set;}
        public string RG {get;set;}
        public string Endereco {get;set;}
        public int Numero {get;set;}
        public string Bairro {get;set;}
        public string Cidade {get;set;}
        public string UF {get;set;}

        public override string ToString()
        {
            return $"{CPF} | {Nome} | {RG} | {Endereco}";
        }
    }
}
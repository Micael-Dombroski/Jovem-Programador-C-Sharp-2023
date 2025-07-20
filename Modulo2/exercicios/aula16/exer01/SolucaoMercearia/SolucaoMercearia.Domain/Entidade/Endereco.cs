using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolucaoMercearia.Domain.Entidade
{
    public struct Endereco
    {
        public string Rua {get;set;}
        public int Numero {get;set;}
        public string Bairro {get;set;}
        public string Cidade {get;set;}
        public string UF {get;set;}

        public override string ToString()
        {
            return $"Rª {Rua} - N° {Numero} - Bairro: {Bairro} - Cidade: {Cidade}({UF})";
        }
    }
}
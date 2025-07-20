using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolucaoTeste03.Classes
{
    public class Cliente
    {
        public string Nome {get;set;}
        public string Cpf {get;set;}
        public string Rg {get;set;}
        public string Endereco {get;set;}
        public Cliente (string nome, string cpf, string rg, string endereco)
        {
            Nome=nome;
            Cpf = cpf;
            Rg = rg;
            Endereco = endereco;
        }
    }
}
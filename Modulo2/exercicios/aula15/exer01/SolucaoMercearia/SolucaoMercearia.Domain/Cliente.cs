using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolucaoMercearia.Domain
{
    public class Cliente
    {
        public int ID {get;set;}
        public string Nome {get;set;}
        public DateTime DataNascimento {get;set;}
        public int Idade
        {
            get
            {
                return DateTime.UtcNow.Year - DataNascimento.Year;
            }
        }
        public Endereco EnderecoMoradia {get;set;}
        public override string ToString()
        {
            return $"ID: {ID} - Nome: {Nome} - Idade: {Idade} - Endereço: {EnderecoMoradia}";
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolucaoMercearia.Domain.Entidade
{
    public class Cliente
    {
        public string Cpf {get;set;}
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
            return $"CPF: {Cpf} - Nome: {Nome} - Idade: {Idade} - Endereço: {EnderecoMoradia}";
        }
    }
}
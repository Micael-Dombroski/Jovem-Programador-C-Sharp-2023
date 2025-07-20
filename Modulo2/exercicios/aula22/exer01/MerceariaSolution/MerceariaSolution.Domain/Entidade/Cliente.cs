using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MerceariaSolution.Domain.Entidade
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

        public override bool Equals(object obj)
        {
            if (obj is Cliente)
            {
                Cliente cliente = (Cliente)obj;
                if (cliente.Cpf == Cpf)
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
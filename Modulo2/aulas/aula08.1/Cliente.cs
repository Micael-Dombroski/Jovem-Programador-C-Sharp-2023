using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula08._1
{
    public class Cliente
    {
        public string Cpf {get; set;}
        public string Rg {get; set;}
        public string Nome {get; set;}
        public string Endereco {get; set;}
        public static int Quantidade {get; private set;}

        public Cliente(string cpf, string rg, string nome)
        {
            this.Cpf = cpf;
            this.Rg = rg;
            this.Nome = nome;
        }

        public Cliente(string cpf, string nome)
        {
            this.Cpf = cpf;
            this.Nome = nome;
            Quantidade++;
        }
        public override string ToString()
        {
            return $"CPF: {Cpf} - Nome: {Nome}";
        }
        public override bool Equals(object obj)
        {
            if (obj is Cliente)
            {
                Cliente clienteNovo = (Cliente)obj;
                if (Cpf == clienteNovo.Cpf)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
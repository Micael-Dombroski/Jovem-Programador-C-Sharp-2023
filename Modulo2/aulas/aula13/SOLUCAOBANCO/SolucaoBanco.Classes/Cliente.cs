using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SolucaoBanco.Classes
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

        public Cliente()
        {
            Quantidade++;
        }

        public Cliente(string cpf, string nome)
        {
            this.Cpf = cpf;
            this.Nome = nome;
            Quantidade++;
        }

        public Cliente(string cpf, string rg, string nome, string endereco)
        {
            this.Cpf = cpf;
            this.Rg = rg;
            this.Nome = nome;
            this.Endereco = endereco;
            Quantidade++;
        }
        public override string ToString()
        {
            return $"CPF: {Cpf} - RG: {Rg} - Nome: {Nome} - Endereço: {Endereco}";
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer04
{
    public class Correntista
    {
        public string Cpf;
        public string Nome;
        public string Sobrenome;
        public double RendaComprovada;
        public DateTime DataNascimento;
        public int Idade;

        public Correntista (string  cpf, string nome, string sobrenome, double rendacomprovada, DateTime datanascimento, int idade)
        {
            Cpf = cpf;
            Nome = nome;
            Sobrenome = sobrenome;
            RendaComprovada = rendacomprovada;
            DataNascimento = datanascimento;
            Idade = idade;
        }
    }
}
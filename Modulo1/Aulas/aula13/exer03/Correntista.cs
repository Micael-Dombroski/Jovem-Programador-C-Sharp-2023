using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer03
{
    public class Correntista
    {
        public string Cpf;
        public string Nome;
        public string Sobrenome;
        public string RendaComprovada;
        public DateTime DataNascimento;
        public int Idade;
        public int Index = 0;

        public void Correntistas (string  cpf, string nome, string sobrenome, string rendacomprovada, DateTime datanascimennto)
        {
            Cpf = cpf;
            Nome = nome;
            Sobrenome = sobrenome;
            RendaComprovada = rendacomprovada;
            DataNascimento = datanascimennto;

        }
    }
}
using System;
namespace exer03
{
    public class Cliente
    {
        public string Nome {get;set;}
        public string Sobrenome {get;set;}
        public string RG {get;set;}
        public string CPF {get;set;}
        public string DataNascimento {get;set;}
        public Cliente (string nome, string sobrenome, string rg, string cpf, string dataNascimento)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            RG = rg;
            CPF = cpf;
            DataNascimento = dataNascimento;
        }
        public Cliente()
        {
            
        }
        public int Idade()
        {
            var dataNasc = DateTime.Parse(DataNascimento);
            int Idade = new DateTime(DateTime.Now.Subtract(dataNasc).Ticks).Year - 1;
            return Idade;
        }
        public bool MaiorDeIdade()
        {
            if(Idade() > 17)
            {
                return true;
            }
            return false;
        }
    }
}
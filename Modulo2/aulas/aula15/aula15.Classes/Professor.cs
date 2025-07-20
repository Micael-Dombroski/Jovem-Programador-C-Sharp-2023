using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula15.Classes
{
    public class Professor
    {
        public int Matricula {get;set;}
        public string Nome {get;set;}
        public DateTime DataNascimento {get;set;}
        public Endereco EnderecoMoradia {get;set;}
        
        public int Idade
        {
            get
            {
                return DateTime.UtcNow.Year - DataNascimento.Year;
            }
        }
        
        public override string ToString()
        {
            return $"{Matricula} {Nome} {Idade} anos {EnderecoMoradia}";
        }
    }
}
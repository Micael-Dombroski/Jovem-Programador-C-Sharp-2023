using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer03.Classes
{
    public class Correntista
    {
        public string Nome {get;set;}
        public string Cpf {get;set;}
        public Correntista (string nome, string cpf)
        {
            Nome = nome;
            Cpf = cpf;
        }
    }
}
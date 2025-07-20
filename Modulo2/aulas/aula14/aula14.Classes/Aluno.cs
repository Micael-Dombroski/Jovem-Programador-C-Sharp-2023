using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula14.Classes
{
    public class Aluno
    {
        public int Matricula {get;set;}
        public string Nome {get;set;}
        public int Idade {get;set;}

        public override string ToString()
        {
            return $"{Matricula} {Nome} {Idade}";
        }
    }
}
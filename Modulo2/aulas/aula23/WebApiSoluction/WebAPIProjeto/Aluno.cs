using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPIProjeto
{
    public class Aluno
    {
        public int Matricula {get;set;}
        public string Nome {get;set;}
        public int Idade {get;set;}

        public override bool Equals(object obj)
        {
            if (obj is Aluno)
            {
                Aluno aluno = (Aluno)obj;
                if (aluno.Matricula == Matricula)
                {
                    return true;
                }
            }
            return false; 
        }

        public override string ToString()
        {
            return $"{Matricula}{Nome}{Idade}";
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
    }
}
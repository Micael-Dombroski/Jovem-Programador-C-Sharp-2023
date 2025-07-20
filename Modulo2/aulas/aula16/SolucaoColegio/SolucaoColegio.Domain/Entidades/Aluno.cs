using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolucaoColegio.Domain.Entidades
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

        public override bool Equals(object obj)
        {
            if (obj is Aluno)
            {
                Aluno aluno = (Aluno) obj;
                if (aluno.Matricula == Matricula)
                {
                    return true;
                }
            }
            return false;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
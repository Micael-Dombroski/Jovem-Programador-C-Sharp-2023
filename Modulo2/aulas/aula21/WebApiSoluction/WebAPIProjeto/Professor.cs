using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPIProjeto
{
    public class Professor
    {
        public int Matricula {get;set;}
        public string Nome {get;set;}
        public DateTime DataNascimento {get;set;}
        public int Idade {
            get
            {
                return DateTime.UtcNow.Year - DataNascimento.Year;
            }
        }
        public string Rua {get;set;}
        public int Numero {get;set;}
        public string Bairro {get;set;}
        public string Cidade {get;set;}
        public string UF {get;set;}

        public override bool Equals(object obj)
        {
            if (obj is Professor)
            {
                Professor professor = (Professor)obj;
                if (professor.Matricula == Matricula)
                {
                    return true;
                }
            }
            return false; 
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"{Matricula} {Nome}";
        }
    }
}
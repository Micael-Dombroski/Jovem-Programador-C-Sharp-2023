using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolucaoColegio.Domain.Entidades
{
    public class Materia
    {
        public int Id {get;set;}
        public string Nome {get;set;}
        public int QuantidadeAula {get;set;}

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return $"{Id} {Nome} {QuantidadeAula}";
        }
    }
}
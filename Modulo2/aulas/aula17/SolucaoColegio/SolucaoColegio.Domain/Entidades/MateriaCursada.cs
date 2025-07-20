using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolucaoColegio.Domain.Entidades
{
    public class MateriaCursada
    {
        public int Id {get;set;}
        public Aluno AlunoCursando {get;set;}
        public Materia MateriaSendoCursada {get;set;}
        public double Nota {get;set;}

        public override string ToString()
        {
            return $"{Id} {AlunoCursando} {MateriaSendoCursada} {Nota}";
        }
    }
}
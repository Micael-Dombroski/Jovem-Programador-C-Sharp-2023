using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer01
{
    public class Aluno
    {
        public int Matricula;
        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;
        public double Nota4;
        public double Media;
        public string Situacao;

        public Aluno (int matricula, string nome, double nota1, double nota2, double nota3, double nota4, double media, string situacao)
        {
            Matricula = matricula;
            Nome = nome;
            Nota1 = nota1;
            Nota2 = nota2;
            Nota3 = nota3;
            Nota4 = nota4;
            Media = media;
            Situacao = situacao;
        }
    }
}
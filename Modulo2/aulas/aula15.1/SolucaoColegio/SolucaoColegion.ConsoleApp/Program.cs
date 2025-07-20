using System;
using  SolucaoColegio.Domain;
using SolucaoColegio.Infra.Data;

namespace SolucaoColegion.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();
            aluno.Matricula = 666;
            aluno.Nome = "Piccolo";
            aluno.Idade = 37;
            AlunoDAO alunoDAO = new AlunoDAO();
            alunoDAO.Adicionar(aluno);
        }
    }
}

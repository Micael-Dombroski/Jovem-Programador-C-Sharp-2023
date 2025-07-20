using System;
using aula14.Classes;

namespace aula14.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno
            {
                Matricula = 10,
                Nome = "Calire Redfield",
                Idade = 22
            };
            AlunoDAO alunoDAO = new AlunoDAO();
            Professor professor = new Professor
            {
                Matricula = 2,
                Nome = "Lucas Manoel",
                DataNascimento = Convert.ToDateTime("2001-10-5"),
                EnderecoMoradia = new Endereco
                {
                    Rua = "Rua 22",
                    Numero = 666,
                    Bairro = "Satander",
                    Cidade = "Banco",
                    UF = "CR"
                }
            };
            Professor professor2 = new Professor
            {
                Matricula = 7,
                Nome = "Majin Boo",
                DataNascimento = Convert.ToDateTime("1800-2-23"),
                EnderecoMoradia = new Endereco
                {
                    Rua = "Rua Sim",
                    Numero = 000,
                    Bairro = "Ruiva",
                    Cidade = "Loira",
                    UF = "BD"
                }
            };
            ProfessorDAO professorDAO = new ProfessorDAO();
            //professorDAO.Excluir(2);
            /*professorDAO.Adicionar(professor2);
            professorDAO.Editar(professor);
            Console.WriteLine(professorDAO.ConsultarPorMatricula(2));*/
            foreach (var item in professorDAO.ConsultarTodos())
            {
                Console.WriteLine(item);
            }
            //alunoDAO.Editar(aluno);
            /*var alunoConsultado = alunoDAO.ConsultarPorMatricula(10);
            Console.WriteLine(alunoConsultado + "\n");*/
            /*alunoDAO.Adicionar(new Aluno
            {
                Matricula = 11,
                Nome = "Jill",
                Idade = 28
            });*/
            /*alunoDAO.Excluir(10);
            var alunos = alunoDAO.ConsultarTodos();
            foreach (var item in alunos)
            {
                Console.WriteLine(item);
            }*/
        }
    }
}

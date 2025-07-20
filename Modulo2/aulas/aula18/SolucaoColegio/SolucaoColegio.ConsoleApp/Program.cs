using System;
using System.Collections.Generic;
using SolucaoColegio.Domain.Entidades;
using SolucaoColegio.Infra.Data.Repository;

namespace SolucaoColegion.ConsoleApp
{
    class Program
    {
        static void Main()
        {
            MateriaCursadaRepository repository = new ();
            //var materia = repository.ConsultarTodos();
            /*MateriaCursada materiaCursada = new MateriaCursada();
            Materia materia = new Materia{
                Id = 2,
                Nome = "Tanto Faz",
                QuantidadeAula = 12
            };
            materiaCursada.MateriaSendoCursada = materia;
            materiaCursada.Nota = 10;
            var materias = repository.ConsultarTodos();

            Aluno aluno = new Aluno
            {
                Matricula = 90,
                Nome = "Luca",
                Idade = 12
            };
            materiaCursada.AlunoCursando = aluno;*/

            /*MateriaCursada materiaCursada = new MateriaCursada();
            Aluno aluno = new Aluno {
                Matricula = 11,
                Nome = "Irinilson",
                Idade = 1000
            };
            materiaCursada.AlunoCursando = aluno;
            Materia materia = new Materia {
                Id = 2,
                Nome = "Tanto Faz",
                QuantidadeAula = 100
            };
            materiaCursada.MateriaSendoCursada = materia;
            materiaCursada.Nota = 10;*/
            //repository.Salvar(materiaCursada);

            foreach (var item in repository.ConsultarPorMateria(2))
            {
                Console.WriteLine(item);
            }
        }
    }
}

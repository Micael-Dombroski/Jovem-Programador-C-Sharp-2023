using System;
using System.Collections.Generic;
using  SolucaoColegio.Domain;
using SolucaoColegio.Domain.Entidades;
using SolucaoColegio.Infra.Data.Repository;

namespace SolucaoColegion.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Materia materia = new Materia();
            materia.Nome = "Projeto";
            materia.QuantidadeAula = 5;
            MateriaRepository repository = new MateriaRepository();
            //repository.Salvar(materia);
            var materias = repository.ConsultarTodos();
            foreach (var item in materias)
            {
                Console.WriteLine(item);
            }
            var materiaConsultada = repository.ConsultarPorId(1);
            materiaConsultada.Nome = "Publicação";
            repository.Editar(materiaConsultada);
            Console.WriteLine("\n\n\n");
            materias = repository.ConsultarTodos();
            foreach (var item in materias)
            {
                Console.WriteLine(item);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SolucaoColegio.Domain.Entidades;

namespace SolucaoColegio.Domain.Repository
{
    public interface IProfessorRepository
    {
        public void Salvar(Professor objeto);
        public void Editar (Professor objeto);
        public void Excluir (int matricula);
        public ICollection<Professor> ConsultarTodos();
        public Professor ConsultarPorMatricula (int matricula);
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SolucaoColegio.Domain.Entidades;

namespace SolucaoColegio.Domain.Repository
{
    public interface IAlunoRepository
    {
        public void Salvar(Aluno objeto);
        public void Editar (Aluno objeto);
        public ICollection<Aluno> ConsultarTodos();
        public Aluno ConsultarPorMatricula (int matricula);
    }
}
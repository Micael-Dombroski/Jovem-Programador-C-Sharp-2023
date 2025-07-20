using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SolucaoColegio.Domain.Entidades;

namespace SolucaoColegio.Domain.Repository
{
    public interface IMateriaCursadaRepository
    {
        public void Salvar(MateriaCursada objeto);
        public void Editar (MateriaCursada objeto);
        public ICollection<MateriaCursada> ConsultarTodos();
        public ICollection<MateriaCursada> ConsultarPorAluno (int matricula);
        public ICollection<MateriaCursada> ConsultarPorMateria (int materiaId);
    }
}
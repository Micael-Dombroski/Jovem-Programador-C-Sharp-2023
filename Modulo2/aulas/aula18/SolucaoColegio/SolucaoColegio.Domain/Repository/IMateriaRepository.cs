using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SolucaoColegio.Domain.Entidades;

namespace SolucaoColegio.Domain.Repository
{
    public interface IMateriaRepository
    {
        public void Salvar(Materia objeto);
        public void Editar (Materia objeto);
        public ICollection<Materia> ConsultarTodos();
        public Materia ConsultarPorId (int id);
    }
}
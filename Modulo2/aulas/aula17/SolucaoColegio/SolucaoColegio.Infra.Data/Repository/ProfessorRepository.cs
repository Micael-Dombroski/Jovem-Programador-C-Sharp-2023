using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SolucaoColegio.Domain.Entidades;
using SolucaoColegio.Domain.Repository;
using SolucaoColegio.Infra.Data.DAO;

namespace SolucaoColegio.Infra.Data.Repository
{
    public class ProfessorRepository: IProfessorRepository
    {
        private ProfessorDAO _dao;
        public ProfessorRepository()
        {
            _dao = new ProfessorDAO();
        }
        public Professor ConsultarPorMatricula(int matricula)
        {
            return _dao.ConsultarPorMatricula(matricula);
        }
        public ICollection<Professor> ConsultarTodos()
        {
            return _dao.ConsultarTodos();
        }
        public void Editar (Professor objeto)
        {
            _dao.Editar(objeto);
        }
        public void Excluir (int matricula)
        {
            _dao.Excluir(matricula);
        }
        public void Salvar(Professor objeto)
        {
            _dao.Adicionar(objeto);
        }
    }
}
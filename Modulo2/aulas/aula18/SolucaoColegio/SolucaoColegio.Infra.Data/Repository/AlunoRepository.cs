using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SolucaoColegio.Domain.Entidades;
using SolucaoColegio.Domain.Repository;
using SolucaoColegio.Infra.Data.DAO;

namespace SolucaoColegio.Infra.Data.Repository
{
    public class AlunoRepository: IAlunoRepository
    {
        private AlunoDAO _dao;
        public AlunoRepository()
        {
            _dao = new();
        }
        
        public Aluno ConsultarPorMatricula (int matricula)
        {
            return _dao.ConsultarPorMatricula(matricula);
        }
        public ICollection<Aluno> ConsultarTodos()
        {
            return _dao.ConsultarTodos();
        }
        public void Editar (Aluno objeto)
        {
            _dao.Editar(objeto);
        }
        public void Salvar(Aluno objeto)
        {
            _dao.Adicionar(objeto);
        }
    }
}
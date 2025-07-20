using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SolucaoColegio.Domain.Entidades;
using SolucaoColegio.Domain.Repository;
using SolucaoColegio.Infra.Data.DAO;

namespace SolucaoColegio.Infra.Data.Repository
{
    public class MateriaRepository
    {
        private MateriaDAO _dao;
        public MateriaRepository()
        {
            _dao = new MateriaDAO();
        }
        public Materia ConsultarPorId(int id)
        {
            return _dao.ConsultarPorId(id);
        }
        public ICollection<Materia> ConsultarTodos()
        {
            return _dao.ConsultarTodos();
        }
        public void Editar (Materia objeto)
        {
            _dao.Editar(objeto);
        }
        public void Salvar(Materia objeto)
        {
            _dao.Adicionar(objeto);
        }
    }
}
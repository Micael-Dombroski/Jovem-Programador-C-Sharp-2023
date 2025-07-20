using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SolucaoMercearia.Domain.Entidade;
using SolucaoMercearia.Domain.Repository;
using SolucaoMercearia.Infra.Data.DAO;

namespace SolucaoMercearia.Infra.Data.Repository
{
    public class ClienteRepository
    {
        private ClienteDAO _dao;
        public ClienteRepository()
        {
            _dao = new ClienteDAO();
        }
        public Cliente ConsultarPorId (int id)
        {
            return _dao.ConsultarPorID(id);
        }
        public ICollection<Cliente> ConsultarTodos()
        {
            return _dao.ConsultarTodos();
        }
        public void Editar (Cliente objeto, int id)
        {
            _dao.Editar(objeto, id);
        }
        public void Excluir (int id)
        {
            _dao.Excluir(id);
        }
        public void Salvar(Cliente objeto)
        {
            _dao.Adicionar(objeto);
        }
    }
}
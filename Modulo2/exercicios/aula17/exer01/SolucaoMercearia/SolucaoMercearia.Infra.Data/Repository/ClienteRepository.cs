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
        public Cliente ConsultarPorCpf (string cpf)
        {
            return _dao.ConsultarPorCPF(cpf);
        }
        public ICollection<Cliente> ConsultarTodos()
        {
            return _dao.ConsultarTodos();
        }
        public void Editar (Cliente objeto, string cpf)
        {
            _dao.Editar(objeto, cpf);
        }
        public void Excluir (string cpf)
        {
            _dao.Excluir(cpf);
        }
        public void Salvar(Cliente objeto)
        {
            _dao.Adicionar(objeto);
        }
    }
}
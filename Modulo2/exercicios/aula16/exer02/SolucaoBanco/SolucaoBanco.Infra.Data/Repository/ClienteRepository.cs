using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SolucaoBanco.Infra.Data.DAO;
using SolucaoBanco.Domain.Entidade;
using SolucaoBanco.Domain.Repository;

namespace SolucaoBanco.Infra.Data.Repository
{
    public class ClienteRepository: IClienteRepository
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
        public List<Cliente> ConsultarTodos()
        {
            return _dao.ConsultarTodos();
        }
        public void Editar (Cliente objeto)
        {
            _dao.Editar(objeto);
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
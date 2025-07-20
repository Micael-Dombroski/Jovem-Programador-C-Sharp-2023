using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BancoSolution.Infra.Data.DAO;
using BancoSolution.Domain.Entidade;
using BancoSolution.Domain.Repository;

namespace BancoSolution.Infra.Data.Repository
{
    public class ClienteRepository: IClienteRepository
    {
        private ClienteDAO _dao;
        private ContaDAO _contaDao;
        public ClienteRepository()
        {
            _dao = new ClienteDAO();
            _contaDao = new ContaDAO();
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
            foreach (var item in _contaDao.ConsultarTodos())
            {
                if (item.Correntista.CPF == cpf)
                {
                    throw new Exception("Não é possível excluir um cliente vinculado a uma conta");
                }
            }
            _dao.Excluir(cpf);
        }
        public void Salvar(Cliente objeto)
        {
            _dao.Adicionar(objeto);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MerceariaSolution.Domain.Repository;
using MerceariaSolution.Domain.Entidade;
using MerceariaSolution.Infra.Data.DAO;

namespace MerceariaSolution.Infra.Data.Repository
{
    public class VendaRepository: IVendaRepository
    {
        private VendaDAO _dao;
        private ClienteDAO _clienteDAO;
        public VendaRepository ()
        {
            _dao = new();
            _clienteDAO = new();
        }
        public ICollection<Venda> ConsultarPorCliente (string cpf)
        {
            Cliente cliente = _clienteDAO.ConsultarPorCPF(cpf);
            if (cliente != null)
            {
                return _dao.ConsultarPorCliente(cliente);
            }
            return null;
        }
        public ICollection<Venda> ConsultarTodos()
        {
            return _dao.ConsultarTodos();
        }
        public void Salvar (Venda venda)
        {
            _dao.Adicionar(venda);
        }
    }
}
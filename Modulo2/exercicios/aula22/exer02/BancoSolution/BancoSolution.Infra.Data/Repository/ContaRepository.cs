using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BancoSolution.Infra.Data.DAO;
using BancoSolution.Domain.Entidade;
using BancoSolution.Domain.Repository;

namespace BancoSolution.Infra.Data.Repository
{
    public class ContaRepository
    {
        private ContaDAO _dao;
        public ContaRepository()
        {
            _dao = new ContaDAO();
        }
        public Conta ConsultarPorAgenciaENumero (int agencia, int numero)
        {
            return _dao.ConsultarPorAgenciaENumero(agencia, numero);
        }
        public List<Conta> ConsultarTodos()
        {
            return _dao.ConsultarTodos();
        }
        public void Editar (Conta objeto)
        {
            _dao.Editar(objeto);
        }
        public void Excluir (int agencia, int numero)
        {
            _dao.Excluir(agencia, numero);
        }
        public void Salvar(Conta objeto)
        {
            _dao.Adicionar(objeto);
        }
    }
}
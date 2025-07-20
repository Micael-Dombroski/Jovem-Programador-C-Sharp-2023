using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SolucaoBanco.Infra.Data.DAO;
using SolucaoBanco.Domain.Entidade;
using SolucaoBanco.Domain.Repository;

namespace SolucaoBanco.Infra.Data.Repository
{
    public class MovimentoBancarioRepository: IMovimentoBancarioRepository
    {
        private MovimentoBancarioDAO _dao;
        private ContaDAO _contaDAO;

        public MovimentoBancarioRepository()
        {
            _dao = new();
            _contaDAO = new();
        }
        public List<MovimentoBancario> ConsultarPorAgenciaENumero (Conta conta)
        {
            return _dao.ConsultarPorAgenciaENumero(conta);
        }
        public List<MovimentoBancario> ConsultarTodos()
        {
            return _dao.ConsultarTodos();;
        }
        public void Salvar(MovimentoBancario objeto)
        {
            _dao.Adicionar(objeto);
        }
    }
}
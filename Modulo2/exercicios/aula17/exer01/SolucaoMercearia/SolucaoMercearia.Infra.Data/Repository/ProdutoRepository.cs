using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SolucaoMercearia.Domain.Entidade;
using SolucaoMercearia.Domain.Repository;
using SolucaoMercearia.Infra.Data.DAO;

namespace SolucaoMercearia.Infra.Data.Repository
{
    public class ProdutoRepository: IProdutoRepository
    {
        private ProdutoDAO _dao;
        public ProdutoRepository()
        {
            _dao = new ProdutoDAO();
        }
        public Produto ConsultarPorId (int id)
        {
            return _dao.ConsultarPorId(id);
        }
        public ICollection<Produto> ConsultarTodos()
        {
            return _dao.ConsultarTodos();
        }
        public void Editar (Produto produto)
        {
            _dao.Editar(produto);
        }
        public void Excluir (int id)
        {
            _dao.Excluir(id);
        }
        public void Salvar(Produto produto)
        {
            _dao.Adicionar(produto);
        }
    }
}
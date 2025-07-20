using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MerceariaSolution.Domain.Entidade;
using MerceariaSolution.Domain.Repository;
using MerceariaSolution.Infra.Data.DAO;

namespace MerceariaSolution.Infra.Data.Repository
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
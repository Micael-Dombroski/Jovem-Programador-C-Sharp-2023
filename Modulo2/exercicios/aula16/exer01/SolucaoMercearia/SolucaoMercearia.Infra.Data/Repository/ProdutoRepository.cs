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
        public string ConsultarPorId (int id)
        {
            return _dao.ConsultarPorId(id);
        }
        public ICollection<string> ConsultarTodos()
        {
            return _dao.ConsultarTodos();
        }
        public void Editar (int id, string nome, string marca, string dataVencimento, string precoUnitario, string unidade, int qtEstoque)
        {
            _dao.Editar(id, nome, marca, dataVencimento, precoUnitario, unidade, qtEstoque);
        }
        public void Excluir (int id)
        {
            _dao.Excluir(id);
        }
        public void Salvar(string nome, string marca, string dataVencimento, string precoUnitario, string unidade, int qtEstoque)
        {
            _dao.Adicionar(nome, marca, dataVencimento, precoUnitario, unidade, qtEstoque);
        }
    }
}
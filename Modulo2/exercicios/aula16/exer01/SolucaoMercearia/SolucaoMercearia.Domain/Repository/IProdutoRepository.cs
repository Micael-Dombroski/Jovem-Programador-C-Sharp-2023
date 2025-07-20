using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolucaoMercearia.Domain.Repository
{
    public interface IProdutoRepository
    {
        public string ConsultarPorId (int id);
        public ICollection<string> ConsultarTodos();
        public void Editar (int id, string nome, string marca, string dataVencimento, string precoUnitario, string unidade, int qtEstoque);
        public void Excluir (int id);
        public void Salvar(string nome, string marca, string dataVencimento, string precoUnitario, string unidade, int qtEstoque);
    }
}
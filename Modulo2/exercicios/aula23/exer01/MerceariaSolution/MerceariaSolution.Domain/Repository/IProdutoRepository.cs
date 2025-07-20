using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MerceariaSolution.Domain.Entidade;

namespace MerceariaSolution.Domain.Repository
{
    public interface IProdutoRepository
    {
        public Produto ConsultarPorId (int id);
        public ICollection<Produto> ConsultarTodos();
        public void Editar (Produto produto);
        public void Excluir (int id);
        public void Salvar(Produto produto);
    }
}
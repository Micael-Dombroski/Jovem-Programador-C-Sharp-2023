using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MerceariaSolution.Domain.Entidade;

namespace MerceariaSolution.Domain.Repository
{
    public interface IUsuarioRepository
    {
        public Usuario ConsultarPorLoginESenha (string login, string senha);
        public ICollection<Usuario> ConsultarTodos();
        public void Editar (Usuario objeto);
        public void Excluir (Usuario objeto);
        public void Salvar(Usuario objeto);
    }
}
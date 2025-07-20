using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MerceariaSolution.Domain.Entidade;

namespace MerceariaSolution.Domain.Repository
{
    public interface IClienteRepository
    {
        public Cliente ConsultarPorCpf (string cpf);
        public ICollection<Cliente> ConsultarTodos();
        public void Editar (Cliente objeto);
        public void Excluir (string cpf);
        public void Salvar(Cliente objeto);
    }
}
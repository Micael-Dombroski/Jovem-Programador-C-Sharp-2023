using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SolucaoMercearia.Domain.Entidade;

namespace SolucaoMercearia.Domain.Repository
{
    public interface IClienteRepository
    {
        public Cliente ConsultarPorId (int id);
        public ICollection<Cliente> ConsultarTodos();
        public void Editar (Cliente objeto);
        public void Excluir (int id);
        public void Salvar(Cliente objeto);
    }
}
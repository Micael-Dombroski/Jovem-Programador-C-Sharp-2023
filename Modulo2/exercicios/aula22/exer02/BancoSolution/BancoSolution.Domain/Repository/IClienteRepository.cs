using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BancoSolution.Domain.Entidade;

namespace BancoSolution.Domain.Repository
{
    public interface IClienteRepository
    {
        public Cliente ConsultarPorCpf (string cpf);
        public List<Cliente> ConsultarTodos();
        public void Editar (Cliente objeto);
        public void Excluir (string cpf);
        public void Salvar(Cliente objeto);
    }
}
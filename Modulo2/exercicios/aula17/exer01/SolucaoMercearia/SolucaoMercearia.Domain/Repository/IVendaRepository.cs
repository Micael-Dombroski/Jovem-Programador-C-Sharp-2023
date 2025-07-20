using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SolucaoMercearia.Domain.Entidade;

namespace SolucaoMercearia.Domain.Repository
{
    public interface IVendaRepository
    {
        public ICollection<Venda> ConsultarPorCliente (string cpf);
        public ICollection<Venda> ConsultarTodos();
        public void Salvar (Venda venda);
    }
}
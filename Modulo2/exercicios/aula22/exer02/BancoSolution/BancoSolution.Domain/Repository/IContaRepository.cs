using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BancoSolution.Domain.Entidade;

namespace BancoSolution.Domain.Repository
{
    public interface IContaRepository
    {
        public Conta ConsultarPorAgenciaENumero (int agencia, int numero);
        public List<Conta> ConsultarTodos();
        public void Editar (Conta objeto);
        public void Excluir (int agencia, int numero);
        public void Salvar(Conta objeto);
    }
}
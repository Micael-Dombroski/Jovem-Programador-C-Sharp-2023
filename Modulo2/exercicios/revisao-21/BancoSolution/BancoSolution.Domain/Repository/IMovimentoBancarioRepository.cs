using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BancoSolution.Domain.Entidade;

namespace BancoSolution.Domain.Repository
{
    public interface IMovimentoBancarioRepository
    {
        public List<MovimentoBancario> ConsultarPorConta (Conta conta);
        public List<MovimentoBancario> ConsultarTodos();
        public void Salvar(MovimentoBancario objeto);
    }
}
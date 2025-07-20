using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SolucaoBanco.Domain.Entidade;

namespace SolucaoBanco.Domain.Repository
{
    public interface IMovimentoBancarioRepository
    {
        public List<MovimentoBancario> ConsultarPorAgenciaENumero (Conta conta);
        public List<MovimentoBancario> ConsultarTodos();
        public void Salvar(MovimentoBancario objeto);
    }
}
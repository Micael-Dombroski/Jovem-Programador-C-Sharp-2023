using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BancoSolution.Domain.Entidade;

namespace BancoSolution.Domain.Repository
{
    public interface IAccountCashFlowRepository
    {
        public void Insert(AccountCashFlow accountCashFlow);
        public void Edit(AccountCashFlow accountCashFlow);
        public void Delete(int id);
        public ICollection<AccountCashFlow> GetByCpf(string cpf);
        public AccountCashFlow GetById(int id);
    }
}
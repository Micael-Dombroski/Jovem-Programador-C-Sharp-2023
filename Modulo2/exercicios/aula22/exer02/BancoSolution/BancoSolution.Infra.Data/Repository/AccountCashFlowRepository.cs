using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BancoSolution.Domain.Entidade;
using BancoSolution.Domain.Repository;

namespace BancoSolution.Infra.Data.Repository
{
    public class AccountCashFlowRepository : IAccountCashFlowRepository
    {
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(AccountCashFlow accountCashFlow)
        {
            throw new NotImplementedException();
        }

        public ICollection<AccountCashFlow> GetAll()
        {
            throw new NotImplementedException();
        }

        public ICollection<AccountCashFlow> GetByCpf(string cpf)
        {
            throw new NotImplementedException();
        }

        public AccountCashFlow GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(AccountCashFlow accountCashFlow)
        {
            throw new NotImplementedException();
        }
    }
}
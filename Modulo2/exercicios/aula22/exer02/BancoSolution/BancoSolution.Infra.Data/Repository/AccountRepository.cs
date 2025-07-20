using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BancoSolution.Domain.Entidade;
using BancoSolution.Domain.Repository;

namespace BancoSolution.Infra.Data.Repository
{
    public class AccountRepository : IAccountRepository
    {
        public void Delete(int agency, int accountNumber)
        {
            throw new NotImplementedException();
        }

        public void Edit(Account account)
        {
            throw new NotImplementedException();
        }

        public ICollection<Account> GetAll()
        {
            throw new NotImplementedException();
        }

        public Account GetByAgencyAndAccountNumber(int agency, int accountNumber)
        {
            throw new NotImplementedException();
        }

        public void Insert(Account account)
        {
            throw new NotImplementedException();
        }
    }
}
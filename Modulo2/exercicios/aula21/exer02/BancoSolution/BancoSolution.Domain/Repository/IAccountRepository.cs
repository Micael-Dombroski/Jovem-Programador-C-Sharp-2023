using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BancoSolution.Domain.Entidade;

namespace BancoSolution.Domain.Repository
{
    public interface IAccountRepository
    {
        public void Insert(Account account);
        public void Edit(Account account);
        public void Delete(int agency, int accountNumber);
        public ICollection<Account> GetAll();
        public Account GetByAgencyAndAccountNumber(int agency, int accountNumber);
    }
}
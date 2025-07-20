using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BancoSolution.Domain.Entidade;

namespace BancoSolution.Domain.Repository
{
    public interface ICustomerRepository
    {
        public void Insert(Customer customer);
        public void Edit(Customer customer);
        public void Delete(string cpf);
        public ICollection<Customer> GetAll();
        public Customer GetByCpf(string cpf);
    }
}
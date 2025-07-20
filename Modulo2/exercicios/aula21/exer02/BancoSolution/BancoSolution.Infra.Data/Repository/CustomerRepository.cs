using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BancoSolution.Domain.Entidade;
using BancoSolution.Domain.Repository;
using BancoSolution.Infra.Data.DAO;

namespace BancoSolution.Infra.Data.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private CustomerDAO _dao = new();
        public void Delete(string cpf)
        {
            _dao.Delete(cpf);
        }

        public void Edit(Customer customer)
        {
            if (_dao.FindByCpf(customer.Cpf) != null)
            {
                _dao.Update(customer);
            }
            else
            {
                throw new Exception("Cliente não possui cadastro em nosso banco");
            }
            
        }

        public ICollection<Customer> GetAll()
        {
            return _dao.FindAll();
        }

        public Customer GetByCpf(string cpf)
        {
            return _dao.FindByCpf(cpf);
        }

        public void Insert(Customer customer)
        {
            if (_dao.FindByCpf(customer.Cpf) == null)
            {
                _dao.Add(customer);
            }
            else
            {
                throw new Exception("Cliente já possui cadastro em nosso banco");
            }
        }
    }
}
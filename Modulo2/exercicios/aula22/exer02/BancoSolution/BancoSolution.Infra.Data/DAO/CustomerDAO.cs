using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using BancoSolution.Domain.Entidade;

namespace BancoSolution.Infra.Data.DAO
{
    public class CustomerDAO: BaseDAO
    {
        public void Add(Customer customer)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"INSERT INTO tb_customer (name, cpf, rg, address, number, neighborhood, city, uf)
                                VALUES (@name, @cpf, @rg, @address, @number, @neighborhood, @city, @uf)";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    AddParametersToSQL(customer, command);
                    command.ExecuteNonQuery();
                }
            }
        }

        public List<Customer> FindAll()
        {
            var customers = new List<Customer>();
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                var query = @"SELECT 
                                name, cpf, rg, address, number, 
                                neighborhood, city, uf 
                            FROM tb_customer";
                using (var command = new SqlCommand(query, conn))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                        customers.Add(ConvertToObject(reader));
                }
            }
            return customers;
        }

        public void Update(Customer customer)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                var query = @"UPDATE tb_customer
                        SET name = @name, rg = @rg, address = @address,
                            neighborhood = @neighborhood, number = @number, city = @city, uf = @uf
                        WHERE cpf = @cpf";
                using (var command = new SqlCommand(query, conn))
                {
                    AddParametersToSQL(customer, command);
                    command.ExecuteNonQuery();
                }
            }

        }

        public Customer FindByCpf(string cpf)
        {
            Customer customer = null;
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                var query = @"SELECT 
                                name, cpf, rg, address, number, 
                                neighborhood, city, uf 
                            FROM tb_customer
                            WHERE cpf = @cpf";
                using (var command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@cpf", cpf);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                        customer = ConvertToObject(reader);
                }
            }
            return customer;
        }

        public bool CustomerExists(string cpf)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                var query = @"SELECT cpf FROM tb_customer WHERE cpf = @cpf";
                using (var command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@cpf", cpf);
                    SqlDataReader reader = command.ExecuteReader();
                    return reader.Read() == true;
                }
            }
        }

        private void CustomerHasAccounts(string cpf)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();

                var query = @"SELECT agency 
                        FROM tb_account
                        WHERE customer_cpf = @cpf";
                using (var command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@cpf", cpf);
                    var reader = command.ExecuteReader();
                    // if (reader.Read() == true)
                    //     throw new Exception("Impossivel deletar. Este cliente possui uma ou mais contas.");
                }
            }
        }

        public void Delete(string cpf)
        {
            CustomerHasAccounts(cpf);

            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();

                var query = @"DELETE FROM tb_customer
                        WHERE cpf = @cpf";
                using (var command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@cpf", cpf);
                    command.ExecuteNonQuery();
                }
            }
        }

        public Customer ConvertToObject(SqlDataReader data)
        {
            return new Customer
            {
                NameCustomer = data["name"].ToString(),
                Cpf = data["cpf"].ToString(),
                AddressCustomer = data["address"].ToString(),
            };
        }

        public void AddParametersToSQL(Customer customer, SqlCommand command)
        {
            command.Parameters.AddWithValue("@name", customer.NameCustomer);
            command.Parameters.AddWithValue("@cpf", customer.Cpf);
            command.Parameters.AddWithValue("@address", customer.AddressCustomer);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using BancoSolution.Domain.Entidade;

namespace BancoSolution.Infra.Data.DAO
{
    public class AccountDAO: BaseDAO
    {
        public CustomerDAO customerDAO = new();

        public void Add(Account account)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"INSERT INTO tb_account (agency, number, customer_cpf, balance, account_type)
                                 VALUES (@agency, @number, @customer_cpf, @balance, @account_type);";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    AddParametersToSQL(account, command);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void Delete(int agency, int number)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                var query = @"DELETE FROM tb_account
                            WHERE agency = @agency AND number = @number";
                using (var command = new SqlCommand(query, conn))
                {
                    AddAgencyAndNumberToSQL(agency, number, command);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void UpdateAccount(int agency, int number, string cpf)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                var query = @"UPDATE tb_account
                              SET customer_cpf = @customer_cpf
                            WHERE agency = @agency AND number = @number";
                using (var command = new SqlCommand(query, conn))
                {
                    AddAgencyAndNumberToSQL(agency, number, command);
                    command.Parameters.AddWithValue("@customer_cpf", cpf);
                    command.ExecuteNonQuery();
                }
            }
        }

        public Account FindByAgencyAndNumber(int agency, int number)
        {
            Account account = null;
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                var query = @"SELECT 
                                customer_cpf, agency, number, balance, account_type
                            FROM tb_account
                            WHERE agency = @agency AND number = @number";
                using (var command = new SqlCommand(query, conn))
                {
                    AddAgencyAndNumberToSQL(agency, number, command);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                        account = ConvertToObject(reader);
                }
            }
            return account;
        }

        public List<Account> FindByCustomer(string cpf)
        {
            List<Account> accounts = new();
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                var query = @"SELECT 
                                customer_cpf, agency, number, balance, account_type
                            FROM tb_account
                            WHERE customer_cpf = @cpf";
                using (var command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@cpf", cpf);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                        accounts.Add(ConvertToObject(reader));
                }
            }
            return accounts;
        }

        public List<Account> FindAll()
        {
            var accounts = new List<Account>();
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                var query = @"SELECT 
                                customer_cpf, agency, number, balance, account_type
                            FROM tb_account";
                using (var command = new SqlCommand(query, conn))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                        accounts.Add(ConvertToObject(reader));
                }
            }
            return accounts;
        }

        public void UpdateBalance(Account account, double value)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                var query = @"UPDATE tb_account
                            SET balance = balance + @value
                            WHERE agency = @agency AND number = @number";
                using (var command = new SqlCommand(query, conn))
                {
                    AddAgencyAndNumberToSQL(account.Agency, account.NumberAccount, command);
                    command.Parameters.AddWithValue("@value", value);
                    command.ExecuteNonQuery();
                }
            }
        }

        public double GetBalance(int agency, int number)
        {
            double balance = 0;
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                var query = @"SELECT balance FROM tb_account
                            WHERE agency = @agency AND number = @number";
                using (var command = new SqlCommand(query, conn))
                {
                    AddAgencyAndNumberToSQL(agency, number, command);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                        balance = Convert.ToDouble(reader["balance"]);
                }
            }
            return balance;
        }

        public Account ConvertToObject(SqlDataReader data)
        {
            Account account = null;
            AccountType accountType = (AccountType)data["account_type"];
            switch (accountType)
            {
                case AccountType.Investment:
                    account = new Account(
                        Convert.ToInt32(data["agency"]),
                        Convert.ToInt32(data["number"]),
                        data["customer_cpf"].ToString(),
                        1)
                    ;
                    break;
                case AccountType.Savings:
                    account = new Account(
                        Convert.ToInt32(data["agency"]),
                        Convert.ToInt32(data["number"]),
                        data["customer_cpf"].ToString(),
                        2);
                    break;
                case AccountType.Checking:
                    account = new Account(
                        Convert.ToInt32(data["agency"]),
                        Convert.ToInt32(data["number"]),
                        data["customer_cpf"].ToString(),
                        3);
                    break;
                default:
                    break;
            }
            return account;
        }

        public void AddParametersToSQL(Account account, SqlCommand command)
        {
            command.Parameters.AddWithValue("@agency", account.Agency);
            command.Parameters.AddWithValue("@number", account.NumberAccount);
            command.Parameters.AddWithValue("@balance", account.Balance);
            command.Parameters.AddWithValue("@customer_cpf", account.CpfCustomer);
            command.Parameters.AddWithValue("@account_type", account.AccountType);
        }
        public void AddAgencyAndNumberToSQL(int agency, int number, SqlCommand command)
        {
            command.Parameters.AddWithValue("@agency", agency);
            command.Parameters.AddWithValue("@number", number);
        }

        public void Deposit(int agency, int number, double value)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                var query = @"UPDATE tb_account
                            SET balance = balance + @value
                            WHERE agency = @agency AND number = @number";
                using (var command = new SqlCommand(query, conn))
                {
                    AddAgencyAndNumberToSQL(agency, number, command);
                    command.Parameters.AddWithValue("@value", value);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void Withdraw(int agency, int number, double value)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                var query = @"UPDATE tb_account
                            SET balance = balance - @value
                            WHERE agency = @agency AND number = @number";
                using (var command = new SqlCommand(query, conn))
                {
                    AddAgencyAndNumberToSQL(agency, number, command);
                    command.Parameters.AddWithValue("@value", value);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
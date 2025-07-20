using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using BancoSolution.Domain.Entidade;

namespace BancoSolution.Infra.Data.DAO
{
    public class AccountCashFlowDAO: BaseDAO
    {
        public CustomerDAO accountDAO = new();

        public void Add(AccountCashFlow accountCashFlow)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"INSERT INTO tb_account_cash_flow (agency, number, value_cash)
                                 VALUES (@agency, @number, @value_cash);";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    AddParametersToSQL(accountCashFlow, command);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void Update(AccountCashFlow accountCashFlow)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"update tb_account_cash_flow
                                 set agency = @agency, number = @number, value_cash = @value_cash
                                 where id = @id;";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    AddParametersToSQL(accountCashFlow, command);
                    command.Parameters.AddWithValue("@id", accountCashFlow.Id);
                    command.ExecuteNonQuery();
                }
            }
        }

        public AccountCashFlow FindById(int id)
        {
            AccountCashFlow accountCashFlow = null;
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                var query = @"SELECT 
                                customer_cpf, agency, number, balance, account_type
                            FROM tb_account
                            WHERE id = @id";
                using (var command = new SqlCommand(query, conn))
                {
                    AddId(id, command);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                        accountCashFlow = ConvertToObject(reader);
                }
            }
            return accountCashFlow;
        }

        public AccountCashFlow ConvertToObject(SqlDataReader data)
        {
            AccountCashFlow accountCashFlow = new();

            accountCashFlow.Id = Convert.ToInt32(data["id"]);
            accountCashFlow.Agency = Convert.ToInt32(data["agency"]);
            accountCashFlow.NumberAccount = Convert.ToInt32(data["number"]);
            return accountCashFlow;
        }

        private void AddId(int id, SqlCommand command)
        {
            command.Parameters.AddWithValue("@id", id);
        }

        public void Delete(AccountCashFlow accountCashFlow)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"delete from tb_account_cash_flow
                                where id = @id;";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    AddParametersToSQL(accountCashFlow, command);
                    command.Parameters.AddWithValue("@id", accountCashFlow.Id);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void AddParametersToSQL(AccountCashFlow accountCashFlow, SqlCommand command)
        {
            command.Parameters.AddWithValue("@agency", accountCashFlow.Agency);
            command.Parameters.AddWithValue("@number", accountCashFlow.NumberAccount);
            command.Parameters.AddWithValue("@value_cash", accountCashFlow.ValueCash);
        }
    }
}
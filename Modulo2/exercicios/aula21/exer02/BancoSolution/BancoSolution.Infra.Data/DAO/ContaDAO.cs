using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BancoSolution.Domain.Entidade;
using System.Data.SqlClient;
using System.Collections;

namespace BancoSolution.Infra.Data.DAO
{
    public class ContaDAO
    {
        private const string stringConexao = @"server=.\SQLexpress;initial catalog=Banco;integrated security=true;";

        public void Adicionar(Conta conta)
        {
            using (var conexao = new SqlConnection(stringConexao))
            {
                conexao.Open();
                using (var command = new SqlCommand("insert into Conta values (@Agencia, @Numero, @CPF_fk, @TipoConta, @Saldo);", conexao))
                {
                    ConverterEntidadeParaSqlCommandParametros(command, conta);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void Editar(Conta conta)
        {
            using (var conexao = new SqlConnection(stringConexao))
            {
                conexao.Open();
                using (var command = new SqlCommand("update Conta set CPF_fk = @CPF_fk, TipoConta = @TipoConta, Saldo = @Saldo where Agencia = @Agencia AND Numero = @Numero;", conexao))
                {
                    ConverterEntidadeParaSqlCommandParametros(command, conta);
                    command.ExecuteNonQuery();
                }
            }
        }

        

        public void Excluir(int agencia, int numero)
        {
            using (var conexao = new SqlConnection(stringConexao))
            {
                conexao.Open();
                using (var command = new SqlCommand("delete from Conta where Agencia = @Agencia AND Numero = @Numero;", conexao))
                {
                    command.Parameters.AddWithValue("@Agencia", agencia);
                    command.Parameters.AddWithValue("@Numero", numero);
                    command.ExecuteNonQuery();
                }
            }
        }

        public Conta ConsultarPorAgenciaENumero(int agencia, int numero)
        {
            Conta conta = null;
            using (var conexao = new SqlConnection(stringConexao))
            {
                conexao.Open();
                using (var command = new SqlCommand("SELECT Agencia, Numero, CPF_fk, TipoConta, Saldo FROM Conta WHERE Agencia = @Agencia AND Numero = @Numero;", conexao))
                {
                    command.Parameters.AddWithValue("@Agencia", agencia);
                    command.Parameters.AddWithValue("@Numero", numero);
                    SqlDataReader dados = command.ExecuteReader();
                    while (dados.Read())
                    {
                        conta = ConverterSqlDataReaderParaEntidades(dados);
                    }
                }
            }
            return conta;
        }

        public List<Conta> ConsultarTodos()
        {
            List<Conta> contas = new List<Conta>();
            using (var conexao = new SqlConnection(stringConexao))
            {
                conexao.Open();
                using (var command = new SqlCommand("SELECT Agencia, Numero, CPF_fk, TipoConta, Saldo FROM Conta", conexao))
                {
                    SqlDataReader dados = command.ExecuteReader();
                    while (dados.Read())
                    {
                        Conta conta = ConverterSqlDataReaderParaEntidades(dados);
                        contas.Add(conta);
                    }
                }
            }
            if (contas.Count == 0)
            {
                return null;
            }
            else
            {
                return contas;
            }
        }

        private void ConverterEntidadeParaSqlCommandParametros (SqlCommand command, Conta conta)
        {
            command.Parameters.AddWithValue("@Agencia", conta.Agencia);
            command.Parameters.AddWithValue("@Numero", conta.Numero);
            command.Parameters.AddWithValue("@CPF_fk", conta.Correntista.CPF);
            command.Parameters.AddWithValue("@TipoConta", conta.MostraTipo());
            command.Parameters.AddWithValue("@Saldo", conta.Saldo);
        }

        public Conta ConverterSqlDataReaderParaEntidades(SqlDataReader dados)
        {
            ClienteDAO clienteDAO = new ClienteDAO();
            Conta conta;
            int tipoConta = Convert.ToInt32(dados["TipoConta"]);
            try
            {
                switch (tipoConta)
                {
                    case 1:
                        conta = new ContaCorrente {
                            Agencia = Convert.ToInt32(dados["Agencia"]),
                            Numero = Convert.ToInt32(dados["Numero"]),
                            Correntista = clienteDAO.ConsultarPorCPF(dados["CPF_fk"].ToString()),
                            TipoConta = tipoConta
                        };
                        break;
                    case 2:
                            conta = new ContaInvestimento{
                            Agencia = Convert.ToInt32(dados["Agencia"]),
                            Numero = Convert.ToInt32(dados["Numero"]),
                            Correntista = clienteDAO.ConsultarPorCPF(dados["CPF_fk"].ToString()),
                            TipoConta = tipoConta
                        };
                        break;
                    case 3:
                        conta = new ContaPoupanca{
                            Agencia = Convert.ToInt32(dados["Agencia"]),
                            Numero = Convert.ToInt32(dados["Numero"]),
                            Correntista = clienteDAO.ConsultarPorCPF(dados["CPF_fk"].ToString()),
                            TipoConta = tipoConta
                        };
                        break;
                    default:
                        throw new ArgumentException("O tipo de Conta informado é inválido");
                }
                conta.Depositar(Convert.ToDouble(dados["Saldo"]));
                return conta;
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
                conta = null;
                return conta;
            }
            
        }
    }
}
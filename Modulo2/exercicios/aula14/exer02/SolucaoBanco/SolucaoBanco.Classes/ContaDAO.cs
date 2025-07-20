using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SolucaoBanco.Classes
{
    public class ContaDAO
    {
        static SqlConnection _conexao = new SqlConnection();
        private const string stringConexao = @"server=.\SQLexpress;initial catalog=Banco4;integrated security=true;";
        public ContaDAO()
        {
            _conexao.ConnectionString = stringConexao;
        }

        public void Adicionar(Conta conta)
        {
            AbrirConexao();
            SqlCommand command = new SqlCommand("insert into Conta values (@Agencia, @Numero, @CPF_fk, @TipoConta, @Saldo);",_conexao);
            ConverterEntidadeParaSqlCommandParametros(command, conta);
            command.ExecuteNonQuery();
            FecharConexao();
        }

        public void Editar(Conta conta)
        {
            AbrirConexao();
            SqlCommand command = new SqlCommand("update Conta set CPF_fk = @CPF_fk, TipoConta = @TipoConta, Saldo = @Saldo where Agencia = @Agencia AND Numero = @Numero;", _conexao);
            ConverterEntidadeParaSqlCommandParametros(command, conta);
            command.ExecuteNonQuery();
            FecharConexao();
        }

        

        public void Excluir(int agencia, int numero)
        {
            AbrirConexao();
            SqlCommand command = new SqlCommand("delete from Conta where Agencia = @Agencia AND Numero = @Numero;", _conexao);
            command.Parameters.AddWithValue("@Agencia", agencia);
            command.Parameters.AddWithValue("@Numero", numero);
            command.ExecuteNonQuery();
            FecharConexao();
        }

        public Conta ConsultarPorAgenciaENumero(int agencia, int numero)
        {
            Conta conta = null;
            AbrirConexao();
            SqlCommand command = new SqlCommand("SELECT Agencia, Numero, CPF_fk, TipoConta, Saldo FROM Conta WHERE Agencia = @Agencia AND Numero = @Numero;", _conexao);
            command.Parameters.AddWithValue("@Agencia", agencia);
            command.Parameters.AddWithValue("@Numero", numero);
            SqlDataReader dados = command.ExecuteReader();
            while (dados.Read())
            {
                conta = ConverterSqlDataReaderParaEntidades(dados);
            }
            FecharConexao();
            return conta;
        }

        public List<Conta> ConsultarTodos()
        {
            List<Conta> contas = new List<Conta>();
            AbrirConexao();
            SqlCommand command = new SqlCommand("SELECT Agencia, Numero, CPF_fk, TipoConta, Saldo FROM Conta", _conexao);
            SqlDataReader dados = command.ExecuteReader();
            while (dados.Read())
            {
                Conta conta = ConverterSqlDataReaderParaEntidades(dados);
                contas.Add(conta);
            }
            FecharConexao();
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
            Conta conta = null;
            int tipoConta = Convert.ToInt32(dados["TipoConta"]);
            if (tipoConta == 1)
            {
                conta = new ContaCorrente {
                    Agencia = Convert.ToInt32(dados["Agencia"]),
                    Numero = Convert.ToInt32(dados["Numero"]),
                    Correntista = clienteDAO.ConsultarPorCPF(dados["CPF_fk"].ToString())
                };
            }
            if (tipoConta == 2)
            {
                conta = new ContaInvestimento{
                    Agencia = Convert.ToInt32(dados["Agencia"]),
                    Numero = Convert.ToInt32(dados["Numero"]),
                    Correntista = clienteDAO.ConsultarPorCPF(dados["CPF_fk"].ToString())
                };
            }
            if (tipoConta == 3)
            {
                conta = new ContaPoupanca{
                    Agencia = Convert.ToInt32(dados["Agencia"]),
                    Numero = Convert.ToInt32(dados["Numero"]),
                    Correntista = clienteDAO.ConsultarPorCPF(dados["CPF_fk"].ToString())
                };
            }
            conta.Depositar(Convert.ToDouble(dados["Saldo"]));
            return conta;
        }

        private void AbrirConexao()
        {
            _conexao.Open();
        }
        private void FecharConexao()
        {
            _conexao.Close();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SolucaoBanco.Classes
{
    public class ClienteDAO
    {
        static SqlConnection _conexao = new SqlConnection();
        private const string stringConexao = @"server=.\SQLexpress;initial catalog=Banco4;integrated security=true;";
        public ClienteDAO()
        {
            _conexao.ConnectionString = stringConexao;
        }

        public void Adicionar(Cliente cliente)
        {
            AbrirConexao();
            SqlCommand command = new SqlCommand("insert into Cliente values (@CPF, @RG, @Nome, @Endereco, @Numero, @Bairro, @Cidade, @UF);",_conexao);
            ConverterEntidadeParaSqlCommandParametros(command, cliente);
            command.ExecuteNonQuery();
            FecharConexao();
        }

        public void Editar(Cliente cliente)
        {
            AbrirConexao();
            SqlCommand command = new SqlCommand("update Cliente set RG = @RG, Nome = @Nome, Endereco = @Endereco, Numero = @Numero, Bairro = @Bairro, Cidade = @Cidade, UF = @UF where CPF = @CPF;", _conexao);
            ConverterEntidadeParaSqlCommandParametros(command, cliente);
            command.ExecuteNonQuery();
            FecharConexao();
        }

        

        public void Excluir(string cpf)
        {
            AbrirConexao();
            SqlCommand command = new SqlCommand("delete from Cliente where CPF = @CPF;", _conexao);
            command.Parameters.AddWithValue("@CPF", cpf);
            command.ExecuteNonQuery();
            FecharConexao();
        }

        public Cliente ConsultarPorCPF(string cpf)
        {
            Cliente cliente = null;
            AbrirConexao();
            SqlCommand command = new SqlCommand("SELECT CPF, RG, Nome, Endereco, Numero, Bairro, Cidade, UF FROM Cliente WHERE CPF = @CPF;", _conexao);
            command.Parameters.AddWithValue("@CPF", cpf);
            SqlDataReader dados = command.ExecuteReader();
            while (dados.Read())
            {
                cliente = ConverterSqlDataReaderParaEntidades(dados);
            }
            FecharConexao();
            return cliente;
        }

        public List<Cliente> ConsultarTodos()
        {
            List<Cliente> clientes = new List<Cliente>();
            AbrirConexao();
            SqlCommand command = new SqlCommand("select CPF, RG, Nome, Endereco, Numero, Bairro, Cidade, UF FROM Cliente", _conexao);
            SqlDataReader dados = command.ExecuteReader();
            while (dados.Read())
            {
                Cliente cliente = ConverterSqlDataReaderParaEntidades(dados);
                clientes.Add(cliente);
            }
            FecharConexao();
            if (clientes.Count == 0)
            {
                return null;
            }
            else
            {
                return clientes;
            }
        }

        private void ConverterEntidadeParaSqlCommandParametros (SqlCommand command, Cliente cliente)
        {
            command.Parameters.AddWithValue("@CPF", cliente.CPF);
            command.Parameters.AddWithValue("@RG", cliente.RG);
            command.Parameters.AddWithValue("@Nome", cliente.Nome);
            command.Parameters.AddWithValue("@Endereco", cliente.Endereco);
            command.Parameters.AddWithValue("@Numero", cliente.Numero);
            command.Parameters.AddWithValue("@Bairro", cliente.Bairro);
            command.Parameters.AddWithValue("@Cidade", cliente.Cidade);
            command.Parameters.AddWithValue("@UF", cliente.UF);
        }

        public Cliente ConverterSqlDataReaderParaEntidades(SqlDataReader dados)
        {
            Cliente cliente = new Cliente{
                CPF = dados["CPF"].ToString()
                ,
                RG = dados["RG"].ToString(),
                Nome = dados["Nome"].ToString()
                ,
                Endereco = dados["Endereco"].ToString(),
                Numero = Convert.ToInt32(dados["Numero"]),
                Bairro = dados["Bairro"].ToString(),
                Cidade = dados["Cidade"].ToString(),
                UF = dados["UF"].ToString()
            };
            return cliente;
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
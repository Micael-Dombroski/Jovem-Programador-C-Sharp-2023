using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SolucaoBanco.Domain.Entidade;
using System.Data.SqlClient;

namespace SolucaoBanco.Infra.Data.DAO
{
    public class ClienteDAO
    {
        private const string stringConexao = @"server=.\SQLexpress;initial catalog=Banco4;integrated security=true;";

        public void Adicionar(Cliente cliente)
        {
            using (var conexao = new SqlConnection(stringConexao))
            {
                conexao.Open();
                using (var command = new SqlCommand("insert into Cliente values (@CPF, @RG, @Nome, @Endereco, @Numero, @Bairro, @Cidade, @UF);", conexao))
                {
                    ConverterEntidadeParaSqlCommandParametros(command, cliente);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void Editar(Cliente cliente)
        {
            using (var conexao = new SqlConnection(stringConexao))
            {
                conexao.Open();
                using (var command = new SqlCommand("update Cliente set RG = @RG, Nome = @Nome, Endereco = @Endereco, Numero = @Numero, Bairro = @Bairro, Cidade = @Cidade, UF = @UF where CPF = @CPF;", conexao))
                {
                    ConverterEntidadeParaSqlCommandParametros(command, cliente);
                    command.ExecuteNonQuery();
                }
            }
        }

        

        public void Excluir(string cpf)
        {
            using (var conexao = new SqlConnection(stringConexao))
            {
                conexao.Open();
                using (var command = new SqlCommand("delete from Cliente where CPF = @CPF;", conexao))
                {
                    command.Parameters.AddWithValue("@CPF", cpf);
                    command.ExecuteNonQuery();
                }
            }
        }

        public Cliente ConsultarPorCPF(string cpf)
        {
            Cliente cliente = null;
            using (var conexao = new SqlConnection(stringConexao))
            {
                conexao.Open();
                using (var command = new SqlCommand("SELECT CPF, RG, Nome, Endereco, Numero, Bairro, Cidade, UF FROM Cliente WHERE CPF = @CPF;", conexao))
                {
                    command.Parameters.AddWithValue("@CPF", cpf);
                    SqlDataReader dados = command.ExecuteReader();
                    while (dados.Read())
                    {
                        cliente = ConverterSqlDataReaderParaEntidades(dados);
                    }
                }
            }
            return cliente;
        }

        public List<Cliente> ConsultarTodos()
        {
            List<Cliente> clientes = new List<Cliente>();
            using (var conexao = new SqlConnection(stringConexao))
            {
                conexao.Open();
                using (var command = new SqlCommand("select CPF, RG, Nome, Endereco, Numero, Bairro, Cidade, UF FROM Cliente", conexao))
                {
                    SqlDataReader dados = command.ExecuteReader();
                    while (dados.Read())
                    {
                        Cliente cliente = ConverterSqlDataReaderParaEntidades(dados);
                        clientes.Add(cliente);
                    }
                }
            }
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
    }
}
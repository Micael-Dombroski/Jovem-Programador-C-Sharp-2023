using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MerceariaSolution.Domain.Entidade;
using System.Data.SqlClient;

namespace MerceariaSolution.Infra.Data.DAO
{
    public class ClienteDAO
    {
        private const string stringConexao = @"server=.\SQLexpress;initial catalog=ESTOQUE4;integrated security=true;";

        public void Adicionar(Cliente cliente)
        {
            using (var conexao = new SqlConnection(stringConexao))
            {
                conexao.Open();
                using (var command = new SqlCommand("insert into Cliente values (@Cpf, @Nome, @Data_Nascimento, @Rua, @Numero, @Bairro, @Cidade, @UF);",conexao))
                {
                    ConverterEntidadeParaSqlCommandParametros(command, cliente);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void Editar(Cliente cliente, string cpf)
        {
            cliente.Cpf = cpf;
            using (var conexao = new SqlConnection(stringConexao))
            {
                conexao.Open();
                using (var command = new SqlCommand("update Cliente set Nome = @Nome, Data_Nascimento = @Data_Nascimento, Rua = @Rua, Numero = @Numero, Bairro = @Bairro, Cidade = @Cidade, UF = @UF where Cpf = @Cpf;", conexao))
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
                using (var command = new SqlCommand("delete from Cliente where Cpf = @Cpf;", conexao))
                {
                    command.Parameters.AddWithValue("@Cpf", cpf);
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
                using (var command = new SqlCommand("SELECT Cpf, Nome, Data_Nascimento, Rua, Numero, Bairro, Cidade, UF FROM Cliente WHERE Cpf = @Cpf;", conexao))
                {
                    command.Parameters.AddWithValue("@Cpf", cpf);
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
            List<Cliente> clientes = new ();
            using (var conexao = new SqlConnection(stringConexao))
            {
                conexao.Open();
                using (var command = new SqlCommand("select Cpf, Nome, Data_Nascimento, Rua, Numero, Bairro, Cidade, UF FROM Cliente", conexao))
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
            command.Parameters.AddWithValue("@Cpf", cliente.Cpf);
            command.Parameters.AddWithValue("@Nome", cliente.Nome);
            command.Parameters.AddWithValue("@Data_Nascimento", cliente.DataNascimento);
            command.Parameters.AddWithValue("@Rua", cliente.EnderecoMoradia.Rua);
            command.Parameters.AddWithValue("@Numero", cliente.EnderecoMoradia.Numero);
            command.Parameters.AddWithValue("@Bairro", cliente.EnderecoMoradia.Bairro);
            command.Parameters.AddWithValue("@Cidade", cliente.EnderecoMoradia.Cidade);
            command.Parameters.AddWithValue("@UF", cliente.EnderecoMoradia.UF);
        }

        public Cliente ConverterSqlDataReaderParaEntidades(SqlDataReader dados)
        {
            Cliente cliente = new Cliente{
                Cpf = dados["Cpf"].ToString()
                ,
                Nome = dados["Nome"].ToString()
                ,
                DataNascimento = Convert.ToDateTime(dados["Data_Nascimento"]),
                EnderecoMoradia = new Endereco
                {
                    Rua = dados["Rua"].ToString(),
                    Numero = Convert.ToInt32(dados["Numero"]),
                    Bairro = dados["Bairro"].ToString(),
                    Cidade = dados["Cidade"].ToString(),
                    UF = dados["UF"].ToString()
                }

            };
            return cliente;
        }
    }
}
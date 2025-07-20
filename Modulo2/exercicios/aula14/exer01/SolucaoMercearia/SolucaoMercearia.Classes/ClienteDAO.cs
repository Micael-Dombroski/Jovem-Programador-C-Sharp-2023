using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SolucaoMercearia.Classes
{
    public class ClienteDAO
    {
        static SqlConnection _conexao = new SqlConnection();
        private const string stringConexao = @"server=.\SQLexpress;initial catalog=ESTOQUE3;integrated security=true;";
        public ClienteDAO()
        {
            _conexao.ConnectionString = stringConexao;
        }

        public void Adicionar(Cliente cliente)
        {
            AbrirConexao();
            SqlCommand command = new SqlCommand("insert into Cliente values (@Nome, @Data_Nascimento, @Rua, @Numero, @Bairro, @Cidade, @UF);",_conexao);
            ConverterEntidadeParaSqlCommandParametros(command, cliente);
            command.ExecuteNonQuery();
            FecharConexao();
        }

        public void Editar(Cliente cliente, int id)
        {
            cliente.ID = id;
            AbrirConexao();
            SqlCommand command = new SqlCommand("update Cliente set Nome = @Nome, Data_Nascimento = @Data_Nascimento, Rua = @Rua, Numero = @Numero, Bairro = @Bairro, Cidade = @Cidade, UF = @UF where ID = @ID;", _conexao);
            ConverterEntidadeParaSqlCommandParametros(command, cliente);
            command.ExecuteNonQuery();
            FecharConexao();
        }

        

        public void Excluir(int id)
        {
            AbrirConexao();
            SqlCommand command = new SqlCommand("delete from Cliente where ID = @ID;", _conexao);
            command.Parameters.AddWithValue("@ID", id);
            command.ExecuteNonQuery();
            FecharConexao();
        }

        public Cliente ConsultarPorID(int id)
        {
            Cliente cliente = null;
            AbrirConexao();
            SqlCommand command = new SqlCommand("SELECT ID, Nome, Data_Nascimento, Rua, Numero, Bairro, Cidade, UF FROM Cliente WHERE ID = @ID;", _conexao);
            command.Parameters.AddWithValue("@ID", id);
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
            SqlCommand command = new SqlCommand("select ID, Nome, Data_Nascimento, Rua, Numero, Bairro, Cidade, UF FROM Cliente", _conexao);
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
            command.Parameters.AddWithValue("@ID", cliente.ID);
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
                ID = Convert.ToInt32(dados["ID"])
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
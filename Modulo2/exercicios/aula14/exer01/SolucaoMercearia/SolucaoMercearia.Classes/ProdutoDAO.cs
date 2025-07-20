using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SolucaoMercearia.Classes
{
    public class ProdutoDAO
    {
        static SqlConnection _conexao = new SqlConnection();
        private const string stringConexao = @"server=.\SQLexpress;initial catalog=ESTOQUE3;integrated security=true;";
        public ProdutoDAO()
        {
            _conexao.ConnectionString = stringConexao;
        }

        public void Adicionar(string nome, string marca, string dataVencimento, string precoUnitario, string unidade, int qtEstoque)
        {
            AbrirConexao();
            SqlCommand command = new SqlCommand("INSERT PRODUTO VALUES (@Nome, @Marca, @DataVencimento, @PrecoUnitario, @Unidade, @QtEstoque)", _conexao);
            ConverterEntidadeParaSqlCommandParametros(command, nome, marca, dataVencimento, precoUnitario, unidade, qtEstoque);
            command.ExecuteNonQuery();
            FecharConexao();
        }

        public void Editar(int id, string nome, string marca, string dataVencimento, string precoUnitario, string unidade, int qtEstoque)
        {
            AbrirConexao();
            SqlCommand command = new SqlCommand("UPDATE PRODUTO SET Nome = @Nome, Marca = @Marca, DataVencimento = @DataVencimento, PrecoUnitario = @PrecoUnitario, Unidade = @Unidade, QtEstoque = @QtEstoque WHERE Id = @Id", _conexao);
            ConverterEntidadeParaSqlCommandParametros(command, nome, marca, dataVencimento, precoUnitario, unidade, qtEstoque);
            command.ExecuteNonQuery();
            FecharConexao();
        }

        

        public void Excluir(int id)
        {
            AbrirConexao();
            SqlCommand command = new SqlCommand("DELETE FROM PRODUTO WHERE Id = @Id", _conexao);
            command.Parameters.AddWithValue("@Id", id);
            command.ExecuteNonQuery();
            FecharConexao();
        }

        public string ConsultarPorId(int id)
        {
            string produto = "";
            AbrirConexao();
            SqlCommand command = new SqlCommand("SELECT * FROM PRODUTO WHERE Id = @Id", _conexao);
            command.Parameters.AddWithValue("@Id", id);
            SqlDataReader dados = command.ExecuteReader();
            while (dados.Read())
            {
                produto = ConverterSqlDataReaderParaEntidades(dados);
            }
            FecharConexao();
            return produto;
        }

        public List<string> ConsultarTodos()
        {
            List<string> produtos = new List<string>();
            string produto = "";
            AbrirConexao();
            SqlCommand command = new SqlCommand("SELECT * FROM PRODUTO", _conexao);
            SqlDataReader dados = command.ExecuteReader();
            while (dados.Read())
            {
                produto = ConverterSqlDataReaderParaEntidades(dados);
                produtos.Add(produto);
            }
            FecharConexao();
            if (produtos.Count == 0)
            {
                return null;
            }
            else
            {
                return produtos;
            }
        }

        private void ConverterEntidadeParaSqlCommandParametros (SqlCommand comando, string nome, string marca, string dataVencimento, string precoUnitario, string unidade, int qtEstoque)
        {
            comando.Parameters.AddWithValue("@Nome", nome);
            comando.Parameters.AddWithValue("@Marca", marca);
            comando.Parameters.AddWithValue("@DataVencimento", dataVencimento);
            comando.Parameters.AddWithValue("@PrecoUnitario", precoUnitario);
            comando.Parameters.AddWithValue("@Unidade", unidade);
            comando.Parameters.AddWithValue("@QtEstoque", qtEstoque);
        }

        public string ConverterSqlDataReaderParaEntidades(SqlDataReader leitor)
        {
            var Id = leitor["Id"];
            var nome = leitor["Nome"];
            var marca = leitor["Marca"];
            var dataVencimento = leitor["DataVencimento"];
            var precoUnitario = leitor["PrecoUnitario"];
            var unidade = leitor["Unidade"];
            var qtEstoque = leitor["QtEstoque"];

            string produto =$"Id: {Id} - Nome: {nome} - Marca: {marca} - Data de Vencimento: {dataVencimento} - Preço Unitário: {precoUnitario} - Quantidade em Estoque: {qtEstoque}";
            return produto;
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
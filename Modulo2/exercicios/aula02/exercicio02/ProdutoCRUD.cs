using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace exercicio02
{
    public class ProdutoCRUD
    {
        private SqlConnection conexao = new SqlConnection();
        public void Adicionar(string nome, string marca, string dataVencimento, string precoUnitario, string unidade, int qtEstoque)
        {
            AbrirConexao();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"INSERT PRODUTO VALUES (@Nome, @Marca, @DataVencimento, @PrecoUnitario, @Unidade, @QtEstoque)";
            comando.Parameters.AddWithValue("@Nome", nome);
            comando.Parameters.AddWithValue("@Marca", marca);
            comando.Parameters.AddWithValue("@DataVencimento", dataVencimento);
            comando.Parameters.AddWithValue("@PrecoUnitario", precoUnitario);
            comando.Parameters.AddWithValue("@Unidade", unidade);
            comando.Parameters.AddWithValue("@QtEstoque", qtEstoque);
            comando.ExecuteNonQuery();
            FecharConexao();
        }

        public List<string> ConsultarTodos()
        {
            List<string> produtos = new List<string>();
            AbrirConexao();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"SELECT * FROM PRODUTO";
            SqlDataReader leitor = comando.ExecuteReader();
            while (leitor.Read())
            {
                var nome = leitor["Nome"];
                var marca = leitor["Marca"];
                var dataVencimento = leitor["DataVencimento"];
                var precoUnitario = leitor["PrecoUnitario"];
                var unidade = leitor["Unidade"];
                var qtEstoque = leitor["QtEstoque"];

                produtos.Add($"Nome: {nome} - Marca: {marca} - Data de Vencimento: {dataVencimento} - Preço Unitário: {precoUnitario} - Quantidade em Estoque: {qtEstoque}");
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

        public string ConsultarPorNomeEMarca(string nomeProduto, string marcaProduto)
        {
            string produto = "";
            AbrirConexao();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"SELECT * FROM PRODUTO WHERE Nome = @Nome AND Marca = @Marca";
            comando.Parameters.AddWithValue("@Nome", nomeProduto);
            comando.Parameters.AddWithValue("@Marca", marcaProduto);
            SqlDataReader leitor = comando.ExecuteReader();
            while (leitor.Read())
            {
                var nome = leitor["Nome"];
                var marca = leitor["Marca"];
                var dataVencimento = leitor["DataVencimento"];
                var precoUnitario = leitor["PrecoUnitario"];
                var unidade = leitor["Unidade"];
                var qtEstoque = leitor["QtEstoque"];

                produto =$"Nome: {nome} - Marca: {marca} - Data de Vencimento: {dataVencimento} - Preço Unitário: {precoUnitario} - Quantidade em Estoque: {qtEstoque}";
            }
            FecharConexao();
            if (string.IsNullOrEmpty(produto))
            {
                return null;
            }
            else 
            {
                return produto;
            }
        }

        public void Alterar(string nome, string marca, string dataVencimento, string precoUnitario, string unidade, int qtEstoque)
        {
            AbrirConexao();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"UPDATE PRODUTO SET DataVencimento = @DataVencimento, PrecoUnitario = @PrecoUnitario, Unidade = @Unidade, QtEstoque = @QtEstoque WHERE Nome = @Nome AND Marca = @Marca";
            comando.Parameters.AddWithValue("@Nome", nome);
            comando.Parameters.AddWithValue("@Marca", marca);
            comando.Parameters.AddWithValue("@DataVencimento", dataVencimento);
            comando.Parameters.AddWithValue("@PrecoUnitario", precoUnitario);
            comando.Parameters.AddWithValue("@Unidade", unidade);
            comando.Parameters.AddWithValue("@QtEstoque", qtEstoque);
            comando.ExecuteNonQuery();
            FecharConexao();
        }

        public void Excluir(string nome, string marca)
        {
            AbrirConexao();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"DELETE FROM PRODUTO WHERE Nome = @Nome AND Marca = @Marca";
            comando.Parameters.AddWithValue("@Nome", nome);
            comando.Parameters.AddWithValue("@Marca", marca);
            comando.ExecuteNonQuery();
            FecharConexao();
        }

        private void AbrirConexao()
        {
            var connectionString = @"server=.\SQLexpress;initial catalog=ESTOQUE;integrated security=true;";
            conexao.ConnectionString = connectionString;
            conexao.Open();
        }
        private void FecharConexao()
        {
            conexao.Close();
        }
    }
}
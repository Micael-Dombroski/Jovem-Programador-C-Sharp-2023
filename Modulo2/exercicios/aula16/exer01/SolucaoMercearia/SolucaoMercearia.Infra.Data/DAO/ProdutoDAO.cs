using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using SolucaoMercearia.Domain.Entidade;

namespace SolucaoMercearia.Infra.Data.DAO
{
    public class ProdutoDAO
    {
        private const string stringConexao = @"server=.\SQLexpress;initial catalog=ESTOQUE3;integrated security=true;";

        public void Adicionar(string nome, string marca, string dataVencimento, string precoUnitario, string unidade, int qtEstoque)
        {
            using (var conexao = new SqlConnection(stringConexao))
            {
                conexao.Open();
                using (var command = new SqlCommand("INSERT PRODUTO VALUES (@Nome, @Marca, @DataVencimento, @PrecoUnitario, @Unidade, @QtEstoque)", conexao))
                {
                    ConverterEntidadeParaSqlCommandParametros(command, nome, marca, dataVencimento, precoUnitario, unidade, qtEstoque);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void Editar(int id, string nome, string marca, string dataVencimento, string precoUnitario, string unidade, int qtEstoque)
        {
            using (var conexao = new SqlConnection(stringConexao))
            {
                conexao.Open();
                using (var command = new SqlCommand("UPDATE PRODUTO SET Nome = @Nome, Marca = @Marca, DataVencimento = @DataVencimento, PrecoUnitario = @PrecoUnitario, Unidade = @Unidade, QtEstoque = @QtEstoque WHERE Id = @Id", conexao))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    ConverterEntidadeParaSqlCommandParametros(command, nome, marca, dataVencimento, precoUnitario, unidade, qtEstoque);
                    command.ExecuteNonQuery();
                }
            }
        }

        

        public void Excluir(int id)
        {
            using (var conexao = new SqlConnection(stringConexao))
            {
                conexao.Open();
                using (var command = new SqlCommand("DELETE FROM PRODUTO WHERE Id = @Id", conexao))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    command.ExecuteNonQuery();
                }
            }
        }

        public string ConsultarPorId(int id)
        {
            string produto = null;
            using (var conexao = new SqlConnection(stringConexao))
            {
                conexao.Open();
                using (var command = new SqlCommand("SELECT * FROM PRODUTO WHERE Id = @Id", conexao))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    SqlDataReader dados = command.ExecuteReader();
                    while (dados.Read())
                    {
                        produto = ConverterSqlDataReaderParaEntidades(dados);
                    }
                }
            }
            return produto;
        }

        public List<string> ConsultarTodos()
        {
            List<string> produtos = new List<string>();
            string produto = "";
            using (var conexao = new SqlConnection(stringConexao))
            {
                conexao.Open();
                using (var command = new SqlCommand("SELECT * FROM PRODUTO", conexao))
                {
                    SqlDataReader dados = command.ExecuteReader();
                    while (dados.Read())
                    {
                        produto = ConverterSqlDataReaderParaEntidades(dados);
                        produtos.Add(produto);
                    }
                }
            }
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

            string produto =$"Id: {Id} - Nome: {nome} - Marca: {marca} - Data de Vencimento: {dataVencimento} - Preço Unitário: {precoUnitario} - Unidade: {unidade} - Quantidade em Estoque: {qtEstoque}";
            return produto;
        }
    }
}
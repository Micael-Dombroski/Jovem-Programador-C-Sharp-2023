using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MerceariaSolution.Domain.Entidade;

namespace MerceariaSolution.Infra.Data.DAO
{
    public class ProdutoDAO
    {
        private const string stringConexao = @"server=.\SQLexpress;initial catalog=ESTOQUE4;integrated security=true;";

        public void Adicionar(Produto produto)
        {
            using (var conexao = new SqlConnection(stringConexao))
            {
                conexao.Open();
                using (var command = new SqlCommand("INSERT PRODUTO VALUES (@Nome, @Marca, @DataVencimento, @PrecoUnitario, @Unidade, @QtEstoque)", conexao))
                {
                    ConverterEntidadeParaSqlCommandParametros(command, produto);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void Editar(Produto produto)
        {
            using (var conexao = new SqlConnection(stringConexao))
            {
                conexao.Open();
                using (var command = new SqlCommand("UPDATE PRODUTO SET Nome = @Nome, Marca = @Marca, DataVencimento = @DataVencimento, PrecoUnitario = @PrecoUnitario, Unidade = @Unidade, QtEstoque = @QtEstoque WHERE Id = @Id", conexao))
                {
                    command.Parameters.AddWithValue("@Id", produto.Id);
                    ConverterEntidadeParaSqlCommandParametros(command, produto);
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

        public Produto ConsultarPorId(int id)
        {
            Produto produto = null;
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

        public List<Produto> ConsultarTodos()
        {
            List<Produto> produtos = new ();
            using (var conexao = new SqlConnection(stringConexao))
            {
                conexao.Open();
                using (var command = new SqlCommand("SELECT * FROM PRODUTO", conexao))
                {
                    SqlDataReader dados = command.ExecuteReader();
                    while (dados.Read())
                    {
                        Produto produto = ConverterSqlDataReaderParaEntidades(dados);
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

        private void ConverterEntidadeParaSqlCommandParametros (SqlCommand comando, Produto produto)
        {
            comando.Parameters.AddWithValue("@Nome", produto.Nome);
            comando.Parameters.AddWithValue("@Marca", produto.Marca);
            comando.Parameters.AddWithValue("@DataVencimento", produto.DataVencimento);
            comando.Parameters.AddWithValue("@PrecoUnitario", produto.PrecoUnitario);
            comando.Parameters.AddWithValue("@Unidade", produto.Unidade);
            comando.Parameters.AddWithValue("@QtEstoque", produto.QtEstoque);
        }

        public Produto ConverterSqlDataReaderParaEntidades(SqlDataReader leitor)
        {
            Produto produto = new Produto
            {
                Id = Convert.ToInt32(leitor["Id"]),
                Nome = leitor["Nome"].ToString(),
                Marca = leitor["Marca"].ToString(),
                DataVencimento = Convert.ToDateTime(leitor["DataVencimento"]),
                PrecoUnitario = Convert.ToDouble(leitor["PrecoUnitario"]),
                Unidade = leitor["Unidade"].ToString(),
                QtEstoque = Convert.ToDouble(leitor["QtEstoque"])
            };
            return produto;
        }
    }
}
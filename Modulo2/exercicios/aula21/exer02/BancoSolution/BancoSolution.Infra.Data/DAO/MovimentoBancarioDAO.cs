using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BancoSolution.Domain.Entidade;
using System.Data.SqlClient;

namespace BancoSolution.Infra.Data.DAO
{
    public class MovimentoBancarioDAO
    {
        private const string stringConexao = @"server=.\SQLexpress;initial catalog=Banco;integrated security=true;";

        public void Adicionar(MovimentoBancario movimento)
        {
            using (var conexao = new SqlConnection(stringConexao))
            {
                conexao.Open();
                using (var command = new SqlCommand("insert into Movimento_Bancario values (@Tipo_Movimento, @Valor_Movimentado, @Conta_Agencia, @Conta_Numero);", conexao))
                {
                    ConverterEntidadeParaSqlCommandParametros(command, movimento);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void Editar(MovimentoBancario movimento)
        {
            using (var conexao = new SqlConnection(stringConexao))
            {
                conexao.Open();
                using (var command = new SqlCommand("update Movimento_Bancario set Tipo_Movimento = @Tipo_Movimento, Conta_Agencia = @Conta_Agencia, Conta_Numero = @Conta_Numero where Id = @Id;", conexao))
                {
                    ConverterEntidadeParaSqlCommandParametros(command, movimento);
                    command.ExecuteNonQuery();
                }
            }
        }

        

        public void Excluir(int id)
        {
            using (var conexao = new SqlConnection(stringConexao))
            {
                conexao.Open();
                using (var command = new SqlCommand("delete from Movimento_Bancario where Id = @Id ;", conexao))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    command.ExecuteNonQuery();
                }
            }
        }

        public List<MovimentoBancario> ConsultarPorAgenciaENumero(Conta conta)
        {
            List<MovimentoBancario> movimentos = new List<MovimentoBancario>();
            using (var conexao = new SqlConnection(stringConexao))
            {
                conexao.Open();
                using (var command = new SqlCommand("SELECT Id, Tipo_Movimento, Valor_Movimentado, Conta_Agencia, Conta_Numero FROM Movimento_Bancario WHERE Conta_Agencia = @Conta_Agencia AND Conta_Numero = @Conta_Numero;", conexao))
                {
                    command.Parameters.AddWithValue("@Conta_Agencia", conta.Agencia);
                    command.Parameters.AddWithValue("@Conta_Numero", conta.Numero);
                    SqlDataReader dados = command.ExecuteReader();
                    while (dados.Read())
                    {
                        MovimentoBancario movimento = ConverterSqlDataReaderParaEntidades(dados, conta);
                        movimentos.Add(movimento);
                    }
                }
            }
            if (movimentos.Count == 0)
            {
                return null;
            }
            else
            {
                return movimentos;
            }
        }

        public List<MovimentoBancario> ConsultarTodos()
        {
            List<MovimentoBancario> movimentos = new();
            using (var conexao = new SqlConnection(stringConexao))
            {
                conexao.Open();
                using (var command = new SqlCommand("SELECT Id, Tipo_Movimento, Valor_Movimentado, Conta_Agencia, Conta_Numero FROM Movimento_Bancario", conexao))
                {
                    SqlDataReader dados = command.ExecuteReader();
                    while (dados.Read())
                    {
                        MovimentoBancario movimento = ConverterSqlDataReaderParaEntidades(dados);
                        movimentos.Add(movimento);
                    }
                }
            }
            if (movimentos.Count == 0)
            {
                return null;
            }
            else
            {
                return movimentos;
            }
        }

        private void ConverterEntidadeParaSqlCommandParametros (SqlCommand command, MovimentoBancario movimento)
        {
            command.Parameters.AddWithValue("@Id", movimento.Id);
            command.Parameters.AddWithValue("@Conta_Agencia", movimento.ContaUsada.Agencia);
            command.Parameters.AddWithValue("@Conta_Numero", movimento.ContaUsada.Numero);
            command.Parameters.AddWithValue("@Tipo_Movimento", movimento.TipoMovimento);
            command.Parameters.AddWithValue("@Valor_Movimentado", movimento.ValorMovimentado);
        }

        public MovimentoBancario ConverterSqlDataReaderParaEntidades(SqlDataReader dados)
        {
            MovimentoBancario movimento = new()
            {
                Id = Convert.ToInt32(dados["Id"]),
                TipoMovimento = dados["Tipo_Movimento"].ToString(),
                ValorMovimentado = Convert.ToDouble(dados["Valor_Movimentado"])
            };
            int agencia = Convert.ToInt32(dados["Conta_Agencia"]);
            int numero = Convert.ToInt32(dados["Conta_Numero"]);
            ContaDAO contaDAO = new();
            movimento.ContaUsada = contaDAO.ConsultarPorAgenciaENumero(agencia, numero);
            return movimento;
        }

        public MovimentoBancario ConverterSqlDataReaderParaEntidades(SqlDataReader dados, Conta conta)
        {
            MovimentoBancario movimento = new()
            {
                Id = Convert.ToInt32(dados["Id"]),
                TipoMovimento = dados["Tipo_Movimento"].ToString(),
                ValorMovimentado = Convert.ToDouble(dados["Valor_Movimentado"]),
                ContaUsada = conta
            };
            return movimento;
        }
    }
}
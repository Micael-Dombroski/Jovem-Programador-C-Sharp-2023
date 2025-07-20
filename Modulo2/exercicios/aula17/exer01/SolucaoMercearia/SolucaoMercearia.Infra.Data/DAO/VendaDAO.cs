using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using SolucaoMercearia.Domain.Entidade;

namespace SolucaoMercearia.Infra.Data.DAO
{
    public class VendaDAO
    {
        private const string stringConexao = @"server=.\SQLexpress;initial catalog=ESTOQUE4;integrated security=true;";

        public void Adicionar(Venda venda)
        {
            using (var conexao = new SqlConnection(stringConexao))
            {
                conexao.Open();
                using (var command = new SqlCommand("INSERT Venda VALUES (@Cliente_Cpf, @Produto_Id, @PrecoUnitario, @QtLevada)", conexao))
                {
                    ConverterEntidadeParaSqlCommandParametros(command, venda);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void Editar(Venda venda)
        {
            using (var conexao = new SqlConnection(stringConexao))
            {
                conexao.Open();
                using (var command = new SqlCommand("UPDATE Venda SET Cliente_Cpf = @Cliente_Cpf, Produto_Id = @Produto_Id, PrecoUnitario = @PrecoUnitario, QtLevada = @QtLevada WHERE Id = @Id", conexao))
                {
                    command.Parameters.AddWithValue("@Id", venda.Id);
                    ConverterEntidadeParaSqlCommandParametros(command, venda);
                    command.ExecuteNonQuery();
                }
            }
        }

        

        public void Excluir(int id)
        {
            using (var conexao = new SqlConnection(stringConexao))
            {
                conexao.Open();
                using (var command = new SqlCommand("DELETE FROM Venda WHERE Id = @Id", conexao))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    command.ExecuteNonQuery();
                }
            }
        }

        public Venda ConsultarPorId(int id)
        {
            Venda venda = null;
            using (var conexao = new SqlConnection(stringConexao))
            {
                conexao.Open();
                using (var command = new SqlCommand(
                    @"SELECT A.CPF, A.Nome as Cliente, A.Data_Nascimento as Nascimento, A.Rua, A.Bairro, A.Cidade, A.UF, 
                    B.Id as Produto_Id, B.Nome as Produto, B.Marca, B.DataVencimento as Vencimento, B.PrecoUnitario, B.Unidade, B.QtEstoque,
                    C.Id as Venda_Id, C.QtLevada
                    FROM Cliente A, Produto B, Venda C WHERE Id = @Id"
                    , conexao))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    SqlDataReader dados = command.ExecuteReader();
                    while (dados.Read())
                    {
                        venda = ConverterSqlDataReaderParaEntidades(dados);
                    }
                }
            }
            return venda;
        }

        public List<Venda> ConsultarTodos()
        {
            List<Venda> vendas = new ();
            using (var conexao = new SqlConnection(stringConexao))
            {
                conexao.Open();
                using (var command = new SqlCommand(
                    @"SELECT A.CPF as CPF, A.Nome as Cliente, A.Data_Nascimento as Nascimento, A.Numero as Numero, A.Rua as Rua, A.Bairro as Bairro, A.Cidade as Cidade, A.UF as UF, 
                    B.Id as Produto_Id, B.Nome as Produto, B.Marca as Marca, B.DataVencimento as Vencimento, B.PrecoUnitario as PrecoUnitario, B.Unidade as Unidade, B.QtEstoque as QtEstoque,
                    C.Id as Venda_Id, C.QtLevada
                    FROM Cliente A
                    INNER JOIN Venda C ON (A.CPF = C.Cliente_Cpf)
                    INNER JOIN Produto B ON (B.Id = C.Produto_Id)"
                    , conexao
                    ))
                {
                    SqlDataReader dados = command.ExecuteReader();
                    while (dados.Read())
                    {
                        Venda venda = ConverterSqlDataReaderParaEntidades(dados);
                        vendas.Add(venda);
                    }
                }
            }
            if (vendas.Count == 0)
            {
                return null;
            }
            else
            {
                return vendas;
            }
        }

        public List<Venda> ConsultarPorCliente(Cliente cliente)
        {
            List<Venda> vendas = new ();
            using (var conexao = new SqlConnection(stringConexao))
            {
                conexao.Open();
                using (var command = new SqlCommand(
                @"SELECT B.Id as Produto_Id, B.Nome as Produto, B.Marca as Marca, B.DataVencimento as Vencimento, B.PrecoUnitario as PrecoUnitario, B.Unidade as Unidade, B.QtEstoque as QtEstoque,
                    C.Id as Venda_Id, C.QtLevada
                    FROM Produto B, Venda C WHERE C.Cliente_Cpf = @Cpf"
                , conexao))
                {
                    command.Parameters.AddWithValue("@Cpf", cliente.Cpf);
                    SqlDataReader dados = command.ExecuteReader();
                    while (dados.Read())
                    {
                        Venda venda = ConverterSqlDataReaderParaEntidades(dados, cliente);
                        vendas.Add(venda);
                    }
                }
            }
            if (vendas.Count == 0)
            {
                return null;
            }
            else
            {
                return vendas;
            }
        }

        private void ConverterEntidadeParaSqlCommandParametros (SqlCommand comando, Venda venda)
        {
            comando.Parameters.AddWithValue("@Cliente_Cpf", venda.ClienteVenda.Cpf);
            comando.Parameters.AddWithValue("@Produto_Id", venda.ProdutoVendido.Id);
            comando.Parameters.AddWithValue("@PrecoUnitario", venda.ProdutoVendido.PrecoUnitario);
            comando.Parameters.AddWithValue("@QtLevada", venda.QuantidadeVendida);
        }

        public Venda ConverterSqlDataReaderParaEntidades(SqlDataReader leitor)
        {
            Venda venda = new Venda();
            Cliente cliente = new ();
            Produto produto = new();
            Endereco endereco = new();
            cliente.Cpf = leitor["CPF"].ToString();
            cliente.Nome = leitor["Cliente"].ToString();
            endereco.Cidade = leitor["Cidade"].ToString();
            endereco.UF = leitor["UF"].ToString();
            endereco.Bairro = leitor["Bairro"].ToString();
            endereco.Rua = leitor["Rua"].ToString();
            endereco.Numero = Convert.ToInt32(leitor["Numero"]);
            cliente.EnderecoMoradia = endereco;
            cliente.DataNascimento = Convert.ToDateTime(leitor["Nascimento"]);
            produto.Id = Convert.ToInt32(leitor["Produto_Id"]);
            produto.Unidade = leitor["Unidade"].ToString();
            produto.PrecoUnitario = Convert.ToDouble(leitor["PrecoUnitario"]);;
            produto.QtEstoque = Convert.ToDouble(leitor["QtEstoque"]);
            produto.DataVencimento = Convert.ToDateTime(leitor["Vencimento"]);
            produto.Marca = leitor["Marca"].ToString();
            produto.Nome = leitor["Produto"].ToString();
            venda.Id = Convert.ToInt32(leitor["Venda_Id"]);
            venda.QuantidadeVendida = Convert.ToDouble(leitor["QtLevada"]);
            venda.ClienteVenda = cliente;
            venda.ProdutoVendido = produto;
            return venda;
        }

        public Venda ConverterSqlDataReaderParaEntidades(SqlDataReader leitor, Cliente cliente)
        {
            Venda venda = new();
            Produto produto = new()
            {
                Id = Convert.ToInt32(leitor["Produto_Id"]),
                Unidade = leitor["Unidade"].ToString(),
                PrecoUnitario = Convert.ToDouble(leitor["PrecoUnitario"]),
                QtEstoque = Convert.ToDouble(leitor["QtEstoque"]),
                DataVencimento = Convert.ToDateTime(leitor["Vencimento"]),
                Marca = leitor["Marca"].ToString(),
                Nome = leitor["Produto"].ToString()
            };
            venda.Id = Convert.ToInt32(leitor["Venda_Id"]);
            venda.QuantidadeVendida = Convert.ToDouble(leitor["QtLevada"]);
            venda.ClienteVenda = cliente;
            venda.ProdutoVendido = produto;
            return venda;
        }
    }
}
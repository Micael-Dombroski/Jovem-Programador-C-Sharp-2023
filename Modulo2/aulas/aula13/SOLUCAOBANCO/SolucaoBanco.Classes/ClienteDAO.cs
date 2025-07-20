using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SolucaoBanco.Classes
{
    public class ClienteDAO
    {
        private SqlConnection _conexao;
        public ClienteDAO()
        {
            _conexao = new SqlConnection();
            var stringConexao = @"server=.\SQLexpress;initial catalog=BANCO2;integrated security=true;";
            _conexao.ConnectionString = stringConexao;
        }

        public void Adicionar(Cliente cliente)
        {
            AbrirConexao();
            SqlCommand command = new SqlCommand("insert into Cliente values (@CPF, @RG, @Nome, @Endereco);",_conexao);
            command.Parameters.AddWithValue("@CPF", cliente.Cpf);
            command.Parameters.AddWithValue("@RG", cliente.Rg);
            command.Parameters.AddWithValue("@Nome", cliente.Nome);
            command.Parameters.AddWithValue("@Endereco", cliente.Endereco);
            command.ExecuteNonQuery();
            FecharConexao();
        }

        public void Editar(Cliente cliente)
        {
            AbrirConexao();
            SqlCommand command = new SqlCommand("update Cliente set RG = @RG, Nome = @Nome,Endereco = @Endereco where CPF = @CPF;", _conexao);
            command.Parameters.AddWithValue("@CPF", cliente.Cpf);
            command.Parameters.AddWithValue("@RG", cliente.Rg);
            command.Parameters.AddWithValue("@Nome", cliente.Nome);
            command.Parameters.AddWithValue("@Endereco", cliente.Endereco);
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

        public Cliente ConsultarPorCpf(string cpf)
        {
            Cliente cliente = null;
            AbrirConexao();
            SqlCommand command = new SqlCommand("SELECT RG, Nome, Endereco FROM CLIENTE WHERE CPF = @CPF;", _conexao);
            command.Parameters.AddWithValue("@CPF", cpf);
            SqlDataReader dados = command.ExecuteReader();
            while (dados.Read())
            {
                cliente = new Cliente
                {
                    Cpf = cpf
                    ,
                    Rg = dados["RG"].ToString()
                    ,
                    Nome = dados["Nome"].ToString()
                    ,
                    Endereco = dados["Endereco"].ToString()
                };
            }
            FecharConexao();
            return cliente;
        }

        public List<Cliente> ConsultarTodos()
        {
            List<Cliente> clientes = new List<Cliente>();
            AbrirConexao();
            SqlCommand command = new SqlCommand("select CPF, RG, Nome, Endereco FROM Cliente", _conexao);
            SqlDataReader dados = command.ExecuteReader();
            while (dados.Read())
            {
                Cliente cliente = new Cliente{
                    Cpf = dados["CPF"].ToString(),
                    Rg = dados["RG"].ToString(),
                    Nome = dados["Nome"].ToString(),
                    Endereco = dados["Endereco"].ToString()
                };
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
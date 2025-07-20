using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using MerceariaSolution.Domain.Entidade;

namespace MerceariaSolution.Infra.Data.DAO
{
    public class UsuarioDAO
    {
        private const string stringConexao = @"server=.\SQLexpress;initial catalog=ESTOQUE4;integrated security=true;";

        public void Adicionar(Usuario usuario)
        {
            using (var conexao = new SqlConnection(stringConexao))
            {
                conexao.Open();
                using (var command = new SqlCommand("insert into Usuario values (@LoginUsuario, @SenhaUsuario);",conexao))
                {
                    ConverterEntidadeParaSqlCommandParametros(command, usuario);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void Editar(Usuario usuario)
        {
            using (var conexao = new SqlConnection(stringConexao))
            {
                conexao.Open();
                using (var command = new SqlCommand("update Usuario set LoginUsuario = @LoginUsuario, SenhaUsuario = @SenhaUsuario where Id = @Id", conexao))
                {
                    command.Parameters.AddWithValue("@Id", usuario.Id);
                    command.Parameters.AddWithValue("@LoginUsuario", usuario.LoginUsuario);
                    command.Parameters.AddWithValue("@SenhaUsuario", usuario.SenhaUsuario);
                    command.ExecuteNonQuery();
                }
            }
        }

        

        public void Excluir(Usuario usuario)
        {
            using (var conexao = new SqlConnection(stringConexao))
            {
                conexao.Open();
                using (var command = new SqlCommand("delete from Usuario where Id = @Id;", conexao))
                {
                    command.Parameters.AddWithValue("@Id", usuario.Id);
                    command.ExecuteNonQuery();
                }
            }
        }

        public Usuario ConsultarPorLoginESenha(string login, string senha)
        {
            Usuario usuario = null;
            using (var conexao = new SqlConnection(stringConexao))
            {
                conexao.Open();
                using (var command = new SqlCommand("SELECT Id, LoginUsuario, SenhaUsuario FROM Usuario WHERE LoginUsuario = @LoginUsuario AND SenhaUsuario = @SenhaUsuario;", conexao))
                {
                    command.Parameters.AddWithValue("@LoginUsuario", login);
                    command.Parameters.AddWithValue("@SenhaUsuario", senha);
                    SqlDataReader dados = command.ExecuteReader();
                    while (dados.Read())
                    {
                        usuario = ConverterSqlDataReaderParaEntidades(dados);
                    }
                }
            }
            return usuario;
        }

        public Usuario ConsultarPorId(int id)
        {
            Usuario usuario = null;
            using (var conexao = new SqlConnection(stringConexao))
            {
                conexao.Open();
                using (var command = new SqlCommand("SELECT Id, LoginUsuario, SenhaUsuario FROM Usuario WHERE Id = @Id", conexao))
                {
                    command.Parameters.AddWithValue("@Id", usuario.Id);
                    SqlDataReader dados = command.ExecuteReader();
                    while (dados.Read())
                    {
                        usuario = ConverterSqlDataReaderParaEntidades(dados);
                    }
                }
            }
            return usuario;
        }

        public List<Usuario> ConsultarTodos()
        {
            List<Usuario> usuarios = new ();
            using (var conexao = new SqlConnection(stringConexao))
            {
                conexao.Open();
                using (var command = new SqlCommand("select Id, LoginUsuario, SenhaUsuario FROM Usuario", conexao))
                {
                    SqlDataReader dados = command.ExecuteReader();
                    while (dados.Read())
                    {
                        Usuario usuario = ConverterSqlDataReaderParaEntidades(dados);
                        usuarios.Add(usuario);
                    }
                }
            }
            if (usuarios.Count == 0)
            {
                return null;
            }
            else
            {
                return usuarios;
            }
        }

        private void ConverterEntidadeParaSqlCommandParametros (SqlCommand command, Usuario usuario)
        {
            command.Parameters.AddWithValue("@Id", usuario.Id);
            command.Parameters.AddWithValue("@LoginUsuario", usuario.LoginUsuario);
            command.Parameters.AddWithValue("@SenhaUsuario", usuario.SenhaUsuario);
        }

        public Usuario ConverterSqlDataReaderParaEntidades(SqlDataReader dados)
        {
            Usuario usuario = new Usuario{
                Id = Convert.ToInt32(dados["Id"])
                ,
                LoginUsuario = dados["LoginUsuario"].ToString()
                ,
                SenhaUsuario = dados["SenhaUsuario"].ToString()

            };
            return usuario;
        }
    }
}
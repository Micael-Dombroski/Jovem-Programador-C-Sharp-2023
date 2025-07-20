using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProjetoDB
{
    public class AlunoCRUD
    {
        private SqlConnection conexao = new SqlConnection();
        public void Adicionar(int matricula, string nome, int idade)
        {
            AbrirConexao();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = conexao;
            sqlCommand.CommandText = @"INSERT ALUNO VALUES (@MATRICULA, @NOME, @IDADE)";
            sqlCommand.Parameters.AddWithValue("@MATRICULA", matricula);
            sqlCommand.Parameters.AddWithValue("@NOME", nome);
            sqlCommand.Parameters.AddWithValue("@IDADE", idade);
            sqlCommand.ExecuteNonQuery();
            FecharConexao();
        }

        public List<string> ConsultarTodos()
        {
            List<string> alunos = new List<string>();
            AbrirConexao();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"SELECT * FROM ALUNO";
            SqlDataReader leitor = comando.ExecuteReader();
            while (leitor.Read())
            {
                var matricula = leitor["MATRICULA"];
                var nome = leitor["NOME"];
                var idade = leitor["IDADE"];

                alunos.Add($"Matricula: {matricula} - Nome: {nome} - Idade: {idade}");
            }
            FecharConexao();
            if (alunos.Count == 0)
            {
                return null;
            }
            else
            {
                return alunos;
            }
        }

        public string ConsultarPorMatricula(int matricula1)
        {
            string aluno = "";
            AbrirConexao();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"SELECT * FROM ALUNO WHERE MATRICULA = @MATRICULA";
            comando.Parameters.AddWithValue("@MATRICULA", matricula1);
            SqlDataReader leitor = comando.ExecuteReader();
            while (leitor.Read())
            {
                var matricula = leitor["MATRICULA"];
                var nome = leitor["NOME"];
                var idade = leitor["IDADE"];

                aluno = $"Matricula: {matricula} - Nome: {nome} - Idade: {idade}";
            }
            FecharConexao();
            if (string.IsNullOrEmpty(aluno))
            {
                return null;
            }
            else 
            {
                return aluno;
            }
        }

        public void Alterar(int matricula, string nome, int idade)
        {
            AbrirConexao();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"UPDATE ALUNO SET NOME = @NOME, IDADE = @IDADE WHERE MATRICULA = @MATRICULA";
            comando.Parameters.AddWithValue("@MATRICULA", matricula);
            comando.Parameters.AddWithValue("@NOME", nome);
            comando.Parameters.AddWithValue("IDADE", idade);
            comando.ExecuteNonQuery();
            FecharConexao();
        }

        public void Excluir(int matricula)
        {
            SqlConnection conexao = new SqlConnection();

            var connectionString = @"server=.\SQLexpress;initial catalog=ESCOLA;integrated security=true;";
            conexao.ConnectionString = connectionString;
            conexao.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"DELETE FROM ALUNO WHERE MATRICULA = @MATRICULA";
            comando.Parameters.AddWithValue("@MATRICULA", matricula);
            comando.ExecuteNonQuery();
            FecharConexao();
        }

        private void AbrirConexao()
        {
            var connectionString = @"server=.\SQLexpress;initial catalog=ESCOLA;integrated security=true;";
            conexao.ConnectionString = connectionString;
            conexao.Open();
        }
        private void FecharConexao()
        {
            conexao.Close();
        }
    }
}
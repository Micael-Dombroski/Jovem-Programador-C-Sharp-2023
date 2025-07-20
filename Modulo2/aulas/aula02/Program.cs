using System;
using System.Data.SqlClient;

namespace aula02
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection conexao = new SqlConnection();

            var connectionString = @"server=.\SQLexpress;initial catalog=NOME_BANCO;integrated security=true;";
            conexao.ConnectionString = connectionString;

            conexao.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;

            comando.CommandText = @"INSERT TABELA VALUES (23, 'ROBO', 32)";
            comando.ExecuteNonQuery();
            conexao.Close();

            conexao.Open();
            comando = new SqlCommand();
            comando.Connection = conexao;
            string nome = "Luna";
            string stringsql = @"SELECT * FROM TABELA WHERE nome = '" + nome + "';";
            SqlDataReader leitor = comando.ExecuteReader();
            /*while (leitor.Read())
            {
                var id = leitor[ID];
                var name = leitor[NOME];
                var idade = leitor[IDADE];
            }*/
            comando.ExecuteNonQuery();
            conexao.Close();
        }
    }
}

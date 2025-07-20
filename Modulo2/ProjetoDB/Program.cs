using System;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace ProjetoDB
{
    class Program
    {
        static void Main(string[] args)
        {
            AlunoCRUD crud = new AlunoCRUD();
            crud.Alterar(1, "Bulma", 32);
            //Console.Write("Informe a matrícula do aluno que deseja excluir: ");
            //crud.Excluir(int.Parse(Console.ReadLine()));
            //crud.Adicionar(1, "Hinata", 18);
            //crud.ConsultarTodos();
            //Console.Write("Insira a Matricula do Aluno que deseja consultar: ");
            //crud.ConsultarPorMatricula(int.Parse(Console.ReadLine()));

            /*Console.WriteLine("Hello World!");
            SqlConnection conexao = new SqlConnection();

            var connectionString = @"server=.\SQLexpress;initial catalog=ESCOLA;integrated security=true;";
            conexao.ConnectionString = connectionString;*/

            /*conexao.Open();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = conexao;

            sqlCommand.CommandText = @"INSERT ALUNO VALUES (1234, 'Jill', 35)";
            sqlCommand.ExecuteNonQuery();
            conexao.Close();*/

            /*conexao.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            Console.Write("Informe o Nome do Aluno que deseja Consultar: ");
            string nomeAluno = Console.ReadLine();
            comando.CommandText = @"SELECT * FROM ALUNO WHERE NOME = '" + nomeAluno + "'";

            while (leitor.Read())
            {
                var matricula = leitor["MATRICULA"];
                var nome = leitor["NOME"];
                var idade = leitor["IDADE"];

                Console.WriteLine($"Matricula: {matricula} - Nome: {nome} - Idade: {idade}");
            }
            conexao.Close();*/

            /*conexao.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            Console.Write("Informe o Nome do Aluno que deseja Consultar: ");
            string nomeAluno = Console.ReadLine();

            Console.Write("Informe a Idade do Aluno que deseja Consultar: ");
            int idadeAluno = int.Parse(Console.ReadLine());
            comando.CommandText = @"SELECT * FROM ALUNO WHERE NOME = @NOME AND IDADE = @IDADE;";
            SqlParameter parametro = new SqlParameter();
            comando.Parameters.AddWithValue("@Nome", nomeAluno);
            comando.Parameters.AddWithValue("@Idade", idadeAluno);
            SqlDataReader leitor = comando.ExecuteReader();

            while (leitor.Read())
            {
                var matricula = leitor["MATRICULA"];
                var nome = leitor["NOME"];
                var idade = leitor["IDADE"];

                Console.WriteLine($"Matricula: {matricula} - Nome: {nome} - Idade: {idade}");
            }
            conexao.Close();*/
        }
    }
}

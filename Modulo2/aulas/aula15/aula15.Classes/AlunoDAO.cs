using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace aula15.Classes
{
    public class AlunoDAO
    {
        static SqlConnection _conexao = new SqlConnection();
        private const string stringConexao = @"server=.\SQLexpress;initial catalog=ESCOLA;integrated security=true;";
        public AlunoDAO()
        {
            _conexao.ConnectionString = stringConexao;
        }

        public void Adicionar(Aluno aluno)
        {
            AbrirConexao();
            SqlCommand command = new SqlCommand("insert into Aluno values (@Matricula, @Nome, @Idade);",_conexao);
            ConverterEntidadeParaSqlCommandParametros(command, aluno);
            command.ExecuteNonQuery();
            FecharConexao();
        }

        public void Editar(Aluno aluno)
        {
            AbrirConexao();
            SqlCommand command = new SqlCommand("update Aluno set Nome = @Nome, Idade = @Idade where Matricula = @Matricula;", _conexao);
            ConverterEntidadeParaSqlCommandParametros(command, aluno);
            command.ExecuteNonQuery();
            FecharConexao();
        }

        

        public void Excluir(int matricula)
        {
            AbrirConexao();
            SqlCommand command = new SqlCommand("delete from Aluno where Matricula = @Matricula;", _conexao);
            command.Parameters.AddWithValue("@Matricula", matricula);
            command.ExecuteNonQuery();
            FecharConexao();
        }

        public Aluno ConsultarPorMatricula(int matricula)
        {
            Aluno aluno = null;
            AbrirConexao();
            SqlCommand command = new SqlCommand("SELECT Matricula, Nome, Idade FROM Aluno WHERE Matricula = @Matricula;", _conexao);
            command.Parameters.AddWithValue("@Matricula", matricula);
            SqlDataReader dados = command.ExecuteReader();
            while (dados.Read())
            {
                aluno = ConverterSqlDataReaderParaEntidades(dados);
            }
            FecharConexao();
            return aluno;
        }

        public List<Aluno> ConsultarTodos()
        {
            List<Aluno> alunos = new List<Aluno>();
            AbrirConexao();
            SqlCommand command = new SqlCommand("select Matricula, Nome, Idade FROM Aluno", _conexao);
            SqlDataReader dados = command.ExecuteReader();
            while (dados.Read())
            {
                Aluno aluno = ConverterSqlDataReaderParaEntidades(dados);
                alunos.Add(aluno);
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

        private void ConverterEntidadeParaSqlCommandParametros (SqlCommand command, Aluno aluno)
        {
            command.Parameters.AddWithValue("@Matricula", aluno.Matricula);
            command.Parameters.AddWithValue("@Nome", aluno.Nome);
            command.Parameters.AddWithValue("@Idade", aluno.Idade);
        }

        public Aluno ConverterSqlDataReaderParaEntidades(SqlDataReader dados)
        {
            Aluno aluno = new Aluno{
                Matricula = Convert.ToInt32(dados["Matricula"])
                ,
                Nome = dados["Nome"].ToString()
                ,
                Idade = Convert.ToInt32(dados["Idade"])
            };
            return aluno;
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
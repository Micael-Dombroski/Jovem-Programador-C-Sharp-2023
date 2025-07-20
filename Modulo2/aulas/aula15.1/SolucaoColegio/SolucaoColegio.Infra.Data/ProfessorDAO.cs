using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SolucaoColegio.Domain;
using System.Data.SqlClient;

namespace SolucaoColegio.Infra.Data
{
    public class ProfessorDAO
    {
        static SqlConnection _conexao = new SqlConnection();
        private const string stringConexao = @"server=.\SQLexpress;initial catalog=ESCOLA;integrated security=true;";
        public ProfessorDAO()
        {
            _conexao.ConnectionString = stringConexao;
        }

        public void Adicionar(Professor professor)
        {
            AbrirConexao();
            SqlCommand command = new SqlCommand("insert into Professor values (@Matricula, @Nome, @Data_Nascimento, @Rua, @Numero, @Bairro, @Cidade, @UF);",_conexao);
            ConverterEntidadeParaSqlCommandParametros(command, professor);
            command.ExecuteNonQuery();
            FecharConexao();
        }

        public void Editar(Professor professor)
        {
            AbrirConexao();
            SqlCommand command = new SqlCommand("update Professor set Nome = @Nome, Data_Nascimento = @Data_Nascimento, Rua = @Rua, Numero = @Numero, Bairro = @Bairro, Cidade = @Cidade, UF = @UF where Matricula = @Matricula;", _conexao);
            ConverterEntidadeParaSqlCommandParametros(command, professor);
            command.ExecuteNonQuery();
            FecharConexao();
        }

        

        public void Excluir(int matricula)
        {
            AbrirConexao();
            SqlCommand command = new SqlCommand("delete from Professor where Matricula = @Matricula;", _conexao);
            command.Parameters.AddWithValue("@Matricula", matricula);
            command.ExecuteNonQuery();
            FecharConexao();
        }

        public Professor ConsultarPorMatricula(int matricula)
        {
            Professor professor = null;
            AbrirConexao();
            SqlCommand command = new SqlCommand("SELECT Matricula, Nome, Data_Nascimento, Rua, Numero, Bairro, Cidade, UF FROM Professor WHERE Matricula = @Matricula;", _conexao);
            command.Parameters.AddWithValue("@Matricula", matricula);
            SqlDataReader dados = command.ExecuteReader();
            while (dados.Read())
            {
                professor = ConverterSqlDataReaderParaEntidades(dados);
            }
            FecharConexao();
            return professor;
        }

        public List<Professor> ConsultarTodos()
        {
            List<Professor> professores = new List<Professor>();
            AbrirConexao();
            SqlCommand command = new SqlCommand("select Matricula, Nome, Data_Nascimento, Rua, Numero, Bairro, Cidade, UF FROM Professor", _conexao);
            SqlDataReader dados = command.ExecuteReader();
            while (dados.Read())
            {
                Professor professor = ConverterSqlDataReaderParaEntidades(dados);
                professores.Add(professor);
            }
            FecharConexao();
            if (professores.Count == 0)
            {
                return null;
            }
            else
            {
                return professores;
            }
        }

        private void ConverterEntidadeParaSqlCommandParametros (SqlCommand command, Professor professor)
        {
            command.Parameters.AddWithValue("@Matricula", professor.Matricula);
            command.Parameters.AddWithValue("@Nome", professor.Nome);
            command.Parameters.AddWithValue("@Data_Nascimento", professor.DataNascimento);
            command.Parameters.AddWithValue("@Rua", professor.EnderecoMoradia.Rua);
            command.Parameters.AddWithValue("@Numero", professor.EnderecoMoradia.Numero);
            command.Parameters.AddWithValue("@Bairro", professor.EnderecoMoradia.Bairro);
            command.Parameters.AddWithValue("@Cidade", professor.EnderecoMoradia.Cidade);
            command.Parameters.AddWithValue("@UF", professor.EnderecoMoradia.UF);
        }

        public Professor ConverterSqlDataReaderParaEntidades(SqlDataReader dados)
        {
            Professor professor = new Professor{
                Matricula = Convert.ToInt32(dados["Matricula"]),
                Nome = dados["Nome"].ToString(),
                DataNascimento = Convert.ToDateTime(dados["Data_Nascimento"]),
                EnderecoMoradia = new Endereco
                {
                    Rua = dados["Rua"].ToString(),
                    Numero = Convert.ToInt32(dados["Numero"]),
                    Bairro = dados["Bairro"].ToString(),
                    Cidade = dados["Cidade"].ToString(),
                    UF = dados["UF"].ToString()
                }

            };
            return professor;
        }

        public List<Professor> ConsultarTodosSemEndereco()
        {
            List<Professor> professores = new List<Professor>();
            AbrirConexao();
            SqlCommand command = new SqlCommand("select Matricula, Nome, Data_Nascimento FROM Professor", _conexao);
            SqlDataReader dados = command.ExecuteReader();
            while (dados.Read())
            {
                Professor professor = ConverterSqlDataReaderParaEntidadeSemEndereco(dados);
                professores.Add(professor);
            }
            FecharConexao();
            if (professores.Count == 0)
            {
                return null;
            }
            else
            {
                return professores;
            }
        }

        private Professor ConverterSqlDataReaderParaEntidadeSemEndereco(SqlDataReader dados)
        {
            Professor professor = new Professor();
            professor.Matricula = Convert.ToInt32(dados["MATRICULA"]);
            professor.Nome = dados["NOME"].ToString();
            professor.DataNascimento = Convert.ToDateTime(dados["DATA_NASCIMENTO"]);
            return professor;
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
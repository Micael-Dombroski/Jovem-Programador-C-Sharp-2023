using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SolucaoColegio.Domain.Entidades;
using System.Data.SqlClient;

namespace SolucaoColegio.Infra.Data.DAO
{
    public class MateriaCursadaDAO
    {
        static SqlConnection _conexao = new SqlConnection();
        private const string stringConexao = @"server=.\SQLexpress;initial catalog=ESCOLA;integrated security=true;";
        public MateriaCursadaDAO()
        {
            _conexao.ConnectionString = stringConexao;
        }

        public void Adicionar(MateriaCursada materiaCursada)
        {
            using (var conexao = new SqlConnection(stringConexao))
            {
                conexao.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = conexao;
                    command.CommandText = @"insert into Materia_Cursada (Matricula_Aluno, Materia_Id, Nota) values (@Matricula_Aluno, @Materia_Id, @Nota);";
                    ConverterEntidadeParaSqlCommandParametros(command, materiaCursada);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void Editar(MateriaCursada materiaCursada)
        {
            using (var conexao = new SqlConnection(stringConexao))
            {
                conexao.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = conexao;
                    command.CommandText = @"update Materia_Cursada set Matricula_Aluno = @Matricula_Aluno, Materia_Id = @Materia_Id, Nota = @Nota 
                                            where Id = @Id;";
                    ConverterEntidadeParaSqlCommandParametros(command, materiaCursada);
                    command.Parameters.AddWithValue("@Id", materiaCursada.Id);
                    command.ExecuteNonQuery();
                }
            }
        }

        

        public void Excluir(int id)
        {
            using (var conexao = new SqlConnection(stringConexao))
            {
                conexao.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = conexao;
                    command.CommandText = @"delete from Materia_Cursada where Id = @Id;";
                    command.Parameters.AddWithValue("@Id", id);
                    command.ExecuteNonQuery();
                }
            }
        }

        public MateriaCursada ConsultarPorId(int id)
        {
            MateriaCursada materiaCursada = null;
            using (var conexao = new SqlConnection(stringConexao))
            {
                conexao.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = conexao;
                    command.CommandText = @"SELECT B.Id, C.id, C.nome, C.quantidade_aulas, B.nota from  Materia_Cursada B
                                            INNER JOIN Materia C ON (B.materia_id = C.id) WHERE B.matricula_aluno = ;";
                    command.Parameters.AddWithValue("@Id", id);
                    SqlDataReader dados = command.ExecuteReader();
                    while (dados.Read())
                    {
                        materiaCursada = ConverterSqlDataReaderParaEntidades(dados);
                    }
                }
            }
            return materiaCursada;
        }

        public List<MateriaCursada> ConsultarPorAluno(Aluno aluno)
        {
            List<MateriaCursada> materiasCursadas = new List<MateriaCursada>();
            using (var conexao = new SqlConnection(stringConexao))
            {
                conexao.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = conexao;
                    command.CommandText = @"select B.Id, C.id as Materia_ID, C.nome as Materia_Nome, C.quantidade_aulas, B.nota from  Materia_Cursada B
                                            INNER JOIN Materia C ON (B.materia_id = C.id) 
                                            WHERE B.matricula_aluno = @Matricula_Aluno;";
                    command.Parameters.AddWithValue("@Matricula_Aluno", aluno.Matricula);
                    SqlDataReader dados = command.ExecuteReader();
                    while (dados.Read())
                    {
                        var materiaCursada = ConverterSqlDataReaderParaEntidades(dados, aluno);
                        materiasCursadas.Add(materiaCursada);
                    }
                }
            }
            if (materiasCursadas.Count == 0)
            {
                return null;
            }
            return materiasCursadas;
        }

        public List<MateriaCursada> ConsultarPorMateria(Materia materia)
        {
            List<MateriaCursada> materiasCursadas = new List<MateriaCursada>();
            using (var conexao = new SqlConnection(stringConexao))
            {
                conexao.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = conexao;
                    command.CommandText = @"select B.Id, A.Matricula, A.Nome as Aluno_Nome, A.Idade,  B.nota from ALUNO A 
                                            INNER JOIN Materia_Cursada B ON (A.Matricula = B.matricula_aluno)
                                            WHERE B.Materia_Id = @Materia_Id;";
                    command.Parameters.AddWithValue("@Materia_Id", materia.Id);
                    SqlDataReader dados = command.ExecuteReader();
                    while (dados.Read())
                    {
                        var materiaCursada = ConverterSqlDataReaderParaEntidades(dados, materia);
                        materiasCursadas.Add(materiaCursada);
                    }
                }
            }
            if (materiasCursadas.Count == 0)
            {
                return null;
            }
            return materiasCursadas;
        }

        public List<MateriaCursada> ConsultarTodos()
        {
            List<MateriaCursada> materiasCursadas = new List<MateriaCursada>();
            using (var conexao = new SqlConnection(stringConexao))
            {
                conexao.Open();
                using (var command =  new SqlCommand(
                    @"SELECT B.Id, A.Matricula, A.Nome as Aluno_Nome, A.Idade, C.id as Materia_Id, C.nome as Materia_Nome, C.quantidade_aulas, B.nota 
                    FROM ALUNO A 
                    INNER JOIN Materia_Cursada B ON (A.Matricula = B.matricula_aluno)
                    INNER JOIN Materia C ON (B.materia_id = C.id)"
                    , conexao
                ))
                {
                    SqlDataReader dados = command.ExecuteReader();
                    while (dados.Read())
                    {
                        MateriaCursada materiaCursada = ConverterSqlDataReaderParaEntidades(dados);
                        materiasCursadas.Add(materiaCursada);
                    }
                }
            }
            if (materiasCursadas.Count == 0)
            {
                return null;
            }
            else
            {
                return materiasCursadas;
            }
        }

        private void ConverterEntidadeParaSqlCommandParametros (SqlCommand command, MateriaCursada materiaCursada)
        {
            command.Parameters.AddWithValue("@Matricula_Aluno", materiaCursada.AlunoCursando.Matricula);
            command.Parameters.AddWithValue("@Materia_Id", materiaCursada.MateriaSendoCursada.Id);
            command.Parameters.AddWithValue("@Nota", materiaCursada.Nota);
        }

        private MateriaCursada ConverterSqlDataReaderParaEntidades(SqlDataReader dados)
        {
            MateriaCursada materiaCursada = new MateriaCursada();
            Aluno alunoCursando = new Aluno();
            Materia materiaSendoCursada = new Materia();
            materiaCursada.Id = Convert.ToInt32(dados["Id"]);
            alunoCursando.Matricula = Convert.ToInt32(dados["Matricula"]);
            alunoCursando.Nome = dados["Aluno_Nome"].ToString();
            alunoCursando.Idade = Convert.ToInt32(dados["Idade"]);;
            materiaCursada.AlunoCursando = alunoCursando;
            materiaSendoCursada.Id = Convert.ToInt32(dados["Materia_Id"]);
            materiaSendoCursada.QuantidadeAula = Convert.ToInt32(dados["Quantidade_Aulas"]);
            materiaSendoCursada.Nome = dados["Materia_Nome"].ToString();
            materiaCursada.MateriaSendoCursada = materiaSendoCursada;
            if (dados["Nota"] != DBNull.Value)
            {
                materiaCursada.Nota = Convert.ToDouble(dados["Nota"]);
            }
            return materiaCursada;
        }

        private MateriaCursada ConverterSqlDataReaderParaEntidades(SqlDataReader dados, Aluno aluno)
        {
            MateriaCursada materiaCursada = new MateriaCursada();
            Materia materiaSendoCursada = new Materia();
            materiaCursada.Id = Convert.ToInt32(dados["Id"]);
            materiaCursada.AlunoCursando = aluno;
            materiaSendoCursada.Id = Convert.ToInt32(dados["Materia_ID"]);
            materiaSendoCursada.QuantidadeAula = Convert.ToInt32(dados["Quantidade_Aulas"]);
            materiaSendoCursada.Nome = dados["Materia_Nome"].ToString();
            materiaCursada.MateriaSendoCursada = materiaSendoCursada;
            if (dados["Nota"] != DBNull.Value)
            {
                materiaCursada.Nota = Convert.ToDouble(dados["Nota"]);
            }
            return materiaCursada;
        }

        private MateriaCursada ConverterSqlDataReaderParaEntidades(SqlDataReader dados, Materia materia)
        {
            MateriaCursada materiaCursada = new MateriaCursada();
            Aluno alunoCursando = new Aluno();
            Materia materiaSendoCursada = new Materia();
            materiaCursada.Id = Convert.ToInt32(dados["Id"]);
            alunoCursando.Matricula = Convert.ToInt32(dados["Matricula"]);
            alunoCursando.Nome = dados["Aluno_Nome"].ToString();
            alunoCursando.Idade = Convert.ToInt32(dados["Idade"]);;
            materiaCursada.AlunoCursando = alunoCursando;
            materiaCursada.MateriaSendoCursada = materia;
            if (dados["Nota"] != DBNull.Value)
            {
                materiaCursada.Nota = Convert.ToDouble(dados["Nota"]);
            }
            return materiaCursada;
        }
    }
}
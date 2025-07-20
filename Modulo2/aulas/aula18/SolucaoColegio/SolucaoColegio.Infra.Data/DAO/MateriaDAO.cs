using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SolucaoColegio.Domain.Entidades;
using System.Data.SqlClient;

namespace SolucaoColegio.Infra.Data.DAO
{
    public class MateriaDAO
    {
        static SqlConnection _conexao = new SqlConnection();
        private const string stringConexao = @"server=.\SQLexpress;initial catalog=ESCOLA;integrated security=true;";
        public MateriaDAO()
        {
            _conexao.ConnectionString = stringConexao;
        }

        public void Adicionar(Materia materia)
        {
            AbrirConexao();
            SqlCommand command = new SqlCommand("insert into Materia values (@Nome, @quantidade_aulas);",_conexao);
            ConverterEntidadeParaSqlCommandParametros(command, materia);
            command.ExecuteNonQuery();
            FecharConexao();
        }

        public void Editar(Materia materia)
        {
            AbrirConexao();
            SqlCommand command = new SqlCommand("update Materia set Nome = @Nome, quantidade_aulas = @quantidade_aulas where Id = @Id;", _conexao);
            ConverterEntidadeParaSqlCommandParametros(command, materia);
            command.Parameters.AddWithValue("@Id", materia.Id);
            command.ExecuteNonQuery();
            FecharConexao();
        }

        

        public void Excluir(int id)
        {
            AbrirConexao();
            SqlCommand command = new SqlCommand("delete from Materia where Id = @Id;", _conexao);
            command.Parameters.AddWithValue("@Id", id);
            command.ExecuteNonQuery();
            FecharConexao();
        }

        public Materia ConsultarPorId(int id)
        {
            Materia materia = null;
            using (var conexao = new SqlConnection(stringConexao))
            {
                conexao.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = conexao;
                    command.CommandText = "SELECT Id, Nome, quantidade_aulas FROM Materia WHERE Id = @Id;";
                    command.Parameters.AddWithValue("@Id", id);
                    SqlDataReader dados = command.ExecuteReader();
                    while (dados.Read())
                    {
                        materia = ConverterSqlDataReaderParaEntidades(dados);
                    }
                }
            }
            return materia;
        }

        public Materia ConsultarPorNome(string nome)
        {
            Materia materia = null;
            using (var conexao = new SqlConnection(stringConexao))
            {
                conexao.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = conexao;
                    command.CommandText = "SELECT Id, Nome, quantidade_aulas FROM Materia WHERE Nome Like @Nome;";
                    command.Parameters.AddWithValue("@Nome","%"+ nome + "%");
                    SqlDataReader dados = command.ExecuteReader();
                    while (dados.Read())
                    {
                        materia = ConverterSqlDataReaderParaEntidades(dados);
                    }
                }
            }
            return materia;
        }

        public List<Materia> ConsultarTodos()
        {
            List<Materia> materias = new List<Materia>();
            using (var conexao = new SqlConnection(stringConexao))
            {
                conexao.Open();
                using (var command =  new SqlCommand("select Id, Nome, quantidade_aulas FROM Materia", conexao))
                {
                    SqlDataReader dados = command.ExecuteReader();
                    while (dados.Read())
                    {
                        Materia materia = ConverterSqlDataReaderParaEntidades(dados);
                        materias.Add(materia);
                    }
                }
            }
            if (materias.Count == 0)
            {
                return null;
            }
            else
            {
                return materias;
            }
        }

        private void ConverterEntidadeParaSqlCommandParametros (SqlCommand command, Materia materia)
        {
            command.Parameters.AddWithValue("@Nome", materia.Nome);
            command.Parameters.AddWithValue("@quantidade_aulas", materia.QuantidadeAula);
        }

        private Materia ConverterSqlDataReaderParaEntidades(SqlDataReader dados)
        {
            Materia materia = new Materia{
                Id = Convert.ToInt32(dados["Id"])
                ,
                Nome = dados["Nome"].ToString()
                ,
                QuantidadeAula = Convert.ToInt32(dados["quantidade_aulas"])
            };
            return materia;
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
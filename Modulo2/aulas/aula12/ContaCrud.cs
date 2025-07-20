using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace aula12
{
    public class ContaCrud
    {
        SqlConnection _conexao;
        public ContaCrud()
        {
            _conexao= new SqlConnection();
            var stringContexao = @"server=.\sqlexpress;initial catalog=Banco1;integrated security=true;";
            _conexao.ConnectionString = stringContexao;
        }
        public void Adicionar()
        {
            AbriConexao();
            SqlCommand comandos = new SqlCommand();
            comandos.Connection = _conexao;
            comandos.CommandText = "insert into Conta(Agencia,Numero,Correntista) values (@Agencia,@Numero,@Correntista);";
            comandos.Parameters.AddWithValue("@Agencia",1);
            comandos.Parameters.AddWithValue("@Numero",4);
            comandos.Parameters.AddWithValue("@Correntista","Lucas");
            comandos.ExecuteNonQuery();
            FecharConexao();
        }
        public void Editar()
        {
            AbriConexao();
            SqlCommand comandos = new SqlCommand();
            comandos.Connection = _conexao;
            comandos.CommandText = "update Conta set Agencia = @Agencia, Numero = @Numero, Correntista = @Correntista where id=@Id;";
            comandos.Parameters.AddWithValue("@Agencia", 1);
            comandos.Parameters.AddWithValue("@Numero", 5);
            comandos.Parameters.AddWithValue("@Correntista", "Sherry");
            comandos.Parameters.AddWithValue("@Id", 3);
            comandos.ExecuteNonQuery();
            FecharConexao();
        }

        public void Excluir()
        {
            AbriConexao();
            SqlCommand comandos = new SqlCommand();
            comandos.Connection = _conexao;
            comandos.CommandText= "delete from Conta where id=@Id";
            comandos.Parameters.AddWithValue("@Id", 2);
            comandos.ExecuteNonQuery();
            FecharConexao();
        }

        public void ConsultarPorId()
        {
            AbriConexao();
            SqlCommand comandos = new SqlCommand();
            comandos.Connection = _conexao;
            comandos.CommandText = @"SELECT Id,Agencia,Numero,Correntista,Saldo
                FROM Conta where Id = @Id;";
            comandos.Parameters.AddWithValue("@Id",1);
            
            SqlDataReader dados = comandos.ExecuteReader();

            while (dados.Read())
            {
                var id = dados["Id"];
                var agencia = dados["Agencia"];
                var numero = dados["Numero"];
                var correntista = dados["Correntista"];
                Console.WriteLine($"Id: {id} - Agencia: {agencia} - Número: {numero} - Correntista: {correntista}");
            }
            FecharConexao();
        }
        private void AbriConexao()
        {
            _conexao.Open();
        }
        private void FecharConexao()
        {
            _conexao.Close();
        }
    }
}
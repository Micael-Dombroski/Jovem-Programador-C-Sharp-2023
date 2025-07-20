using System;
using System.Data.SqlClient;

namespace aula12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            ContaCrud contaCrud = new ContaCrud();
            //contaCrud.Adicionar();
            //contaCrud.Editar();
            //contaCrud.Excluir();
            contaCrud.ConsultarPorId();



            /*SqlConnection conexao = new SqlConnection();
            var stringContexao = @"server=.\sqlexpress;initial catalog=Banco1;integrated security=true;";
            conexao.ConnectionString = stringContexao;*/
            /*conexao.Open();
            SqlCommand comandos = new SqlCommand("insert into Conta(Agencia,Numero,Correntista) values (1,1,'Jill');", conexao);
            SqlCommand comandos = new SqlCommand();*/
            //comandos.Connection = conexao;
            //comandos.CommandText = "insert into Conta(Agencia,Numero,Correntista) values (1,3,'Roger');";
            //comandos.ExecuteNonQuery();
            /*comandos.CommandText = @"SELECT Id,Agencia,Numero,Correntista,Saldo
                FROM [Banco1].[dbo].[Conta]
                where Id = 2;;";*/
            
            /*string nome = "Jill";
            comandos.CommandText = @"SELECT Id,Agencia,Numero,Correntista,Saldo
                FROM Conta where Correntista = @Correntsita;";
            /*SqlParameter parametro01 = new SqlParameter();
            parametro01.ParamenterName = "@Correntista";
            parametro01.Value = nome;
            comandos.Parameters.Add(parametro01);*/
            //comandos.Parameters.AddWithValue("@Correntista", nome);//resume as 4 linhas de cima*/
            
            /*SqlDataReader dados = comandos.ExecuteReader();
            while (dados.Read())
            {
                var correntista = dados["Correntista"];
                Console.WriteLine($"Correntista: {correntista}");
            }
            conexao.Close();*/
            
        }
    }
}

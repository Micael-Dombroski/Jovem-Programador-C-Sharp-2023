using System;
using System.Data.SqlClient;

namespace exercicio01
{
    class Program
    {
        static string ler;
        static SqlConnection conexao = new SqlConnection();
        static void Main(string[] args)
        {
            //Parte 1

            var connectionString = @"server=.\SQLexpress;initial catalog=ESTOQUE;integrated security=true;";
            conexao.ConnectionString = connectionString;

            conexao.Open();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = conexao;

            sqlCommand.CommandText = @"INSERT PRODUTO VALUES ('Coquinha', 'Coca Cola', '2025-10-20', 7.50, 'L', 20),
            ('Achocolatado em Pó', 'Nescau', '2024-5-19', 18.00, 'Kg', 12), ('Margarina', 'Doriana', '2024-8-21', 12.50, 'Kg', 27), 
            ('Suco', 'Tang', '2023-10-5', 1.25, 'g', 50), ('Caldo de Galinha', 'Knor', '2024-6-8', 2.50, 'g', 25), 
            ('Linguicinha', 'Seara', '2023-9-19', 15.00, 'Kg', 17), ('Breja', 'Skol', '2025-4-12', 5.00, 'ML', 36),
            ('Pão Caseiro', 'Vó', '2023-8-25', 4.50, 'g', 7), ('Banana', 'Bananeira', '2023-9-23', 1.50, 'g', 20),
            ('Bala', 'Plutonita', '2023-09-30', 0.75, 'g', 67)";
            sqlCommand.ExecuteNonQuery();
            conexao.Close();

            conexao.Open();
            sqlCommand = new SqlCommand();
            sqlCommand.Connection = conexao;

            sqlCommand.CommandText = @"UPDATE PRODUTO SET Nome = 'Coca', Marca = 'Coca-Cola' WHERE Nome = 'Coquinha'";
            sqlCommand.ExecuteNonQuery();

            sqlCommand.CommandText = @"UPDATE PRODUTO SET Nome = 'Cerveja', PrecoUnitario = 1.95 WHERE Nome = 'Breja'";
            sqlCommand.ExecuteNonQuery();

            sqlCommand.CommandText = @"UPDATE PRODUTO SET Nome = 'Chiclete' WHERE Nome = 'Bala'";
            sqlCommand.ExecuteNonQuery();

            sqlCommand.CommandText = @"UPDATE PRODUTO SET Nome = 'Linguiça', Marca = 'Perdigao', PrecoUnitario = '14.50' WHERE Nome = 'Linguicinha'";
            sqlCommand.ExecuteNonQuery();

            sqlCommand.CommandText = @"UPDATE PRODUTO SET DataVencimento = '2024-5-20' WHERE Nome = 'Margarina'";
            sqlCommand.ExecuteNonQuery();

            sqlCommand.CommandText = @"UPDATE PRODUTO SET Nome = 'Achocolatado', PrecoUnitario = 7.50, Unidade = 'ML' WHERE Marca = 'Nescau'";
            sqlCommand.ExecuteNonQuery();
            conexao.Close();

            conexao.Open();
            sqlCommand = new SqlCommand();
            sqlCommand.Connection = conexao;
            
            sqlCommand.CommandText = @"DELETE FROM PRODUTO WHERE Nome IS NOT NULL";
            sqlCommand.ExecuteNonQuery();

            conexao.Close();

            //Parte 2
            do
            {
                Console.Clear();
                Console.WriteLine("====================");
                Console.WriteLine("  Menu de Produtos  ");
                Console.WriteLine("====================");
                Console.WriteLine("[1] Cadastrar");
                Console.WriteLine("[2] Listar");
                Console.WriteLine("[3] Excluir");
                Console.WriteLine("[4] Sair");
                Resposta();
                switch (ler)
                {
                    case "1":
                        Cadastrar();
                        break;
                    case "2":
                        Listar();
                        break;
                    case "3":
                        Excluir();
                        break;
                    case "4":
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("[3RR0R] Opção Inválida");
                        break;
                }
            } while (ler.ToLower() != "4");
        }
        static void Resposta()
        {
            Console.Write("=> ");
            ler=Console.ReadLine();
        }
        static void Cadastrar()
        {
            Console.WriteLine("Informe o Nome do Produto que deseja cadastrar:");
            Resposta();
            string nome = ler;
            Console.WriteLine("Informe a Marca do Produto:");
            Resposta();
            string marca = ler;
            Console.WriteLine("Informe a Data de Vencimento do Produto (Ano-Mês-Dia):");
            Resposta();
            var vencimento = ler;
            Console.WriteLine("Informe o Valor Unitário do Produto (Ex: 123.45):");
            Resposta();
            string valorUnit = ler;
            Console.WriteLine("Informe a Unidade desse Produto (Ex: Kg): ");
            Resposta();
            string unidade = ler;
            Console.WriteLine("Informe a Quantidade desse Produto em Estoque:");
            Resposta();
            int qtEstoque = Convert.ToInt32(ler);

            var connectionString = @"server=.\SQLexpress;initial catalog=ESTOQUE;integrated security=true;";
            conexao.ConnectionString = connectionString;
            conexao.Open();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = conexao;

            sqlCommand.CommandText= @"INSERT PRODUTO VALUES ('" + nome + "', '" + marca + "', '" + vencimento + "', " + valorUnit + ", '" + unidade + "', " + qtEstoque + ")";

            sqlCommand.ExecuteNonQuery();
            conexao.Close();
        }
        static void Listar()
        {
            var connectionString = @"server=.\SQLexpress;initial catalog=ESTOQUE;integrated security=true;";
            conexao.ConnectionString = connectionString;
            conexao.Open();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = conexao;
            sqlCommand.CommandText= @"SELECT * FROM PRODUTO";
            SqlDataReader leitor = sqlCommand.ExecuteReader();
            while (leitor.Read())
            {
                var nome = leitor["Nome"];
                var marca = leitor["Marca"];
                var dataVencimento = leitor["DataVencimento"];
                var precoUnitario = leitor["PrecoUnitario"];
                var unidade = leitor["Unidade"];
                var qtEstoque = leitor["QtEstoque"];
                Console.WriteLine("------------------------- Lista de Produtos -------------------------");
                Console.WriteLine($"Nome: {nome} - Marca: {marca} - Data de Vencimento: {dataVencimento} - Preço Unitário: {precoUnitario} - Unidade: {unidade} - Quantidade em Estoque: {qtEstoque}");
            }
            conexao.Close();
            Console.WriteLine("\n Pressione Qualquer tecla para voltar ao Menu Principal");
            Console.ReadLine();
        }
        static void Excluir()
        {
            Console.WriteLine("Informe o Nome do Produto que deseja excluir:");
            Resposta();
            string nome = ler;
            var connectionString = @"server=.\SQLexpress;initial catalog=ESTOQUE;integrated security=true;";
            conexao.ConnectionString = connectionString;

            conexao.Open();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = conexao;
            
            sqlCommand.CommandText = @$"DELETE FROM PRODUTO WHERE Nome = '{nome}'";
            sqlCommand.ExecuteNonQuery();

            conexao.Close();
        }
    }
}

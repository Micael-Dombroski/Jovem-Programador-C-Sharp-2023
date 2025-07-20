using System;
using System.Data.SqlClient;

namespace exercicio01
{
    class Program
    {
        static string ler;
        static string connectionString = @"server=.\SQLexpress;initial catalog=ESTOQUE;integrated security=true;";
        static SqlConnection conexao = new SqlConnection();
        static void Main(string[] args)
        {
            conexao.ConnectionString = connectionString;
            //Adicionando uns produtos para agilizar o processo
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

            do
            {
                Console.Clear();
                Console.WriteLine("====================");
                Console.WriteLine("  Menu de Produtos  ");
                Console.WriteLine("====================");
                Console.WriteLine("[1] Cadastrar");
                Console.WriteLine("[2] Consultar");
                Console.WriteLine("[3] Listar");
                Console.WriteLine("[4] Excluir");
                Console.WriteLine("[5] Sair");
                Resposta();
                switch (ler)
                {
                    case "1":
                        Cadastrar();
                        break;
                    case "2":
                        Consultar();
                        break;
                    case "3":
                        Listar();
                        break;
                    case "4":
                        Excluir();
                        break;
                    case "5":
                        Console.WriteLine("Saindo...");
                        //Deletando aqui para não ficar cadastrando os produtos sempre que executar
                        conexao.Open();
                        sqlCommand = new SqlCommand();
                        sqlCommand.Connection = conexao;

                        sqlCommand.CommandText = @$"DELETE PRODUTO WHERE NOME IS NOT NULL";

                        sqlCommand.ExecuteNonQuery();
                        conexao.Close();
                        break;
                    default:
                        Console.WriteLine("[3RR0R] Opção Inválida");
                        break;
                }
            } while (ler.ToLower() != "5");
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
            string vencimento = ler;
            Console.WriteLine("Informe o Valor Unitário do Produto (Ex: 123.45):");
            Resposta();
            string valorUnit = ler;
            Console.WriteLine("Informe a Unidade desse Produto (Ex: Kg): ");
            Resposta();
            string unidade = ler;
            Console.WriteLine("Informe a Quantidade desse Produto em Estoque:");
            Resposta();
            int qtEstoque = int.Parse(ler);

            conexao.ConnectionString = connectionString;
            conexao.Open();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = conexao;

            sqlCommand.CommandText = @$"INSERT PRODUTO VALUES ('{nome}', '{marca}', '{vencimento}', {valorUnit}, '{unidade}', {qtEstoque})";

            sqlCommand.ExecuteNonQuery();
            conexao.Close();
        }

        static void Consultar()
        {
            Console.WriteLine("Informe o Nome do Produto que deseja Consultar: ");
            Resposta();
            string Nome = ler;
            Console.WriteLine("Informe a Marca do Produto que deseja Consultar: ");
            Resposta();
            string Marca = ler;
            conexao.ConnectionString = connectionString;
            conexao.Open();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = conexao;
            sqlCommand.CommandText= @"SELECT * FROM PRODUTO WHERE NOME = '" + Nome + "' AND MARCA = '" + Marca + "'";
            SqlDataReader leitor = sqlCommand.ExecuteReader();
            Console.WriteLine("------------------------- Consulta de Produto -------------------------");
            while (leitor.Read())
            {
                var nome = leitor["Nome"];
                var marca = leitor["Marca"];
                var dataVencimento = leitor["DataVencimento"];
                var precoUnitario = leitor["PrecoUnitario"];
                var unidade = leitor["Unidade"];
                var qtEstoque = leitor["QtEstoque"];
                Console.WriteLine($"Nome: {nome} - Marca: {marca} - Data de Vencimento: {dataVencimento} - Preço Unitário: {precoUnitario} - Unidade: {unidade} - Quantidade em Estoque: {qtEstoque}");
            }
            conexao.Close();
            Console.WriteLine("\n Pressione Qualquer tecla para voltar ao Menu Principal");
            Console.ReadLine();

        }

        static void Listar()
        {
            Console.WriteLine("Você deseja lista:");
            Console.WriteLine("[1] Todos os Produtos");
            Console.WriteLine("[2] Todos os Produtos acima de R$9,99");
            Console.WriteLine("[3] Todos os Produtos Vencidos");
            Resposta();
            switch (ler)
            {
                case "1":
                    ListarTodosOsProdutos();
                    break;
                case "2":
                    ListarTodosOsProdutosDe10ReaisOuMais();
                    break;
                case "3":
                    ListarTodosOsProdutosVencidos();
                    break;
                default:
                    Console.WriteLine("Opção Inválida");
                    break;
            }
        }
        static void ListarTodosOsProdutos()
        {
            conexao.ConnectionString = connectionString;
            conexao.Open();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = conexao;
            sqlCommand.CommandText= @"SELECT * FROM PRODUTO";
            SqlDataReader leitor = sqlCommand.ExecuteReader();
            Console.WriteLine("------------------------- Lista de Produtos -------------------------");
            while (leitor.Read())
            {
                var nome = leitor["Nome"];
                var marca = leitor["Marca"];
                var dataVencimento = leitor["DataVencimento"];
                var precoUnitario = leitor["PrecoUnitario"];
                var unidade = leitor["Unidade"];
                var qtEstoque = leitor["QtEstoque"];
                Console.WriteLine($"Nome: {nome} - Marca: {marca} - Data de Vencimento: {dataVencimento} - Preço Unitário: {precoUnitario} - Unidade: {unidade} - Quantidade em Estoque: {qtEstoque}");
            }
            conexao.Close();
            Console.WriteLine("\n Pressione Qualquer tecla para voltar ao Menu Principal");
            Console.ReadLine();
        }

        static void ListarTodosOsProdutosDe10ReaisOuMais()
        {
            conexao.ConnectionString = connectionString;
            conexao.Open();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = conexao;
            sqlCommand.CommandText= @"SELECT * FROM PRODUTO WHERE PrecoUnitario > 9.99";
            SqlDataReader leitor = sqlCommand.ExecuteReader();
            Console.WriteLine("------------------------- Lista de Produtos -------------------------");
            while (leitor.Read())
            {
                var nome = leitor["Nome"];
                var marca = leitor["Marca"];
                var dataVencimento = leitor["DataVencimento"];
                var precoUnitario = leitor["PrecoUnitario"];
                var unidade = leitor["Unidade"];
                var qtEstoque = leitor["QtEstoque"];
                Console.WriteLine($"Nome: {nome} - Marca: {marca} - Data de Vencimento: {dataVencimento} - Preço Unitário: {precoUnitario} - Unidade: {unidade} - Quantidade em Estoque: {qtEstoque}");
            }
            conexao.Close();
            Console.WriteLine("\n Pressione Qualquer tecla para voltar ao Menu Principal");
            Console.ReadLine();
        }

        static void ListarTodosOsProdutosVencidos()
        {
            conexao.ConnectionString = connectionString;
            conexao.Open();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = conexao;
            sqlCommand.CommandText= @$"SELECT * FROM PRODUTO WHERE DataVencimento < GetDate()";
            SqlDataReader leitor = sqlCommand.ExecuteReader();
            Console.WriteLine("------------------------- Lista de Produtos -------------------------");
            while (leitor.Read())
            {
                var nome = leitor["Nome"];
                var marca = leitor["Marca"];
                var dataVencimento = leitor["DataVencimento"];
                var precoUnitario = leitor["PrecoUnitario"];
                var unidade = leitor["Unidade"];
                var qtEstoque = leitor["QtEstoque"];
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

using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace exercicio02
{
    class Program
    {
        static string ler;
        static string connectionString = @"server=.\SQLexpress;initial catalog=ESTOQUE;integrated security=true;";
        static SqlConnection conexao = new SqlConnection();
        static ProdutoCRUD crud = new ProdutoCRUD();
        static void Main(string[] args)
        {
            conexao.ConnectionString = connectionString;
            //Adicionando uns produtos para agilizar o processo
            conexao.Open();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = conexao;
            /*
            sqlCommand.CommandText = @"INSERT PRODUTO VALUES ('Coquinha', 'Coca Cola', '2025-10-20', 7.50, 'L', 20),
            ('Achocolatado em Pó', 'Nescau', '2024-5-19', 18.00, 'Kg', 12), ('Margarina', 'Doriana', '2024-8-21', 12.50, 'Kg', 27), 
            ('Suco', 'Tang', '2023-10-5', 1.25, 'g', 50), ('Caldo de Galinha', 'Knor', '2024-6-8', 2.50, 'g', 25), 
            ('Linguicinha', 'Seara', '2023-9-19', 15.00, 'Kg', 17), ('Breja', 'Skol', '2025-4-12', 5.00, 'ML', 36),
            ('Pão Caseiro', 'Vó', '2023-8-25', 4.50, 'g', 7), ('Banana', 'Bananeira', '2023-9-23', 1.50, 'g', 20),
            ('Bala', 'Plutonita', '2023-09-30', 0.75, 'g', 67)";
            sqlCommand.ExecuteNonQuery();*/
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
                Console.WriteLine("[4] Editar");
                Console.WriteLine("[5] Excluir");
                Console.WriteLine("[6] Sair");
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
                        Editar();
                        break;
                    case "5":
                        Excluir();
                        break;
                    case "6":
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
            } while (ler.ToLower() != "6");
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
            crud.Adicionar(nome, marca, vencimento, valorUnit, unidade, qtEstoque);
        }

        static void Consultar()
        {
            Console.WriteLine("Informe o Nome do Produto que deseja Consultar: ");
            Resposta();
            string Nome = ler;
            Console.WriteLine("Informe a Marca do Produto que deseja Consultar: ");
            Resposta();
            string Marca = ler;
            if (crud.ConsultarPorNomeEMarca(Nome, Marca) == null)
            {
                Console.WriteLine("[3RR0R] Produto Não Encontrado");
            }
            else
            {
                Console.WriteLine(crud.ConsultarPorNomeEMarca(Nome, Marca));
            }
            Console.WriteLine("\n Pressione Qualquer tecla para voltar ao Menu Principal");
            Console.ReadLine();

        }

        static void Listar()
        {
            if (crud.ConsultarTodos() == null)
            {
                Console.WriteLine("[3RR0R] Não Há Nenhum Produto Cadastrado");
            }
            else
            {
                Console.WriteLine("------------------------- Lista de Produtos -------------------------");
                foreach (var item in crud.ConsultarTodos())
                {
                    Console.WriteLine(item);
                }
            }
            Console.WriteLine("\n Pressione Qualquer tecla para voltar ao Menu Principal");
            Console.ReadLine();
        }
        static void Editar()
        {
            Console.WriteLine("Informe o Nome do Produto que deseja editar:");
            Resposta();
            string nome = ler;
            Console.WriteLine("Informe a Marca do Produto que deseja editar:");
            Resposta();
            string marca = ler;
            if (crud.ConsultarPorNomeEMarca(nome, marca) == null)
            {
                Console.WriteLine("[3RR0R] Produto Não Encontrado");
                Console.WriteLine("\n Pressione Qualquer tecla para voltar ao Menu Principal");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Informe a Nova Data de Vencimento do Produto (Ano-Mês-Dia):");
                Resposta();
                string vencimento = ler;
                Console.WriteLine("Informe o Novo Valor Unitário do Produto (Ex: 123.45):");
                Resposta();
                string valorUnit = ler;
                Console.WriteLine("Informe a Nova Unidade desse Produto (Ex: Kg): ");
                Resposta();
                string unidade = ler;
                Console.WriteLine("Informe a Nova Quantidade desse Produto em Estoque:");
                Resposta();
                int qtEstoque = int.Parse(ler);
                crud.Alterar(nome, marca, vencimento, valorUnit, unidade, qtEstoque);
            }
        }
        static void Excluir()
        {
            Console.WriteLine("Informe o Nome do Produto que deseja excluir:");
            Resposta();
            string nome = ler;
            Console.WriteLine("Informe a Marca do Produto que deseja excluir:");
            Resposta();
            string marca = ler;
            crud.Excluir(nome, marca);
        }
    }
}

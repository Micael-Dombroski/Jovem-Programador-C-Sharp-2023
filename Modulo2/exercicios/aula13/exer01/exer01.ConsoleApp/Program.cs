using System;
using System.Collections.Generic;
using exer01.Classes;

namespace exer01.ConsoleApp
{
    class Program
    {
        static string ler;
        static ProdutoDAO dao = new ProdutoDAO();
        static void Main(string[] args)
        {
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
            dao.Adicionar(nome, marca, vencimento, valorUnit, unidade, qtEstoque);
        }

        static void Consultar()
        {
            Console.WriteLine("Informe o Id Produto que deseja Consultar: ");
            Resposta();
            int id = int.Parse(ler);
            if (dao.ConsultarPorId(id) == null)
            {
                Console.WriteLine("[3RR0R] Produto Não Encontrado");
            }
            else
            {
                Console.WriteLine(dao.ConsultarPorId(id));
            }
            Console.WriteLine("\n Pressione Qualquer tecla para voltar ao Menu Principal");
            Console.ReadLine();

        }

        static void Listar()
        {
            if (dao.ConsultarTodos() == null)
            {
                Console.WriteLine("[3RR0R] Não Há Nenhum Produto Cadastrado");
            }
            else
            {
                Console.WriteLine("------------------------- Lista de Produtos -------------------------");
                foreach (var item in dao.ConsultarTodos())
                {
                    Console.WriteLine(item);
                }
            }
            Console.WriteLine("\n Pressione Qualquer tecla para voltar ao Menu Principal");
            Console.ReadLine();
        }
        static void Editar()
        {
            Console.WriteLine("Informe o Id do Produto que deseja editar:");
            Resposta();
            int id = int.Parse(ler);
            if (dao.ConsultarPorId(id) == null)
            {
                Console.WriteLine("[3RR0R] Produto Não Encontrado");
                Console.WriteLine("\n Pressione Qualquer tecla para voltar ao Menu Principal");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Informe o Novo Nome do Produto:");
                Resposta();
                string nome = ler;
                Console.WriteLine("Informe a Nova Marca do Produto:");
                Resposta();
                string marca = ler;
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
                dao.Editar(id, nome, marca, vencimento, valorUnit, unidade, qtEstoque);
            }
        }
        static void Excluir()
        {
            Console.WriteLine("Informe o Id do Produto que deseja excluir:");
            Resposta();
            int id = int.Parse(ler);
            dao.Excluir(id);
        }
    }
}

using System;
using System.Collections.Generic;
using SolucaoMercearia.Classes;

namespace SolucaoMercearia.ConsoleApp
{
    class Program
    {
        static int optMenuPrin;
        static string ler;
        static ProdutoDAO dao = new ProdutoDAO();
        static ClienteDAO clienteDAO = new ClienteDAO();
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("====================");
                Console.WriteLine("        Menu        ");
                Console.WriteLine("====================");
                Console.WriteLine("[1] Clientes");
                Console.WriteLine("[2] Produtos");
                Console.WriteLine("[3] Sair");
                Resposta();
                optMenuPrin = int.Parse(ler);
                switch (optMenuPrin)
                {
                    case 1:
                        MenuCliente();
                        break;
                    case 2:
                        MenuProduto();
                        break;
                    case 3:
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("[3RR0R] Opção Inválida");
                        break;
                }
            } while (optMenuPrin != 3);
        }
        static void Resposta()
        {
            Console.Write("=> ");
            ler=Console.ReadLine();
        }

        static void MenuCliente()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("====================");
                Console.WriteLine("  Menu de Cliente  ");
                Console.WriteLine("====================");
                Console.WriteLine("[1] Cadastrar");
                Console.WriteLine("[2] Consultar");
                Console.WriteLine("[3] Listar");
                Console.WriteLine("[4] Editar");
                Console.WriteLine("[5] Excluir");
                Console.WriteLine("[6] Voltar");
                Resposta();
                switch (ler)
                {
                    case "1":
                        CadastrarCliente();
                        break;
                    case "2":
                        ConsultarCliente();
                        break;
                    case "3":
                        ListarClientes();
                        break;
                    case "4": 
                        EditarCliente();
                        break;
                    case "5":
                        ExcluirCliente();
                        break;
                    case "6":
                        Console.WriteLine("Voltando...");
                        break;
                    default:
                        Console.WriteLine("[3RR0R] Opção Inválida");
                        break;
                }
            } while (ler.ToLower() != "6");
        }

        static void MenuProduto()
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
                Console.WriteLine("[6] Voltar");
                Resposta();
                switch (ler)
                {
                    case "1":
                        CadastrarProduto();
                        break;
                    case "2":
                        ConsultarProduto();
                        break;
                    case "3":
                        ListarProdutos();
                        break;
                    case "4": 
                        EditarProduto();
                        break;
                    case "5":
                        ExcluirProduto();
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

        static void CadastrarCliente()
        {
            Console.WriteLine("Informe o Nome do Cliente que deseja cadastrar:");
            Resposta();
            string nome = ler;
            Console.WriteLine("Informe a Data de Nascimento do Cliente que deseja cadastrar (ano-mês-dia):");
            Resposta();
            DateTime dataNascimento = Convert.ToDateTime(ler);
            Console.WriteLine("Informe a Rua do Cliente que deseja cadastrar:");
            Resposta();
            string rua = ler;
            Console.WriteLine("Informe o Número da Residência do Cliente que deseja cadastrar:");
            Resposta();
            int numero = int.Parse(ler);
            Console.WriteLine("Informe o Bairro do Cliente que deseja cadastrar:");
            Resposta();
            string bairro = ler;
            Console.WriteLine("Informe a Cidade do Cliente que deseja cadastrar:");
            Resposta();
            string cidade = ler;
            Console.WriteLine("Informe o UF do Cliente que deseja cadastrar:");
            Resposta();
            string uf = ler;
            Cliente cliente = new Cliente
            {
                Nome = nome,
                DataNascimento = dataNascimento,
                EnderecoMoradia = new Endereco
                {
                    Rua = rua,
                    Numero = numero,
                    Bairro = bairro,
                    Cidade = cidade,
                    UF = uf
                }
            };
            clienteDAO.Adicionar(cliente);
        }

        static void ConsultarCliente()
        {
            Console.WriteLine("Informe o Id Cliente que deseja Consultar: ");
            Resposta();
            int id = int.Parse(ler);
            if (clienteDAO.ConsultarPorID(id) == null)
            {
                Console.WriteLine("[3RR0R] Cliente Não Encontrado");
            }
            else
            {
                Console.WriteLine(clienteDAO.ConsultarPorID(id));
            }
            Console.WriteLine("\n Pressione Qualquer tecla para voltar ao Menu Principal");
            Console.ReadLine();
        }

        static void ListarClientes()
        {
            if (clienteDAO.ConsultarTodos() == null)
            {
                Console.WriteLine("[3RR0R] Não Há Nenhum Cliente Cadastrado");
            }
            else
            {
                Console.WriteLine("------------------------- Lista de Clientes -------------------------");
                foreach (var item in clienteDAO.ConsultarTodos())
                {
                    Console.WriteLine(item);
                }
            }
            Console.WriteLine("\n Pressione Qualquer tecla para voltar ao Menu Principal");
            Console.ReadLine();
        }

        static void EditarCliente()
        {
            Console.WriteLine("Informe o Id do Cliente que deseja editar:");
            Resposta();
            int id = int.Parse(ler);
            if (dao.ConsultarPorId(id) == null)
            {
                Console.WriteLine("[3RR0R] Cliente Não Encontrado");
                Console.WriteLine("\n Pressione Qualquer tecla para voltar ao Menu Principal");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Informe o Novo Nome do Cliente:");
                Resposta();
                string nome = ler;
                Console.WriteLine("Informe a Nova Data de Nascimento do Cliente(ano-mês-dia):");
                Resposta();
                DateTime dataNascimento = Convert.ToDateTime(ler);
                Console.WriteLine("Informe a Nova Rua do Cliente:");
                Resposta();
                string rua = ler;
                Console.WriteLine("Informe o Novo Número da Residência do Cliente:");
                Resposta();
                int numero = int.Parse(ler);
                Console.WriteLine("Informe o Novo Bairro do Cliente:");
                Resposta();
                string bairro = ler;
                Console.WriteLine("Informe a Nova Cidade do Cliente:");
                Resposta();
                string cidade = ler;
                Console.WriteLine("Informe o Novo UF do Cliente:");
                Resposta();
                string uf = ler;
                Cliente cliente = new Cliente
                {
                    Nome = nome,
                    DataNascimento = dataNascimento,
                    EnderecoMoradia = new Endereco
                    {
                        Rua = rua,
                        Numero = numero,
                        Bairro = bairro,
                        Cidade = cidade,
                        UF = uf
                    }
                };
                clienteDAO.Editar(cliente, id);
            }
        }

        static void ExcluirCliente()
        {
            Console.WriteLine("Informe o Id do Cliente que deseja excluir:");
            Resposta();
            int id = int.Parse(ler);
            clienteDAO.Excluir(id);
        }

        static void CadastrarProduto()
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

        static void ConsultarProduto()
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

        static void ListarProdutos()
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
        static void EditarProduto()
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
        static void ExcluirProduto()
        {
            Console.WriteLine("Informe o Id do Produto que deseja excluir:");
            Resposta();
            int id = int.Parse(ler);
            dao.Excluir(id);
        }
    }
}

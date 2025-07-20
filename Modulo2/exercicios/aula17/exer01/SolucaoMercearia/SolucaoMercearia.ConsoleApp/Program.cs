using System;
using System.Collections.Generic;
using SolucaoMercearia.Domain.Entidade;
using SolucaoMercearia.Infra.Data.Repository;

namespace SolucaoMercearia.ConsoleApp
{
    class Program
    {
        static int optMenuPrin;
        static string ler;
        static ProdutoRepository produtoRepo = new();
        static ClienteRepository clienteRepo = new ();
        static VendaRepository vendaRepo = new();
        static void Main()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("====================");
                Console.WriteLine("        Menu        ");
                Console.WriteLine("====================");
                Console.WriteLine("[1] Produto");
                Console.WriteLine("[2] Cliente");
                Console.WriteLine("[3] Vendas");
                Console.WriteLine("[4] Sair");
                Console.WriteLine("====================");
                Resposta();
                optMenuPrin = int.Parse(ler);
                ler = "";
                switch (optMenuPrin)
                {
                    case 1:
                        MenuProduto();
                        break;
                    case 2:
                        MenuCliente();
                        break;
                    case 3:
                        MenuVendas();
                        break;
                    case 4:
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("\n [3RR0R] Opção Inválida");
                        break;
                }
            } while (optMenuPrin != 4);
        }
        static void Resposta()
        {
            Console.Write("=> ");
            ler=Console.ReadLine();
        }

        static void MenuCliente()
        {
            int optMenuCliente;
            do
            {
                Console.Clear();
                Console.WriteLine("====================");
                Console.WriteLine("  Menu de Cliente   ");
                Console.WriteLine("====================");
                Console.WriteLine("[1] Cadastrar");
                Console.WriteLine("[2] Editar");
                Console.WriteLine("[3] Consultar por CPF");
                Console.WriteLine("[4] Consultar Todos");
                Console.WriteLine("[5] Excluir por CPF");
                Console.WriteLine("[6] Voltar");
                Console.WriteLine("====================");
                Resposta();
                optMenuCliente = int.Parse(ler);
                ler = "";
                switch (optMenuCliente)
                {
                    case 1:
                        CadastrarCliente();
                        break;
                    case 2:
                        EditarCliente();
                        break;
                    case 3:
                        ConsultarCliente();
                        break;
                    case 4: 
                        ListarClientes();
                        break;
                    case 5:
                        ExcluirCliente();
                        break;
                    case 6:
                        Console.WriteLine("Voltando...");
                        break;
                    default:
                        Console.WriteLine("\n [3RR0R] Opção Inválida");
                        break;
                }
            } while (optMenuCliente != 6);
        }

        static void MenuProduto()
        {
            int optMenuProduto;
            do
            {
                Console.Clear();
                Console.WriteLine("====================");
                Console.WriteLine("  Menu de Produtos  ");
                Console.WriteLine("====================");
                Console.WriteLine("[1] Cadastrar");
                Console.WriteLine("[2] Editar");
                Console.WriteLine("[3] Consultar por id");
                Console.WriteLine("[4] Consultar Todos");
                Console.WriteLine("[5] Excluir por id");
                Console.WriteLine("[6] Voltar");
                Console.WriteLine("====================");
                Resposta();
                optMenuProduto = int.Parse(ler);
                switch (optMenuProduto)
                {
                    case 1:
                        CadastrarProduto();
                        break;
                    case 2:
                        EditarProduto();
                        break;
                    case 3:
                        ConsultarProduto();
                        break;
                    case 4: 
                        ListarProdutos();
                        break;
                    case 5:
                        ExcluirProduto();
                        break;
                    case 6:
                        Console.WriteLine("Voltando...");
                        break;
                    default:
                        Console.WriteLine("\n [3RR0R] Opção Inválida");
                        break;
                }
            } while (optMenuProduto != 6);
        }

        static void MenuVendas()
        {
            int optMenuVendas;
            do
            {
                Console.Clear();
                Console.WriteLine("====================");
                Console.WriteLine("   Menu de Vendas   ");
                Console.WriteLine("====================");
                Console.WriteLine("[1] Cadastrar");
                Console.WriteLine("[2] Consultar por Cliente");
                Console.WriteLine("[3] Consultar Todos");
                Console.WriteLine("[4] Voltar");
                Console.WriteLine("====================");
                Resposta();
                optMenuVendas = int.Parse(ler);
                ler = "";
                switch (optMenuVendas)
                {
                    case 1:
                        CadastrarVenda();
                        break;
                    case 2:
                            ListarVendasPorCliente();
                        break;
                    case 3:
                        ListarVendas();
                        break;
                    case 4:
                        Console.WriteLine("Voltando...");
                        break;
                    default:
                        Console.WriteLine("\n [3RR0R] Opção Inválida");
                        break;
                }
            } while (optMenuVendas != 4);
        }

        static void CadastrarCliente()
        {
            string resultado = "\n [AVISO] Cliente cadastrado com Sucesso!";
            try
            {
                Console.WriteLine("Informe o CPF do Cliente que deseja cadastrar (Ex: xxx.xxx.xxx-xx): ");
                Resposta();
                string cpf = ler;
                if (clienteRepo.ConsultarPorCpf(cpf) != null)
                {
                    throw new ArgumentException("\n [3RR0R] CPF já Cadastrado!");
                    

                }
                else
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
                        Cpf = cpf,
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
                    clienteRepo.Salvar(cliente);
                }
            }
            catch
            {
                ArgumentException e = new();
                if (e.Message != "\n [3RR0R] CPF já Cadastrado!")
                {
                    e = new("\n [3RR0R] Algum campo foi preenchido de maneira incorreta, por favor tente cadastrar novamente o cliente");
                }
                Console.WriteLine(e.Message);
                resultado = "";
            }
            finally
            {
                if (resultado != "")
                {
                    Console.WriteLine(resultado);
                }
                Console.WriteLine("\n Pressione Qualquer tecla para voltar ao Menu de Clientes");
                Console.ReadKey();
            }
        }

        static void ConsultarCliente()
        {
            try
            {
                Console.WriteLine("Informe o Cpf Cliente que deseja Consultar: ");
                Resposta();
                string cpf = ler;
                if (clienteRepo.ConsultarPorCpf(cpf) == null)
                {
                    throw new ArgumentException("\n [3RR0R] Cliente Não Encontrado");
                }
                else
                {
                    Console.WriteLine(clienteRepo.ConsultarPorCpf(cpf));
                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("\n Pressione Qualquer tecla para voltar ao Menu de Clientes");
                Console.ReadKey();
            }
        }

        static void ListarClientes()
        {
            try
            {
                if (clienteRepo.ConsultarTodos() == null)
                {
                    throw new ArgumentException("\n [3RR0R] Não Há Nenhum Cliente Cadastrado");
                }
                else
                {
                    Console.WriteLine("------------------------- Lista de Clientes -------------------------");
                    foreach (var item in clienteRepo.ConsultarTodos())
                    {
                        Console.WriteLine(item);
                    }
                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("\n Pressione Qualquer tecla para voltar ao Menu de Clientes");
                Console.ReadKey();
            }
        }

        static void EditarCliente()
        {
            try
            {
                Console.WriteLine("Informe o CPF do Cliente que deseja editar:");
                Resposta();
                string cpf = ler;
                if (clienteRepo.ConsultarPorCpf(cpf) == null)
                {
                    throw new ArgumentException("\n [3RR0R] Cliente Não Encontrado");
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
                    clienteRepo.Editar(cliente, cpf);
                    Console.WriteLine("\n [AVISO] Cliente editado com Sucesso!");
                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("\n Pressione Qualquer tecla para voltar ao Menu de Clientes");
                Console.ReadKey();
            }
        }

        static void ExcluirCliente()
        {
            try
            {
                Console.WriteLine("Informe o CPF do Cliente que deseja excluir:");
                Resposta();
                string cpf = ler;
                if (clienteRepo.ConsultarPorCpf(cpf) == null)
                {
                    throw new ArgumentException("\n [3RR0R] Cliente Não Encontrado");
                    
                }
                else
                {
                    if (vendaRepo.ConsultarPorCliente(cpf) is not null)
                    {
                        throw new ArgumentException("\n [3RR0R] Não é possível Excluir um Cliente já Vinculado a uma Venda");
                    }
                    clienteRepo.Excluir(cpf);
                    Console.WriteLine("\n [AVISO] Cliente Excluído com Sucesso!");
                }
                
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("\n Pressione Qualquer tecla para voltar ao Menu de Clientes");
                Console.ReadKey();
            }
        }

        static void CadastrarProduto()
        {
            string resultado = "\n [Aviso] Produto cadastrado com Sucesso!";
            try
            {
                Console.WriteLine("Informe o Nome do Produto que deseja cadastrar: ");
                Resposta();
                string nome = ler;
                Console.WriteLine("Informe a Marca do Produto:");
                Resposta();
                string marca = ler;
                Console.WriteLine("Informe a Data de Vencimento do Produto (Ano-Mês-Dia):");
                Resposta();
                DateTime vencimento = Convert.ToDateTime(ler);
                Console.WriteLine("Informe o Valor Unitário do Produto (Ex: 123.45):");
                Resposta();
                double valorUnit = double.Parse(ler);
                Console.WriteLine("Informe a Unidade desse Produto (Ex: Kg): ");
                Resposta();
                string unidade = ler;
                Console.WriteLine("Informe a Quantidade desse Produto em Estoque:");
                Resposta();
                double qtEstoque = double.Parse(ler);
                Produto produto = new Produto
                {
                    Nome = nome,
                    Marca = marca,
                    DataVencimento = vencimento,
                    PrecoUnitario = Convert.ToDouble(valorUnit.ToString("F")),
                    Unidade = unidade,
                    QtEstoque = qtEstoque
                };
                produtoRepo.Salvar(produto);
            }
            catch
            {
                ArgumentException e = new("\n [3RR0R] Algum campo foi preenchido de maneira incorreta, por favor tente cadastrar novamente o produto");
                Console.WriteLine(e.Message);
                resultado = "";
            }
            finally
            {
                if (resultado != "")
                {
                    Console.WriteLine(resultado);
                }
                Console.WriteLine("\n Pressione Qualquer tecla para voltar ao Menu de Produtos");
                Console.ReadKey();
            }
            
        }

        static void ConsultarProduto()
        {
            try
            {
                Console.WriteLine("Informe o Id Produto que deseja Consultar: ");
                Resposta();
                int id = int.Parse(ler);
                if (produtoRepo.ConsultarPorId(id) is null)
                {
                    throw new ArgumentException("\n [3RR0R] Produto Não Encontrado");
                }
                else
                {
                    Console.WriteLine("\n Dados do Produto: \n");
                    Console.WriteLine(produtoRepo.ConsultarPorId(id));
                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("\n Pressione Qualquer tecla para voltar ao Menu de Produtos");
                Console.ReadKey();
            }

        }

        static void ListarProdutos()
        {
            try
            {
                if (produtoRepo.ConsultarTodos() == null)
                {
                    throw new ArgumentException("\n [3RR0R] Não Há Nenhum Produto Cadastrado");
                }
                else
                {
                    Console.WriteLine("------------------------- Lista de Produtos -------------------------");
                    foreach (var item in produtoRepo.ConsultarTodos())
                    {
                        Console.WriteLine(item);
                    }
                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("\n Pressione Qualquer tecla para voltar ao Menu de Produtos");
                Console.ReadKey();
            }
        }
        static void EditarProduto()
        {
            string resultado = "\n [AVISO] Produto editado com Sucesso!";
            try
            {
                Console.WriteLine("Informe o Id do Produto que deseja editar:");
                Resposta();
                int id = int.Parse(ler);
                if (produtoRepo.ConsultarPorId(id) == null)
                {
                    throw new ArgumentException("\n [3RR0R] Produto Não Encontrado");
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
                    DateTime vencimento = Convert.ToDateTime(ler);
                    Console.WriteLine("Informe o Novo Valor Unitário do Produto (Ex: 123.45):");
                    Resposta();
                    double valorUnit = double.Parse(ler);
                    Console.WriteLine("Informe a Nova Unidade desse Produto (Ex: Kg): ");
                    Resposta();
                    string unidade = ler;
                    Console.WriteLine("Informe a Nova Quantidade desse Produto em Estoque:");
                    Resposta();
                    double qtEstoque = double.Parse(ler);
                    Produto produto = new Produto
                    {
                        Id = id,
                        Nome = nome,
                        Marca = marca,
                        DataVencimento = vencimento,
                        PrecoUnitario = Convert.ToDouble(valorUnit.ToString("F")),
                        Unidade = unidade,
                        QtEstoque = qtEstoque
                    };
                    produtoRepo.Editar(produto);
                }
            }
            catch (ArgumentException e)
            {
                if (e.Message != "\n [3RR0R] Produto Não Encontrado")
                {
                    e = new ArgumentException("\n [3RR0R] Algum campo foi preenchido de maneira incorreta, por favor tente cadastrar novamente o produto");
                }
                Console.WriteLine(e.Message);
                resultado = "";
            }
            finally
            {
                if (resultado != "")
                {
                    Console.WriteLine(resultado);
                }
                Console.WriteLine("\n Pressione Qualquer tecla para voltar ao Menu de Produtos");
                Console.ReadKey();
            }
        }
        static void ExcluirProduto()
        {
            try
            {
                Console.WriteLine("Informe o Id do Produto que deseja excluir:");
                Resposta();
                int id = int.Parse(ler);
                if (produtoRepo.ConsultarPorId(id) == null)
                {
                    throw new ArgumentException("\n [3RR0R] Produto Não Encontrado");
                }
                if (vendaRepo.ConsultarTodos() is not null)
                {
                    foreach (var item in vendaRepo.ConsultarTodos())
                    {
                        if (item.ProdutoVendido.Id == id)
                        {
                            throw new ArgumentException("\n [3RR0R] Não se pode Excluir um Produto já Vinculado a uma Venda");
                        }
                    }
                }
                produtoRepo.Excluir(id);
                Console.WriteLine("\n [Aviso] Produto excluído com Sucesso!");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("\n Pressione Qualquer tecla para voltar ao Menu de Produtos");
                Console.ReadKey();
            }
        }

        static void CadastrarVenda()
        {
            string resultado = "\n [Aviso] Venda cadastrada com Sucesso!";
            try
            {
                Console.WriteLine("Informe o Cpf do Cliente para o qual a Venda foi Efetuada: ");
                Resposta();
                string cpf = ler;
                if (clienteRepo.ConsultarPorCpf(cpf) is null)
                {
                    throw new ArgumentException("\n [3RR0R] Cliente Não Encontrado");
                }
                Console.WriteLine("Informe o Id do Produto da Venda: ");
                Resposta();
                int id = int.Parse(ler);
                if (produtoRepo.ConsultarPorId(id) is null)
                {
                    throw new ArgumentException("\n [3RR0R] Produto Não Encontrado");
                }
                double qtVendida;
                do
                {
                    Console.WriteLine("Informe a Quantidade Vendida do Produto: ");
                    Resposta();
                    qtVendida = Convert.ToDouble(double.Parse(ler).ToString("F"));
                    if (qtVendida > produtoRepo.ConsultarPorId(id).QtEstoque || qtVendida <= 0)
                    {
                        Console.WriteLine("\n [3RR0R] A Quantidade vendida do Produto não pode ser Maior que sua quantidade em estoque e/ou inferior ou igual a 0");
                        Console.WriteLine("\n Pressione Qualquer tecla para voltar ao Menu de Vendas");
                        Console.ReadKey();
                    }
                } while (qtVendida > produtoRepo.ConsultarPorId(id).QtEstoque || qtVendida <= 0);
                Venda venda = new()
                {
                    ClienteVenda = clienteRepo.ConsultarPorCpf(cpf),
                    ProdutoVendido = produtoRepo.ConsultarPorId(id),
                    QuantidadeVendida = qtVendida
                };
                vendaRepo.Salvar(venda);
                Produto produto = produtoRepo.ConsultarPorId(id);
                produto.QtEstoque = Convert.ToDouble((produto.QtEstoque - qtVendida).ToString("F"));
                produtoRepo.Editar(produto);
            }
            catch
            {
                ArgumentException e = new();
                if (e.Message != "\n [3RR0R] Cliente Não Encontrado" && e.Message != "\n [3RR0R] Produto Não Encontrado")
                {
                    e = new("\n [3RR0R] Algum campo foi preenchido de maneira incorreta, por favor tente cadastrar novamente a venda");
                }
                Console.WriteLine(e.Message);
                resultado = "";
            }
            finally
            {
                if (resultado != "")
                {
                    Console.WriteLine(resultado);
                }
                Console.WriteLine("\n Pressione Qualquer tecla para voltar ao Menu de Vendas");
                Console.ReadKey();
            }
            
        }

        static void ListarVendasPorCliente()
        {
            try
            {
                string cpf;
                Console.WriteLine("Informe o CPF do Cliente que deseja ver as Vendas: ");
                Resposta();
                cpf = ler;
                if (clienteRepo.ConsultarPorCpf(cpf) is null)
                {
                     throw new ArgumentException("\n [3RR0R] Cliente Não Cadastrado!");
                }
                if (vendaRepo.ConsultarPorCliente(cpf) == null)
                {
                    throw new ArgumentException("\n [3RR0R] Não Há Nenhuma Venda Cadastrada para esse Cliente!");
                }
                else
                {
                    Console.WriteLine("------------------------- Lista de Vendas -------------------------");
                    Console.WriteLine("| Nome Cliente | Nome Produto | Quantidade | Preço Unitário | Total|");
                    foreach (var item in vendaRepo.ConsultarPorCliente(cpf))
                    {
                        Console.WriteLine(item);
                    }
                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("\n Pressione Qualquer tecla para voltar ao Menu de Vendas");
                Console.ReadKey();
            }
        }

        static void ListarVendas()
        {
            try
            {
                ICollection<Venda> vendas = vendaRepo.ConsultarTodos();
                if (vendas is null)
                {
                    throw new ArgumentException("\n [3RR0R] Não Há Nenhuma Venda Cadastrada");
                }
                else
                {
                    Console.WriteLine("------------------------- Lista de Vendas -------------------------");
                    Console.WriteLine("| Nome Cliente | Nome Produto | Quantidade | Preço Unitário | Total|");
                    foreach (var item in vendas)
                    {
                        Console.WriteLine(item);
                    }
                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("\n Pressione Qualquer tecla para voltar ao Menu de Vendas");
                Console.ReadKey();
            }
        }
    }
}

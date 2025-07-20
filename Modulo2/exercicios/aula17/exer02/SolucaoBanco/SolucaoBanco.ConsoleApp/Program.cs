using System;
using System.Collections.Generic;
using SolucaoBanco.Domain.Entidade;
using SolucaoBanco.Infra.Data.Repository;

namespace SolucaoBanco.ConsoleApp
{
    class Program
    {
        static string ler;
        static int optPrin;
        static ContaRepository contaRepo = new();
        static ClienteRepository clienteRepo = new();
        static MovimentoBancarioRepository movimentoBancarioRepo = new();
        static void Main()
        {

            do
            {
                Console.Clear();
                Console.WriteLine("====================");
                Console.WriteLine("        Menu        ");
                Console.WriteLine("====================");
                Console.WriteLine("[1] Dados das contas");
                Console.WriteLine("[2] Dados dos clientes");
                Console.WriteLine("[3] Sair");
                Console.WriteLine("====================\n");
                Resposta();
                optPrin = int.Parse(ler);
                switch (optPrin)
                {
                    case 1:
                        MenuConta();
                        break;
                    case 2:
                        MenuCliente();
                        break;
                    case 3:
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("[3RR0R] Opção Inválida");
                        break;
                }
            } while (optPrin != 3);
        }

        static void Resposta()
        {
            Console.Write("=> ");
            ler=Console.ReadLine();
        }

        static void Voltar()
        {
            Console.WriteLine("\nPressione qualquer tecla para voltar");
            Console.ReadKey();
        }

        static void MenuConta()
        {
            int optMenuConta;
            do
            {
                optMenuConta = 0;
                Console.Clear();
                Console.WriteLine("====================");
                Console.WriteLine("    Menu Contas     ");
                Console.WriteLine("====================");
                Console.WriteLine("[1] Adicionar conta");
                Console.WriteLine("[2] Editar conta");
                Console.WriteLine("[3] Listar todas as contas");
                Console.WriteLine("[4] Consultar conta");
                Console.WriteLine("[5] Excluir conta");
                Console.WriteLine("[6] Depositar");
                Console.WriteLine("[7] Sacar");
                Console.WriteLine("[8] Saldo");
                Console.WriteLine("[9] Movimento Bancário");
                Console.WriteLine("[0] Voltar");
                Console.WriteLine("====================\n");
                Resposta();
                optMenuConta = int.Parse(ler);
                switch (optMenuConta)
                {
                    case 1:
                        AdicionarConta();
                        break;
                    case 2:
                        EditarConta();
                        break;
                    case 3:
                        ListarContas();
                        break;
                    case 4:
                        ConsultarConta();
                        break;
                    case 5:
                    ExcluirConta();
                            break;
                    case 6:
                        ArgumentException e = new("[3RR0R] Algum dado deve ter sido inserido incorretamente, por favor tente novamente mais tarde!");
                        try
                        {
                            Console.WriteLine("Informe o Número da Agência da Conta que deseja efetuar o Depósito: ");
                            Resposta();
                            int agencia = int.Parse(ler);
                            Console.WriteLine("Informe o Número da Conta que deseja efetuar o Depósito: ");
                            Resposta();
                            int numero = int.Parse(ler);
                            if (contaRepo.ConsultarPorAgenciaENumero(agencia, numero) is null)
                            {
                                e= new ArgumentException("[3RR0R] Conta não Encontrada!");
                                throw new Exception();
                                
                            }
                            else
                            {
                                Conta conta = contaRepo.ConsultarPorAgenciaENumero(agencia, numero);
                                Console.Write("Informe o valor que deseja despositar: R$ ");
                                double deposito = double.Parse(Console.ReadLine());
                                deposito = Convert.ToDouble(deposito.ToString("F"));
                                if (deposito <= 0)
                                {
                                    e= new ArgumentException("[3RR0R] Não foi possível efetuar o depósito!");
                                    throw new Exception();
                                }
                                DepositarNaConta(conta, deposito);
                                Console.WriteLine("[AVISO] Depósito efetuado com sucesso!");
                            }
                        }
                        catch
                        {
                            Console.WriteLine(e.Message);
                        }
                        finally
                        {
                            Voltar();
                        }
                        break;
                    case 7:
                        e = new("[3RR0R] Algum dado foi inserido incorretamente, por favor tente novamente!");
                        try
                        {
                            Console.WriteLine("Informe o Número da Agência da Conta que deseja efetuar o Saque: ");
                            Resposta();
                            int agencia = int.Parse(ler);
                            Console.WriteLine("Informe o Número da Conta que deseja efetuar o Saque: ");
                            Resposta();
                            int numero = int.Parse(ler);
                            if (contaRepo.ConsultarPorAgenciaENumero(agencia, numero) is null)
                            {
                                e= new ArgumentException("[3RR0R] Conta não Encontrada!");
                                throw new Exception();
                                
                            }
                            else
                            {
                                Conta conta = contaRepo.ConsultarPorAgenciaENumero(agencia, numero);
                                Console.Write("Informe o valor que deseja sacar: R$ ");
                                double saque = double.Parse(Console.ReadLine());
                                saque = Convert.ToDouble(saque.ToString("F"));
                                if (saque <= 0 || saque > conta.Saldo)
                                {
                                    e= new ArgumentException("[3RR0R] Não foi possível efetuar o saque!");
                                    throw new Exception();
                                }
                                SacarDaConta(conta, saque);
                                Console.WriteLine("[AVISO] Saque efetuado com sucesso!");
                            }
                        }
                        catch
                        {
                            Console.WriteLine(e.Message);
                        }
                        finally
                        {
                            Voltar();
                        }
                        break;
                    case 8:
                        Saldo();
                        break;
                    case 9:
                        MenuMovimentoBancario();
                        break;
                    case 0:
                        Console.WriteLine("Voltando...");
                        break;
                    default:
                        Console.WriteLine("[3RR0R] Opção Inválida");
                        break;
                }

            } while (optMenuConta != 0);

        }

        static void MenuCliente()
        {
            int optMenuCliente;
            do
            {
                optMenuCliente = 0;
                Console.Clear();
                Console.WriteLine("====================");
                Console.WriteLine("    Menu Clientes     ");
                Console.WriteLine("====================");
                Console.WriteLine("[1] Adicionar cliente");
                Console.WriteLine("[2] Editar cliente");
                Console.WriteLine("[3] Listar todos os clientes");
                Console.WriteLine("[4] Consultar cliente");
                Console.WriteLine("[5] Excluir cliente");
                Console.WriteLine("[6] Voltar");
                Console.WriteLine("====================\n");
                Resposta();
                optMenuCliente = int.Parse(ler);
                switch (optMenuCliente)
                {
                    case 1:
                        AdicionarCliente();
                        break;
                    case 2:
                        EditarCliente();
                        break;
                    case 3:
                        ListarClientes();
                        break;
                    case 4:
                        ConsultarCliente();
                        break;
                    case 5:
                        ExcluirCliente();
                        break;
                    default:
                        Console.WriteLine("[3RR0R] Opção Inválida");
                        break;
                }
            } while (optMenuCliente != 6);
        }

        static void AdicionarConta()
        {
            Console.WriteLine("------Tipo de Contas------");
            Console.WriteLine("[1] Conta Corrente");
            Console.WriteLine("[2] Conta Investimento");
            Console.WriteLine("[3] Conta Poupança");
            Console.WriteLine("[4] Voltar");
            Console.WriteLine("--------------------------");
            Resposta();
            int tipoConta = 0;
            do
            {
                switch (ler)
                {
                    case "1":
                        tipoConta = int.Parse(ler);
                        break;
                    case "2":
                        tipoConta = int.Parse(ler);
                        break;
                    case "3":
                        tipoConta = int.Parse(ler);
                        break;
                    case "4":
                        Console.WriteLine("Voltando...");
                        Voltar();
                        break;
                    default:
                        Console.WriteLine("[3RR0R] Opção Inválida");
                        break;
                }
            } while (ler != "1" && ler != "2" && ler != "3" && ler != "4");
            tipoConta = int.Parse(ler);
            if (tipoConta > 3)
            {
                return;
            }
            ArgumentException e = new("[3RR0R] Algum dado foi inserido incorretamente, por favor tente novamente!");
            try
            {
                Console.WriteLine("Informe o Número da Agência da Conta que deseja Cadastrar: ");
                Resposta();
                int agencia = int.Parse(ler);
                Console.WriteLine("Informe o Número da Conta que deseja Cadastrar: ");
                Resposta();
                int numero = int.Parse(ler);
                if (contaRepo.ConsultarPorAgenciaENumero(agencia,numero) != null)
                {
                    e= new ArgumentException("[3RR0R] Conta já Cadastrada!");
                }
                Console.WriteLine("Informe o CPF do Correntista da Conta que deseja Cadastrar (Ex: 111.111.111-11): ");
                Resposta();
                string cpf = ler;
                if (clienteRepo.ConsultarPorCpf(cpf) is null)
                {
                    e= new ArgumentException("[3RR0R] Correntista Não Cadastrado!");

                }
                Cliente correntista = clienteRepo.ConsultarPorCpf(cpf);
                Conta conta = null;
                switch (tipoConta)
                {
                    case 1:
                        conta = new ContaCorrente
                        {
                            Agencia = agencia,
                            Numero = numero,
                            Correntista = correntista
                        };
                        break;
                    case 2:
                        conta = new ContaInvestimento
                        {
                            Agencia = agencia,
                            Numero = numero,
                            Correntista = correntista
                        };
                        break;
                    case 3:
                        conta = new ContaPoupanca
                        {
                            Agencia = agencia,
                            Numero = numero,
                            Correntista = correntista
                        };
                        break;
                    default:
                        Console.WriteLine("[3RR0R] Opção Inválida");
                        break;
                }
                double saldo= 0;
                do
                {
                    Console.Write("Informe o Saldo Inicial da Conta: R$ ");
                    saldo = double.Parse(Console.ReadLine());
                    saldo = Convert.ToDouble(saldo.ToString("F"));
                    if (saldo <= 0)
                    {
                        Console.WriteLine("[3RR0R] O Saldo Não Pode ser menor ou igual a R$ 0,00\n");
                        Voltar();
                        Console.Clear();
                        Console.Write("Informe o Saldo Inicial da Conta: R$ ");
                        saldo = double.Parse(Console.ReadLine());
                        saldo = Convert.ToDouble(saldo.ToString("F"));
                    }
                } while (saldo <= 0);
                conta.Depositar(saldo);
                contaRepo.Salvar(conta);
                Console.WriteLine("[AVISO] Conta Cadastrada com Sucesso!");
            }
            catch
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Voltar();
            }
        }

        static void EditarConta()
        {
            ArgumentException e = new("[3RR0R] Algum campo foi inserido incorretamente, por favor tente novamente!");
            try
            {
                Console.WriteLine("Informe o Número da Agência da Conta que deseja Editar: ");
                Resposta();
                int agencia = int.Parse(ler);
                Console.WriteLine("Informe o Número da Agência da Conta que deseja Editar: ");
                Resposta();
                int numero = int.Parse(ler);
                if (contaRepo.ConsultarPorAgenciaENumero(agencia,numero) is null)
                {
                    e= new ArgumentException("[3RR0R] Conta não Encontrada!");
                    throw new Exception();
                }
                Conta conta = contaRepo.ConsultarPorAgenciaENumero(agencia,numero);
                Conta contaEditada = null;
                Console.WriteLine("Deseja editar o tipo da Conta? S/N");
                Resposta();
                if (ler.ToLower() == "s")
                {
                    do
                    {
                        Console.WriteLine("Informe o Novo Tipo da Conta: [1] Conta Corrente, [2] Conta Investimeto, [3] Conta Poupança");
                        Resposta();
                        switch (ler)
                        {
                            case "1":
                                contaEditada = new ContaCorrente
                                {
                                    Agencia = conta.Agencia,
                                    Numero = conta.Numero,
                                    Correntista = conta.Correntista
                                };
                                break;
                            case "2":
                                contaEditada = new ContaInvestimento
                                {
                                    Agencia = conta.Agencia,
                                    Numero = conta.Numero,
                                    Correntista = conta.Correntista
                                };
                                break;
                            case "3":
                                contaEditada = new ContaPoupanca
                                {
                                    Agencia = conta.Agencia,
                                    Numero = conta.Numero,
                                    Correntista = conta.Correntista
                                };
                                break;
                            default:
                                Console.WriteLine("[3RR0R] Opção Inválida");
                                break;
                        }
                    } while (ler != "1" && ler != "2" && ler != "3");
                }
                else
                {
                    contaEditada = conta;
                }
                Console.WriteLine("Deseja Editar o Correntista da Conta? S/N");
                Resposta();
                if (ler.ToLower() == "s")
                {
                    string cpf;
                    do
                    {
                        Console.WriteLine("Informe o CPF do Novo Correntista da Conta (Ex: 111.111.111-11):");
                        Resposta();
                        cpf = ler;
                        if (clienteRepo.ConsultarPorCpf(cpf) is null)
                        {
                            e= new ArgumentException("[3RR0R] Correntista não Cadastrado!");
                            throw new Exception();
                        }
                    } while (clienteRepo.ConsultarPorCpf(cpf) is null);
                    contaEditada.Correntista = clienteRepo.ConsultarPorCpf(cpf);
                }
                contaEditada.Depositar(conta.Saldo);
                contaRepo.Editar(contaEditada);
                Console.WriteLine("[AVISO] Conta Editada Com Sucesso!");
            }
            catch
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Voltar();
            }
            
        }
        
        static void ListarContas()
        {
            try
            {
                if (contaRepo.ConsultarTodos() is null)
                {
                    throw new ArgumentException("[3RR0R] Não Há Nenhuma Conta Cadastrada");
                }
                Console.WriteLine("Lista de Todas as Contas Cadastradas\n");
                Console.WriteLine("Agência | Número | Correntista | Tipo da Conta | Saldo\n");
                foreach (var item in contaRepo.ConsultarTodos())
                {
                    Console.WriteLine(item);
                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Voltar();
            }
        }

        static void ConsultarConta()
        {
            ArgumentException e = new("[3RR0R] Algum campo foi preenchido incorretamente, por favor tenta novamente!");
            try
            {
                Console.WriteLine("Informe o Número da Agência da Conta que deseja Excluir: ");
                Resposta();
                int agencia = int.Parse(ler);
                Console.WriteLine("Informe o Número da Conta que deseja Excluir: ");
                Resposta();
                int numero = int.Parse(ler);
                if (contaRepo.ConsultarPorAgenciaENumero(agencia, numero) is null)
                {
                    e= new ArgumentException("[3RR0R] Conta não Encontrada");
                }
                Conta conta = contaRepo.ConsultarPorAgenciaENumero(agencia, numero);
                Console.WriteLine("------Dados da Conta------");
                Console.WriteLine($"Agência: {conta.Agencia}");
                Console.WriteLine($"Número: {conta.Numero}");
                Console.WriteLine($"Correntista: {conta.Correntista.Nome}");
                Console.WriteLine($"Tipo: {conta.MostrarTipoConta()}");
            }
            catch
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Voltar();
            }
        }

        static void ExcluirConta()
        {
            ArgumentException e = new("[3RR0R] Algum campo foi preenchido incorretamente, por favor tenta novamente!");
            try
            {
                Console.WriteLine("Informe o Número da Agência da Conta que deseja Excluir: ");
                Resposta();
                int agencia = int.Parse(ler);
                Console.WriteLine("Informe o Número da Conta que deseja Excluir: ");
                Resposta();
                int numero = int.Parse(ler);
                if (contaRepo.ConsultarPorAgenciaENumero(agencia, numero) is null)
                {
                    e= new ArgumentException("[3RR0R] Conta não Encontrada");
                    throw new Exception();
                }
                Conta conta = contaRepo.ConsultarPorAgenciaENumero(agencia,numero);
                if (movimentoBancarioRepo.ConsultarPorAgenciaENumero(conta) != null)
                {
                    e= new ArgumentException("[3RR0R] Não é possível Excluir uma Conta que já efetuou alguma Movimentação Bancária");
                    throw new Exception();
                }
                contaRepo.Excluir(agencia, numero);
                Console.WriteLine("\n [AVISO] Conta Excluída com Sucesso");
            }
            catch
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Voltar();
            }
        }

        static void SacarDaConta(Conta conta, double valor)
        {
            try
            {
                if (valor <= 0 && conta.Saldo < valor)
                {
                    throw new ArgumentException("Não foi possível Efetuar o Saque!");
                }
                conta.Sacar(valor);
                contaRepo.Editar(conta);
                MovimentoBancario movimento = new()
                {
                    ContaUsada = conta,
                    TipoMovimento = "Saque",
                    ValorMovimentado = valor
                };
                movimentoBancarioRepo.Salvar(movimento);
            }
            catch(ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {

            }
        }
        static void DepositarNaConta(Conta conta, double valor)
        {
            try
            {
                if (valor > 0)
                {
                    conta.Depositar(valor);
                }
                else
                {
                    throw new ArgumentException("[3RR0R] Não foi Possível Efetuar o Depósito!");
                }
                if (contaRepo.ConsultarPorAgenciaENumero(conta.Agencia, conta.Numero) == null)
                {
                    contaRepo.Salvar(conta);
                }
                else
                {
                    MovimentoBancario movimento = new()
                    {
                        ContaUsada = conta,
                        TipoMovimento = "Depósito",
                        ValorMovimentado = valor
                    };
                    movimentoBancarioRepo.Salvar(movimento);
                }
                contaRepo.Editar(conta);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {

            }
        }

        static void Saldo()
        {
            ArgumentException e = new ("[3RR0R] Algum campo foi preenchido incorretamente, por favor tenta novamente!");
            try
            {
                Console.WriteLine("Informe o Número da Agência da Conta que deseja Consultar o Saldo: ");
                Resposta();
                int agencia = int.Parse(ler);
                Console.WriteLine("Informe o Número da Conta que deseja Consultar o Saldo: ");
                Resposta();
                int numero = int.Parse(ler);
                if (contaRepo.ConsultarPorAgenciaENumero(agencia, numero) is null)
                {
                    e= new ArgumentException("[3RR0R] Conta não Cadastrada");
                    throw new Exception();
                }
                Conta conta = contaRepo.ConsultarPorAgenciaENumero(agencia, numero);
                Console.WriteLine($"\nSaldo: R$ {conta.Saldo.ToString("F")}");
            }
            catch
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Voltar();
            }
        }

        static void AdicionarCliente()
        {
            string nome;
            string rg;
            int numero;
            string endereco;
            string bairro;
            string cidade;
            string uf;
            ArgumentException e = new ("[3RR0R] Algum campo foi preenchido incorretamente, por favor tente novamente");
            try
            {
                Console.WriteLine("Informe o CPF do Cliente que deseja Cadastrar (Ex: 111.111.111-11): ");
                Resposta();
                string cpf = ler;
                if (clienteRepo.ConsultarPorCpf(cpf) != null)
                {
                    e= new ArgumentException("[3RR0R] Cliente Já Cadastrado!");
                    throw new Exception();
                }
                Console.WriteLine("Informe o Novo Nome do Cliente: ");
                Resposta();
                nome = ler;
                Console.WriteLine("Informe o Novo RG do Cliente: ");
                Resposta();
                rg = ler;
                Console.WriteLine("Informe o Novo Endereço do Cliente: ");
                Resposta();
                endereco = ler;
                Console.WriteLine("Informe o Novo Número do Cliente: ");
                Resposta();
                numero = int.Parse(ler);
                Console.WriteLine("Informe o Novo Bairro do Cliente: ");
                Resposta();
                bairro = ler;
                Console.WriteLine("Informe a Nova Cidade do Cliente: ");
                Resposta();
                cidade = ler;
                Console.WriteLine("Informe o Novo UF do Cliente: ");
                Resposta();
                uf = ler;
                Cliente cliente = new()
                {
                    Nome = nome,
                    CPF = cpf,
                    RG = rg,
                    Endereco = endereco,
                    Numero = numero,
                    Bairro = bairro,
                    Cidade = cidade,
                    UF = uf
                };
                clienteRepo.Salvar(cliente);
                Console.WriteLine("[AVISO] Cliente Cadastrado com Sucesso!");
            }
            catch
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Voltar();
            }
        }

        static void EditarCliente()
        {
            ArgumentException e = new("[3RR0R] Algum campo foi preenchido incorretamente, por favor tente novamente!");;
            try
            {
                Console.WriteLine("Informe o CPF do Cliente que deseja Editar: ");
                Resposta();
                string cpf = ler;
                if (clienteRepo.ConsultarPorCpf(cpf) is null)
                {
                    e= new ArgumentException("[3RR0R] Cliente Não Cadastrado!");
                    throw new Exception();
                }
                Cliente cliente = clienteRepo.ConsultarPorCpf(cpf);
                Console.WriteLine("Deseja Editar o Nome? S/N");
                Resposta();
                if (ler.ToLower() == "s")
                {
                    Console.WriteLine("Informe o Novo Nome do Cliente: ");
                    Resposta();
                    cliente.Nome = ler;
                }
                Console.WriteLine("Deseja Editar o RG? S/N");
                Resposta();
                if (ler.ToLower() == "s")
                {
                    Console.WriteLine("Informe o Novo RG do Cliente: ");
                    Resposta();
                    cliente.RG = ler;
                }
                Console.WriteLine("Deseja Editar o Endereço? S/N");
                Resposta();
                if (ler.ToLower() == "s")
                {
                    Console.WriteLine("Informe o Novo Endereço do Cliente: ");
                    Resposta();
                    cliente.Endereco = ler;
                }
                Console.WriteLine("Deseja Editar o Número? S/N");
                Resposta();
                if (ler.ToLower() == "s")
                {
                    Console.WriteLine("Informe o Novo Número do Cliente: ");
                    Resposta();
                    cliente.Numero = int.Parse(ler);
                }
                Console.WriteLine("Deseja Editar o Bairro? S/N");
                Resposta();
                if (ler.ToLower() == "s")
                {
                    Console.WriteLine("Informe o Novo Bairro do Cliente: ");
                    Resposta();
                    cliente.Bairro = ler;
                }
                Console.WriteLine("Deseja Editar a Cidade? S/N");
                Resposta();
                if (ler.ToLower() == "s")
                {
                    Console.WriteLine("Informe a Nova Cidade do Cliente: ");
                    Resposta();
                    cliente.Cidade = ler;
                }
                Console.WriteLine("Deseja Editar o UF? S/N");
                Resposta();
                if (ler.ToLower() == "s")
                {
                    Console.WriteLine("Informe o Novo UF do Cliente: ");
                    Resposta();
                    cliente.UF = ler;
                    }
                clienteRepo.Editar(cliente);
                Console.WriteLine("[AVISO] Cliente Editado com Sucesso!");
            }
            catch
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Voltar();
            }
        }

        static void ListarClientes()
        {
            try
            {
                if (clienteRepo.ConsultarTodos() is null)
                {
                    throw new ArgumentException("[3RR0R] Não Há Nenhum Cliente Cadastrado");
                }
                Console.WriteLine("Lista de Todos os Clientes Cadastrados\n");
                Console.WriteLine("     CPF      |     Nome     |     RG     |    Endereço\n");
                foreach (var item in clienteRepo.ConsultarTodos())
                {
                    Console.WriteLine(item);
                }
            }
            catch(ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Voltar();
            }
                
        }

        static void ConsultarCliente()
        {
            try
            {
                Console.WriteLine("Informe o CPF do Cliente que deseja Consultar (Ex: 111.111.111-11): ");
                Resposta();
                string cpf = ler;
                if (clienteRepo.ConsultarPorCpf(cpf) is null)
                {
                    throw new ArgumentException("[3RR0R] Cliente Não Cadastrado!");
                }
                Cliente cliente = clienteRepo.ConsultarPorCpf(cpf);
                Console.WriteLine("Informações do Cliente\n");
                Console.WriteLine("     CPF      |     Nome     |     RG     |    Endereço\n");
                Console.WriteLine(cliente);
            }
            catch(ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Voltar();
            }  
        }
        
        static void ExcluirCliente()
        {
            try
            {
                Console.WriteLine("Informe o CPF do Cliente que deseja Excluir (Ex: 111.111.111-11): ");
                Resposta();
                string cpf = ler;
                if (clienteRepo.ConsultarPorCpf(cpf) is null)
                {
                    throw new ArgumentException("[3RR0R] Cliente Não Cadastrado!");
                }
                bool clienteTemConta = false;
                Cliente cliente = clienteRepo.ConsultarPorCpf(cpf);
                List<Conta> contas = contaRepo.ConsultarTodos();
                if (contas != null)
                {
                    foreach (Conta item in contas)
                    {
                        var cpfCorrentista = item.Correntista.CPF;
                        if (cliente.CPF == cpfCorrentista)
                        {
                            clienteTemConta = true;
                            break;
                        }
                    }
                }
                if (clienteTemConta == true)
                {
                    throw new ArgumentException("[3RR0R] Cliente Não Pode Ser Excluído Pois Está Vinculado a uma Conta!");
                }
                clienteRepo.Excluir(cpf);
                Console.WriteLine("\n [AVISO] Cliente Excluído com Sucesso!");
            }
            catch(ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Voltar();
            }
        }

        static void MenuMovimentoBancario()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("------Menu Movimento Bancário------");
                Console.WriteLine("[1] Exibir todos os Movimentos Bancários");
                Console.WriteLine("[2] Exibir todos os Movimentos Bancários de uma Conta");
                Console.WriteLine("[3] Voltar");
                Console.WriteLine("--------------------------");
                Resposta();
                switch (ler)
                {
                    case "1":
                        ListarMovimentosBancarios();
                        break;
                    case "2":
                        ListarMovimentosBancariosPorConta();
                        break;
                    case "3":
                        Console.WriteLine("Voltando...");
                        Voltar();
                        break;
                    default:
                        Console.WriteLine("[3RR0R] Opção Inválida");
                        break;
                }
            } while (ler != "1" && ler != "2" && ler != "3" && ler != "4");
        }

        static void ListarMovimentosBancarios()
        {
            try
            {
                List<MovimentoBancario> movimentos = movimentoBancarioRepo.ConsultarTodos();
                if (movimentos is null)
                {
                    throw new ArgumentException("[3RR0R] Não há nenhum Movimento Bancarário Registrado!");
                }
                Console.WriteLine("                             Lista dos Movimentos Bancários                             \n");
                Console.WriteLine("| Id | Agência | Número | Tipo da Conta | Correntista | Movimentação | Valor Movimentado |");
                foreach (var item in movimentos)
                {
                    Console.WriteLine(item);
                }
            }
            catch(ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Voltar();
            }
        }

        static void ListarMovimentosBancariosPorConta()
        {
            ArgumentException e = new("[3RR0R] Algum dado foi inserido incorretamente, por favor tente novamente!");
            try
            {
                Console.WriteLine("Informe o Número da Agência da Conta que deseja ver a movimentação Bancária: ");
                Resposta();
                int agencia = int.Parse(ler);
                Console.WriteLine("Informe o Número da Conta que deseja ver a movimentação Bancária: ");
                Resposta();
                int numero = int.Parse(ler);
                Conta conta = contaRepo.ConsultarPorAgenciaENumero(agencia, numero);
                if (conta is null)
                {
                    e= new ArgumentException("[3RR0R] Conta não Cadastrada!");
                    throw new Exception();
                }
                else
                {
                    List<MovimentoBancario> movimentos = movimentoBancarioRepo.ConsultarPorAgenciaENumero(conta);
                    if (movimentos is null)
                    {
                        e= new ArgumentException("[3RR0R] Não há nenhum Movimento Bancário envolvendo essa Conta!");
                        throw new Exception();
                    }
                    Console.WriteLine("                             Lista dos Movimentos Bancários                             \n");
                    Console.WriteLine("| Id | Agência | Número | Tipo da Conta | Correntista | Movimentação | Valor Movimentado |");
                    foreach (var item in movimentos)
                    {
                        Console.WriteLine(item);
                    }
                }
            }
            catch
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Voltar();
            }
        }
    }
}

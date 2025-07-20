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
        static ContaRepository contaRepo = new ContaRepository();
        static ClienteRepository clienteRepo = new ClienteRepository();
        static void Main(string[] args)
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
            Console.WriteLine("\nPressione quanlquer tecla para voltar");
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
                Console.WriteLine("[9] Voltar");
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
                        Console.WriteLine("Informe o Número da Agência da Conta que deseja efetuar o Depósito: ");
                        Resposta();
                        int agencia = int.Parse(ler);
                        Console.WriteLine("Informe o Número da Conta que deseja efetuar o Depósito: ");
                        Resposta();
                        int numero = int.Parse(ler);
                        if (contaRepo.ConsultarPorAgenciaENumero(agencia, numero) is null)
                        {
                            Console.WriteLine("Conta não Encontrada");
                            Voltar();
                        }
                        else
                        {
                            Conta conta = contaRepo.ConsultarPorAgenciaENumero(agencia, numero);
                            Console.Write("Informe o valor que deseja despositar: R$ ");
                            double deposito = double.Parse(Console.ReadLine());
                            DepositarNaConta(conta, deposito);
                        }
                        break;
                    case 7:
                        Console.WriteLine("Informe o Número da Agência da Conta que deseja efetuar o Saque: ");
                        Resposta();
                        agencia = int.Parse(ler);
                        Console.WriteLine("Informe o Número da Conta que deseja efetuar o Saque: ");
                        Resposta();
                        numero = int.Parse(ler);
                        if (contaRepo.ConsultarPorAgenciaENumero(agencia, numero) is null)
                        {
                            Console.WriteLine("Conta não Encontrada!");
                            Voltar();
                        }
                        else
                        {
                            Conta conta = contaRepo.ConsultarPorAgenciaENumero(agencia, numero);
                            Console.Write("Informe o valor que deseja sacar: R$ ");
                            double saque = double.Parse(Console.ReadLine());
                            SacarDaConta(conta, saque);
                        }
                        break;
                    case 8:
                        Saldo();
                        break;
                    case 9:
                        Console.WriteLine("Voltando...");
                        break;
                    default:
                        Console.WriteLine("[3RR0R] Opção Inválida");
                        break;
                }

            } while (optMenuConta != 9);

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
                        return;
                        break;
                    default:
                        Console.WriteLine("[3RR0R] Opção Inválida");
                        break;
                }
            } while (ler != "1" && ler != "2" && ler != "3");
            Console.WriteLine("Informe o Número da Agência da Conta que deseja Cadastrar: ");
            Resposta();
            int agencia = int.Parse(ler);
            Console.WriteLine("Informe o Número da Conta que deseja Cadastrar: ");
            Resposta();
            int numero = int.Parse(ler);
            if (contaRepo.ConsultarPorAgenciaENumero(agencia,numero) != null)
            {
                Console.WriteLine("Conta já Cadastrada!");
                Voltar();
                return;
            }
            Console.WriteLine("Informe o CPF do Correntista da Conta que deseja Cadastrar (Ex: 111.111.111-11): ");
            Resposta();
            string cpf = ler;
            if (clienteRepo.ConsultarPorCpf(cpf) is null)
            {
                Console.WriteLine("Correntista Não Cadastrado!");
                Voltar();
                return;
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
                if (saldo <= 0)
                {
                    Console.WriteLine("O Saldo Não Pode ser menor ou igual a R$ 0,00\n");
                    Console.Write("Informe o Saldo Inicial da Conta: R$ ");
                    saldo = double.Parse(Console.ReadLine());
                }
            } while (saldo <= 0);
            conta.Depositar(saldo);
            contaRepo.Salvar(conta);
            Console.WriteLine("Conta Cadastrada com Sucesso!");
            Voltar();

        }

        static void EditarConta()
        {
            Console.WriteLine("Informe o Número da Agência da Conta que deseja Editar: ");
            Resposta();
            int agencia = int.Parse(ler);
            Console.WriteLine("Informe o Número da Agência da Conta que deseja Editar: ");
            Resposta();
            int numero = int.Parse(ler);
            if (contaRepo.ConsultarPorAgenciaENumero(agencia,numero) is null)
            {
                Console.WriteLine("Conta não Encontrada!");
                Voltar();
                return;
            }
            Conta conta = contaRepo.ConsultarPorAgenciaENumero(agencia,numero);
            Conta contaEditada = null;
            Console.WriteLine("Deseja editar o tipo da Conta? S/N");
            Resposta();
            if (ler.ToLower() == "s")
            {
                int tipoConta;
                do
                {
                    Console.WriteLine("Informe o Novo Tipo da Conta: [1] Conta Corrente, [2] Conta Investimeto, [3] Conta Poupança");
                    Resposta();
                    tipoConta = int.Parse(ler);
                    switch (tipoConta)
                    {
                        case 1:
                            contaEditada = new ContaCorrente
                            {
                                Agencia = conta.Agencia,
                                Numero = conta.Numero,
                                Correntista = conta.Correntista
                            };
                            break;
                        case 2:
                            contaEditada = new ContaInvestimento
                            {
                                Agencia = conta.Agencia,
                                Numero = conta.Numero,
                                Correntista = conta.Correntista
                            };
                            break;
                        case 3:
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
                } while (tipoConta != 1 && tipoConta != 2 && tipoConta != 3);
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
                        Console.WriteLine("[3RR0R] Correntista não Cadastrado!");
                    }
                } while (clienteRepo.ConsultarPorCpf(cpf) is null);
                contaEditada.Correntista = clienteRepo.ConsultarPorCpf(cpf);
            }
            contaEditada.Depositar(conta.Saldo);
            contaRepo.Editar(contaEditada);
            Console.WriteLine("Conta Editada Com Sucesso!");
            Voltar();
        }
        
        static void ListarContas()
        {
            if (contaRepo.ConsultarTodos() is null)
            {
                Console.WriteLine("[3RR0R] Não Há Nenhuma Conta Cadastrada");
                Voltar();
                return;
            }
            Console.WriteLine("Lista de Todas as Contas Cadastradas\n");
            Console.WriteLine("Agência | Número | Correntista | Tipo da Conta | Saldo\n");
            foreach (var item in contaRepo.ConsultarTodos())
            {
                Console.WriteLine(item);
            }
            Voltar();
        }

        static void ConsultarConta()
        {
            Console.WriteLine("Informe o Número da Agência da Conta que deseja Consultar: ");
            Resposta();
            int agencia = int.Parse(ler);
            Console.WriteLine("Informe o Número da Conta que deseja Consultar: ");
            Resposta();
            int numero = int.Parse(ler);
            if (contaRepo.ConsultarPorAgenciaENumero(agencia, numero) is null)
            {
                Console.WriteLine("Conta não Encontrada");
                Voltar();
                return;
            }
            Conta conta = contaRepo.ConsultarPorAgenciaENumero(agencia, numero);
            Console.WriteLine("------Dados da Conta------");
            Console.WriteLine($"Agência: {conta.Agencia}");
            Console.WriteLine($"Número: {conta.Numero}");
            Console.WriteLine($"Correntista: {conta.Correntista.Nome}");
            Console.WriteLine($"Tipo: {conta.MostrarTipoConta()}");
            Voltar();
        }

        static void ExcluirConta()
        {
            Console.WriteLine("Informe o Número da Agência da Conta que deseja Excluir: ");
            Resposta();
            int agencia = int.Parse(ler);
            Console.WriteLine("Informe o Número da Conta que deseja Excluir: ");
            Resposta();
            int numero = int.Parse(ler);
            if (contaRepo.ConsultarPorAgenciaENumero(agencia, numero) is null)
            {
                Console.WriteLine("Conta não Encontrada");
                Voltar();
                return;
            }
            contaRepo.Excluir(agencia, numero);
            Console.WriteLine("\nConta Excluída com Sucesso");
            Voltar();
        }

        static void SacarDaConta(Conta conta, double valor)
        {
            if (valor > 0 && conta.Saldo >= valor)
            {
                Console.WriteLine("Saque Efetuado com Sucesso!");
            }
            else
            {
                Console.WriteLine("Não foi possível Efetuar o Saque!");
                Voltar();
                return;
            }
            conta.Sacar(valor);
            contaRepo.Editar(conta);
            Voltar();
            
        }
        static void DepositarNaConta(Conta conta, double valor)
        {
            conta.Depositar(valor);
            if (valor > 0)
            {
                Console.WriteLine("Depósito Efetuado com Sucesso!");
            }
            else
            {
                Console.WriteLine("Não foi Possível Efetuar o Depósito!");
                Voltar();
                return;
            }
            if (contaRepo.ConsultarPorAgenciaENumero(conta.Agencia, conta.Numero) == null)
            {
                contaRepo.Salvar(conta);
                Voltar();
                return;
            }
            contaRepo.Editar(conta);
            Voltar();
        }

        static void Saldo()
        {
            Console.WriteLine("Informe o Número da Agência da Conta que deseja Consultar o Saldo: ");
            Resposta();
            int agencia = int.Parse(ler);
            Console.WriteLine("Informe o Número da Conta que deseja Consultar o Saldo: ");
            Resposta();
            int numero = int.Parse(ler);
            if (contaRepo.ConsultarPorAgenciaENumero(agencia, numero) is null)
            {
                Console.WriteLine("Conta não Encontrada");
                Voltar();
                return;
            }
            Conta conta = contaRepo.ConsultarPorAgenciaENumero(agencia, numero);
            Console.WriteLine($"\nSaldo: R$ {conta.Saldo.ToString("F")}");
            Voltar();
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
            Console.WriteLine("Informe o CPF do Cliente que deseja Cadastrar (Ex: 111.111.111-11): ");
            Resposta();
            string cpf = ler;
            if (clienteRepo.ConsultarPorCpf(cpf) != null)
            {
                Console.WriteLine("[3RR0R] Cliente Já Cadastrado!");
                Voltar();
                return;
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
            Cliente cliente = new Cliente
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
            Console.WriteLine("Cliente Cadastrado com Sucesso!");
            Voltar();
        }

        static void EditarCliente()
        {
            Console.WriteLine("Informe o CPF do Cliente que deseja Editar: ");
            Resposta();
            string cpf = ler;
            if (clienteRepo.ConsultarPorCpf(cpf) is null)
            {
                Console.WriteLine("[3RR0R] Cliente Não Cadastrado!");
                Voltar();
                return;
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
            Console.WriteLine("Cliente Editado com Sucesso!");
            Voltar();
        }

        static void ListarClientes()
        {
            if (clienteRepo.ConsultarTodos() is null)
            {
                Console.WriteLine("[3RR0R] Não Há Nenhum Cliente Cadastrado");
                Voltar();
                return;
            }
            Console.WriteLine("Lista de Todos os Clientes Cadastrados\n");
            Console.WriteLine("     CPF      |     Nome     |     RG     |    Endereço\n");
            foreach (var item in clienteRepo.ConsultarTodos())
            {
                Console.WriteLine(item);
            }
            Voltar();
        }

        static void ConsultarCliente()
        {
            Console.WriteLine("Informe o CPF do Cliente que deseja Consultar: ");
            Resposta();
            string cpf = ler;
            if (clienteRepo.ConsultarPorCpf(cpf) is null)
            {
                Console.WriteLine("[3RR0R] Cliente Não Cadastrado!");
                Voltar();
                return;
            }
            Cliente cliente = clienteRepo.ConsultarPorCpf(cpf);
            Console.WriteLine("Informações do Cliente\n");
            Console.WriteLine("     CPF      |     Nome     |     RG     |    Endereço\n");
            Console.WriteLine(cliente);
            Voltar();
        }
        
        static void ExcluirCliente()
        {
            Console.WriteLine("Informe o CPF do Cliente que deseja Excluir: ");
            Resposta();
            string cpf = ler;
            if (clienteRepo.ConsultarPorCpf(cpf) is null)
            {
                Console.WriteLine("[3RR0R] Cliente Não Cadastrado!");
                Voltar();
                return;
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
                Console.WriteLine("[3RR0R] Cliente Não Pode Ser Excluído Pois Está Vinculado a uma Conta!");
                Voltar();
                return;
            }
            clienteRepo.Excluir(cpf);
            Console.WriteLine("\nCliente Excluído com Sucesso!");
            Voltar();

        }
    }
}

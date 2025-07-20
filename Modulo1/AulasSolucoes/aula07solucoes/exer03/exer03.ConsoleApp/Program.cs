using System;
using System.Collections.Generic;
using exer03.Classes;

namespace exer03.ConsoleApp
{
    class Program
    {
        static CrudConta contas = new CrudConta();
        static CrudCliente clientes = new CrudCliente("","","","");
        static string ler = "";
        static int optMenu;
        static int opt;
        static bool analisar;
        static int agencia = 0;
        static double saldo;
        static Cliente cliente = new Cliente("","","","");
        static void Main(string[] args)
        {
            do
            {
                do
                {
                    analisar = true;
                    try
                    {
                        //Menu Principal
                        Console.WriteLine("--------------------------");
                        Console.WriteLine("-----------Menu-----------");
                        Console.WriteLine("--------------------------");
                        Console.WriteLine("[1] Dados das Contas");
                        Console.WriteLine("[2] Dados dos Clientes");
                        Console.WriteLine("[3] Total de Dinheiro em Caixa");
                        Console.WriteLine("[4] Total de Tributos");
                        Console.WriteLine("[5] Testes");
                        Console.WriteLine("[6] Sair");
                        Console.WriteLine("--------------------------");
                        Console.Write("Escolha a opção desejada: ");
                        ler = Console.ReadLine();
                        for (int i = 0; i < ler.Length; i++)
                        {
                            if (ler[i] > 57 || ler[i] < 48)
                            {
                                analisar = false;
                                throw new ArgumentException("Use apenas números nesse campo");
                            }
                        }
                        if (ler.Length > 1)
                        {
                            analisar = false;
                            throw new ArgumentException("O opção indisponível");
                        }
                        optMenu = Convert.ToInt32(ler);
                        if (optMenu > 6 || optMenu < 1)
                        {
                            analisar = false;                        
                            throw new ArgumentException("O opção indisponível");
                        }
                        if (analisar == true)
                        {
                            Console.Clear();
                        }
                    } catch (ArgumentException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                } while (analisar == false);
                switch (optMenu)
                {
                    case 1:
                        MenuContas();
                    break;
                    case 2:
                        MenuClientes();
                    break;
                    case 3:
                        TotalEmCaixa();
                    break;
                    case 4:
                        TotalTributos();
                    break;
                    case 5:
                        Testes();
                    break;
                    case 6:
                        Console.WriteLine("Saindo...");
                        opt = 6;
                    break;
                    default:
                        Console.WriteLine("Opção Inválida");
                    break;
                }
            } while (opt != 6);
        }
        static void MenuContas()
        {
            do
            {
                do
                {
                    analisar = true;
                    try
                    {  
                        Console.WriteLine("--------------------------");
                        Console.WriteLine("--------Menu Conta--------");
                        Console.WriteLine("--------------------------");
                        Console.WriteLine("[1] Adicionar Conta");
                        Console.WriteLine("[2] Editar Conta");
                        Console.WriteLine("[3] Listar Todas as Contas");
                        Console.WriteLine("[4] Consultar Conta");
                        Console.WriteLine("[5] Excluir Conta");
                        Console.WriteLine("[6] Voltar");
                        Console.WriteLine("--------------------------");
                        ler = Console.ReadLine();
                        for (int i = 0; i < ler.Length; i++)
                        {
                            if (ler[i] > 57 || ler[i] < 48)
                            {
                                analisar = false;
                                throw new ArgumentException("Use apenas números nesse campo");
                            }
                        }
                        if (ler.Length > 1)
                        {
                            analisar = false;
                            throw new ArgumentException("O opção indisponível");
                        }
                        optMenu = Convert.ToInt32(ler);
                        if (optMenu > 6 || optMenu < 1)
                        {
                            analisar = false;                        
                            throw new ArgumentException("O opção indisponível");
                        }
                        if (analisar == true)
                        {
                            Console.Clear();
                        }
                    } catch (ArgumentException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                } while (analisar == false);
                switch (optMenu)
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
                        Console.WriteLine("Voltando...");
                    break;
                    default:
                        Console.WriteLine("Opção Indisponível");
                    break;
                }
            } while (optMenu != 6);
        }

        static void MenuClientes()
        {
            do
            {
                do
                {
                    analisar = true;
                    try
                    {  
                        Console.WriteLine("--------------------------");
                        Console.WriteLine("-------Menu Cliente-------");
                        Console.WriteLine("--------------------------");
                        Console.WriteLine("[1] Adicionar Cliente");
                        Console.WriteLine("[2] Editar Cliente");
                        Console.WriteLine("[3] Listar Todos as Clientes");
                        Console.WriteLine("[4] Consultar Cliente");
                        Console.WriteLine("[5] Excluir Cliente");
                        Console.WriteLine("[6] Voltar");
                        Console.WriteLine("--------------------------");
                        ler = Console.ReadLine();
                        for (int i = 0; i < ler.Length; i++)
                        {
                            if (ler[i] > 57 || ler[i] < 48)
                            {
                                analisar = false;
                                throw new ArgumentException("Use apenas números nesse campo");
                            }
                        }
                        if (ler.Length > 1)
                        {
                            analisar = false;
                            throw new ArgumentException("O opção indisponível");
                        }
                        optMenu = Convert.ToInt32(ler);
                        if (optMenu > 6 || optMenu < 1)
                        {
                            analisar = false;                        
                            throw new ArgumentException("O opção indisponível");
                        }
                        if (analisar == true)
                        {
                            Console.Clear();
                        }
                    } catch (ArgumentException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                } while (analisar == false);
                switch (optMenu)
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
                    case 6:
                        Console.WriteLine("Voltando...");
                    break;
                    default:
                        Console.WriteLine("Opção Indisponível");
                    break;
                }
            } while (optMenu != 6);
        }

        static void TotalEmCaixa()
        {
            double totalEmCaixa = 0.0;
            foreach (Conta conta in contas.ConsultarTodos())
            {
                totalEmCaixa+=conta.Saldo;
            }
            Console.WriteLine($"O Total em Caixa é: R$ {totalEmCaixa}");
        }

        static void TotalTributos()
        {
            double totalTributos = 0.0;
            foreach (Conta conta in contas.ConsultarTodos())
            {
                if (conta.Agencia == 02)
                {
                    ContaInvestimento investimento = (ContaInvestimento)conta;
                    totalTributos+= investimento.CalcularTributo();
                } else if (conta.Agencia == 03)
                {
                    ContaCorrente corrente = (ContaCorrente)conta;
                    totalTributos+=corrente.CalcularTributo();
                }
            }
            Console.WriteLine($"O Total de Tributos é: R$ {totalTributos.ToString("F")}");
        }

        static void AdicionarConta()
        {
            do
            {
                do
                {
                    analisar = true;
                    try
                    {
                        Console.WriteLine($"Você gostaria de:");
                        Console.WriteLine("[1] Adicionar Conta Poupança");
                        Console.WriteLine("[2] Adicionar Conta Investimento");
                        Console.WriteLine("[3] Adicionar Conta Corrente");
                        Console.WriteLine("[4] Voltar");
                        ler = Console.ReadLine();
                        for (int i = 0; i < ler.Length; i++)
                        {
                            if (ler[i] > 57 || ler[i] < 48)
                            {
                                analisar = false;
                                throw new ArgumentException("Use apenas números nesse campo");
                            }
                        }
                        if (ler.Length > 1)
                        {
                            analisar = false;
                            throw new ArgumentException("O opção indisponível");
                        }
                        optMenu = Convert.ToInt32(ler);
                        if (optMenu > 4 || optMenu < 1)
                        {
                            analisar = false;                        
                            throw new ArgumentException("O opção indisponível");
                        }
                        if (analisar == true)
                        {
                            Console.Clear();
                        }
                    } catch (ArgumentException e)
                    {
                        Console.WriteLine(e.Message);
                    } 
                } while (analisar == false);
                switch (optMenu)
                {
                    case 1:
                        string cpf;
                        bool cpfJaCadastrado = false;
                        do
                        {
                            do
                            {
                                Console.Write("Informe o CPF do cliente: ");
                                ler = Console.ReadLine();
                            } while(ValCPF(ler) == false);
                            cpf = ler;
                            if (clientes.ConsultarCPF(cpf)==null)
                            {
                                Console.WriteLine("Cliente não cadastrado");
                                cpfJaCadastrado = false;
                            } else
                            {
                                cpfJaCadastrado = true;
                                bool jaPossuiConta = false;
                                foreach (Conta item in contas.ConsultarTodos())
                                {
                                    if (item.Correntista.Cpf == cpf)
                                    {
                                        Console.WriteLine("O Cliente já possui uma conta");
                                        jaPossuiConta = true;
                                    }
                                }
                                if (jaPossuiConta == false)
                                {
                                    Cliente cliente = clientes.ConsultarCPF(cpf);
                                    agencia = 01;
                                    saldo = 0.0;
                                    do
                                    {
                                        Console.Write("Informe o valor de saldo com que deseja abrir a conta: R$ ");
                                        ler = Console.ReadLine();
                                    } while (EDOUBLE(ler) == false);
                                    saldo = Convert.ToDouble(ler);
                                    Conta poupanca = new ContaPoupanca(agencia,cliente,saldo);
                                    poupanca.Numero = poupanca.QuantidadeDeContasAtual();
                                    contas.Cadastrar(poupanca);
                                }    
                            }
                        } while (cpfJaCadastrado == false);
                        
                        
                    break;
                    case 2:
                        cpfJaCadastrado = false;
                        do
                        {
                            do
                            {
                                Console.Write("Informe o CPF do cliente: ");
                                ler = Console.ReadLine();
                            } while(ValCPF(ler) == false);
                            cpf = ler;
                            if (clientes.ConsultarCPF(cpf)==null)
                            {
                                Console.WriteLine("Cliente não cadastrado");
                                cpfJaCadastrado = false;
                            }
                            else
                            {
                                cpfJaCadastrado = true;
                                bool jaPossuiConta = false;
                                foreach (Conta item in contas.ConsultarTodos())
                                {
                                    if (item.Correntista.Cpf == cpf)
                                    {
                                        Console.WriteLine("O Cliente já possui uma conta");
                                        jaPossuiConta = true;
                                    }
                                }
                                if (jaPossuiConta == false)
                                {
                                    Cliente cliente = clientes.ConsultarCPF(cpf);
                                    agencia = 02;
                                    saldo = 0.0;
                                    do
                                    {
                                        Console.Write("Informe o valor de saldo com que deseja abrir a conta: R$ ");
                                        ler = Console.ReadLine();
                                    } while (EDOUBLE(ler) == false);
                                    saldo = Convert.ToDouble(ler);
                                    Conta investimento = new ContaInvestimento(agencia,cliente,saldo);
                                    investimento.Numero = investimento.QuantidadeDeContasAtual();
                                    contas.Cadastrar(investimento);
                                }
                            }
                        } while (cpfJaCadastrado == false);
                    break;
                    case 3:
                        cpfJaCadastrado = false;
                        do
                        {
                            do
                            {
                                Console.Write("Informe o CPF do cliente: ");
                                ler = Console.ReadLine();
                            } while(ValCPF(ler) == false);
                            cpf = ler;
                            if (clientes.ConsultarCPF(cpf)==null)
                            {
                                Console.WriteLine("Cliente não cadastrado");
                                cpfJaCadastrado = false;
                            }
                            else
                            {
                                cpfJaCadastrado = true;
                                bool jaPossuiConta = false;
                                foreach (Conta item in contas.ConsultarTodos())
                                {
                                    if (item.Correntista.Cpf == cpf)
                                    {
                                        Console.WriteLine("O Cliente já possui uma conta");
                                        jaPossuiConta = true;
                                    }
                                }
                                if (jaPossuiConta == false)
                                {
                                    Cliente cliente = clientes.ConsultarCPF(cpf);
                                    agencia = 03;
                                    saldo = 0.0;
                                    do
                                    {
                                        Console.Write("Informe o valor de saldo com que deseja abrir a conta: R$ ");
                                        ler = Console.ReadLine();
                                    } while (EDOUBLE(ler) == false);
                                    saldo = Convert.ToDouble(ler);
                                    Conta corrente = new ContaCorrente(agencia,cliente,saldo);
                                corrente.Numero = corrente.QuantidadeDeContasAtual();
                                contas.Cadastrar(corrente);
                                }  
                            }
                        } while (cpfJaCadastrado == false);
                    break;
                    case 4:
                        Console.WriteLine("Voltando...");
                    break;
                    default:
                        Console.WriteLine("Opção Indisponível");
                    break;
                }
            } while (optMenu != 4);
        }

        static void EditarConta()
        {
            do
            {
                analisar = true;
                do
                {
                    Console.WriteLine("Informe o número da conta que deseja Editar: ");
                    ler = Console.ReadLine();
                } while (ENumero(ler) == false);
                int numero = Convert.ToInt32(ler);
                if (contas.ConsultarNumero(numero) == null)
                {
                    Console.WriteLine("Conta não cadastrada");
                } else
                {
                    Conta editarConta = contas.ConsultarNumero(numero);
                    int agencia =0;
                    string cpf="";
                    do
                    {
                        do
                        {
                            Console.Write("Informe o CPF do cliente: ");
                            ler = Console.ReadLine();
                        } while(ValCPF(ler) == false);
                        cpf = ler;
                        if (editarConta.Correntista.Cpf == cpf)
                        {
                            Console.WriteLine("Gostaria de mudar o tipo de Conta? S/N");
                            ler = Console.ReadLine();
                            if (ler.ToLower() == "s")
                            {
                                bool analisarOpt = true;
                                do
                                {
                                    analisarOpt = true;
                                    try
                                    {
                                        Console.WriteLine($"Você gostaria de Mudar sua Conta para:");
                                        Console.WriteLine("[1] Conta Poupança");
                                        Console.WriteLine("[2] Conta Investimento");
                                        Console.WriteLine("[3] Conta Corrente");
                                        ler = Console.ReadLine();
                                        for (int i = 0; i < ler.Length; i++)
                                        {
                                            if (ler[i] > 57 || ler[i] < 48)
                                            {
                                                analisarOpt = false;
                                                throw new ArgumentException("Use apenas números nesse campo");
                                            }
                                        }
                                        if (ler.Length > 1)
                                        {
                                            analisarOpt = false;
                                            throw new ArgumentException("O opção indisponível");
                                        }
                                        optMenu = Convert.ToInt32(ler);
                                        if (optMenu > 4 || optMenu < 1)
                                        {
                                            analisarOpt = false;                        
                                            throw new ArgumentException("O opção indisponível");
                                        }
                                        if (analisarOpt == true)
                                        {
                                            opt = Convert.ToInt32(ler);
                                            Console.Clear();
                                        }
                                    } catch (ArgumentException e)
                                    {
                                        Console.WriteLine(e.Message);
                                    } 
                                } while (analisarOpt == false);
                                switch(opt)
                                {
                                    case 1:
                                        agencia = 01;
                                        ContaPoupanca poupanca = new ContaPoupanca(editarConta.Agencia, editarConta.Correntista, editarConta.Saldo);
                                        poupanca.Agencia = agencia;
                                        poupanca.Numero = editarConta.Numero;
                                        contas.Editar(editarConta,(Conta)poupanca);
                                    break;
                                    case 2:
                                        agencia = 02;
                                        ContaInvestimento investimento = new ContaInvestimento(editarConta.Agencia, editarConta.Correntista, editarConta.Saldo);
                                        investimento.Agencia = agencia;
                                        investimento.Numero = editarConta.Numero;
                                        contas.Editar(editarConta,(Conta)investimento);
                                    break;
                                    case 3:
                                        agencia = 03;
                                        ContaCorrente corrente = new ContaCorrente(editarConta.Agencia, editarConta.Correntista, editarConta.Saldo);
                                        corrente.Agencia = agencia;
                                        corrente.Numero = editarConta.Numero;
                                        contas.Editar(editarConta,(Conta)corrente);
                                    break;
                                    default:
                                        Console.WriteLine("Opção Inválida");
                                    break;
                                }
                            }
                        } else
                        {
                            Console.WriteLine("O Cliente informado não é o dono dessa Conta");
                        }
                    } while (editarConta.Correntista.Cpf != cpf);
                }
            } while (analisar == false);
        }

        static void ListarContas()
        {
            Console.WriteLine(" Lista de Contas");
            Console.WriteLine(" Agencia | Número | Correntista | Saldo");
            foreach (Conta conta in contas.ConsultarTodos())
            {
                Console.Write($"      {conta.Agencia}     |");
                Console.Write($"  {conta.Numero}  |");
                Console.Write($" {conta.Correntista.Nome}  |");
                Console.WriteLine($"   R$ {conta.Saldo}");
            }
        }

        static void ConsultarConta()
        {
            do
            {
                analisar = true;
                do
                {
                    Console.Write("Informe o número da Conta que deseja Consultar: ");
                    ler = Console.ReadLine();
                } while (ENumero(ler) == false);
                int numero = Convert.ToInt32(ler);
                if (contas.ConsultarNumero(numero) == null)
                {
                    Console.WriteLine("Conta Não Cadastrada");
                    analisar = false;
                } else
                {
                    Conta conta = contas.ConsultarNumero(numero);
                    do
                    {
                        Console.Write("Informe o CPF do Correntista dessa conta: ");
                        ler = Console.ReadLine();
                    } while(ValCPF(ler)==false);
                    string cpf = ler;
                    if (conta.Correntista.Cpf == cpf)
                    {
                        Console.Clear();
                        Console.WriteLine("----------------Informaçoes da Conta-----------------");
                        Console.WriteLine($"Correntista: {conta.Correntista.Nome}");
                        Console.Write("Tipo de Conta: ");
                        if (conta.Agencia is 01)
                        {
                            Console.WriteLine("Poupança");
                            ContaPoupanca poupanca = (ContaPoupanca)conta;
                            Console.WriteLine($"Rendimento: R$ {poupanca.CalcularRendimento()}");
                        }
                        if (conta.Agencia is 02)
                        {
                            Console.WriteLine("Investimento");
                            ContaInvestimento investimento = (ContaInvestimento)conta;
                            Console.WriteLine($"Rendimento: R$ {investimento.CalcularRendimento()}");
                            Console.WriteLine($"Tributo: R$ {investimento.CalcularTributo()}");
                        }
                        if (conta.Agencia is 03)
                        {
                            Console.WriteLine("Corrente");
                            ContaCorrente corrente = (ContaCorrente)conta;
                            Console.WriteLine($"Tributo: R$ {corrente.CalcularTributo()}");
                        }
                        Console.WriteLine($"Numero da Conta: {conta.Numero}");
                        Console.Write("------------------------------------------------------");
                        Console.WriteLine("\n Você gostaria de Sacar, Depositar ou Visualizar seu Saldo? S/N");
                        ler = Console.ReadLine();
                        if (ler.ToLower() == "s")
                        {
                            int opcao = 0;
                            Console.Clear();
                            do
                            {
                                do
                                {
                                    Console.WriteLine("O que você gostaria de fazer?");
                                    Console.WriteLine("[1] Sacar");
                                    Console.WriteLine("[2] Depositar");
                                    Console.WriteLine("[3] Ver Saldo");
                                    Console.WriteLine("[4] Voltar");
                                    Console.Write("Informe o Número da Opção desejada: ");
                                    ler = Console.ReadLine();
                                } while (ENumero(ler) == false);
                                opcao = Convert.ToInt32(ler);
                                switch (opcao)
                                {
                                    case 1:
                                        if (conta.Agencia == 01)
                                        {
                                            ContaPoupanca poupanca = (ContaPoupanca)conta;
                                            do
                                            {
                                                Console.Write("Informe o valor que deseja Sacar: R$ ");
                                                ler = Console.ReadLine();
                                            } while (EDOUBLE(ler) == false);
                                            double saque = Convert.ToDouble(ler);
                                            if (poupanca.Sacar(saque) == true)
                                            {
                                                contas.Editar(conta,poupanca);
                                            }
                                            
                                        }
                                        if (conta.Agencia == 02)
                                        {
                                            ContaInvestimento investimento = (ContaInvestimento)conta;
                                            do
                                            {
                                                Console.Write("Informe o valor que deseja Sacar: R$ ");
                                                ler = Console.ReadLine();
                                            } while (EDOUBLE(ler) == false);
                                            double saque = Convert.ToDouble(ler);
                                            if(investimento.Sacar(saque)==true)
                                            {
                                                contas.Editar(conta,investimento);
                                            }
                                        }
                                        if (conta.Agencia == 03)
                                        {
                                            ContaCorrente corrente = (ContaCorrente)conta;
                                            do
                                            {
                                                Console.Write("Informe o valor que deseja Sacar: R$ ");
                                                ler = Console.ReadLine();
                                            } while (EDOUBLE(ler) == false);
                                            double saque = Convert.ToDouble(ler);
                                            if(corrente.Sacar(saque)==true)
                                            {
                                                contas.Editar(conta,corrente);
                                            }
                                        }
                                    break;
                                    case 2:
                                        if (conta.Agencia == 01)
                                        {
                                            ContaPoupanca poupanca = (ContaPoupanca)conta;
                                            do
                                            {
                                                Console.Write("Informe o valor que deseja Depositar: R$ ");
                                                ler = Console.ReadLine();
                                            } while (EDOUBLE(ler) == false);
                                            double deposito = Convert.ToDouble(ler);
                                            if (poupanca.Depositar(deposito) == true)
                                            {
                                                contas.Editar(conta,poupanca);
                                            }
                                        }
                                        if (conta.Agencia == 02)
                                        {
                                            ContaInvestimento investimento = (ContaInvestimento)conta;
                                            do
                                            {
                                                Console.Write("Informe o valor que deseja Depositar: R$ ");
                                                ler = Console.ReadLine();
                                            } while (EDOUBLE(ler) == false);
                                            double deposito = Convert.ToDouble(ler);
                                            if (investimento.Depositar(deposito) == true)
                                            {
                                                contas.Editar(conta,investimento);
                                            }
                                        }
                                        if (conta.Agencia == 03)
                                        {
                                            ContaCorrente corrente = (ContaCorrente)conta;
                                            do
                                            {
                                                Console.Write("Informe o valor que deseja Depositar: R$ ");
                                                ler = Console.ReadLine();
                                            } while (EDOUBLE(ler) == false);
                                            double deposito = Convert.ToDouble(ler);
                                            if (corrente.Depositar(deposito) == true)
                                            {
                                                contas.Editar(conta,corrente);
                                            }
                                        }
                                    break;
                                    case 3:
                                        Console.WriteLine($"Saldo: R$ {conta.Saldo}");
                                    break;
                                    case 4:
                                        Console.WriteLine("Voltando...");
                                    break;
                                    default:
                                        Console.WriteLine("Opção Inválida");
                                    break;
                                }
                            } while (opcao != 4);
                        }
                    } else
                    {
                        Console.Write("O CPF informado difere do CPF do Correntista desta Conta");
                    }
                }
            } while (analisar == false);
        }

        static void ExcluirConta()
        {
            do
            {
                analisar = true;
                do
                {
                    Console.Write("Informe o número da Conta que deseja Excluir: ");
                    ler = Console.ReadLine();
                } while (ENumero(ler) == false);
                int numero = Convert.ToInt32(ler);
                if (contas.ConsultarNumero(numero) == null)
                {
                    Console.WriteLine("Conta Não Cadastrada");
                    analisar = false;
                } else
                {
                    Conta conta = contas.ConsultarNumero(numero);
                    do
                    {
                        Console.Write("Informe o CPF do Correntista dessa conta: ");
                        ler = Console.ReadLine();
                    } while(ValCPF(ler)==false);
                    string cpf = ler;
                    if (conta.Correntista.Cpf == cpf)
                    {
                        Console.WriteLine("Tem certeza que deseja excluir esta conta?: S/N");
                        ler = Console.ReadLine();
                        if (ler.ToLower() == "s")
                        {
                            contas.Excluir(conta);
                            Console.WriteLine("Conta Excluída!");
                        }
                    }

                }
            } while (analisar == false);
        }

        static void AdicionarCliente()
        {
            do
            {
                analisar = true;
                Console.Write("Informe o Nome do Cliente: ");
                string nome = Console.ReadLine();
                bool cpfJaCadastrado = false;
                do
                {
                    cpfJaCadastrado = false;
                    do
                    {
                        do
                        {
                            Console.Write("Informe o CPF do Cliente: ");
                            ler = Console.ReadLine();
                        } while(ValCPF(ler)==false);
                    } while(ValidarCPF(ler) == false);
                    
                    if (clientes.ConsultarCPF(ler) != null )
                    {
                        cpfJaCadastrado = true;
                        Console.WriteLine("Um Cliente com esse CPF já foi cadastrado!");
                    }
                } while (cpfJaCadastrado == true);
                string cpf = ler;
                do
                {
                    Console.Write("Informe o RG do Cliente: ");
                    ler = Console.ReadLine();
                } while (ValRg(ler) == false);
                string rg = ler;
                Console.Write("Informe o Endereço do Cliente: ");
                string endereco = Console.ReadLine();
                Cliente cliente = new Cliente(nome,cpf,rg,endereco);
                clientes.Cadastrar(cliente);


            } while (analisar == false);
        }

        static void EditarCliente()
        {
            do
            {
                analisar = true;
                string nome = "";
                string cpfEditar = "";
                string rg = "";
                string endereco = "";
                do
                {
                    Console.Write("Informe o CPF do Cliente que deseja editar: ");
                    ler = Console.ReadLine();
                } while(ValCPF(ler)==false);
                string cpf = ler;
                if (clientes.ConsultarCPF(cpf) == null)
                {
                    Console.Write("Cliente não cadastrado");
                } else
                {
                    Cliente cliente = clientes.ConsultarCPF(cpf);
                    Console.WriteLine("Deseja Editar o Nome do Cliente? S/N");
                    ler=Console.ReadLine();
                    if (ler.ToLower() == "s")
                    {
                       Console.Write("Informe o Novo Nome do Cliente: ");
                       nome=Console.ReadLine();
                    }
                    Console.WriteLine("Deseja Editar o RG do Cliente? S/N");
                    ler=Console.ReadLine();
                    if (ler.ToLower() == "s")
                    {
                        do
                        {
                            Console.Write("Informe o Novo RG do Cliente: ");
                            ler=Console.ReadLine();
                        } while (ValRg(ler) == false);
                        rg = ler;
                    }
                    Console.WriteLine("Deseja Editar o Endereço do Cliente? S/N");
                    ler=Console.ReadLine();
                    if (ler.ToLower() == "s")
                    {
                        Console.Write("Informe o Novo Endereço do Cliente: ");
                        endereco = Console.ReadLine();
                    }
                    Cliente editarCliente = clientes.ConsultarCPF(cpf);
                    if (nome.Length > 0)
                    {
                        editarCliente.Nome = nome;
                    }
                    if (cpfEditar.Length > 0)
                    {
                        editarCliente.Cpf = cpfEditar;
                    }
                    if (rg.Length > 0)
                    {
                        editarCliente.Rg = rg;
                    }
                    if (endereco.Length > 0)
                    {
                        editarCliente.Endereco = endereco;
                    }
                    clientes.Editar(editarCliente);
                }
            } while (analisar == false);
        }

        static void ListarClientes()
        {
            Console.WriteLine(" Lista de Clientes");
            Console.WriteLine(" CPF | Nome | RG | Endereço");
            foreach (KeyValuePair<string, Cliente> par in clientes.ConsultarTodos())
            {
                Cliente item = par.Value;
                string cpf = item.Cpf;
                string rg = item.Rg;
                Console.Write($" {cpf[0]}{cpf[1]}{cpf[2]}.{cpf[3]}{cpf[4]}{cpf[5]}.{cpf[6]}{cpf[7]}{cpf[8]}-{cpf[9]}{cpf[10]} |");
                Console.Write($" {item.Nome} |");
                Console.Write($" {rg[0]}{rg[1]}.{rg[2]}{rg[3]}{rg[4]}.{rg[5]}{rg[6]}{rg[7]}-{rg[8]} |");
                Console.WriteLine($" {item.Endereco}");
            }

        }

        static void ConsultarCliente()
        {
            do
            {
                Console.Write("Informe o CPF do Cliente que deseja Consultar: ");
                ler = Console.ReadLine();
            } while(ValCPF(ler)==false);
            string cpf = ler;
            if (clientes.ConsultarCPF(cpf) == null)
            {
                Console.Write("Cliente não cadastrado");
            } else
            {
                Cliente cliente = clientes.ConsultarCPF(cpf);
                cpf = cliente.Cpf;
                string rg = cliente.Rg;
                Console.WriteLine(" Lista de Clientes");
                Console.WriteLine(" CPF | Nome | RG | Endereço");
                Console.Write($" {cpf[0]}{cpf[1]}{cpf[2]}.{cpf[3]}{cpf[4]}{cpf[5]}.{cpf[6]}{cpf[7]}{cpf[8]}-{cpf[9]}{cpf[10]} |");
                Console.Write($" {cliente.Nome} |");
                Console.Write($" {rg[0]}{rg[1]}.{rg[2]}{rg[3]}{rg[4]}.{rg[5]}{rg[6]}{rg[7]}-{rg[8]} |");
                Console.WriteLine($" {cliente.Endereco}");
            }
        }

        static void ExcluirCliente()
        {
            do
            {
                Console.Write("Informe o CPF do Cliente que deseja Excluir: ");
                ler = Console.ReadLine();
            } while(ValCPF(ler)==false);
            string cpf = ler;
            if (clientes.ConsultarCPF(cpf) == null)
            {
                Console.Write("Cliente não cadastrado");
            } else
            {
                Cliente cliente = clientes.ConsultarCPF(cpf);
                bool clienteViculadoAConta = false;
                foreach (Conta conta in contas.ConsultarTodos())
                {
                    if (cliente == conta.Correntista)
                    {
                        clienteViculadoAConta = true;
                    }
                }
                if (clienteViculadoAConta == true)
                {
                    Console.WriteLine("Não é possível  Excluir um Cliente vinculado a uma Conta!");
                } else
                {
                    Console.WriteLine("Tem certeza que deseja excluir o Cliente? S/N");
                    ler = Console.ReadLine();
                    if (ler.ToLower() == "s")
                    {
                        clientes.Excluir(cliente);
                        Console.WriteLine("Cliente excluído!");
                    }
                }
                
            }
        }

        static bool ENumero (string palavra)
        {
            for (int i = opt; i < palavra.Length; i++)
            {
                if (palavra[i] > 57 || palavra[i] < 48)
                {
                    Console.WriteLine("Use apenas números nesse campo");
                    return false;
                }
            }
            return true;
        }
        static bool EDOUBLE (string palavra)
        {
            int contarVirgula = 0;
            for (int i = opt; i < palavra.Length; i++)
            {
                if ((palavra[i] > 57 || palavra[i] < 48) && palavra[i] != 44)
                {
                    Console.WriteLine("Use apenas números nesse campo");
                    return false;
                } else if (palavra[i] == 44)
                {
                    contarVirgula++;
                    if (contarVirgula > 1)
                    {
                        Console.WriteLine("Não use mais de uma vírgula para esse valor");
                        return false;
                    } else if (i+2 != palavra.Length-1)
                    {
                        Console.WriteLine("O número só pode ter 2 casas decimais após a vírgula");
                        return false;
                    }
                }
            }
            return true;
        }

        static bool ValCPF(string Cpf)
        {
            try
            {
                if (Cpf.Length < 11 || Cpf.Length > 11)
                {
                    throw new ArgumentException("O número de caracteres inseridos não bate com a quantidade que essa informação exige");;
                }
                for (int i = 0; i < Cpf.Length; i++)
                {
                    if (Cpf[i] < 48 || Cpf[i] > 57)
                    {
                        throw new ArgumentException("Use apenas números nessa informação");
                    }
                }
                return true;
            } catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
        static bool ValRg (string Rg)
        {
            try
            {
                if (Rg.Length < 9 || Rg.Length > 9)
                {
                    throw new ArgumentException("O número de caracteres inseridos não bate com a quantidade que essa informação exige");;
                }
                for (int i = 0; i < Rg.Length; i++)
                {
                    if (Rg[i] < 48 || Rg[i] > 57)
                    {
                        throw new ArgumentException("Use apenas números nessa informação");
                    }
                }
                Console.WriteLine("RG válido");
                return true;
            } catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
        static bool ValidarCPF(string cpf)
        {
            int num1 = 0;
            int num2 = 0;
            int multiplicador = 10;
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    if (ValorNumero(cpf[i]) > 9)
                    {
                        throw new ArgumentException("3RR0R: use apenas números");
                    }
                    else
                    {
                        if (i < 9)
                        {
                            num1 += (ValorNumero(cpf[i])) * multiplicador; // gerando um cpf válido cpf 12345678909 //outro cpf válido 12345678800
                            //(1*10)+(2*9)+(3*8)+(4*7)+(5*6)+(6*5)+(7*4)+(8*3)+(8*2)=28+52+60+52+16=80+60+68=208%11=10
                            //(1*11)+(2*10)+(3*9)+(4*8)+(5*7)+(6*6)+(7*5)+(8*4)+(8*3)+(0*2)=11+20+27+32+35+36+35+32+24+0=31+59+71+67+24=90+71+91=252%11=10
                        }
                        num2 += (ValorNumero(cpf[i])) * (multiplicador + 1);
                        multiplicador--;
                    }
                }
            } catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
                return false;
            } 
            num1 = num1%11;
            if (num1 < 2)
            {
                num1 = 0;
            }
            else
            {
                num1 = 11 - num1;
            }
            num2 = num2%11;
            if (num2 < 2)
            {
                num2 = 0;
            }
            else
            {
                num2 = 11 - num2;
            }
            try
            {
                if ($"{num1}{num2}" == $"{cpf[9]}{cpf[10]}")
                {
                    return true;
                }
                else
                {
                    throw new ArgumentException("CPF inválido");
                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
        static int ValorNumero(int numero)
        {
            switch (numero)
            {
                case 48:
                    return 0;
                    break;
                case 49:
                    return 1;
                    break;
                case 50:
                    return 2;
                    break;
                case 51:
                    return 3;
                    break;
                case 52:
                    return 4;
                    break;
                case 53:
                    return 5;
                    break;
                case 54:
                    return 6;
                    break;
                case 55:
                    return 7;
                    break;
                case 56:
                    return 8;
                    break;
                case 57:
                    return 9;
                    break;
                default:
                    return 10;
                    break;
            }
        }
        static void Testes()
        {
            string testeCpf1 = "01234567890";
            string testeCpf2 = "0123456y789";
            string testeCpf3 = "12345678909";
            Console.WriteLine("-----------Teste 1 CPF-----------");
            if (ValCPF(testeCpf1) == true)
            {
                Console.WriteLine("O CPF Só possui números, agora vamos para a validação do cpf");
                Console.WriteLine("-----------Teste 2 CPF-----------");
                if (ValidarCPF(testeCpf1) == true)
                {
                    Console.WriteLine("CPF validado, agora vamos ver se  o CPF já não está cadastrado");
                    Console.WriteLine("-----------Teste 3 CPF-----------");
                    if (clientes.ConsultarCPF(testeCpf1) == null)
                    {
                        Console.WriteLine("CPF ainda não cadastrado");
                    }
                    else
                    {
                        Console.WriteLine("CPF cadastrado");
                    }
                }
                else
                {
                    Console.WriteLine("CPF inválido");
                }
            }
            else
            {
                Console.WriteLine("3RR0R: o CPF não possui apenas números");
            }
            Console.WriteLine("-----------Teste 1 CPF-----------");
            if (ValCPF(testeCpf2) == true)
            {
                Console.WriteLine("O CPF Só possui números, agora vamos para a validação do cpf");
                Console.WriteLine("-----------Teste 2 CPF-----------");
                if (ValidarCPF(testeCpf2) == true)
                {
                    Console.WriteLine("CPF validado, agora vamos ver se  o CPF já não está cadastrado");
                    Console.WriteLine("-----------Teste 3 CPF-----------");
                    if (clientes.ConsultarCPF(testeCpf2) == null)
                    {
                        Console.WriteLine("CPF ainda não cadastrado");
                    }
                    else
                    {
                        Console.WriteLine("CPF cadastrado");
                    }
                }
                else
                {
                    Console.WriteLine("CPF inválido");
                }
            }
            else
            {
                Console.WriteLine("3RR0R: o CPF não possui apenas números");
            }
            Console.WriteLine("-----------Teste 1 CPF-----------");
            if (ValCPF(testeCpf3) == true)
            {
                Console.WriteLine("O CPF Só possui números, agora vamos para a validação do cpf");
                Console.WriteLine("-----------Teste 2 CPF-----------");
                if (ValidarCPF(testeCpf3) == true)
                {
                    Console.WriteLine("CPF validado, agora vamos ver se  o CPF já não está cadastrado");
                    Console.WriteLine("-----------Teste 3 CPF-----------");
                    if (clientes.ConsultarCPF(testeCpf3) == null)
                    {
                        Console.WriteLine("CPF ainda não cadastrado");
                    }
                    else
                    {
                        Console.WriteLine("CPF cadastrado");
                    }
                }
                else
                {
                    Console.WriteLine("CPF inválido");
                }
            }
            else
            {
                Console.WriteLine("3RR0R: o CPF não possui apenas números");
            }
            Cliente clienteTeste1 = new Cliente("Michael", "12345678902", "123456789", "Rua das Bananas");
            Conta contaTeste1 = new ContaCorrente(03, clienteTeste1, 2000.00);
            Cliente clienteTeste2 = new Cliente("Otavio", "09876543211", "123456777", "Casas Bahia");
            Conta contaTeste2 = new ContaPoupanca(01, clienteTeste2, 1000.00);
            Cliente clienteTeste3 = new Cliente("Anne Frank", "12378945601", "987654321", "Costa Rica");
            Conta contaTeste3 = new ContaPoupanca(02, clienteTeste3, 10000.00);
            contaTeste1.Numero=2023;
            contaTeste2.Numero=1984;
            contaTeste3.Numero=0413;
            clientes.Cadastrar(clienteTeste2);
            clientes.Cadastrar(clienteTeste3);
            contas.Cadastrar(contaTeste2);
            Console.WriteLine("-----------Teste 4 Cliente-----------");
            Console.WriteLine("Verificando se o Cliente já está cadastrado: ");
            if (clientes.ConsultarCPF(clienteTeste1.Cpf) is null)
            {
                Console.WriteLine("Cliente não Cadastrado");
            }
            else
            {
                //Exibindo os Dados do Cliente
            }
            Console.WriteLine("-----------Teste 4 Cliente-----------");
            Console.WriteLine("Verificando se o Cliente já está cadastrado: ");
            if (clientes.ConsultarCPF(clienteTeste2.Cpf) is null)
            {
                Console.WriteLine("Cliente não Cadastrado");
            }
            else
            {
                //Exibindo os Dados do Cliente
            }
            Console.WriteLine("-----------Teste 4 Cliente-----------");
            Console.WriteLine("Verificando se o Cliente já está cadastrado: ");
            if (clientes.ConsultarCPF(clienteTeste3.Cpf) is null)
            {
                Console.WriteLine("Cliente não Cadastrado");
            }
            else
            {
                //Exibindo os Dados do Cliente
            }
            Console.WriteLine("-----------Teste 5 Cliente-----------");
            Console.WriteLine("Verificando se a Conta já está Cadastrada: ");
            if (contas.ConsultarNumero(contaTeste1.Numero) == null)
            {
                Console.WriteLine("Conta Não Cadastrada");
            }
            else
            {
                Conta contaTeste = contas.ConsultarNumero(contaTeste1.Numero);
                Console.WriteLine("-----------Teste 6 Conta-----------");
                Console.WriteLine("Verificando se o CPF do Cliente bate com o CPF cadastrado na Conta: ");
                if (contaTeste.Correntista.Cpf == "12345678902")
                {
                    //Mostrar Informações da Conta
                }
                else
                {
                    Console.WriteLine("O CPF informado difere do CPF pertencente à Conta");
                }
            }
            Console.WriteLine("-----------Teste 5 Conta-----------");
            Console.WriteLine("Verificando se a Conta já está Cadastrada: ");
            if (contas.ConsultarNumero(contaTeste2.Numero) == null)
            {
                Console.WriteLine("Conta Não Cadastrada");
            }
            else
            {
                Conta contaTeste = contas.ConsultarNumero(contaTeste2.Numero);
                Console.WriteLine("-----------Teste 6 Conta-----------");
                Console.WriteLine("Verificando se o CPF do Cliente bate com o CPF cadastrado na Conta: ");
                if (contaTeste.Correntista.Cpf == "09876543211")
                {
                    //Mostrar Informações da Conta
                }
                else
                {
                    Console.WriteLine("O CPF informado difere do CPF pertencente à Conta");
                }
            }
            Console.WriteLine("-----------Teste 5 Conta-----------");
            Console.WriteLine("Verificando se a Conta já está Cadastrada: ");
            if (contas.ConsultarNumero(contaTeste2.Numero) == null)
            {
                Console.WriteLine("Conta Não Cadastrada");
            }
            else
            {
                Conta contaTeste = contas.ConsultarNumero(contaTeste2.Numero);
                Console.WriteLine("-----------Teste 6 Conta-----------");
                Console.WriteLine("Verificando se o CPF do Cliente bate com o CPF cadastrado na Conta: ");
                if (contaTeste.Correntista.Cpf == "09876543210") //Teste Igual ao Anterior mas com CPF diferente
                {
                    //Mostrar Informações da Conta
                }
                else
                {
                    Console.WriteLine("O CPF informado difere do CPF pertencente à Conta");
                }
            }
            Console.WriteLine("-----------Teste 5 Conta-----------");
            Console.WriteLine("Verificando se a Conta já está Cadastrada: ");
            if (contas.ConsultarNumero(contaTeste3.Numero) == null)
            {
                Console.WriteLine("Conta Não Cadastrada");
            }
            else
            {
                Conta contaTeste = contas.ConsultarNumero(contaTeste3.Numero);
                Console.WriteLine("-----------Teste 6 Conta-----------");
                Console.WriteLine("Verificando se o CPF do Cliente bate com o CPF cadastrado na Conta: ");
                if (contaTeste.Correntista.Cpf == "12378945601")
                {
                    //Mostrar Informações da Conta
                }
                else
                {
                    Console.WriteLine("O CPF informado difere do CPF pertencente à Conta");
                }
            }
            Console.WriteLine("-----------Teste 7 Conta-----------");
            Console.WriteLine("Fazendo Depósito: ");
            if (contaTeste2.Depositar(-1000.00))
            {
                //Mostrar Mensagem dizendo que o Depósito foi efetuado com Sucesso
            }
            else
            {
                //Mostrar Mensagem dizendo que não foi possível efetuar o Depósito e informar o motivo
            }
            Console.WriteLine("-----------Teste 8 Conta-----------");
            Console.WriteLine("Fazendo Saque: ");
            if (contaTeste2.Sacar(250.00))
            {
                //Mostrar Mensagem dizendo que o Saque foi efetuado com Sucesso
            }
            else
            {
                //Mostrar Mensagem dizendo que não foi possível efetuar o Saque e informar o motivo
            }
            //Corrente:03  Poupança:01  Investimento:02
            Console.WriteLine("-----------Teste 9 Conta-----------");
            Console.WriteLine("Excluindo Conta: ");
            contas.Excluir(contaTeste2);
            //Mensagem Informando que a Conta foi excluindo
            Console.WriteLine("-----------Teste 10 Cliente-----------");
            Console.WriteLine("Excluindo Cliente: ");
            clientes.Excluir(clienteTeste2);
            //Mensagem Informando que o Cliente foi excluindo
            clientes.Excluir(clienteTeste2);
            clientes.Excluir(clienteTeste3);
            contas.Excluir(contaTeste2);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace exer02
{
    class Program
    {
        static int menuOpt;
        static CrudConta contas = new CrudConta();
        static TotalizadorContas saldoTotal = new TotalizadorContas();
        static TotalizadorRendimento rendimentoTotal = new TotalizadorRendimento(); 
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("======Menu======");
                Console.WriteLine("[1] Adicionar Conta");
                Console.WriteLine("[2] Editar Conta");
                Console.WriteLine("[3] Listar Contas");
                Console.WriteLine("[4] Consultar Conta");
                Console.WriteLine("[5] Excluir Conta");
                Console.WriteLine("[6] Valor Total das Contas");
                Console.WriteLine("[7] Valor Total do Rendimento");
                Console.WriteLine("[8] Grandes Contas");
                Console.WriteLine("[9] Sair");
                Console.WriteLine("================");
                Console.Write("\nInforme o Número da Opção Desejada: ");
                menuOpt = int.Parse(Console.ReadLine());
                switch (menuOpt)
                {
                    case 1:
                        Console.Clear();
                        int tipoConta;
                        do
                        {
                            Console.WriteLine("Escolha o Tipo de Conta que Deseja Adicionar: ");
                            Console.WriteLine("[1] Conta Poupança");
                            Console.WriteLine("[2] Conta Corrente");
                            Console.WriteLine("[3] Conta Investimento");
                            Console.Write("\n=> ");
                            tipoConta = int.Parse(Console.ReadLine());
                        } while (tipoConta > 3 || tipoConta < 1); 
                        Console.Write("Informe o Número da Agência da Conta: ");
                        int agencia = int.Parse(Console.ReadLine());
                        Console.Write("Informe o Nome do Correntista da Conta: ");
                        string correntista = Console.ReadLine();
                        double saldo;
                        do
                        {
                            Console.Write("Informe o Saldo da Conta: R$ ");
                            saldo = double.Parse((double.Parse(Console.ReadLine())).ToString("F"));
                            if (saldo <= 0)
                            {
                                Console.WriteLine("[3RR0R] O saldo inicial não pode ser igual ou inferior a 0!");
                            }
                        } while (saldo <= 0);
                        switch (tipoConta)
                        {
                            case 1:
                                ContaPoupanca contaP = new ContaPoupanca(agencia, correntista);
                                contaP.Depositar(saldo);
                                contas.Adicionar(contaP);
                                saldoTotal.SomarSaldo(contaP);
                                rendimentoTotal.AdicionarPoup(contaP);
                                break;
                            case 2:
                                ContaCorrente contaC = new ContaCorrente(agencia, correntista);
                                contaC.Depositar(saldo);
                                contas.Adicionar(contaC);
                                saldoTotal.SomarSaldo(contaC);
                                break;
                            case 3:
                                ContaInvestimento contaI = new ContaInvestimento(agencia, correntista);
                                contaI.Depositar(saldo);
                                contas.Adicionar(contaI);
                                saldoTotal.SomarSaldo(contaI);
                                rendimentoTotal.AdicionarInv(contaI);
                                break;
                            default:
                                Console.WriteLine("[3RR0R] Opção Inválida!");
                                break;
                        }
                        break;
                    case 2:
                        Console.Clear();
                        Console.Write("Informe o Número da Conta que Deseja Editar: ");
                        int numeroConta = int.Parse(Console.ReadLine());
                        if (contas.Consultar(numeroConta) == null)
                        {
                            Console.WriteLine("[3RR0R] Conta Não Cadastrada!");
                        }
                        else
                        {
                            Conta conta = contas.Consultar(numeroConta);
                            Console.WriteLine("Deseja editar a Agência da Conta? S/N");
                            string ler = Console.ReadLine();
                            if (ler.ToLower() == "s")
                            {
                                Console.Write("Informe o Novo Número da Agência da Conta: ");
                                agencia = int.Parse(Console.ReadLine());
                                conta.Agencia = agencia;
                            }
                            Console.WriteLine("Deseja editar o Correntista da Conta? S/N");
                            ler = Console.ReadLine();
                            if (ler.ToLower() == "s")
                            {
                                Console.Write("Informe o Novo Correntista da Conta: ");
                                correntista = Console.ReadLine();
                                conta.Correntista = correntista;
                            }
                            contas.Editar(conta);
                        }
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("=====Lista de Contas=====");
                        Console.Write("Agência");
                        Console.Write("|");
                        Console.Write("Número");
                        Console.Write("|");
                        Console.Write("Correntista");
                        Console.Write("|");
                        Console.WriteLine("Saldo");
                        foreach (KeyValuePair<int, Conta> par in contas.Listar())
                        {
                            Console.WriteLine(par.Value.ToString());
                        }
                        Console.WriteLine("==========================");
                        break;
                    case 4:
                        Console.Clear();
                        Console.Write("Informe o Número da Conta que Deseja Consultar: ");
                        int nConta = int.Parse(Console.ReadLine());
                        if (contas.Consultar(nConta) == null)
                        {
                            Console.WriteLine("[3RR0R] Conta Não Cadastrada!");
                        }
                        else
                        {
                            foreach (KeyValuePair<int,Conta> par in contas.Listar())
                            {
                                if (par.Key == nConta)
                                {
                                    int optConta;
                                    do
                                    {
                                        Console.WriteLine("=====Dados da Conta=====");
                                        Console.Write("Agência");
                                        Console.Write("|");
                                        Console.Write("Número");
                                        Console.Write("|");
                                        Console.WriteLine("Correntista");
                                        Console.WriteLine($"{par.Value.Agencia}|{par.Value.Numero}|{par.Value.Correntista}");
                                        Console.WriteLine("========================");
                                        Console.WriteLine("=====Menu=====");
                                        Console.WriteLine("[1] Sacar");
                                        Console.WriteLine("[2] Depositar");
                                        Console.WriteLine("[3] Saldo");
                                        Console.WriteLine("==============");
                                        Console.Write("Informe o Número da Opção Desejada: ");
                                        optConta = int.Parse(Console.ReadLine());
                                        switch (optConta)
                                        {
                                            case 1:
                                                Console.Write("Informe o Valor que Deseja Sacar: R$ ");
                                                double saque = double.Parse(Console.ReadLine());
                                                saldoTotal.RemoverSaldo(par.Value);
                                                par.Value.Sacar(saque);
                                                if (rendimentoTotal.ExcluirInv(par.Value.Numero)==true)
                                                {
                                                    rendimentoTotal.AdicionarInv((ContaInvestimento)par.Value);
                                                }
                                                else if (rendimentoTotal.ExcluirPoup(par.Value.Numero) == true)
                                                {
                                                    rendimentoTotal.AdicionarPoup((ContaPoupanca)par.Value);
                                                }
                                                saldoTotal.SomarSaldo(par.Value);
                                                break;
                                            case 2:
                                                Console.Write("Informe o Valor que Deseja Depositar: R$ ");
                                                double deposito = double.Parse(Console.ReadLine());
                                                saldoTotal.RemoverSaldo(par.Value);
                                                par.Value.Depositar(deposito);
                                                if (rendimentoTotal.ExcluirInv(par.Value.Numero)==true)
                                                {
                                                    rendimentoTotal.AdicionarInv((ContaInvestimento)par.Value);
                                                }
                                                else if (rendimentoTotal.ExcluirPoup(par.Value.Numero) == true)
                                                {
                                                    rendimentoTotal.AdicionarPoup((ContaPoupanca)par.Value);
                                                }
                                                saldoTotal.SomarSaldo(par.Value);
                                                break;
                                            case 3:
                                                Console.WriteLine($"Seu Saldo Atual é: R$ {par.Value.Saldo.ToString("F")}");
                                                break;
                                            default:
                                                Console.WriteLine("[3RR0R] Opção Inválida!");
                                                break;
                                        }
                                    } while (optConta != 3);
                                }
                            }
                        }
                        break;
                    case 5:
                        Console.Write("Informe o Número da Conta que Deseja Excluir: ");
                        int contaExcluir = int.Parse(Console.ReadLine());
                        if (contas.Consultar(contaExcluir) == null)
                        {
                            Console.WriteLine("[3RR0R] Conta Não Cadastrada!");
                        }
                        else
                        {
                            saldoTotal.RemoverSaldo(contas.Consultar(contaExcluir));
                            contas.Excluir(contaExcluir);
                            Console.WriteLine("Conta Excluída com Sucesso!");
                            if (rendimentoTotal.ExcluirInv(contaExcluir)==true)
                            {
                            }
                            else if (rendimentoTotal.ExcluirPoup(contaExcluir) == true)
                            {
                            }
                        }
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine(saldoTotal.ToString());
                        break;
                    case 7:
                        Console.Clear();
                        Console.WriteLine(rendimentoTotal.ToString());
                        break;
                    case 8:
                        List<Conta> listaContas = new List<Conta>();
                        foreach (KeyValuePair<int,Conta> par in contas.Listar())
                        {
                            listaContas.Add(par.Value);
                        }
                        var listaContasGrandes = from c in listaContas 
                        where c.Saldo > 500000 select new {c.Agencia, c.Numero, c.Correntista, c.Saldo};
                        Console.WriteLine("=====Relatório de Contas Grandes=====");
                        Console.WriteLine("Agência | Número | Correntista | Saldo");
                        foreach (var item in listaContasGrandes)
                        {
                            Console.WriteLine($"{item.Agencia}|{item.Numero}|{item.Correntista}|{item.Saldo.ToString("F")}");
                        }
                        Console.WriteLine("=====================================");
                        break;
                    case 9:
                        Console.Clear();
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("[3RR0R] Opção Inválida!");
                        break;
                }
                if (menuOpt != 9)
                {
                    Console.WriteLine("\n Pressione Qualquer Tecla Para Voltar ao Menu");
                    Console.ReadKey();
                }
            } while(menuOpt != 9);
        }
    }
}

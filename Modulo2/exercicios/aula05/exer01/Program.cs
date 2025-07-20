using System;

namespace exer01
{
    class Program
    {
        static void Main(string[] args)
        {
            string ler;
            Conta c1 = new Conta();
            c1.Numero = 1;
            c1.Titular = "Euclides";
            c1.Depositar(2000.00);
            Conta c2 = new Conta();
            c2.Numero = 2;
            c2.Titular = "Mary";
            c2.Depositar(1200.00);
            Conta c3 = new Conta();
            c3.Numero = 1;
            c3.Titular = "Junin";
            c3.Depositar(8000.00);
            Conta c4 = new Conta();
            c4.Numero = 2;
            c4.Titular = "Jucemara";
            c4.Depositar(5000.00);
            do
            {
                Console.WriteLine("Deseja Comparar alguma Conta? S/N");
                ler = Console.ReadLine();
                if (ler.ToLower() == "s")
                {
                    int n1,n2;
                    do
                    {
                        Console.WriteLine("Informe o Número da Primeira Conta que quer comparar (1,2,3 ou 4):");
                        n1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Informe o Número da Segunda Conta que quer comparar (1,2,3 ou 4):");
                        n2 = int.Parse(Console.ReadLine());
                        if ((n1 > 4 || n1 < 1) || (n2 > 4 || n2 < 1))
                        {
                            Console.WriteLine("O Número Escolhido deve ser entre 1 à 4");
                        }
                        if (n1 == n2)
                        {
                            Console.WriteLine("[3RR0R] Não é Possível comparar uma conta com ela mesma");
                        }
                    } while ((n1 == n2) || (n1 > 4 || n1 < 1) || (n2 > 4 || n2 < 1));
                    switch (n1)
                    {
                        case 1:
                            switch (n2)
                            {
                                case 1:
                                    Console.WriteLine("[3RR0R] Não é Possível comparar uma conta com ela mesma");
                                    break;
                                case 2:
                                    Console.WriteLine(c1.CompararContas(c1,c2));
                                    break;
                                case 3:
                                    Console.WriteLine(c1.CompararContas(c1,c3));
                                    break;
                                case 4:
                                    Console.WriteLine(c1.CompararContas(c1,c4));
                                    break;
                                default:
                                Console.WriteLine("[3RR0R] Opção Inválida");
                                    break;
                            }
                            break;
                        case 2:
                            switch (n2)
                            {
                                case 1:
                                    Console.WriteLine(c1.CompararContas(c2,c1));
                                    break;
                                case 2:
                                    Console.WriteLine("[3RR0R] Não é Possível comparar uma conta com ela mesma");
                                    break;
                                case 3:
                                    Console.WriteLine(c1.CompararContas(c2,c3));
                                    break;
                                case 4:
                                    Console.WriteLine(c1.CompararContas(c2,c4));
                                    break;
                                default:
                                Console.WriteLine("[3RR0R] Opção Inválida");
                                    break;
                            }
                            break;
                        case 3:
                            switch (n2)
                            {
                                case 1:
                                    Console.WriteLine(c1.CompararContas(c3,c1));
                                    break;
                                case 2:
                                    Console.WriteLine(c1.CompararContas(c3,c2));
                                    break;
                                case 3:
                                    Console.WriteLine("[3RR0R] Não é Possível comparar uma conta com ela mesma");
                                    break;
                                case 4:
                                    Console.WriteLine(c1.CompararContas(c3,c4));
                                    break;
                                default:
                                Console.WriteLine("[3RR0R] Opção Inválida");
                                    break;
                            }
                            break;
                        case 4:
                            switch (n2)
                            {
                                case 1:
                                    Console.WriteLine(c1.CompararContas(c4,c1));
                                    break;
                                case 2:
                                    Console.WriteLine(c1.CompararContas(c4,c2));
                                    break;
                                case 3:
                                    Console.WriteLine(c1.CompararContas(c4,c3));
                                    break;
                                case 4:
                                    Console.WriteLine("[3RR0R] Não é Possível comparar uma conta com ela mesma");
                                    break;
                                default:
                                    Console.WriteLine("[3RR0R] Opção Inválida");
                                    break;
                            }
                            break;
                        default:
                            Console.WriteLine("Conta Inválida");
                            break;
                    }
                }
            } while (ler.ToLower() =="s");
            int opt;
            do
            {
                Console.WriteLine("===Opção De Conta===");
                Console.WriteLine("[1] Sacar");
                Console.WriteLine("[2] Transferir");
                Console.WriteLine("[3] Deposistar");
                Console.WriteLine("[4] Ver Saldo");
                Console.WriteLine("[5] Sair");
                Console.WriteLine("====================");
                Console.Write("Informe o Número da Opção Desejada: ");
                opt = int.Parse(Console.ReadLine());
                switch (opt)
                {
                    case 1:
                        Console.WriteLine("Informe o Número da Conta que vai efetuar o Saque (1,2,3 ou 4):");
                        int n1 = int.Parse(Console.ReadLine());
                        switch (n1)
                        {
                            case 1:
                                double saque;
                                Console.Write("Informe o Valor do Saque: ");
                                saque = double.Parse(Console.ReadLine());
                                if (c1.Sacar(saque) == false)
                                {
                                    Console.WriteLine("Não Foi Possível Efetuar o Saque!");
                                }
                                else
                                {
                                    Console.WriteLine("Saque Efetuado com Sucesso!");
                                }
                                break;
                            case 2:
                                Console.Write("Informe o Valor do Saque: ");
                                saque = double.Parse(Console.ReadLine());
                                if (c2.Sacar(saque) == false)
                                {
                                    Console.WriteLine("Não Foi Possível Efetuar o Saque!");
                                }
                                else
                                {
                                    Console.WriteLine("Saque Efetuado com Sucesso!");
                                }
                                break;
                            case 3:
                                Console.Write("Informe o Valor do Saque: ");
                                saque = double.Parse(Console.ReadLine());
                                if (c3.Sacar(saque) == false)
                                {
                                    Console.WriteLine("Não Foi Possível Efetuar o Saque!");
                                }
                                else
                                {
                                    Console.WriteLine("Saque Efetuado com Sucesso!");
                                }
                                break;
                            case 4:
                                Console.Write("Informe o Valor do Saque: ");
                                saque = double.Parse(Console.ReadLine());
                                if (c4.Sacar(saque) == false)
                                {
                                    Console.WriteLine("Não Foi Possível Efetuar o Saque!");
                                }
                                else
                                {
                                    Console.WriteLine("Saque Efetuado com Sucesso!");
                                }
                                break;
                            default:
                                Console.WriteLine("[3RR0R] Opção Inválida");
                                break;
                        }
                        break;
                    case 2:
                        int n2;
                        do
                        {
                            Console.Write("Informe o Número da Conta que vai Efetuar a Transferência (1,2,3 ou 4): ");
                            n1 = int.Parse(Console.ReadLine());
                            Console.Write("Informe o Número da Conta que vai Receber a Transferência (1,2,3 ou 4): ");
                            n2 = int.Parse(Console.ReadLine());
                            if (n1 == n2)
                            {
                                Console.WriteLine("[3RR03] O Número da Conta que vai Efetuar a Transferência Deve Ser Diferente do Número da Conta que Receberá a Transferência!");
                            }
                            else
                            {
                                switch (n1)
                                {
                                    case 1:
                                        switch (n2)
                                        {
                                            case 1:
                                                Console.WriteLine("[3RR03] O Número da Conta que vai Efetuar a Transferência Deve Ser Diferente do Número da Conta que Receberá a Transferência!");
                                                break;
                                            case 2:
                                                Console.Write("Informe o Valor da Transferência: ");
                                                double transferencia = double.Parse(Console.ReadLine());
                                                if (c1.Transferir(c1,c2,transferencia) == false)
                                                {
                                                    Console.WriteLine("Não Foi Possível Efetuar a Trasnferência!");
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Trasnferência Efetuada Com Sucesso!");
                                                }
                                                break;
                                            case 3:
                                                Console.Write("Informe o Valor da Transferência: ");
                                                transferencia = double.Parse(Console.ReadLine());
                                                if (c1.Transferir(c1,c3,transferencia) == false)
                                                {
                                                    Console.WriteLine("Não Foi Possível Efetuar a Trasnferência!");
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Trasnferência Efetuada Com Sucesso!");
                                                }
                                                break;
                                            case 4:
                                                Console.Write("Informe o Valor da Transferência: ");
                                                transferencia = double.Parse(Console.ReadLine());
                                                if (c1.Transferir(c1,c4,transferencia) == false)
                                                {
                                                    Console.WriteLine("Não Foi Possível Efetuar a Trasnferência!");
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Trasnferência Efetuada Com Sucesso!");
                                                }
                                                break;
                                            default:
                                            Console.WriteLine("[3RR0R] Opção Inválida");
                                                break;
                                        }
                                        break;
                                    case 2:
                                        switch (n2)
                                        {
                                            case 1:
                                                Console.Write("Informe o Valor da Transferência: ");
                                                double transferencia = double.Parse(Console.ReadLine());
                                                if (c1.Transferir(c2,c1,transferencia) == false)
                                                {
                                                    Console.WriteLine("Não Foi Possível Efetuar a Trasnferência!");
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Trasnferência Efetuada Com Sucesso!");
                                                }
                                                break;
                                            case 2:
                                                Console.WriteLine("[3RR03] O Número da Conta que vai Efetuar a Transferência Deve Ser Diferente do Número da Conta que Receberá a Transferência!");
                                                break;
                                            case 3:
                                                Console.Write("Informe o Valor da Transferência: ");
                                                transferencia = double.Parse(Console.ReadLine());
                                                if (c1.Transferir(c2,c3,transferencia) == false)
                                                {
                                                    Console.WriteLine("Não Foi Possível Efetuar a Trasnferência!");
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Trasnferência Efetuada Com Sucesso!");
                                                }
                                                break;
                                            case 4:
                                                Console.Write("Informe o Valor da Transferência: ");
                                                transferencia = double.Parse(Console.ReadLine());
                                                if (c1.Transferir(c2,c1,transferencia) == false)
                                                {
                                                    Console.WriteLine("Não Foi Possível Efetuar a Trasnferência!");
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Trasnferência Efetuada Com Sucesso!");
                                                }
                                                break;
                                            default:
                                            Console.WriteLine("[3RR0R] Opção Inválida");
                                                break;
                                        }
                                        break;
                                    case 3:
                                        switch (n2)
                                        {
                                            case 1:
                                                Console.Write("Informe o Valor da Transferência: ");
                                                double transferencia = double.Parse(Console.ReadLine());
                                                if (c1.Transferir(c3,c1,transferencia) == false)
                                                {
                                                    Console.WriteLine("Não Foi Possível Efetuar a Trasnferência!");
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Trasnferência Efetuada Com Sucesso!");
                                                }
                                                break;
                                            case 2:
                                                Console.Write("Informe o Valor da Transferência: ");
                                                transferencia = double.Parse(Console.ReadLine());
                                                if (c1.Transferir(c3,c3,transferencia) == false)
                                                {
                                                    Console.WriteLine("Não Foi Possível Efetuar a Trasnferência!");
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Trasnferência Efetuada Com Sucesso!");
                                                }
                                                break;
                                            case 3:
                                                Console.WriteLine("[3RR03] O Número da Conta que vai Efetuar a Transferência Deve Ser Diferente do Número da Conta que Receberá a Transferência!");
                                                break;
                                            case 4:
                                                Console.Write("Informe o Valor da Transferência: ");
                                                transferencia = double.Parse(Console.ReadLine());
                                                if (c1.Transferir(c3,c4,transferencia) == false)
                                                {
                                                    Console.WriteLine("Não Foi Possível Efetuar a Trasnferência!");
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Trasnferência Efetuada Com Sucesso!");
                                                }
                                                break;
                                            default:
                                            Console.WriteLine("[3RR0R] Opção Inválida");
                                                break;
                                        }
                                        break;
                                    case 4:
                                        switch (n2)
                                        {
                                            case 1:
                                                Console.Write("Informe o Valor da Transferência: ");
                                                double transferencia = double.Parse(Console.ReadLine());
                                                if (c1.Transferir(c4,c1,transferencia) == false)
                                                {
                                                    Console.WriteLine("Não Foi Possível Efetuar a Trasnferência!");
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Trasnferência Efetuada Com Sucesso!");
                                                }
                                                break;
                                            case 2:
                                                Console.Write("Informe o Valor da Transferência: ");
                                                transferencia = double.Parse(Console.ReadLine());
                                                if (c1.Transferir(c4,c2,transferencia) == false)
                                                {
                                                    Console.WriteLine("Não Foi Possível Efetuar a Trasnferência!");
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Trasnferência Efetuada Com Sucesso!");
                                                }
                                                break;
                                            case 3:
                                                Console.Write("Informe o Valor da Transferência: ");
                                                transferencia = double.Parse(Console.ReadLine());
                                                if (c1.Transferir(c4,c3,transferencia) == false)
                                                {
                                                    Console.WriteLine("Não Foi Possível Efetuar a Trasnferência!");
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Trasnferência Efetuada Com Sucesso!");
                                                }
                                                break;
                                            case 4:
                                                Console.WriteLine("[3RR03] O Número da Conta que vai Efetuar a Transferência Deve Ser Diferente do Número da Conta que Receberá a Transferência!");
                                                break;
                                            default:
                                                Console.WriteLine("[3RR0R] Opção Inválida");
                                                break;
                                        }
                                        break;
                                    default:
                                        Console.WriteLine("Conta Inválida");
                                        break;
                                }
                            }
                        } while(n1 == n2);
                        break;
                    case 3:
                        Console.WriteLine("Informe o Número da Conta que vai efetuar o Depósito (1,2,3 ou 4):");
                        n1 = int.Parse(Console.ReadLine());
                        switch (n1)
                        {
                            case 1:
                                double deposito;
                                Console.Write("Informe o Valor do Depósito: ");
                                deposito = double.Parse(Console.ReadLine());
                                if (c1.Depositar(deposito) == false)
                                {
                                    Console.WriteLine("Não Foi Possível Efetuar o Depósito!");
                                }
                                else
                                {
                                    Console.WriteLine("Depósito Efetuado com Sucesso!");
                                }
                                break;
                            case 2:
                                Console.Write("Informe o Valor do Depósito: ");
                                deposito = double.Parse(Console.ReadLine());
                                if (c2.Depositar(deposito) == false)
                                {
                                    Console.WriteLine("Não Foi Possível Efetuar o Depósito!");
                                }
                                else
                                {
                                    Console.WriteLine("Depósito Efetuado com Sucesso!");
                                }
                                break;
                            case 3:
                                Console.Write("Informe o Valor do Depósito: ");
                                deposito = double.Parse(Console.ReadLine());
                                if (c3.Depositar(deposito) == false)
                                {
                                    Console.WriteLine("Não Foi Possível Efetuar o Depósito!");
                                }
                                else
                                {
                                    Console.WriteLine("Depósito Efetuado com Sucesso!");
                                }
                                break;
                            case 4:
                                Console.Write("Informe o Valor do Depósito: ");
                                deposito = double.Parse(Console.ReadLine());
                                if (c4.Depositar(deposito) == false)
                                {
                                    Console.WriteLine("Não Foi Possível Efetuar o Depósito!");
                                }
                                else
                                {
                                    Console.WriteLine("Depósito Efetuado com Sucesso!");
                                }
                                break;
                            default:
                                Console.WriteLine("[3RR0R] Opção Inválida");
                                break;
                        }
                        break;
                    case 4:
                        Console.Write("Informe o Número da Conta que Deseja Ver o Saldo (1,2,3 ou 4): ");
                        n1 = int.Parse(Console.ReadLine());
                        switch (n1)
                        {
                            case 1:
                                Console.WriteLine($"O Saldo Atual da Conta é: R$ {c1.SaldoAtual().ToString("F")}");
                                break;
                            case 2:
                                Console.WriteLine($"O Saldo Atual da Conta é: R$ {c2.SaldoAtual().ToString("F")}");
                                break;
                            case 3:
                                Console.WriteLine($"O Saldo Atual da Conta é: R$ {c3.SaldoAtual().ToString("F")}");
                                break;
                            case 4:
                                Console.WriteLine($"O Saldo Atual da Conta é: R$ {c4.SaldoAtual().ToString("F")}");
                                break;
                            default:
                                Console.WriteLine("[3RR0R] Opção Inválida");
                                break;
                        }
                        break;
                    case 5:
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("[3RR0R] Opção Inválida");
                        break;
                }
            } while(opt != 5);
            Console.Clear();
            Console.WriteLine("Saldos Finais Das Contas ");
            Console.WriteLine($"Conta 1: R$ {c1.SaldoAtual().ToString("F")}");
            Console.WriteLine($"Conta 2: R$ {c2.SaldoAtual().ToString("F")}");
            Console.WriteLine($"Conta 3: R$ {c3.SaldoAtual().ToString("F")}");
            Console.WriteLine($"Conta 4: R$ {c4.SaldoAtual().ToString("F")}");
        }
    }
}
 
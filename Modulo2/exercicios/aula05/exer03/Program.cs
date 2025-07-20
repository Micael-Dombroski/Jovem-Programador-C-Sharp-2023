using System;

namespace exer03
{
    class Program
    {
        static void Main(string[] args)
        {
            var nascimento = new DateTime(2000,6,18);
            Cliente cl1 = new Cliente("Lucas", "Albuquerque", "123213","123",nascimento.ToString("dd/MM/yyyy"));
            Conta c1 = new Conta(123, 1, cl1, 2000.00);
            nascimento = new DateTime(2008,4,16);
            Cliente cl2 = new Cliente("Raissa", "Lima", "195195","195", nascimento.ToString("dd/MM/yyyy"));
            Conta c2 = new Conta(321, 2, cl2, 1650.00);
            nascimento = new DateTime(1997,9,23);
            Cliente cl3 = new Cliente("Douglas", "Rufalo", "456456","456", nascimento.ToString("dd/MM/yyyy"));
            Conta c3 = new Conta(123, 3, cl3, 895.50);
            nascimento = new DateTime(2004,2,1);
            Cliente cl4 = new Cliente("Alice", "Angel", "098098","098", nascimento.ToString("dd/MM/yyyy"));
            Conta c4 = new Conta(123, 4, cl4, 12040.00);
            string ler;
            do
            {
                Console.WriteLine("Deseja Acessar um Conta? S/N");
                ler = Console.ReadLine();
                if (ler.ToLower()=="s")
                {
                    int nConta;
                    do
                    {
                        Console.Write("Informe o Número da Conta que Deseja Acessar (1,2,3 ou 4): ");
                        nConta = int.Parse(Console.ReadLine());
                        if (nConta > 4 || nConta < 1)
                        {
                            Console.WriteLine("[3RR0R] Opção Inválida!");
                        }
                    } while (nConta > 4 || nConta < 1);
                    switch (nConta)
                    {
                        case 1:
                            MenuConta(c1);
                            break;
                        case 2:
                            MenuConta(c2);
                            break;
                        case 3:
                            MenuConta(c3);
                            break;
                        case 4:
                            MenuConta(c4);
                            break;
                        default:
                            Console.WriteLine("[3RR0R] Opção Inválida");
                            break;
                    }
                }
            } while (ler.ToLower() == "s");
            Console.Clear();
            Console.WriteLine("\n");
            Console.WriteLine("========Lista de Correntistas========");
            Console.WriteLine($"Nome: {c1.Correntista.Nome} {c1.Correntista.Sobrenome}");
            Console.WriteLine($"Idade: {c1.Correntista.Idade()} anos");
            Console.WriteLine($"Saldo Da Conta: R$ {c1.SaldoAtual().ToString("F")}");
            Console.WriteLine();
            Console.WriteLine($"Nome: {c2.Correntista.Nome} {c2.Correntista.Sobrenome}");
            Console.WriteLine($"Idade: {c2.Correntista.Idade()} anos");
            Console.WriteLine($"Saldo Da Conta: R$ {c2.SaldoAtual().ToString("F")}");
            Console.WriteLine();
            Console.WriteLine($"Nome: {c3.Correntista.Nome} {c3.Correntista.Sobrenome}");
            Console.WriteLine($"Idade: {c3.Correntista.Idade()} anos");
            Console.WriteLine($"Saldo Da Conta: R$ {c3.SaldoAtual().ToString("F")}");
            Console.WriteLine();
            Console.WriteLine($"Nome: {c4.Correntista.Nome} {c4.Correntista.Sobrenome}");
            Console.WriteLine($"Idade: {c4.Correntista.Idade()} anos");
            Console.WriteLine($"Saldo Da Conta: R$ {c4.SaldoAtual().ToString("F")}");
            Console.WriteLine("=====================================");

        }
        static void MenuConta(Conta conta)
        {
            int opt;
            do
            {
                Console.WriteLine("===Opção De Conta===");
                Console.WriteLine("[1] Sacar");
                Console.WriteLine("[2] Deposistar");
                Console.WriteLine("[3] Ver Saldo");
                Console.WriteLine("[4] Ver Correntista");
                Console.WriteLine("[5] Sair");
                Console.WriteLine("====================");
                Console.Write("Informe o Número da Opção Desejada: ");
                opt = int.Parse(Console.ReadLine());
                switch (opt)
                {
                    case 1:
                        Console.Write("Informe o Valor do Saque que Deseja Fazer: ");
                        double saque = double.Parse(Console.ReadLine());
                        if (conta.Sacar(saque) == true)
                        {
                            Console.WriteLine("Saque Bem Sucedido!");
                        }
                        else
                        {
                            Console.WriteLine("Não Foi Possível Efetuar o Saque...");
                        }
                        break;
                    case 2:
                        Console.Write("Informe o Valor do Depósito que Deseja Fazer: ");
                        double deposito = double.Parse(Console.ReadLine());
                        if (conta.Depositar(deposito) == true)
                        {
                            Console.WriteLine("Depósito Bem Sucedido!");
                        }
                        else
                        {
                            Console.WriteLine("Não Foi Possível Efetuar o Depósito...");
                        }
                        break;
                    case 3:
                        Console.WriteLine($"O Saldo Atual da Conta é: R$ {conta.SaldoAtual().ToString("F")}");
                        break;
                    case 4:
                        Console.WriteLine("=======Dados Do Correntista=======");
                        Console.WriteLine($"Nome Completo: {conta.Correntista.Nome} {conta.Correntista.Sobrenome}");
                        Console.WriteLine($"CPF: {conta.Correntista.CPF}");
                        Console.WriteLine($"RG: {conta.Correntista.RG}");
                        Console.WriteLine($"Idade: {conta.Correntista.Idade()} anos");
                        Console.Write($"Maior de Idade: ");
                        if (conta.Correntista.MaiorDeIdade()==true)
                        {
                            Console.WriteLine("Sim");
                        }
                        else
                        {
                            Console.WriteLine("Não");
                        }
                        Console.WriteLine("==================================");
                        break;
                    case 5:
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("[3RR0R] Opção Inválida");
                        break;
                }
            } while (opt != 5);
        }
    }
}

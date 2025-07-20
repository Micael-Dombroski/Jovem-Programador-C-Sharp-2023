using System;

namespace exer01
{
    class Program
    {
        static void Main(string[] args)
        {
            string ler;
            Conta[] contas = new Conta[2];
            var conta = new Conta();
            conta.numero = 1;
            Console.Write("Informe o nome do correntista " + conta.numero + ": ");
            conta.correntista = Console.ReadLine();
            Console.Write("Informe o saldo do correntista " + conta.numero + " (Ex: 1111,11): ");
            ler = Console.ReadLine();
            conta.saldo = Convert.ToDouble(ler);
            contas[0] = conta;
            Console.WriteLine($"{conta.numero} - {conta.correntista} - {conta.saldo}");
            var conta1 = new Conta();
            conta1.numero = 2;
            Console.Write("Informe o nome do correntista " + conta1.numero + ": ");
            conta1.correntista = Console.ReadLine();
            Console.Write("Informe o saldo do correntista " + conta1.numero + " (Ex: 1111,11): ");
            ler = Console.ReadLine();
            conta1.saldo = Convert.ToDouble(ler);
            int resposta;
            do 
            {
                Console.WriteLine("O que você deseja fazer?");
                Console.WriteLine("1 - Sacar");
                Console.WriteLine("2 - Depositar");
                Console.WriteLine("3 - Transferir");
                Console.Write("Informe o número da opção desejada: ");
                ler = Console.ReadLine();
                resposta = Convert.ToInt32(ler);
                switch(resposta)
                {
                    case 1:
                        Console.Write("Você deseja sacar dinheiro da conta 1 ou da conta 2? Informe o número da conta: ");
                        ler = Console.ReadLine();
                        resposta = Convert.ToInt32(ler);
                        if (resposta == 1)
                        {
                            Console.Write("Informe o valor que deseja sacar (Ex: 111,11): R$");
                            ler = Console.ReadLine();
                            double valorSaque = Convert.ToDouble(ler);
                            if (conta.Sacar(valorSaque))
                            {
                                Console.WriteLine("Saque efetuado com sucesso!");
                                Console.WriteLine($"{conta.numero} - {conta.correntista} - {conta.saldo}");
                            }
                            else 
                            {
                                Console.WriteLine("Não é possível sacar o valor informado...");
                            }
                        } else if (resposta == 2)
                        {
                            Console.Write("Informe o valor que deseja sacar (Ex: 111,11): R$");
                            ler = Console.ReadLine();
                            double valorSaque = Convert.ToDouble(ler);
                            if (conta1.Sacar(valorSaque))
                            {
                                Console.WriteLine("Saque efetuado com sucesso!");
                                Console.WriteLine($"{conta1.numero} - {conta1.correntista} - {conta1.saldo}");
                            }
                            else 
                            {
                                Console.WriteLine("Não é possível sacar o valor informado...");
                            }
                        } else 
                        {
                            Console.WriteLine("Não existe uma conta com esse número...");
                        }
                    break;
                    case 2:
                        Console.Write("Você deseja depositar dinheiro na conta 1 ou na conta 2? Informe o número da conta: ");
                        ler = Console.ReadLine();
                        resposta = Convert.ToInt32(ler);
                        if (resposta == 1)
                        {
                            Console.Write("Informe o valor que deseja depositar (Ex: 111,11): R$");
                            ler = Console.ReadLine();
                            double valorDeposito = Convert.ToDouble(ler);
                            if (conta.Depositar(valorDeposito))
                            {
                                Console.WriteLine("Depósito efetuado com sucesso!");
                                Console.WriteLine($"{conta.numero} - {conta.correntista} - {conta.saldo}");
                            }
                            else 
                            {
                                Console.WriteLine("Não é possível depositar o valor informado...");
                            }
                        } else if (resposta == 2)
                        {
                            Console.Write("Informe o valor que deseja depositar (Ex: 111,11): R$");
                            ler = Console.ReadLine();
                            double valorDeposito = Convert.ToDouble(ler);
                            if (conta1.Depositar(valorDeposito))
                            {
                                Console.WriteLine("Depósito efetuado com sucesso!");
                                Console.WriteLine($"{conta1.numero} - {conta1.correntista} - {conta1.saldo}");
                            }
                            else 
                            {
                                Console.WriteLine("Não é possível depositar o valor informado...");
                            }
                        }
                    break;
                    case 3:
                        Console.WriteLine("Você deseja transferir dinheiro:");
                        Console.WriteLine("1 - Da conta 1 para a conta 2");
                        Console.WriteLine("2 - Da conta 2 para a conta 1");
                        Console.Write("Informe a opção desejada: ");
                        ler = Console.ReadLine();
                        Console.WriteLine();
                        resposta = Convert.ToInt32(ler);
                        if (resposta == 1)
                        {
                            Console.WriteLine($"{conta.numero} - {conta.correntista} - {conta.saldo}");
                            Console.WriteLine($"{conta1.numero} - {conta1.correntista} - {conta1.saldo}");
                            Console.Write("Informe o valor que deseja transferir: (Ex:111,11) R$");
                            ler = Console.ReadLine();
                            double valorTransferencia = Convert.ToDouble(ler);
                            if (conta.Transferir(valorTransferencia, ref conta1.saldo))
                            {
                                Console.WriteLine("Transferência efetuada com sucesso!");
                                Console.WriteLine($"{conta.numero} - {conta.correntista} - {conta.saldo}");
                                Console.WriteLine($"{conta1.numero} - {conta1.correntista} - {conta1.saldo}");
                            } else 
                            {
                                Console.WriteLine("Não foi possível efetuar a transferência...");
                            }
                        } else if (resposta == 2)
                        {
                            Console.WriteLine($"{conta1.numero} - {conta1.correntista} - {conta1.saldo}");
                            Console.WriteLine($"{conta.numero} - {conta.correntista} - {conta.saldo}");
                            Console.Write("Informe o valor que deseja transferir: (Ex:111,11) R$");
                            ler = Console.ReadLine();
                            double valorTransferencia = Convert.ToDouble(ler);
                            if (conta1.Transferir(valorTransferencia, ref conta.saldo))
                            {
                                Console.WriteLine("Transferência efetuada com sucesso!");
                                Console.WriteLine($"{conta1.numero} - {conta1.correntista} - {conta1.saldo}");
                                Console.WriteLine($"{conta.numero} - {conta.correntista} - {conta.saldo}");
                            } else 
                            {
                                Console.WriteLine("Não foi possível efetuar a transferência...");
                            }
                        } else
                        {
                            Console.WriteLine("A opção informada não está disponível...");
                        }

                    break;
                    default:
                        Console.WriteLine("O valor informado não está presente no menu de opções...");
                    break;
                }
                Console.WriteLine("Deseja continuar navegando nas opções do nosso menu? Sim/Não");
                ler = Console.ReadLine();
            } while (ler.ToLower() == "sim");
        }
    }
}

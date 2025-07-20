using System;
using exer03.Classes;
using System.Collections.Generic;

namespace exer03.ConsoleApp
{
    class Program
    {
        static Correntista correntistaFantasma = new Correntista("l", "1");
        static CrudConta contas = new CrudConta(0,0,correntistaFantasma);
        static string ler;
        static void Main(string[] args)
        {
            contas.CarregandoDados();
            int opt;
            do
            {
                do
                {
                    Console.WriteLine("------Menu Contas------");
                    Console.WriteLine("[1] Cadastrar Conta");
                    Console.WriteLine("[2] Consultar Conta");
                    Console.WriteLine("[3] Editar Conta");
                    Console.WriteLine("[4] Excluir Conta");
                    Console.WriteLine("[5] Exibir Todas as Contas");
                    Console.WriteLine("[6] Sair");
                    Console.Write("Informe o Número da Opção Desejada: ");
                    ler = Console.ReadLine();
                } while (ENumero(ler) == false);
                opt = Convert.ToInt32(ler);
                switch (opt)
                {
                    case 1:
                            do
                            {
                                Console.Write("Informe o Número da Agência: ");
                                ler = Console.ReadLine();
                            } while (ENumero(ler) == false);
                            int agencia = Convert.ToInt32(ler);
                            int tipo = 0;
                            do
                            {
                                Console.Write("Informe o Número da Conta: ");
                                ler = Console.ReadLine();
                            } while (ENumero(ler) == false);
                            int numero = Convert.ToInt32(ler);
                            int OptTipo = 0;
                            do
                            {
                                do
                                {
                                    Console.WriteLine("Tipos de Conta");
                                    Console.WriteLine("[1] Conta Poupança");
                                    Console.WriteLine("[2] Conta Corrente");
                                    Console.WriteLine("[3] Conta Investimento");
                                    Console.Write("Informe o Número Correspondente a Opção Desejada: ");
                                    ler = Console.ReadLine();
                                } while (ENumero(ler) == false);
                                int Opt = Convert.ToInt32(ler);
                                switch (Opt)
                                {
                                    case 1:
                                        Console.WriteLine("Você Escolheu a Opção Conta Poupança!");
                                        tipo = 013;
                                        OptTipo = 1;
                                    break;
                                    case 2:
                                        Console.WriteLine("Você Escolheu a Opção Conta Corrente!");
                                        tipo = 001;
                                        OptTipo = 2;
                                    break;
                                    case 3:
                                        Console.WriteLine("Você Escolheu a Opção Conta Investimento!");
                                        tipo = 009;
                                        OptTipo = 3;
                                    break;
                                    default:
                                        Console.WriteLine("Opção Inválida");
                                    break;
                                }
                            } while (OptTipo > 3 || OptTipo < 1); 
                            Console.Write("Informe o Nome do Correntista: ");
                            string nome = Console.ReadLine();
                            do
                            {  
                                do
                                {
                                    do
                                    {
                                        Console.Write("Informe o CPF do Correntista: ");
                                        ler = Console.ReadLine();
                                    } while (ValCPF(ler) == false);
                                } while (ValidarCPF(ler) == false);
                                if (contas.ConsultarCPF(ler) != null)
                                {
                                    Console.WriteLine("O Cpf informado já  está vinculado a  uma conta!");
                                }
                            } while (contas.ConsultarCPF(ler) != null);
                            string cpf = ler;
                            Correntista correntista = new Correntista(nome,cpf);
                            Conta conta = new Conta(agencia, numero, correntista);
                            conta.Tipo = tipo;
                            contas.Cadastrar(conta);
                        break;
                    case 2:
                        do
                        {
                            try
                            {
                                do
                                {
                                    do
                                    {
                                        Console.Write("Informe o CPF da Conta do Funcionário que deseja Consultar: ");
                                        ler = Console.ReadLine();
                                    } while (ValCPF(ler)==false);
                                } while (ValidarCPF(ler)==false);
                                if (contas.ConsultarCPF(ler) == null)
                                {
                                    throw new ArgumentOutOfRangeException("Conta Não Cadastrada");
                                }
                                else
                                {
                                    conta = contas.ConsultarCPF(ler);
                                    Console.WriteLine("Agencia | Numero | Tipo         | Correnstista | CPF");
                                    cpf = conta.Correntista.Cpf;
                                    Console.Write($"{conta.Agencia} | ");
                                    Console.Write($"{conta.Numero} | ");
                                    Console.Write($"{conta.Tipo} | ");
                                    Console.Write($"{conta.Correntista.Nome} | ");
                                    Console.WriteLine($"{cpf[0]}{cpf[1]}{cpf[2]}.{cpf[3]}{cpf[4]}{cpf[5]}.{cpf[6]}{cpf[7]}{cpf[8]}-{cpf[9]}{cpf[10]}");
                                }
                            }
                            catch (ArgumentOutOfRangeException e)
                            {
                                Console.WriteLine(e.Message);
                            }
                        } while (contas.ConsultarCPF(ler) == null);
                            
                        break;
                    case 3:
                        cpf= "1";
                        do
                        {
                            try
                            {
                                do
                                {
                                    do
                                    {
                                        Console.Write("Informe o CPF da Conta do Funcionário que deseja Editar: ");
                                        ler = Console.ReadLine();
                                    } while (ValCPF(ler)==false);
                                } while (ValidarCPF(ler)==false);
                                string cpfEditar = ler;
                                cpf = ler;
                                if (contas.ConsultarCPF(cpfEditar) == null)
                                {
                                    throw new ArgumentOutOfRangeException("Conta Não Cadastrada");
                                }
                                else
                                {
                                    conta = contas.ConsultarCPF(cpfEditar);
                                    Console.WriteLine("Deseja Editar o Número da Agência da Conta? S/N");
                                    ler = Console.ReadLine();
                                    if (ler.ToLower() == "s")
                                    {
                                        do
                                        {
                                            Console.Write("Informe o Número da Agência: ");
                                            ler = Console.ReadLine();
                                        } while (ENumero(ler) == false);
                                    } else
                                    {
                                        ler = $"{conta.Agencia}";
                                    }
                                    agencia = Convert.ToInt32(ler);
                                    tipo = 0;
                                    Console.WriteLine("Deseja o Número da Conta? S/N");
                                    ler = Console.ReadLine();
                                    if (ler.ToLower() == "s")
                                    {
                                        do
                                        {
                                            Console.Write("Informe o Número da Conta: ");
                                            ler = Console.ReadLine();
                                        } while (ENumero(ler) == false);
                                    } else
                                    {
                                        ler = $"{conta.Numero}";
                                    }
                                    numero = Convert.ToInt32(ler);
                                    Console.WriteLine("Deseja o Tipo da Conta? S/N");
                                    ler = Console.ReadLine();
                                    OptTipo = 0;
                                    if (ler.ToLower() == "s")
                                    {
                                        do
                                        {
                                            do
                                            {
                                                Console.WriteLine("Tipos de Conta");
                                                Console.WriteLine("[1] Conta Poupança");
                                                Console.WriteLine("[2] Conta Corrente");
                                                Console.WriteLine("[3] Conta Investimento");
                                                Console.Write("Informe o Número Correspondente a Opção Desejada: ");
                                                ler = Console.ReadLine();
                                            } while (ENumero(ler) == false);
                                            int Opt = Convert.ToInt32(ler);
                                            switch (Opt)
                                            {
                                                case 1:
                                                    Console.WriteLine("Você Escolheu a Opção Conta Poupança!");
                                                    tipo = 013;
                                                    OptTipo = 1;
                                                break;
                                                case 2:
                                                    Console.WriteLine("Você Escolheu a Opção Conta Corrente!");
                                                    tipo = 001;
                                                    OptTipo = 2;
                                                break;
                                                case 3:
                                                    Console.WriteLine("Você Escolheu a Opção Conta Investimento!");
                                                    tipo = 009;
                                                    OptTipo = 3;
                                                break;
                                                default:
                                                    Console.WriteLine("Opção Inválida");
                                                break;
                                            }
                                        } while (OptTipo > 3 || OptTipo < 1); 
                                    } else
                                    {
                                        tipo = conta.Tipo;
                                    }
                                    Console.WriteLine("Deseja Editar o Nome do Correntista? S/N");
                                    ler = Console.ReadLine();
                                    if (ler.ToLower() == "s")
                                    {
                                        Console.Write("Informe o Nome do Correntista: ");
                                        nome = Console.ReadLine();
                                    }  else
                                    {
                                        nome = conta.Correntista.Nome;
                                    }
                                    correntista = new Correntista(nome,cpfEditar);
                                    Conta contaEditada = new Conta(agencia, numero, correntista);
                                    conta.Tipo = tipo;
                                    contas.Editar(contaEditada);
                                }
                            }
                            catch (ArgumentOutOfRangeException e)
                            {
                                Console.WriteLine(e.Message);
                            }
                        } while (contas.ConsultarCPF(cpf) == null);
                                
                        break;
                    case 4:
                        do
                        {
                            do
                            {
                                Console.Write("Informe o CPF da Conta do Funcionário que deseja Excluir: ");
                                ler = Console.ReadLine();
                            } while (ValCPF(ler)==false);
                        } while (ValidarCPF(ler)==false);
                        if (contas.ConsultarCPF(ler) == null)
                        {
                            Console.WriteLine("Conta Não Cadastrada");
                        }
                        else
                        {
                            contas.Excluir(ler);
                        }
                        break;
                    case 5:
                        Console.WriteLine("Agencia | Numero | Tipo         | Correnstista | CPF");
                        foreach (KeyValuePair<string, Conta> par in contas.ConsultarTodos())
                        {
                            Conta item = par.Value; 
                            cpf = item.Correntista.Cpf;
                            Console.Write($"{item.Agencia} | ");
                            Console.Write($"{item.Numero} | ");
                            Console.Write($"{item.Tipo} | ");
                            Console.Write($"{item.Correntista.Nome} | ");
                            Console.WriteLine($"{cpf[0]}{cpf[1]}{cpf[2]}.{cpf[3]}{cpf[4]}{cpf[5]}.{cpf[6]}{cpf[7]}{cpf[8]}-{cpf[9]}{cpf[10]}");
                        }
                        break;
                    case 6:
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opção Inválida");
                        break;
                }
            } while(opt != 6);
        }
        static bool ValTipo(int tipo)
        {
            try
            {
                if (tipo == 013 || tipo == 001 || tipo == 009)
                {
                    return true;
                }
                else
                {
                    throw new ArgumentException("Tipo de Conta Inválido");
                }
            } catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
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
        static bool ENumero (string palavra)
        {
            try
            {
                for (int i = 0; i < palavra.Length; i++)
                {
                    if (palavra[i] > 57 || palavra[i] < 48)
                    {
                        throw new ArgumentException("Use apenas números nesse campo");
                    }
                }
            } catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            return true;
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
                            num1 += (ValorNumero(cpf[i])) * multiplicador;
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
    }
}

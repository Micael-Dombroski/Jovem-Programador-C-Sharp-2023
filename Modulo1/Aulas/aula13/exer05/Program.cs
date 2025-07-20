using System;

namespace exer05
{
    class Program
    {
        static int index = 0;
        static Correntista [] correntistas = new Correntista[0];
        static Conta [] contas = new Conta[0];
        static string cpf = "";
        static string nome = ""; 
        static string sobrenome = "";
        static double rendaComprovada = 0.0;
        static int idade = 0;
        static int numero = 0;
        static double saldo = 0;
        static void Main(string[] args)
        {
            //int c= 0;
            int resposta = 0;
            while (resposta != 5)
            {
                if  (index == 1)
                {
                    Console.WriteLine("Gostaria de fazer um depósito ou saque? Sim/Não");
                    string ler = Console.ReadLine();
                    if (ler.ToLower() == "sim")
                    {
                        Console.WriteLine("Digite 1 caso deseje fazer um saque.");
                        Console.WriteLine("Digite 2 caso deseje fazer um depósito.");
                        ler = Console.ReadLine();
                        int opt = Convert.ToInt32(ler);
                        if (opt == 1)
                        {
                            Console.Write("Informe o CPF da conta que deseja fazer o saque: ");
                            ler = Console.ReadLine();
                            Console.WriteLine();
                            for (int i = 0; i < index; i++)
                            {
                                if (ler == correntistas[i].Cpf)
                                {
                                    Console.Write("Informe o valor que deseja sacar: (Ex: 1111,11) R$ ");
                                    ler = Console.ReadLine();
                                    double saque = Convert.ToDouble(ler);
                                    if (Sacar(saque,i)) 
                                    {
                                        Console.WriteLine("Saque realizado com sucesso!");
                                    } else 
                                    {
                                        Console.WriteLine("Não foi possível realizar o saque...");
                                    }
                                } else if (i == index-1)
                                {
                                    Console.WriteLine("O CPF não está cadastrado a nenhuma conta, por favor faça seu cadastro!");
                                }
                            }

                        } else if (opt == 2)
                        {
                            Console.Write("Informe o CPF da conta que deseja fazer o depósito: ");
                            ler = Console.ReadLine();
                            Console.WriteLine();
                            for (int i = 0; i < index; i++)
                            {
                                if (ler == correntistas[i].Cpf)
                                {
                                    Console.Write("Informe o valor que deseja depositar: (Ex: 1111,11) R$ ");
                                    ler = Console.ReadLine();
                                    double deposito = Convert.ToDouble(ler);
                                    if (Depositar(deposito,i)) 
                                    {
                                        Console.WriteLine("Depósito realizado com sucesso!");
                                    } else 
                                    {
                                        Console.WriteLine("Não foi possível realizar o depósito...");
                                    }
                                } else if (i == index-1)
                                {
                                    Console.WriteLine("O CPF não está cadastrado a nenhuma conta, por favor faça seu cadastro!");
                                }
                            }
                        } else
                        {
                            Console.WriteLine("Opção inválida...");
                        }
                    }
                } else if  (index > 1)
                {
                    Console.WriteLine("Gostaria de fazer um depósito, um saque ou uma transação? Sim/Não");
                    string ler = Console.ReadLine();
                    if (ler.ToLower() == "sim")
                    {
                        Console.WriteLine("Digite 1 caso deseje fazer um saque.");
                        Console.WriteLine("Digite 2 caso deseje fazer um depósito.");
                        Console.WriteLine("Digite 3 caso deseje fazer uma transação.");
                        ler = Console.ReadLine();
                        int opt = Convert.ToInt32(ler);
                        if (opt == 1)
                        {
                            Console.Write("Informe o CPF da sua conta: ");
                            ler = Console.ReadLine();
                            Console.WriteLine();
                            for (int i = 0; i < index; i++)
                            {
                                if (ler == correntistas[i].Cpf)
                                {
                                    Console.Write("Informe o valor que deseja sacar: (Ex: 1111,11) R$ ");
                                    ler = Console.ReadLine();
                                    double saque = Convert.ToDouble(ler);
                                    if (Sacar(saque,i)) 
                                    {
                                        Console.WriteLine("Saque realizado com sucesso!");
                                    } else 
                                    {
                                        Console.WriteLine("Não foi possível realizar o saque...");
                                    }
                                } else if (i == index-1)
                                {
                                    Console.WriteLine("O CPF não está cadastrado a nenhuma conta, por favor faça seu cadastro!");
                                }
                            }

                        } else if (opt == 2)
                        {
                            Console.Write("Informe o CPF da conta que deseja fazer o depósito: ");
                            ler = Console.ReadLine();
                            Console.WriteLine();
                            for (int i = 0; i < index; i++)
                            {
                                if (ler == correntistas[i].Cpf)
                                {
                                    Console.Write("Informe o valor que deseja depositar: (Ex: 1111,11) R$ ");
                                    ler = Console.ReadLine();
                                    double deposito = Convert.ToDouble(ler);
                                    if (Depositar(deposito,i)) 
                                    {
                                        Console.WriteLine("Depósito realizado com sucesso!");
                                    } else 
                                    {
                                        Console.WriteLine("Não foi possível realizar o depósito...");
                                    }
                                } else if (i == index-1)
                                {
                                    Console.WriteLine("O CPF não está cadastrado a nenhuma conta, por favor faça seu cadastro!");
                                }
                            }
                        } else if (opt == 3)
                        {
                            Console.Write("Informe o CPF da sua conta: ");
                            ler = Console.ReadLine();
                            Console.WriteLine();
                            for (int i = 0; i < index; i++)
                            {
                                if (ler == correntistas[i].Cpf)
                                {
                                    Console.Write("Informe o CPF da conta que você deseja fazer a transação: ");
                                    ler = Console.ReadLine();
                                    Console.WriteLine();
                                    if (ler == correntistas[i].Cpf)
                                    {
                                        Console.WriteLine("Você não pode fazer uma transação para sua própria conta!");
                                    } else 
                                    {
                                        for (int j = 0; j < index; j++)
                                        {
                                            if (ler == correntistas[j].Cpf)
                                            {
                                                Console.WriteLine("Informe o valor da transação: (Ex: R$ 1111,11) R$ ");
                                                ler = Console.ReadLine();
                                                double  transacao = Convert.ToDouble(ler);
                                                if (Transacao(transacao,i,j))
                                                {
                                                    Console.WriteLine("Transação efeituada com sucesso!");
                                                } else
                                                {
                                                    Console.WriteLine("Não foi possível efetuar a transação...");
                                                }
                                            } else if (j == index-1)
                                            {
                                                Console.WriteLine("O CPF não está cadastrado a nenhuma conta, por favor faça seu cadastro!");
                                            }
                                        }
                                    }
                                        
                                } else if (i == index-1)
                                {
                                    Console.WriteLine("O CPF não está cadastrado a nenhuma conta, por favor faça seu cadastro!");
                                }
                            }
                        } else
                        {
                            Console.WriteLine("Opção inválida...");
                        }
                    }
                }
                Console.WriteLine("Navegue pelo noso menu de opções abaixo!");
                Console.WriteLine("1 - Inserir Novo correntista");
                Console.WriteLine("2 - Consultar correntista");
                Console.WriteLine("3 - Deletar correntista");
                Console.WriteLine("4 - Editar correntista");                
                Console.WriteLine("5 - Sair do sistema");
                Console.Write("Digite uma das opções do menu: ");
                //var correntista = new Correntista(cpf,nome,sobrenome,rendaComprovada,data);
                resposta = int.Parse(Console.ReadLine());
                              
                Console.WriteLine();
                switch (resposta)
                {
                    case 1:
                        NovoCorrentista();
                    break;
                    case 2:
                        ConsultarCorrentista();
                    break;
                    case 3:
                        ExcluirCorrentista();
                    break;
                    case 4:
                        EditarCorrentista();
                    break;
                    case 5:
                        Console.WriteLine("Saindo...");
                    break;
                    default:
                        Console.WriteLine("A opção selecionada não está disponível em nosso menu!");
                    break;
                }
            }

        }
        static void NovoCorrentista()
        {
            cpf = "";
            nome = ""; 
            sobrenome = "";
            rendaComprovada = 0.0;
                Console.Write("Informe o CPF do novo correntista (Use apenas números): ");
                cpf = Console.ReadLine();
                Console.WriteLine();
                for (int i = 0; i < cpf.Length; i++)
                {
                    string lercpf = cpf;
                    int letracpf = Convert.ToInt32(lercpf[i]);
                    if (letracpf < 48 || letracpf > 57)
                    {
                        Console.WriteLine("3RR0R: O número CPF deve conter apenas números...");
                        Console.Write("Informe o CPF do novo correntista (Use apenas números): ");
                        cpf = "";
                        cpf = Console.ReadLine();
                        i=0;
                        Console.WriteLine();
                    }

                }
                for (int i = 0; i < index; i++)
                {
                    while (correntistas[i].Cpf == cpf || cpf.Length != 11)
                    {
                        Console.WriteLine("3RR0R: O número de caracteres é diferente do número de caracteres que um CPF possui ou o CPF já está cadastrado...");
                        Console.Write("Informe o CPF do novo correntista (Use apenas números): ");
                        cpf = "";
                        cpf = Console.ReadLine();
                        Console.WriteLine();
                        for (int j = 0; j < cpf.Length; j++)
                        {
                            string lercpf = cpf;
                            int letracpf = Convert.ToInt32(lercpf[j]);
                            if (letracpf < 48 || letracpf > 57)
                            {
                                Console.WriteLine("3RR0R: O número CPF deve conter apenas números...");
                                Console.Write("Informe o CPF do novo correntista (Use apenas números): ");
                                cpf = "";
                                cpf = Console.ReadLine();
                                j=0;
                                Console.WriteLine();
                            }

                        }
                    }
                }    
                Console.Write("Informe o nome do novo correntista: ");
                nome = Console.ReadLine();
                Console.WriteLine();
                Console.Write("Informe o sobrenome do novo correntista: ");
                sobrenome = Console.ReadLine();
                Console.WriteLine();
                Console.Write("Informe o seu dia de nascimento: ");
                string ler = Console.ReadLine();
                int dia = Convert.ToInt32(ler);
                Console.WriteLine();
                Console.Write("Informe o seu mês de nascimento: ");
                ler = Console.ReadLine();
                int mes = Convert.ToInt32(ler);
                Console.WriteLine();
                Console.Write("Informe o seu ano de nascimento: ");
                ler = Console.ReadLine();
                int ano = Convert.ToInt32(ler);
                Console.WriteLine();
                var dataNascimento = new DateTime(ano,mes,dia);
                var dataAtual = DateTime.Now;
                int diaAtual = dataAtual.Day;
                int mesAtual = dataAtual.Month;
                int anoAtual = dataAtual.Year;
                if (mesAtual==mes)
                {
                    if (diaAtual>=dia)
                    {
                        idade = anoAtual-ano;
                    } else 
                    {
                        idade = anoAtual-ano-1;
                    }
                } else if (mesAtual>mes)
                {
                    idade = anoAtual-ano;
                } else
                {
                    idade = anoAtual-ano-1;
                }
                Console.Write("Informe a renda comprovada do novo correntista (Ex: R$ 1111,11): R$ ");
                ler = Console.ReadLine();
                rendaComprovada = Convert.ToDouble(ler);
                Console.WriteLine();
                numero=1;

                for (int j = 0; j < index; j++)
                {
                    while (numero == contas[j].Numero)
                    {
                        numero++;
                        j=0;
                    }
                }

                Console.Write("Informe o saldo da conta do correntista (Ex: R$ 1111,11): R$ ");
                ler = Console.ReadLine();
                saldo = Convert.ToDouble(ler);
 
            var correntista = new Correntista(cpf,nome,sobrenome,rendaComprovada,dataNascimento,idade);
            var conta = new Conta(numero,saldo);
            Correntista [] tempCorrentista = new Correntista[correntistas.Length + 1];

            for (int j = 0; j < correntistas.Length; j++)
            {
                tempCorrentista[j] = correntistas[j];
            }
            correntistas = tempCorrentista;
            correntistas[index] = correntista;

            Conta [] tempConta = new Conta [contas.Length+1];
            for (int j = 0; j < contas.Length; j++)
            {
                tempConta[j] = contas[j];
            }
            contas = tempConta;
            contas[index] = conta;

            index++;
        }
        static void EditarCorrentista ()
        {
         Console.Write("informe o CPF do correntista que deseja editar (Use apenas números): ");
            var ler = Console.ReadLine();
            for (int i = 0; i < index; i++)
            {
                if (ler == correntistas[i].Cpf)
                {
                    Console.WriteLine("Deseja editar o CPF desse correntista? Sim/Não");
                    ler = Console.ReadLine();
                    ler = ler.ToLower();
                    if (ler == "sim")
                    {
                        Console.Write("Informe o novo CPF desse correntista (Use apenas números): ");
                        ler = Console.ReadLine();
                        Console.WriteLine();
                        for (int contar = 0; contar < index; contar++)
                        {
                            for (int j = 0; j < cpf.Length; j++)
                            {
                                string lercpf = cpf;
                                int letracpf = Convert.ToInt32(lercpf[j]);
                                if (letracpf < 48 || letracpf > 57)
                                {
                                    Console.WriteLine("3RR0R: O número CPF deve conter apenas números...");
                                    Console.Write("Informe o CPF do novo correntista (Use apenas números): ");
                                    cpf = "";
                                    cpf = Console.ReadLine();
                                    Console.WriteLine();
                                }
                            }
                            while (correntistas[contar].Cpf == ler || ler.Length != 11)
                            {
                                Console.WriteLine("3RR0R: O número de caracteres é diferente do número de caracteres que um CPF possui ou o CPF já está cadastrado...");
                                Console.Write("Informe o novo CPF do novo correntista (Use apenas números): ");
                                ler = Console.ReadLine();
                                Console.WriteLine();
                                contar = 0;
                            }
                        }
                        
                        correntistas[i].Cpf = ler;
                    }
                    Console.WriteLine("Deseja editar a data de nascimento desse correntista? Sim/Não");
                    ler = Console.ReadLine();
                    if (ler.ToLower()=="sim")
                    {
                        Console.Write("Informe a dia de nascimento do correntista: ");
                        ler = Console.ReadLine();
                        int dia = Convert.ToInt32(ler);
                        Console.WriteLine();
                        Console.Write("Informe a mês de nascimento do correntista: ");
                        ler = Console.ReadLine();
                        int mes = Convert.ToInt32(ler);
                        Console.WriteLine();
                        Console.Write("Informe a ano de nascimento do correntista: ");
                        ler = Console.ReadLine();
                        int ano = Convert.ToInt32(ler);
                        Console.WriteLine();
                        var dataAtual = DateTime.Now;
                        int diaAtual = dataAtual.Day;
                        int mesAtual = dataAtual.Month;
                        int anoAtual = dataAtual.Year;
                        if (mesAtual==mes)
                        {
                            if (diaAtual>=dia)
                            {
                                correntistas[i].Idade = anoAtual-ano;
                            } else 
                            {
                                correntistas[i].Idade = anoAtual-ano-1;
                            }
                        } else if (mesAtual>mes)
                        {
                            correntistas[i].Idade = anoAtual-ano;
                        } else
                        {
                            correntistas[i].Idade = anoAtual-ano-1;
                        }
                    }
                    Console.WriteLine("Deseja editar o nome desse correntista? Sim/Não");
                    ler = Console.ReadLine();
                    ler = ler.ToLower();
                    if (ler == "sim")
                    {
                        Console.Write("Informe o novo nome desse correntista: ");
                        correntistas[i].Nome = Console.ReadLine();
                        Console.WriteLine();
                    }
                    Console.WriteLine("Deseja editar o sobrenome desse correntista? Sim/Não");
                    ler = Console.ReadLine();
                    ler = ler.ToLower();
                    if (ler == "sim")
                    {
                        Console.Write("Informe o novo sobrenome desse correntista: ");
                        correntistas[i].Sobrenome = Console.ReadLine();
                        Console.WriteLine();
                    }
                    Console.WriteLine("Deseja editar a renda comprovada desse correntista? Sim/Não");
                    ler = Console.ReadLine();
                    ler = ler.ToLower();
                    if (ler == "sim")
                    {
                        Console.Write("Informe a nova renda comprovada desse correntista  (Ex: R$ 1111,11): ");
                        ler = Console.ReadLine();
                        correntistas[i].RendaComprovada = Convert.ToDouble(ler);
                        Console.WriteLine();
                    }
                } else
                {
                    Console.WriteLine("CPF não cadastrado!");
                }   
            }
        }
        static void ExcluirCorrentista()
        {
            Console.Write("Informe o CPF do correntista que deseja deletar (Use apenas números): ");
            string ler = Console.ReadLine();
            for (int i = 0; i < index; i++)
            {
                if (ler == correntistas[i].Cpf)
                {
                    Console.WriteLine($"Tem certeza que deseja deletar o correntista {i+1}? Sim/Não");
                    string ler1 = Console.ReadLine();
                    ler1 = ler1.ToLower();
                    if (ler1 == "sim")
                    {
                        Correntista [] correntistaTemp = new Correntista [correntistas.Length - 1];
                        Conta [] contasTemp = new Conta [contas.Length - 1];
                        int v=0;
                        for (int n = 0; n < index - 1; n++)
                        {
                            if (correntistas[i].Cpf == ler)
                            {
                                v=1;
                            }
                            if (v < 1)
                            {
                                correntistaTemp[n] = correntistas[n];
                                contasTemp[n] = contas[n];
                            } else
                            {
                                correntistaTemp[n] = correntistas[n+1];
                                contasTemp[n] = contas[n+1];
                            }
                        }
                        correntistas=correntistaTemp;
                        contas = contasTemp;
                        index--;
                        if (index < 0)
                        {
                            index = 0;
                        }
                                    
                    }
                } else if (i == index-1)
                {
                    Console.WriteLine("CPF não cadastrado!");
                }
            }
        }
        static void ConsultarCorrentista()
        {
            Console.Write("informe o CPF do correntista que deseja consultar (Use apenas números): ");
            string ler = Console.ReadLine();
            for (int i = 0; i < index; i++)
            {
                if (ler == correntistas[i].Cpf)
                {
                    string cpf = correntistas[i].Cpf;
                    Console.WriteLine("============================");
                    Console.WriteLine("Correntista " + (i+1));
                    Console.WriteLine();
                    Console.WriteLine(cpfcorrentista(i));
                    Console.WriteLine($"Idade: {correntistas[i].Idade} anos");
                    Console.WriteLine($"Nome: {correntistas[i].Nome}");
                    Console.WriteLine($"Sobrenome: {correntistas[i].Sobrenome}");
                    Console.WriteLine($"Renda Comprovada: R$ {correntistas[i].RendaComprovada}");
                    Console.WriteLine($"Conta {contas[i].Numero}");
                    Console.WriteLine($"Saldo: R$ {contas[i].Saldo}");
                    Console.WriteLine();
                    Console.WriteLine("============================\n");
                } else if (i == index-1)
                {
                    Console.WriteLine("CPF não cadastrado!");
                }
            }
        }
        static string cpfcorrentista (int i)
        {
            string cpf = correntistas[i].Cpf;
            return $"CPF: {cpf[0]}{cpf[1]}{cpf[2]}.{cpf[3]}{cpf[4]}{cpf[5]}.{cpf[6]}{cpf[7]}{cpf[8]}-{cpf[9]}{cpf[10]}";
        }
        static bool Sacar(double saque, int i)
        {
            if (saque <= contas[i].Saldo && saque > 0.0)
            {
                contas[i].Saldo -= saque;
                return true;
            }
            return false;
        }
        static bool Depositar(double deposito, int i)
        {
            if (deposito > 0.0)
            {
                contas[i].Saldo+=deposito;
                return true;
            }
            return false;
        }
        static bool Transacao(double transacao,int i, int j)
        {
            if (transacao <= contas[i].Saldo && transacao >0.0)
            {
                contas[i].Saldo-= transacao;
                contas[j].Saldo+= transacao;
                return true;
            }
            return false;
        }
    }
}

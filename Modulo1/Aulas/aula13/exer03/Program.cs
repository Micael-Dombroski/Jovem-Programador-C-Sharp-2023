using System;

namespace exer03
{
    class Program
    {
        static int index = 0;
        static Correntista [] correntistas = new Correntista[0];
        static void Main(string[] args)
        {
            
            //int c= 0;
            int resposta = 0;
            while (resposta != 5)
            {
                Console.WriteLine("Navegue pelo noso menu de opções abaixo!");
                Console.WriteLine("1 - Inserir Novo correntista");
                Console.WriteLine("2 - Consultar correntista");
                Console.WriteLine("3 - Deletar correntista");
                Console.WriteLine("4 - Editar correntista");                
                Console.WriteLine("5 - Sair do sistema");
                Console.Write("Digite uma das opções do menu: ");
                resposta = int.Parse(Console.ReadLine());
                var correntista = new Correntista();                
                Console.WriteLine();
                switch (resposta)
                {
                    case 1:
                        NovoCorrentista(correntista);
                    break;
                    case 2:
                        ConsultarCorrentista(correntista);
                    break;
                    case 3:
                        ExcluirCorrentista(correntista);
                    break;
                    case 4:
                        EditarCorrentista(correntista);
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
        static void NovoCorrentista(Correntista correntista)
        {
            Correntista [] tempCorrentista = new Correntista[correntistas.Length + 1];
            for (int j = 0; j < correntistas.Length; j++)
            {
                tempCorrentista[j] = correntistas[j];
            }
            correntistas = tempCorrentista;
            correntistas[index] = correntista;
            index++;
    
                Console.Write("Informe o CPF do novo correntista (Use apenas números): ");
                correntista.Cpf = Console.ReadLine();
                Console.WriteLine();
                for (int i = 0; i < index; i++)
                {
                    string lercpf = correntista.Cpf;
                    int letracpf = Convert.ToInt32(lercpf[i]);
                    if (letracpf < 48 || letracpf > 57)
                    {
                        Console.WriteLine("3RR0R: O número CPF deve conter apenas números...");
                        Console.Write("Informe o CPF do novo correntista (Use apenas números): ");
                        correntista.Cpf = "";
                        correntista.Cpf = Console.ReadLine();
                        Console.WriteLine();
                    }
                }
                if (index > 1)
                {
                    for (int i = 0; i < index-1; i++)
                    {
                        if (correntistas[i].Cpf == correntista.Cpf)
                        {
                            Console.WriteLine("CPF já cadastrado!");
                            Console.Write("Informe o CPF do novo correntista (Use apenas números): ");
                            correntista.Cpf = "";
                            correntista.Cpf = Console.ReadLine();
                            i = 0;
                            Console.WriteLine();
                        }
                    }
                    while (correntista.Cpf.Length != 11)
                    {
                        Console.WriteLine("3RR0R: O número de caracteres é diferente do número de caracteres que um CPF possui...");
                        Console.Write("Informe o CPF do novo correntista (Use apenas números): ");
                        correntista.Cpf = "";
                        correntista.Cpf = Console.ReadLine();
                        Console.WriteLine();
                        for (int i = 0; i < index-1; i++)
                        {
                            if (correntistas[i].Cpf == correntista.Cpf)
                            {
                                Console.WriteLine("CPF já cadastrado!");
                                Console.Write("Informe o CPF do novo correntista (Use apenas números): ");
                                correntista.Cpf = "";
                                correntista.Cpf = Console.ReadLine();
                                Console.WriteLine();
                            }
                        }
                    } 
                }    
                Console.Write("Informe o nome do novo correntista: ");
                correntista.Nome = Console.ReadLine();
                Console.WriteLine();
                Console.Write("Informe o sobrenome do novo correntista: ");
                correntista.Sobrenome = Console.ReadLine();
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
                correntista.DataNascimento = new DateTime(ano,mes,dia);
                var dataAtual = DateTime.Now;
                int diaAtual = dataAtual.Day;
                int mesAtual = dataAtual.Month;
                int anoAtual = dataAtual.Year;
                if (mesAtual==mes)
                {
                    if (diaAtual>=dia)
                    {
                        correntista.Idade = anoAtual-ano;
                    } else 
                    {
                        correntista.Idade = anoAtual-ano-1;
                    }
                } else if (mesAtual>mes)
                {
                    correntista.Idade = anoAtual-ano;
                } else
                {
                    correntista.Idade = anoAtual-ano-1;
                }
                Console.Write("Informe a renda comprovada do novo correntista: R$ ");
                correntista.RendaComprovada = Console.ReadLine();
                Console.WriteLine();
 
            correntista.Index++;
        }
        static void EditarCorrentista (Correntista correntista)
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
                    Console.WriteLine("Deseja eidtar a data de nascimento desse correntista? Sim/Não");
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
                        Console.Write("Informe a nova renda comprovada desse correntista: ");
                        correntistas[i].RendaComprovada = Console.ReadLine();
                        Console.WriteLine();
                    }
                } else
                {
                    Console.WriteLine("CPF não cadastrado!");
                }   
            }
        }
        static void ExcluirCorrentista(Correntista correntista)
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
                        Correntista [] correntistaTemp = new Correntista [index];
                        int v=0;
                        for (int n = 0; n < index; n++)
                        {
                            if (correntistas[i].Cpf == ler)
                            {
                                v=1;
                            }
                            if (v < 1)
                            {
                                correntistaTemp[n] = correntistas[n];
                            } else
                            {
                                correntistaTemp[n] = correntistas[n+1];
                            }
                        }
                        correntistas=correntistaTemp;
                        index--;
                                    
                    }
                } else if (i == index-1)
                {
                    Console.WriteLine("CPF não cadastrado!");
                }
            }
        }
        static void ConsultarCorrentista(Correntista correntista)
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
    }
}

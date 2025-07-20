using System;

namespace exer04
{
    class Program
    {
        static int index = 0;
        static Correntista [] correntistas = new Correntista[0];
        static string cpf = "";
        static string nome = ""; 
        static string sobrenome = "";
        static double rendaComprovada = 0.0;
        static int idade = 0;
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
 
            var correntista = new Correntista(cpf,nome,sobrenome,rendaComprovada,dataNascimento,idade);
            Correntista [] tempCorrentista = new Correntista[correntistas.Length + 1];
            for (int j = 0; j < correntistas.Length; j++)
            {
                tempCorrentista[j] = correntistas[j];
            }
            correntistas = tempCorrentista;
            correntistas[index] = correntista;
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
                            } else
                            {
                                correntistaTemp[n] = correntistas[n+1];
                            }
                        }
                        correntistas=correntistaTemp;
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

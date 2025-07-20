using System;

namespace exer03
{
    class Program
    {
        static void Main(string[] args)
        {
            string [,] correntista = new string [1,4];
            int c= 0;
            int resposta = 0;
            while (resposta != 6)
            {
                Console.WriteLine("Navegue pelo noso menu de opções abaixo!");
                Console.WriteLine("1 - Novo correntista");
                Console.WriteLine("2 - Editar correntista");
                Console.WriteLine("3 - Consultar correntista");
                Console.WriteLine("4 - Deletar correntista");
                Console.WriteLine("5 - Mostrar todos os correntistas");
                Console.WriteLine("6 - Sair do sistema");
                Console.Write("Digite uma das opções do menu: ");
                resposta = int.Parse(Console.ReadLine());
                Console.WriteLine();
                switch (resposta)
                {
                    case 1:
                        if (c < 1)
                        {
                            Console.Write("Informe o CPF do novo correntista (Use apenas números): ");
                            correntista [c,0] = Console.ReadLine();
                            Console.WriteLine();
                            for (int i = 0; i < correntista[c,0].Length; i++)
                            {
                                string lercpf = correntista[c,0];
                                int letracpf = Convert.ToInt32(lercpf[i]);
                                if (letracpf < 48 || letracpf > 57)
                                {
                                    Console.WriteLine("3RR0R: O número CPF deve conter apenas números...");
                                    Console.Write("Informe o CPF do novo correntista (Use apenas números): ");
                                    correntista[c,0] = "";
                                    correntista [c,0] = Console.ReadLine();
                                    Console.WriteLine();
                                }
                            }
                            while (correntista[c,0].Length != 11)
                            {
                                Console.WriteLine("3RR0R: O número de caracteres é diferente do número de caracteres que um CPF possui...");
                                Console.Write("Informe o CPF do novo correntista: ");
                                correntista[c,0] = "";
                                correntista [c,0] = Console.ReadLine();
                                Console.WriteLine();
                                for (int i = 0; i < correntista[c,0].Length; i++)
                                {
                                    string lercpf = correntista[c,0];
                                    int letracpf = Convert.ToInt32(lercpf[i]);
                                    if (letracpf < 48 || letracpf > 57)
                                    {
                                        Console.WriteLine("3RR0R: O número CPF deve conter apenas números...");
                                        Console.Write("Informe o CPF do novo correntista (Use apenas números): ");
                                        correntista[c,0] = "";
                                        correntista [c,0] = Console.ReadLine();
                                        Console.WriteLine();
                                    }
                                }
                            }
                            
                            Console.Write("Informe o nome do novo correntista: ");
                            correntista [c,1] = Console.ReadLine();
                            Console.WriteLine();
                            Console.Write("Informe o sobrenome do novo correntista: ");
                            correntista [c,2] = Console.ReadLine();
                            Console.WriteLine();
                            Console.Write("Informe a renda comprovada do novo correntista: R$ ");
                            correntista [c,3] = Console.ReadLine();
                            Console.WriteLine();
                        } else 
                        {
                            aumentararray(c,ref correntista);
                            Console.Write("Informe o CPF do novo correntista (Use apenas números): ");
                            correntista [c,0] = Console.ReadLine();
                            Console.WriteLine();
                            for (int i = 0; i < c; i++)
                            {
                                if (correntista[c,0] == correntista[i,0])
                                {
                                    Console.WriteLine("CPF já cadastrado!");
                                    Console.Write("Informe o CPF do novo correntista (Use apenas números): ");
                                    correntista[c,0] = "";
                                    correntista [c,0] = Console.ReadLine();
                                    Console.WriteLine();
                                }
                            }
                            while (correntista[c,0].Length != 11)
                            {
                                Console.WriteLine("3RR0R: O número de caracteres é diferente do número de caracteres que um CPF possui...");
                                Console.Write("Informe o CPF do novo correntista (Use apenas números): ");
                                correntista[c,0] = "";
                                correntista [c,0] = Console.ReadLine();
                                Console.WriteLine();
                                for (int i = 0; i < c; i++)
                                {
                                    if (correntista[c,0] == correntista[i,0])
                                    {
                                        Console.WriteLine("CPF já cadastrado!");
                                        Console.Write("Informe o CPF do novo correntista (Use apenas números): ");
                                        correntista[c,0] = "";
                                        correntista [c,0] = Console.ReadLine();
                                        Console.WriteLine();
                                    }
                                }
                            }
                            Console.Write("Informe o nome do novo correntista: ");
                            correntista [c,1] = Console.ReadLine();
                            Console.WriteLine();
                            Console.Write("Informe o sobrenome do novo correntista: ");
                            correntista [c,2] = Console.ReadLine();
                            Console.WriteLine();
                            Console.Write("Informe a renda comprovada do novo correntista: R$ ");
                            correntista [c,3] = Console.ReadLine();
                            Console.WriteLine();
                        }
                        c++;
                    break;
                    case 2:
                        Console.Write("informe o CPF do correntista que deseja editar (Use apenas números): ");
                        var ler = Console.ReadLine();
                        for (int i = 0; i < c; i++)
                        {
                            if (ler == correntista[i,0])
                            {
                                Console.WriteLine("Deseja editar o CPF desse correntista? Sim/Não");
                                ler = Console.ReadLine();
                                ler = ler.ToLower();
                                if (ler == "sim")
                                {
                                    Console.Write("Informe o novo CPF desse correntista (Use apenas números): ");
                                    ler = Console.ReadLine();
                                    Console.WriteLine();
                                    for (int contar = 0; contar < c; contar++)
                                    {
                                        while (correntista[contar,0] == ler || ler.Length != 11)
                                        {
                                            Console.WriteLine("3RR0R: O número de caracteres é diferente do número de caracteres que um CPF possui ou o CPF já está cadastrado...");
                                            Console.Write("Informe o novo CPF do novo correntista (Use apenas números): ");
                                            ler = Console.ReadLine();
                                            Console.WriteLine();
                                            contar = 0;
                                        }
                                    }
                                    correntista[i,0] = ler;
                                }
                                Console.WriteLine("Deseja editar o nome desse correntista? Sim/Não");
                                ler = Console.ReadLine();
                                ler = ler.ToLower();
                                if (ler == "sim")
                                {
                                    Console.Write("Informe o novo nome desse correntista: ");
                                    correntista [i,1] = Console.ReadLine();
                                    Console.WriteLine();
                                }
                                Console.WriteLine("Deseja editar o sobrenome desse correntista? Sim/Não");
                                ler = Console.ReadLine();
                                ler = ler.ToLower();
                                if (ler == "sim")
                                {
                                    Console.Write("Informe o novo sobrenome desse correntista: ");
                                    correntista [i,2] = Console.ReadLine();
                                    Console.WriteLine();
                                }
                                Console.WriteLine("Deseja editar a renda comprovada desse correntista? Sim/Não");
                                ler = Console.ReadLine();
                                ler = ler.ToLower();
                                if (ler == "sim")
                                {
                                    Console.Write("Informe a nova renda comprovada desse correntista: ");
                                    correntista [i,3] = Console.ReadLine();
                                    Console.WriteLine();
                                }
                            } else
                            {
                                Console.WriteLine("CPF não cadastrado!");
                            }
                        }
                    break;
                    case 3:
                        Console.Write("informe o CPF do correntista que deseja consultar (Use apenas números): ");
                        ler = Console.ReadLine();
                        for (int i = 0; i < c; i++)
                        {
                            if (ler == correntista[i,0])
                            {
                                string cpf = correntista[i,0];
                                Console.WriteLine("============================");
                                Console.WriteLine("Correntista " + (i+1));
                                Console.WriteLine();
                                Console.WriteLine(cpfcorrentista(i,correntista));
                                Console.WriteLine(nomecorrentista(i,correntista));
                                Console.WriteLine(sobrenomecorrentista(i,correntista));
                                Console.WriteLine(rendacompcorrentista(i,correntista));
                                Console.WriteLine();
                                Console.WriteLine("============================\n");
                            } else if (i == c-1)
                            {
                                Console.WriteLine("CPF não cadastrado!");
                            }
                        }
                    break;
                    case 4:
                        Console.Write("informe o CPF do correntista que deseja deletar (Use apenas números): ");
                        ler = Console.ReadLine();
                        for (int i = 0; i < c; i++)
                        {
                            if (ler == correntista[i,0])
                            {
                                Console.WriteLine($"Tem certeza que deseja deletar o correntista {i+1}? Sim/Não");
                                string ler1 = Console.ReadLine();
                                ler1 = ler1.ToLower();
                                if (ler1 == "sim")
                                {
                                    reduzarray(c,ref correntista,ler);
                                    c--;
                                    
                                }
                            } else if (i == c-1)
                            {
                                Console.WriteLine("CPF não cadastrado!");
                            }
                        }
                    break;
                    case 5:
                        Console.WriteLine("Abaixo está a lista de todos os correntistas...\n");
                        for (int i = 0; i < c; i++)
                        {
                            Console.WriteLine("============================");
                            Console.WriteLine("Correntista " + (i+1));
                            Console.WriteLine();
                            Console.WriteLine(cpfcorrentista(i,correntista));
                            Console.WriteLine(nomecorrentista(i,correntista));
                            Console.WriteLine(sobrenomecorrentista(i,correntista));
                            Console.WriteLine(rendacompcorrentista(i,correntista));
                            Console.WriteLine();
                            Console.WriteLine("============================\n");

                        }
                    break;
                    case 6:
                        Console.WriteLine("Saindo...");
                    break;
                    default:
                        Console.WriteLine("A opção selecionada não está disponível em nosso menu!");
                    break;
                }
            }
        } //cont = c; array = correntista;
        static void aumentararray (int cont, ref string [,] array)
        {
            string [,] temp = new string [cont+1,4];
                for (int i = 0; i < cont ; i++)
                {
                    temp [i,0] = array [i,0];
                    temp [i,1] = array [i,1];
                    temp [i,2] = array [i,2];
                    temp [i,3] = array [i,3];
                }
                array=temp;
        }//cont = c; aray = correntista; leitura = ler;
        static void reduzarray (int cont, ref string [,] array, string leitura)
        {
            string [,] temp = new string [cont,4];
            int v=0;
            for (int n = 0; n < cont; n++)
            {
                if (array[n,0] == leitura)
                {
                    v=1;
                }
                if (v < 1)
                {
                    temp[n,0] = array[n,0];
                    temp[n,1] = array[n,1];
                    temp[n,2] = array[n,2];
                    temp[n,3] = array[n,3];
                } else if (n==cont-1)
                {
                    temp[n,0] = "";
                    temp[n,1] = "";
                    temp[n,2] = "";
                    temp[n,3] = "";
                } else
                {
                    temp[n,0] = array[n+1,0];
                    temp[n,1] = array[n+1,1];
                    temp[n,2] = array[n+1,2];
                    temp[n,3] = array[n+1,3];
                }
            }
            array=temp;
        }//indi = i; array = correntista;
        static string cpfcorrentista (int indi, string [,] array)
        {
            string cpf = array[indi,0];
            return $"CPF: {cpf[0]}{cpf[1]}{cpf[2]}.{cpf[3]}{cpf[4]}{cpf[5]}.{cpf[6]}{cpf[7]}{cpf[8]}-{cpf[9]}{cpf[10]}";
        }
        static string nomecorrentista (int indi, string [,] array)
        {
            string cpf = array[indi,0];
            return $"Nome: {array[indi,1]}";
        }
        static string sobrenomecorrentista (int indi, string [,] array)
        {
            string cpf = array[indi,0];
            return $"Sobrenome: {array[indi,2]}";
        }
        static string rendacompcorrentista (int indi, string [,] array)
        {
            string cpf = array[indi,0];
            return $"Renda comprovada: R$ {array[indi,3]}";
        }
    }
}

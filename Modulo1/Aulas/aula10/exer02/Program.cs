using System;

namespace exer02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos funcionários solicitaram aposentadoria?");
            var ler = Console.ReadLine();
            int n = Convert.ToInt32(ler);
            int maiornome = 0;
            string [] nome = new string [n];
            int [] idade = new int [n];
            int [] anostrabalhados = new int [n];
            string [] vaiaposentar = new string [n];
            for (int c = 0; c < n; c++)
            {
                Console.Write("Informe o nome do Funcionário " + (c+1) + ": ");
                ler = Console.ReadLine();
                nome[c] = nomefuncionario(nome[c],ler);
                if (maiornome < nome[c].Length)
                {
                    maiornome = nome[c].Length;
                }
                idade[0] = 0;
                Console.WriteLine("");
                Console.Write("Informe a idade do Funcionário " + (c+1) + ": ");
                ler = Console.ReadLine();
                int lerint = Convert.ToInt32(ler);
                idade[c] = idadefuncionario(idade[c],lerint);
                if (idade[c] == 0) {
                    Console.WriteLine("A idade informada é muito baixa, informe outra idade...");
                    Console.Write("Informe a idade do Funcionário " + (c+1) + ": ");
                    ler = Console.ReadLine();
                    lerint = Convert.ToInt32(ler);
                    idade[c] = idadefuncionario(idade[c],lerint);
                }
                Console.WriteLine("");
                anostrabalhados[c] = 0;
                Console.Write("Informe os anos trabalhados do Funcionário " + (c+1) + ": ");
                ler = Console.ReadLine();
                lerint = Convert.ToInt32(ler);
                anostrabalhados[c] = tempdtrabalho(anostrabalhados[c], lerint, idade[c]);
                if (anostrabalhados[c] == 0)
                {
                    Console.WriteLine("A idade do funcionário não pode ser  inferior ao seus anos trabalhados...");
                    Console.Write("Informe os anos trabalhados do Funcionário " + (c+1) + ": ");
                    ler = Console.ReadLine();
                    lerint = Convert.ToInt32(ler);
                    anostrabalhados[c] = tempdtrabalho(anostrabalhados[c], lerint, idade[c]);
                }
                Console.WriteLine("");
                vaiaposentar[c] = vaiapos(idade[c], anostrabalhados[c]);
            }
            Console.WriteLine("Relatório...");
            Console.Write("Nome");
            for (int c =0; c < maiornome + 4; c++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("Idade          Tempo          Situação");
            Console.Write("----");
            for (int c =0; c < maiornome + 6; c++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("-----          -----          --------");
            for (int c = 0; c < n; c++)
            {
                    Console.Write(nome[c]);
                    int nspaces = (maiornome-nome[c].Length) + 7;
                    for (int c1 = 0; c1 < nspaces; c1++)
                    {
                        Console.Write(" ");
                    }
                    if (idade[c] < 10) {
                        Console.Write("0" + idade[c] + " anos");
                    } else
                    {
                        Console.Write(idade[c] + " anos");
                    }
                    Console.Write("        ");
                    if (anostrabalhados[c] < 10) {
                        Console.Write("0" + anostrabalhados[c] + " anos");
                    } else
                    {
                        Console.Write(anostrabalhados[c] + " anos");
                    }
                    Console.Write("          ");
                    Console.WriteLine(vaiaposentar[c]);
            }
        }
        static string nomefuncionario (string v1,  string v2)
        {
            v1 = v2;
            return v1;
        }
        static int idadefuncionario (int v1,  int v2)
        {
            if (v2 > 13)
            {
                v1=v2;
            }
            return v1;
        }
        static  int tempdtrabalho (int v1, int v2, int v3)
        {
            if (v2 < v3)
            {
                v1=v2;
            }
            return v1;
        }
        static string vaiapos (int v1, int v2)
        {
            if (v1 > 64 || v2 > 34 || (v1 > 59 && v2 > 25))
            {
                return "Sim";
            } else
            {
                return "Não";
            }
        }    
        
    }
}

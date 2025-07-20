using System;

namespace exer06
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
                nome[c] = ler;
                if (maiornome < nome[c].Length)
                {
                    maiornome = nome[c].Length;
                }
                Console.WriteLine("");
                Console.Write("Informe a idade do Funcionário " + (c+1) + ": ");
                ler = Console.ReadLine();
                idade[c] = Convert.ToInt32(ler);
                Console.WriteLine("");
                Console.Write("Informe os anos trabalhados do Funcionário " + (c+1) + ": ");
                ler = Console.ReadLine();
                anostrabalhados[c] = Convert.ToInt32(ler);
                Console.WriteLine("");
                int ano = idade[c];
                int anotb = anostrabalhados[c];
                while (ano < anotb)
                {
                    Console.WriteLine("ERR0R: A diferença entre a idade e  anos trabalhados não bate!");
                    Console.Write("Informe os anos trabalhados do Funcionário " + (c+1) + ": ");
                    ler = Console.ReadLine();
                    anostrabalhados[c] = Convert.ToInt32(ler);
                    anotb = anostrabalhados[c];
                }
                if (ano >= 65 || anotb >= 35)
                {
                    vaiaposentar[c] = "Sim";
                } else if (ano >= 60 && anotb >= 25)
                {
                    vaiaposentar[c] = "Sim";
                } else {
                    vaiaposentar[c] = "Não";
                }
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
    }
}

using System;

namespace exer02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos trabalhadores solicitaram a aposentadoria?");
            var ler = Console.ReadLine();
            int n = Convert.ToInt32(ler);
            string [,] solaposent = new string  [n,4];
            int idade = 0; 
            int tempotb = 0; 
            int maiornome = 0;
            for (int c = 0; c < n; c++)
            {
                Console.Write("Informe o nome do Funcionário " + (c+1) + ": ");
                ler = Console.ReadLine();
                solaposent[c,0] = ler;
                if (maiornome < solaposent[c,0].Length)
                {
                    maiornome = solaposent[c,0].Length;
                }
                Console.WriteLine("");
                Console.Write("Informe a idade do Funcionário " + (c+1) + ": ");
                ler = Console.ReadLine();
                idade = Convert.ToInt32(ler);
                if (idade < 10) {
                        solaposent[c,1] = $"0{idade} anos";
                    } else
                    {
                        solaposent[c,1] = $"{idade} anos";
                    }
                Console.WriteLine("");
                Console.Write("Informe os anos trabalhados do Funcionário " + (c+1) + ": ");
                ler = Console.ReadLine();
                tempotb = Convert.ToInt32(ler);
                while (tempotb > idade)
                {
                    Console.WriteLine("ERR0R: A diferença entre a idade e  anos trabalhados não bate!");
                    Console.Write("Informe os anos trabalhados do Funcionário " + (c+1) + ": ");
                    ler = Console.ReadLine();
                    tempotb = Convert.ToInt32(ler);
                }
                if (tempotb < 10) {
                    solaposent[c,2]= $"0{tempotb} anos";
                } else
                {
                    solaposent[c,2]= $"{tempotb} anos";
                }
                Console.WriteLine("");
                if (idade >= 65 || tempotb >= 35)
                {
                    solaposent[c,3] = "Sim";
                } else if (idade >= 60 && tempotb >= 25)
                {
                    solaposent[c,3] = "Sim";
                } else {
                    solaposent[c,3] = "Não";
                }
            }
            Console.WriteLine("Relatório...");
            Console.Write("Nome");
            for (int c =0; c < maiornome + 6; c++)
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
                    Console.Write(solaposent[c,0]);
                    int nspaces = (maiornome-solaposent[c,0].Length) + 10;
                    for (int c1 = 0; c1 < nspaces; c1++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(solaposent[c,1]);
                    Console.Write("        ");
                    Console.Write(solaposent[c,2]);
                    Console.Write("          ");
                    Console.WriteLine(solaposent[c,3]);
            }
        }
    }
}

using System;

namespace exer04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos contatos você tem na agenda?");
            var ler = Console.ReadLine();
            int n = Convert.ToInt32(ler);
            string [,] infocontato = new string [n,3];
            string ntelefone = "";
            int numerotel = 0, qtnumeros = 0, qtcharespecial = 0;
            for (int c =0; c < n; c++)
            {
                Console.Write("Informe o nome do contato " + (c+1) + ": ");
                infocontato [c,0] = Console.ReadLine();
                Console.WriteLine("");
                Console.Write("Informe o número de telefone desse contato (Ex: (11) 11111-1111): ");
                ntelefone = Console.ReadLine();
                Console.WriteLine("");
                for (int c1 = 0; c1 < ntelefone.Length; c1++)
                {
                    numerotel = ntelefone[c1];
                    if (numerotel > 47 && numerotel < 58)
                    {
                        qtnumeros++;
                    } else
                    {
                        qtcharespecial++;
                    }
                }
                while (qtcharespecial > 4 || qtnumeros > 11)
                {
                    if (qtcharespecial > 4)
                    {
                        Console.WriteLine("3RR0R: Parece que o número de  telefone informado possui mais caracteres especiais que o permitido...");
                    }
                    if (qtnumeros > 11)
                    {
                        Console.WriteLine("3RR0R: Parece que o número de  telefone informado possui mais números que o permitido...");
                    }
                    Console.Write("Informe o número de telefone desse contato (Ex: (11) 11111-1111): ");
                    ntelefone = Console.ReadLine();
                    Console.WriteLine("");
                    qtnumeros=0;
                    qtcharespecial=0;
                    for (int c1 = 0; c1 < ntelefone.Length; c1++)
                    {
                        numerotel = ntelefone[c1];
                        if (numerotel > 47 && numerotel < 58)
                        {
                            qtnumeros++;
                        } else
                        {
                            qtcharespecial++;
                        }
                    }
                }
                infocontato[c,1] = ntelefone;
                Console.Write("Informe o endereço desse contato: ");
                infocontato[c,2] = Console.ReadLine();
                Console.WriteLine("");
            }
            Console.WriteLine("===========================");
            Console.WriteLine("     Lista de Contatos     ");
            Console.WriteLine("===========================");
            for (int c =0; c< n; c++)
            {
                Console.WriteLine("Nome: " + infocontato[c,0]);
                Console.WriteLine("Telefone: " + infocontato[c,1]);
                Console.WriteLine("Endereço: " + infocontato[c,2]);
                Console.WriteLine("");
            }
            Console.WriteLine("===========================");
        }
    }
}

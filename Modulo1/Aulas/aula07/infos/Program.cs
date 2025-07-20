using System;

namespace infos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Estruturas de repetição: for, while, do e foreach...
            for (int c = 0; c < 9; c++)
            {
                Console.WriteLine(c);
            }
            Console.WriteLine("Fim!");
            int c1 = 0;
            while (c1 < 9) 
            {
                Console.WriteLine(c1);
                c1++;
            }
            int c2 = 0;
            Console.WriteLine("Fim!");
            do {
                Console.WriteLine(c2);
                c2++;
            } while (c2 < 9 );
            Console.WriteLine("Fim!");
            /*string horario = "";
            for (int hora = 0; hora < 24; hora++)
            {
                for (int minuto = 0; minuto < 60; minuto ++)
                {
                    for (int segundo = 0; segundo < 60; segundo ++)
                    {
                        Console.WriteLine("Horário: " + hora + ":" + minuto + ":" + segundo);
                        horario = $"{hora}:{minuto}:{segundo}";
                    }
                }
            }
            Console.WriteLine("Horário: 00:00:00");*/

        }
    }
}

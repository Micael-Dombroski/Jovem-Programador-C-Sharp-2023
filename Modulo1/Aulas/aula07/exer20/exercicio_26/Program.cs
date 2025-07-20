using System;

namespace exercicio_26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira um número: ");
            var ler = Console.ReadLine();
            int c = 1;
            int random = 0;
            do
            {
                Console.WriteLine(ler);
                c++;
                random = c;
            } while (c < 1000);
            Console.WriteLine(random);
        }
    }
}

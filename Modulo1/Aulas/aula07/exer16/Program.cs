using System;

namespace exer16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira um número: ");
            var ler = Console.ReadLine();
            int c = 1;
            int random = 0;
            while (c <= 1000)
            {
                Console.WriteLine(ler);
                c++;
                random = c;
            }
            //Console.WriteLine(random);
        }
    }
}

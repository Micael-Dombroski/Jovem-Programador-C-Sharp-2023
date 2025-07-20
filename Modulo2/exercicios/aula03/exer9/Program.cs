using System;

namespace exer9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira um número: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine($"{n}x{i}={n*i}");
                Console.ReadKey();
            }
        }
    }
}

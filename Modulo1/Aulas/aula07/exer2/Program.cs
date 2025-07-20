using System;

namespace exer2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira um número: ");
            var ler = Console.ReadLine();
            int num = Convert.ToInt32(ler);
            for (int c = 1; c <= 10; c++)
            {
                Console.WriteLine(num + " x " + c + " = " + (num * c));
            }
        }
    }
}

using System;

namespace exer13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um número: ");
            var ler = Console.ReadLine();
            double n = Convert.ToDouble(ler);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(n + " x 1 = " + (n*1));
            Console.WriteLine(n + " x 2 = " + (n*2));
            Console.WriteLine(n + " x 3 = " + (n*3));
            Console.WriteLine(n + " x 4 = " + (n*4));
            Console.WriteLine(n + " x 5 = " + (n*5));
            Console.WriteLine(n + " x 6 = " + (n*6));
            Console.WriteLine(n + " x 7 = " + (n*7));
            Console.WriteLine(n + " x 8 = " + (n*8));
            Console.WriteLine(n + " x 9 = " + (n*9));
            Console.WriteLine(n + " x 10 = " + (n*10));
        }
    }
}

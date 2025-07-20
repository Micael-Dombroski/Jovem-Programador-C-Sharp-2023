using System;

namespace exer8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira um número: ");
            var ler = Console.ReadLine();
            double num = Convert.ToDouble(ler);
            int aleatorio = 0;
            for (int c = 1; c <= 1000; c++)
            {
                Console.WriteLine(num);
                aleatorio = c;
            }
            //Console.WriteLine(aleatorio);
        }
    }
}

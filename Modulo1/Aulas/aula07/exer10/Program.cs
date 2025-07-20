using System;

namespace exer10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira um número: ");
            var ler = Console.ReadLine();
            int num = Convert.ToInt32(ler);
            int c = 1;
            while (c <= 10)
            {
                Console.WriteLine(num + " x " + c + " = " + (num*c));
                c++;
            }
        }
    }
}

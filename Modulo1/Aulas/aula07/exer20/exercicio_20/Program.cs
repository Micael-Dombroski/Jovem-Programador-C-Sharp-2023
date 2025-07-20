using System;

namespace exercicio_20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira um número: ");
            var ler = Console.ReadLine();
            int num = Convert.ToInt32(ler);
            int c = 1;
            do
            {
                Console.WriteLine(num + " x " + c + " = " + (num*c));
                c++;
            } while (c <= 10);
        }
    }
}

using System;

namespace exer4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe um valor: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Informe outro valor: ");
            double b = double.Parse(Console.ReadLine());
            double x = a;
            a = b;
            b = x;
            Console.WriteLine("O valor armazenado na primeira variável foi: " + a);
            Console.WriteLine("O valor armazenado na segunda variável foi: " + b);
        }
    }
}

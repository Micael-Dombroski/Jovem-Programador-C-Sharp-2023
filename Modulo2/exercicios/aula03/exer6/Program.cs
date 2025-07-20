using System;

namespace exer6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe um número: ");
            int n = int.Parse(Console.ReadLine());
            if (n > 0)
            {
                for (int i = n; i >= 0; i--)
                {
                    Console.WriteLine(i);
                }
            } else
            {
                for (int i = n; i <= 0; i++)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

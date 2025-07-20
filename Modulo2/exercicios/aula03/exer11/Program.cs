using System;

namespace exer11
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 11; i++)
            {
                for (int j = 0; j < 11; j++)
                {
                    Console.Write($"{j}x{i}={j*i}\t");
                }
                Console.WriteLine();
            }
        }
    }
}

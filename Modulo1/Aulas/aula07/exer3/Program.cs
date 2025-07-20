using System;

namespace exer3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int c = 1; c <= 10; c++)
            {
                for (int c2 = 1; c2 <= 10; c2++)
                {
                    Console.WriteLine(c + " x " + c2 + " = " + (c * c2));
                }
                Console.WriteLine(" ");
            }
        }
    }
}

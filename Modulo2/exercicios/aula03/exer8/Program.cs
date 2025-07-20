using System;

namespace exer8
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1=0;
            int n2=1;
            int n3=0;
            Console.Write($"{n1}, {n2}, ");
            while (n3 < 500)
            {
                n3=n1+n2;
                n1=n2;
                n2=n3;
                if (n3 > 500)
                {
                    Console.Write($"{n3}.");
                } else
                {
                    Console.Write($"{n3}, ");
                }
            }
        }
    }
}

using System;

namespace exer7
{
    class Program
    {
        static void Main(string[] args)
        {
            int numprimo;
            for (int n = 1; n < 1000; n++)
            {
                numprimo = 0;
                for (int c = n; c >= 1; c--)
                {
                    if (n == 1)
                    {
                        numprimo++;
                    }
                    if (n%c == 0)
                    {
                        numprimo++;
                    }
                }
                if (numprimo == 2) {
                    Console.WriteLine(n);
                }
            }
        }
    }
}

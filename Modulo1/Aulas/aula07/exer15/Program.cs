using System;

namespace exer15
{
    class Program
    {
        static void Main(string[] args)
        {
            int numprimo;
            int n = 1;
            while (n < 1000)
            {
                numprimo = 0;
                int c = n;
                while (c >= 1)
                {
                    if (n == 1)
                    {
                        numprimo++;
                    }
                    if (n%c == 0)
                    {
                        numprimo++;
                    }
                    c--;
                }
                if (numprimo == 2) {
                    Console.WriteLine(n);
                }
                n++;
            }
        }
    }
}

using System;

namespace exercicio_25
{
    class Program
    {
        static void Main(string[] args)
        {
            int numprimo;
            int n = 1;
            do
            {
                numprimo = 0;
                int c = n;
                do
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
                } while (c >= 1);
                if (numprimo == 2) {
                    Console.WriteLine(n);
                }
                n++;
            } while (n < 1000);
        }
    }
}

using System;

namespace exer12
{
    class Program
    {
        static void Main(string[] args)
        {
            int c = 1;
            while (c <= 1000)
            {
                int traco = 1;
                while (traco == 1 && c < 1000)
                {
                    Console.Write(c + "-");
                    traco++;
                }
                while (c == 1000)
                {
                    Console.Write(c + ".");
                    c++;
                }
                c++;
            }
        }
    }
}

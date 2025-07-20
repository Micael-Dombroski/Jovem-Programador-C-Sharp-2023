using System;

namespace exercicio_22
{
    class Program
    {
        static void Main(string[] args)
        {
            int c = 1;
            do
            {
                int traco = 1;
                do
                {
                    Console.Write(c + "-");
                    traco++;
                } while (traco == 1 && c < 1000);
                c++;
            } while (c < 1000);
            Console.Write(c + ".");
        }
    }
}

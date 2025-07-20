using System;

namespace exercicio_24
{
    class Program
    {
        static void Main(string[] args)
        {
            int c = 1;
            do
            {
                Console.WriteLine(c);
                c+= 2;
            } while (c <= 1000);
        }
    }
}

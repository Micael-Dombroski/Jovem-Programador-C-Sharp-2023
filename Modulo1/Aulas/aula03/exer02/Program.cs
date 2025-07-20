using System;

namespace exer02 
{
    class Program
    {
        static void Main (string[] args)
        {
            var cont = 1;
            Console.WriteLine("0" + cont);
            while (cont < 9)
            {
                cont++;
                Console.ReadKey();
                Console.WriteLine("0" + cont);
            }
            cont++;
            Console.ReadKey();
            Console.WriteLine(cont);
        }
    }
}

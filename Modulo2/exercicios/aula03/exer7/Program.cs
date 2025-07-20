using System;

namespace exer7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o valor inicial: ");
            int inicio = int.Parse(Console.ReadLine());
            int fim;
            do 
            {
                Console.Write("Informe o valor final: ");
                fim = int.Parse(Console.ReadLine());
            } while (fim <= inicio);
            Console.WriteLine(inicio);
            for (int i = inicio; i < fim; i+=2)
            {
                if (i%2 == 1)
                {
                    i++;
                }
                Console.WriteLine(i);
            }
            Console.WriteLine(fim);
        }
    }
}

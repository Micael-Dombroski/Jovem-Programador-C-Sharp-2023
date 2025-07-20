using System;

namespace exer10
{
    class Program
    {
        static void Main(string[] args)
        {
            double [] n = new double[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Informe um valor: ");
                n[i] = double.Parse(Console.ReadLine());
            }
            double menor = n[0];
            double maior = n[0];
            for (int i = 0; i < 10; i++)
            {
                if (n[i] > maior)
                {
                    maior = n[i];
                }
                if (n[i] < menor)
                {
                    menor = n[i];
                }
            }
            Console.WriteLine("O maior valor informado foi: " + maior);
            Console.WriteLine("O menor valor informado foi: " + menor);
        }
    }
}

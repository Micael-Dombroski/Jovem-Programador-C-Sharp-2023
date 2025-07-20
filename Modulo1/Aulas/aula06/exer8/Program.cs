using System;

namespace exer8
{
    class Program
    {
        static void Main(string[] args)
        {
            int c = 0;
            var ler = "";
            string par = "";
            string impar = "";
            int n = 0;
            while (c < 5) {
                Console.WriteLine("Informe um valor: ");
                ler = Console.ReadLine();
                n = Convert.ToInt32(ler);
                if (n%2 == 0)
                {
                    Console.WriteLine("O valor " + n + " é par!");
                    par = $"{par} {n};";
                } else {
                    impar = $"{impar} {n};";
                    Console.WriteLine("O valor " + n + " é impar!");
                }
                c++;
            }
            Console.WriteLine("Valores Pares: " + par);
            Console.WriteLine("Valores Impares: " + impar);

        }
    }
}

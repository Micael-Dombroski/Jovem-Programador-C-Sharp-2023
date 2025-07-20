using System;

namespace exer12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Detector de ano bissexto");
            Console.WriteLine("Informe  o ano:");
            string ler = Console.ReadLine();
            int ano = Convert.ToInt32(ler);
            if (ano%4 == 0) {
                Console.WriteLine(ano + " é um ano bissexto!");
            } else {
                Console.WriteLine(ano + " não é um ano bissexto!");
            }
        }
    }
}

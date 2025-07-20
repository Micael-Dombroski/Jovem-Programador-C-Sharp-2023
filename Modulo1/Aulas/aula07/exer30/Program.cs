using System;

namespace exer30
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira um valor: ");
            var ler = Console.ReadLine();
            int num = Convert.ToInt32(ler);
            int numfat = 0;
            int contar = num;
            for (int c = 1; c < num; c++)
            {

                contar = contar * c;
                numfat = contar;
            }
            Console.WriteLine("O fatorial de " + num + " é " + numfat);
        }
    }
}

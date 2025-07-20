using System;

namespace exer18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira um número: ");
            var ler = Console.ReadLine();
            int num = Convert.ToInt32(ler);
            int soma = 0;
            while (num != 0)
            {
                if (num%2 == 1)
                {
                    soma += num;
                }
                Console.WriteLine("Quando quiser encerrar a entrada de dados insira 0");
                Console.WriteLine("Insira um número: ");
                ler = Console.ReadLine();
                num = Convert.ToInt32(ler);
            }
            Console.WriteLine("A soma dos números ímpares inseridos é: " + soma);
        }
    }
}

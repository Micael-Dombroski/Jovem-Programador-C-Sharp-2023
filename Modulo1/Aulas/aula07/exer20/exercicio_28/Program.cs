using System;

namespace exercicio_28
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quando quiser encerrar a entrada de dados insira 0");
            Console.WriteLine("Insira um número: ");
            var ler = Console.ReadLine();
            int num = Convert.ToInt32(ler);
            int soma = 0;
            do
            {
                if (num%2 == 1)
                {
                    soma += num;
                }
                Console.WriteLine("Insira um número: ");
                ler = Console.ReadLine();
                num = Convert.ToInt32(ler);
            } while (num != 0);
            Console.WriteLine("A soma dos números ímpares inseridos é: " + soma);
        }
    }
}

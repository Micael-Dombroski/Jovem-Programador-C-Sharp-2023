using System;

namespace exer9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa de doação de sangue!");
            Console.WriteLine("Informe sua idade: ");
            var ler = Console.ReadLine();
            byte idade = Convert.ToByte(ler);
            if (idade >= 18)
            {
                Console.WriteLine("Informe seu peso em Kg: ");
                ler = Console.ReadLine();
                double peso = Convert.ToDouble(ler);
                if (peso > 50 && peso < 120) 
                {
                    Console.WriteLine("Você está apto para doar sangue. :)");
                } else {
                    Console.WriteLine("Você não está apto para doar sangue.");
                    Console.WriteLine("Seu peso não se encaixa no necessário para ser doador de sangue. :(");
                }
            } else {
                Console.WriteLine("Você não está apto para doar sangue.");
                Console.WriteLine("Você não tem idade para doar sangue. :(");
            }
        }
    }
}

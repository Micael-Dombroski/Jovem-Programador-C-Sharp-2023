using System;

namespace exer19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o nome de uma pessoa: ");
            var ler = Console.ReadLine();
            Console.WriteLine("Deseja inserir outro nome? S/N");
            var resposta = Console.ReadLine();
            while (resposta == "S" || resposta == "s")
            {
                Console.WriteLine("Insira o nome de uma pessoa: ");
                ler = Console.ReadLine();
                Console.WriteLine("Deseja inserir outro nome? S/N");
                resposta = Console.ReadLine();
            }
        }
    }
}

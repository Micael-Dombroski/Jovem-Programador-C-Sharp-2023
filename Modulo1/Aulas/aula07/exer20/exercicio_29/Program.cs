using System;

namespace exercicio_29
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o nome de uma pessoa: ");
            var ler = Console.ReadLine();
            Console.WriteLine("Deseja inserir outro nome? S/N");
            var resposta = Console.ReadLine();
            do
            {
                Console.WriteLine("Insira o nome de uma pessoa: ");
                ler = Console.ReadLine();
                Console.WriteLine("Deseja inserir outro nome? S/N");
                resposta = Console.ReadLine();
            } while (resposta == "S" || resposta == "s");
        }
    }
}

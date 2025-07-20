using System;
namespace exer9 
{
    class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um número: ");
            var num = Console.ReadLine();
            int valor = Convert.ToInt32(num);
            Console.WriteLine("Número par: " + ((valor%2) == 0));
        }
    }
}

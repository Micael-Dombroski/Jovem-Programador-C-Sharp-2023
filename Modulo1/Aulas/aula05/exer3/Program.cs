using System;
namespace exer3
{
    class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira um número: ");
            decimal v1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Insira outro número: ");
            decimal v2 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Agora serão feitas algumas operação com os valores informados...");
            Console.WriteLine("Soma dos valores: " + (v1 + v2));
            Console.WriteLine("Subtração dos valores: " + (v1 - v2));
            Console.WriteLine("Divisão dos valores: " + (v1/v2));
            Console.WriteLine("Multiplicação dos valores: " + (v1 * v2));
        }
    }
}
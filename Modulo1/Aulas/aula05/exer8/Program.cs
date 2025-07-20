using System;
namespace exer8 
{
    class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um número:");
            var num = Console.ReadLine();
            int valor = Convert.ToInt32(num);
            decimal valor1 = Convert.ToDecimal(valor);
            Console.WriteLine("Somando o valor informado com 2 temos: " + (valor + 2));
            Console.WriteLine("Multiplicando o valor informado por 2 temos: " + (valor * 2));
            Console.WriteLine("Dividindo o valor informado por 2 temos: " + (valor1 / 2));
            Console.WriteLine("Subtraindo 2 do valor informado temos: " + (valor - 2));
            
        }
    }
}
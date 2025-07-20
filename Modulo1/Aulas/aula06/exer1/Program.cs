using System;

namespace exer1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Defina o comprimento em centímetros do primeiro lado do triângulo: ");
            var ler = Console.ReadLine();
            int lado1 = Convert.ToInt32(ler);
            Console.WriteLine("Defina o comprimento em centímetros do segundo lado do triângulo: ");
            ler = Console.ReadLine();
            int lado2 = Convert.ToInt32(ler);
            Console.WriteLine("Defina o comprimento em centímetros do terceiro lado do triângulo: ");
            ler = Console.ReadLine();
            int lado3 = Convert.ToInt32(ler);
            if (lado1 == lado2 && lado2 == lado3)
            {
                Console.WriteLine("O triângulo é equilátero!");
            } else if (lado1 != lado2 && lado2 != lado3 && lado1 != lado3)
            {
                Console.WriteLine("O triângulo é escaleno!");
            } else {
                Console.WriteLine("O triângulo é isóceles!");
            }
        }
    }
}

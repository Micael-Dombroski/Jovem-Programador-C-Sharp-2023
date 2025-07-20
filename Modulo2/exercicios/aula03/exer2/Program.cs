using System;

namespace exer2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Defina o comprimento em centímetros do primeiro lado do triângulo: ");
            string ler = Console.ReadLine();
            double lado1 = Convert.ToDouble(ler);
            Console.WriteLine("Defina o comprimento em centímetros do segundo lado do triângulo: ");
            ler = Console.ReadLine();
            double lado2 = Convert.ToDouble(ler);
            Console.WriteLine("Defina o comprimento em centímetros do terceiro lado do triângulo: ");
            ler = Console.ReadLine();
            double lado3 = Convert.ToDouble(ler);
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

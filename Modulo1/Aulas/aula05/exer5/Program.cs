using System;
namespace exer5 
{
    class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Descobrindo o Tipo de Triângulo.");
            Console.WriteLine("informe o comprimento do primeiro lado em centímetros: ");
            var v1 = Console.ReadLine();
            int lado1 = Convert.ToInt32(v1);
            Console.WriteLine("informe o comprimento do segundo lado em centímetros: ");
            var v2 = Console.ReadLine();
            int lado2 = Convert.ToInt32(v2);
            Console.WriteLine("informe o comprimento do terceiro lado em centímetros: ");
            var v3 = Console.ReadLine();
            int lado3 = Convert.ToInt32(v3);
            Console.WriteLine("Equilátero: " + (lado1 == lado2 && lado2 == lado3));
            Console.WriteLine("Escaleno: " + (lado1 != lado2 && lado2 != lado3 && lado1 != lado3));
            Console.WriteLine("Isóceles: " + ((lado1 == lado2 && lado1 != lado3) || (lado2 == lado3 && lado2 != lado1) || (lado1 == lado3 && lado1 != lado2)));
        }
    }
}
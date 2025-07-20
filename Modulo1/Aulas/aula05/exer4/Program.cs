using System;
namespace exer4 
{
    class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Para calcular a área de um triângulo equilátero será necessário algumas informações...");
            Console.WriteLine("Informe a medida dos lados do triângulo: ");
            var lado = Console.ReadLine();
            int vlado = Convert.ToInt32(lado);
            Console.WriteLine("A área do triângulo é: " + (((vlado * vlado) * (Math.Pow(3,1.5)))/4));
        }
    }
}
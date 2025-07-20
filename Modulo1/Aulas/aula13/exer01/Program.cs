using System;

namespace exer01
{
    class Program
    {
        static void Main(string[] args)
        {
            var calcArea = new Area();
            Console.Write("Informe o raio do círculo: ");
            string ler = Console.ReadLine();
            calcArea.Raio = Convert.ToDouble(ler);

            Console.Write($"A área do círculo é: {calcArea.CalcularArea()}.");
        }
    }
}

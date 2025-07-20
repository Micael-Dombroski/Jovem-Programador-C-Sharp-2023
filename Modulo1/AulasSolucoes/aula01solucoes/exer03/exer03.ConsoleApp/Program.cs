using System;
using exer03.Classes;

namespace exer03.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isQuadrado;
            bool isRetangulo;
            bool isCirculo;
            Console.WriteLine("Hello World!");
            IAreaCalculavel [] areaCalculavel = new IAreaCalculavel[9];
            areaCalculavel [0] = new Quadrado(5);
            areaCalculavel [1] = new Retangulo(10,6);
            areaCalculavel [2] = new Circulo(4);
            areaCalculavel [3] = new Quadrado(4.8);
            areaCalculavel [4] = new Retangulo(9,4.5);
            areaCalculavel [5] = new Circulo(3.2);
            areaCalculavel [6] = new Quadrado(6.9);
            areaCalculavel [7] = new Retangulo(3,7);
            areaCalculavel [8] = new Circulo(8);
            for (int i=0; i < areaCalculavel.Length; i++)
            {
                isQuadrado = (areaCalculavel[i] is Quadrado);
                isCirculo = (areaCalculavel[i] is Circulo);
                isRetangulo = (areaCalculavel[i] is Retangulo);
                if (isQuadrado)
                {
                    Console.Write("A Área do quadrado é: ");
                } else if (isCirculo)
                {
                    Console.Write("A Área do círculo é: ");
                } else if (isRetangulo)
                {
                    Console.Write("A Área do retângulo é: ");
                }
                Console.WriteLine(areaCalculavel[i].calculaArea().ToString("F"));
                
            }
        }
    }
}

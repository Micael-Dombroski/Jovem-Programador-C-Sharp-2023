using System;

namespace exer03
{
    class Program
    {
        static void Main(string[] args)
        {
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
                Console.WriteLine(areaCalculavel[i].calculaArea());
            }
            
        }
    }
}

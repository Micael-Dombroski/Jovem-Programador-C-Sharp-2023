using System;
using System.Collections.Generic;
using exer01.Classes;

namespace exer01.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Verificando o cálculo da área de um retângulo:
            Retangulo retangulo = new Retangulo(4,8);
            double areaRetangulo = 32.00;
            if (retangulo.calculaArea() == areaRetangulo)
            {
                Console.WriteLine("Área Correta");
            }
            else
            {
                Console.WriteLine("Área Incorreta");
            }
            //Verificando o cálculo da área de um quadrado:
            Quadrado quadrado = new Quadrado(2);
            double areaQuadrado = 4.00;
            if (quadrado.calculaArea() == areaQuadrado)
            {
                Console.WriteLine("Área Correta");
            }
            else
            {
                Console.WriteLine("Área Incorreta");
            }
            //Verificando o cálculo da área de um círculo:
            Circulo circulo = new Circulo(3);
            double areaCirculo = 28.26;
            if (circulo.calculaArea() == areaCirculo)
            {
                Console.WriteLine("Área Correta");
            }
            else
            {
                Console.WriteLine("Área Incorreta");
            }
        }
    }
}

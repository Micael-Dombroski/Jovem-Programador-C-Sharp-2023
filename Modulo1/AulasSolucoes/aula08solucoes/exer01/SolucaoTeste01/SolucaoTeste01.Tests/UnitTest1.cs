using NUnit.Framework;
using System;
using SolucaoTeste01.Classes;

namespace SolucaoTeste01.Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void calcular_area_retangulo_base_4_altura_8()
    {
        Retangulo retangulo = new Retangulo(4,8);
        var resultado = retangulo.calculaArea();
        if (resultado == 32)
        {
            Console.WriteLine($"A área do retângulo é {resultado}");
        }
        Assert.AreEqual(resultado, 32);
    }

    [Test]
    public void calcular_area_quadrado_lado_2()
    {
        Quadrado quadrado = new Quadrado(2);
        var resultado = quadrado.calculaArea();
        if (resultado == 4)
        {
            Console.WriteLine($"A área do quadrado é {resultado}");
        }
        Assert.AreEqual(resultado, 4);
    }

    [Test]
    public void calcular_area_circulo_raio_3()
    {
        Circulo circulo = new Circulo(3);
        var resultado = circulo.calculaArea();
        if (resultado == 28.26)
        {
            Console.WriteLine($"A área do círculo é {resultado}");
        }
        Assert.AreEqual(resultado, 28.26);
    }
}
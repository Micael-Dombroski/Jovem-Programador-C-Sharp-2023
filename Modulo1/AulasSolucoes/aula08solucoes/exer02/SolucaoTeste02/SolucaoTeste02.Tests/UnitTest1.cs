using SolucaoTeste02.Classes;
using System;
namespace SolucaoTeste02.Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Somar_5_e_3()
    {
        Calculadora soma = new Soma(5,3);
        var resultado = soma.Operacao();
        if (resultado == 8)
        {
            Console.WriteLine($"O resultado da Operação Executada é: {resultado}");
        }
        Assert.AreEqual(resultado, 8);
    }

    [Test]
    public void Subtrair_8_menos_3()
    {
        Calculadora subtracao = new Subtracao(8,3);
        var resultado = subtracao.Operacao();
        if (resultado == 5)
        {
            Console.WriteLine($"O resultado da Operação Executada é: {resultado}");
        }
        Assert.AreEqual(resultado, 5);
    }

    [Test]
    public void Dividir_5_por_2()
    {
        Calculadora divisao = new Divisao(5,2);
        var resultado = divisao.Operacao();
        if (resultado == 2.5)
        {
            Console.WriteLine($"O resultado da Operação Executada é: {resultado}");
        }
        Assert.AreEqual(resultado, 2.5);
    }

    [Test]
    public void Multiplicar_7_por_4()
    {
        Calculadora multiplicacao = new Multiplicacao(7,4);
        var resultado = multiplicacao.Operacao();
        if (resultado == 28)
        {
            Console.WriteLine($"O resultado da Operação Executada é: {resultado}");
        }
        Assert.AreEqual(resultado, 28);
    }

    [Test]
    public void Potencia_base_2_expoente_6()
    {
        Calculadora potencia = new Potencia(2,6);
        var resultado = potencia.Operacao();
        if (resultado == 64)
        {
            Console.WriteLine($"O resultado da Operação Executada é: {resultado}");
        }
        Assert.AreEqual(resultado, 64);
    }

}
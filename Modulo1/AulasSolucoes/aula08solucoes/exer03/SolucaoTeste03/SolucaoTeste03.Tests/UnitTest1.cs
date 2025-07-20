using SolucaoTeste03.Classes;
using System;
namespace SolucaoTeste03.Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void saldo_500_efetuando_saque_300()
    {
        Cliente cliente = new Cliente("lucas","1","12","rua");
        Conta corrente = new ContaCorrente(01, cliente, 500.00);
        double saque = 300.00;
        Assert.IsTrue(corrente.Sacar(saque) != false);
    }

    [Test]
    public void saldo_800_efetuando_saque_error900()
    {
        Cliente cliente = new Cliente("alexia","5","1","casa");
        Conta poupanca = new ContaPoupanca(01, cliente, 800.00);
        double saque = 900.00;
        Assert.IsTrue(poupanca.Sacar(saque) != false);
    }

    [Test]
    public void saldo_800_efetuando_saque_error0()
    {
        Cliente cliente = new Cliente("alexia","5","1","casa");
        Conta poupanca = new ContaPoupanca(01, cliente, 800.00);
        double saque = 0;
        poupanca.Sacar(saque);
        Assert.IsTrue(0 < saque);
    }

    [Test]
    public void saldo_500_efetuando_saque_error300_negativo()
    {
        Cliente cliente = new Cliente("lucas","1","12","rua");
        Conta investimento = new ContaInvestimento(01, cliente, 500.00);
        double saque = -300.00;
        investimento.Sacar(saque);
        Assert.IsTrue(0 < saque);
    }

    [Test]
    public void saldo_500_efetuando_deposito_1000()
    {
        Cliente cliente = new Cliente("lucas","1","12","rua");
        Conta corrente = new ContaCorrente(01, cliente, 500.00);
        double deposito = 1000.00;
        corrente.Depositar(deposito);
        Assert.IsTrue(corrente.Saldo >= deposito);
    }

    [Test]
    public void saldo_800_efetuando_deposito_error200_negativo()
    {
        Cliente cliente = new Cliente("alexia","5","1","casa");
        Conta poupanca = new ContaPoupanca(01, cliente, 800.00);
        double deposito = -200.00;
        poupanca.Depositar(deposito);
        Assert.IsTrue(0 < deposito);
    }

    [Test]
    public void saldo_500_efetuando_deposito_error0()
    {
        Cliente cliente = new Cliente("lucas","1","12","rua");
        Conta investimento = new ContaInvestimento(01, cliente, 500.00);
        double deposito = 0;
        investimento.Depositar(deposito);
        Assert.IsTrue(0 < deposito);
    }

    [Test]
    public void saldo_500_calculo_Tributo_conta_investimento_51()
    {
        Cliente cliente = new Cliente("lucas","1","12","rua");
        ContaInvestimento investimento = new ContaInvestimento(01, cliente, 500.00);
        double tributo = investimento.CalcularTributo();
        if (tributo == 51.00)
        {
            Console.WriteLine($"Valor Tributo: R$ {tributo}");
        }
        Assert.AreEqual(tributo, 51.00);
    }

    [Test]
    public void saldo_1000_calculo_Tributo_conta_investimento_error200()
    {
        Cliente cliente = new Cliente("ana","23","1","lua");
        ContaInvestimento investimento = new ContaInvestimento(01, cliente, 1000.00);
        double tributo = investimento.CalcularTributo();
        if (tributo == 200.00)
        {
            Console.WriteLine($"Valor Tributo: R$ {tributo}");
        }
        Assert.AreEqual(tributo, 200.00);
    }

    [Test]
    public void saldo_2000_calculo_Tributo_conta_corrente_200()
    {
        Cliente cliente = new Cliente("lucas","1","12","rua");
        ContaCorrente corrente = new ContaCorrente(01, cliente, 2000.00);
        double tributo = corrente.CalcularTributo();
        if (tributo == 200.00)
        {
            Console.WriteLine($"Valor Tributo: R$ {tributo}");
        }
        Assert.AreEqual(tributo, 200.00);
    }

    [Test]
    public void saldo_100_calculo_Tributo_conta_corrente_error15()
    {
        Cliente cliente = new Cliente("lucas","1","12","rua");
        ContaCorrente corrente = new ContaCorrente(01, cliente, 100.00);
        double tributo = corrente.CalcularTributo();
        if (tributo == 15.00)
        {
            Console.WriteLine($"Valor Tributo: R$ {tributo}");
        }
        Assert.AreEqual(tributo, 15.00);
    }

    [Test]
    public void saldo_1000_calculo_Rendimento_conta_investimento_20()
    {
        Cliente cliente = new Cliente("lucas","1","12","rua");
        ContaInvestimento investimento = new ContaInvestimento(01, cliente, 1000.00);
        double rendimento = investimento.CalcularRendimento();
        if (rendimento == 20.00)
        {
            Console.WriteLine($"Valor Rendimento: R$ {rendimento}");
        }
        Assert.AreEqual(rendimento, 20.00);
    }

    [Test]
    public void saldo_3000_calculo_Rendimento_conta_investimento_error205()
    {
        Cliente cliente = new Cliente("lucas","1","12","rua");
        ContaInvestimento investimento = new ContaInvestimento(01, cliente, 3000.00);
        double rendimento = investimento.CalcularRendimento();
        if (rendimento == 205.00)
        {
            Console.WriteLine($"Valor Rendimento: R$ {rendimento}");
        }
        Assert.AreEqual(rendimento, 205.00);
    }

    [Test]
    public void saldo_4000_calculo_Rendimento_conta_poupanca_20()
    {
        Cliente cliente = new Cliente("lucas","1","12","rua");
        ContaPoupanca poupanca = new ContaPoupanca(01, cliente, 4000.00);
        double rendimento = poupanca.CalcularRendimento();
        if (rendimento == 20.00)
        {
            Console.WriteLine($"Valor Rendimento: R$ {rendimento}");
        }
        Assert.AreEqual(rendimento, 20.00);
    }

    [Test]
    public void saldo_15000_calculo_Rendimento_conta_poupanca_error300()
    {
        Cliente cliente = new Cliente("lucas","1","12","rua");
        ContaPoupanca poupanca = new ContaPoupanca(01, cliente, 15000.00);
        double rendimento = poupanca.CalcularRendimento();
        if (rendimento == 300.00)
        {
            Console.WriteLine($"Valor Rendimento: R$ {rendimento}");
        }
        Assert.AreEqual(rendimento, 300.00);
    }
}
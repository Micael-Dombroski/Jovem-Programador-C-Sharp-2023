using System;

namespace aula06
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente c01 = new ContaCorrente();
            c01.Numero = 123456;
            Cliente cli01 = new Cliente("000.000.000-00", "Claire");
            c01.Titular = cli01;
            c01.Depositar(1000);
            ContaPoupanca c02 = new ContaPoupanca();
            c02.Numero = 987458;
            Cliente cli02 = new Cliente("111.111.111-11", "Jill");
            c02.Titular = cli02;
            c02.Depositar(956.50);
            ContaInvestimento c03 = new ContaInvestimento();
            c03.Numero = 234458;
            Cliente cli03 = new Cliente("123.123.123-12", "Carlos");
            c03.Titular = cli03;
            c03.Depositar(7777.77);
            var saqueEfetuado = c01.Sacar(10.50);
            var saqueEfetuado2 = c02.Sacar(59.99);
            var saqueEfetuado3 = c03.Sacar(7000);
            if (saqueEfetuado == true)
            {
                Console.WriteLine("Saque realizado com Sucesso!");
            }
            else
            {
                Console.WriteLine("[3RR0R] Não foi possível efetuar o Saque!");
            }
            if (saqueEfetuado2 == true)
            {
                Console.WriteLine("Saque realizado com Sucesso!");
            }
            else
            {
                Console.WriteLine("[3RR0R] Não foi possível efetuar o Saque!");
            }
            if (saqueEfetuado3 == true)
            {
                Console.WriteLine("Saque realizado com Sucesso!");
            }
            else
            {
                Console.WriteLine("[3RR0R] Não foi possível efetuar o Saque!");
            }
            TotalizadorContas t01 = new TotalizadorContas();
            TotalizadorRendimento t02 = new TotalizadorRendimento();
            TotalizadorDeTributos t03 = new TotalizadorDeTributos();
            t03.SomarTributo(c02);
            t03.SomarTributo(c03);
            t02.SomarRendimento(c02);
            t02.SomarRendimento(c03);
            t01.SomarSaldo(c02);
            t01.SomarSaldo(c01);
            t01.SomarSaldo(c03);
            Console.WriteLine($"Número: {c01.Numero} - CPF: {c01.Titular.Cpf} - Titular: {c01.Titular.Nome} - Saldo Atual: R$ {c01.Saldo.ToString("F")}");
            Console.WriteLine($"Número: {c02.Numero} - CPF: {c02.Titular.Cpf} - Titular: {c02.Titular.Nome} - Saldo Atual: R$ {c02.Saldo.ToString("F")} - Rendimento: {c02.RendimentoTotal().ToString("F")} - Tributo: R$ {c02.CalcularTributo().ToString("F")}");
            Console.WriteLine($"Número: {c03.Numero} - CPF: {c03.Titular.Cpf} - Titular: {c03.Titular.Nome} - Saldo Atual: R$ {c03.Saldo.ToString("F")} - Rendimento: {c03.RendimentoTotal().ToString("F")} - Tributo: R$ {c03.CalcularTributo().ToString("F")}");
            Console.WriteLine($"Saldo Total do Banco: R$ {t01.Total.ToString("F")}");
            Console.WriteLine($"Rendimento Total do Banco: R$ {t02.TotalRendimento.ToString("F")}");
            Console.WriteLine($"Tributo Total do Banco: R$ {t03.Total.ToString("F")}");
        }
    }
}

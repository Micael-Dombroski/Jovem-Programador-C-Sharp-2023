using System;
using System.Collections.Generic;
using System.Linq;

namespace aula10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Conta> contas = new List<Conta>();
            Conta conta01 = new ContaCorrente(1,1);
            Cliente cliente01 = new Cliente("000.000.000-00", "Jorge");
            conta01.Titular=cliente01;
            Conta conta02 = new ContaInvestimento(1,2);
            Cliente cliente02 = new Cliente("000.000.000-01", "Matheus");
            conta02.Titular=cliente02;
            Conta conta03 = new ContaCorrente(1,3);
            Cliente cliente03 = new Cliente("000.000.000-02", "Clare");
            conta03.Titular=cliente03;
            Conta conta04 = new ContaPoupanca(1,4);
            Cliente cliente04 = new Cliente("000.000.000-03", "Goku");
            conta04.Titular=cliente04;
            conta01.Depositar(2000);
            conta02.Depositar(1000);
            conta03.Depositar(1999);
            conta04.Depositar(3000);
            contas.Add(conta01);
            contas.Add(conta02);
            contas.Add(conta03);
            contas.Add(conta04);
            //Language Integrade Query
            //var filtradas = contas.Where((Conta c) => {return c.Saldo > 1999;});
            //var filtradas = contas.Where(c => {return c.Saldo > 1999;});
            var filtradas = contas.Where(c => c.Saldo > 1999);
            foreach (var item in filtradas)
            {
                Console.WriteLine($"{item} - {item.Titular}");
            }
            var saldoTotal = contas.Sum(c => c.Saldo);
            Console.WriteLine($"Saldo Total: R$ {saldoTotal.ToString("F")}");
            var saldoMedia = contas.Average(c => c.Saldo);
            Console.WriteLine($"Média de Saldo: R$ {saldoMedia.ToString("F")}");

            var filtrar = from c in contas
                        where c.Saldo > 0
                        orderby c.Saldo
                        select new {c.Numero, c.Titular.Nome, c.Saldo};
            foreach (var item in filtrar)
            {
                Console.WriteLine(item);
            }
        }
    }
}

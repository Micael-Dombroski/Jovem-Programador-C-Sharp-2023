using System;

namespace aula05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            /*O comando \t cria a distância q a tecla tab faz, 
            logo todos os itens terão a mesma distância entre si*/
            Conta c01 = new Conta();
            c01.numero = 123456;
            c01.titular.Nome = "Sakura";
            c01.titular.CPF = "1123";
            c01.titular.Endereço = "rua";
            c01.titular.Telefone = 1234;
            c01.saldo = 5.99;
            Conta c02 = new Conta();
            c02.numero = 123457;
            c02.titular.Nome = "Hinata";
            c02.titular.CPF = "8171";
            c02.titular.Endereço = "lua";
            c02.titular.Telefone = 4534;
            c02.saldo = 2.99;
            
            Console.WriteLine($"{c01.numero} - {c01.titular.Nome} - {c01.saldo.ToString("F")}");
            Console.WriteLine($"{c02.numero} - {c02.titular.Nome} - {c02.saldo.ToString("F")}");
            c02.Depositar(50.00);
            c01.Sacar(4.80);
            Console.WriteLine($"{c01.numero} - {c01.titular.Nome} - {c01.saldo.ToString("F")}");
            Console.WriteLine($"{c02.numero} - {c02.titular.Nome} - {c02.saldo.ToString("F")}");
            
        }
    }
}

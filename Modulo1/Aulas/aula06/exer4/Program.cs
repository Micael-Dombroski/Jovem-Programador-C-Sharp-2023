using System;

namespace exer4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha entre as 10 opções:");
            Console.WriteLine("");
            Console.Write("[01]");
            Console.Write("[02]");
            Console.Write("[03]");
            Console.WriteLine("");
            Console.Write("[04]");
            Console.Write("[05]");
            Console.Write("[06]");
            Console.WriteLine("");
            Console.Write("[07]");
            Console.Write("[08]");
            Console.Write("[09]");
            Console.WriteLine("");
            Console.Write("    ");
            Console.Write("[10]");
            Console.Write("    ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Insira a opção escolhida: ");
            var ler = Console.ReadLine();
            int X = Convert.ToInt32(ler);
            if (X > 0 && X <= 10)
            {
                if (X == 1) {
                    Console.WriteLine("A Opção selecionada foi a Opção número 1.");
                } else if (X == 2) {
                    Console.WriteLine("A Opção selecionada foi a Opção número 2.");
                } else if (X == 3) {
                    Console.WriteLine("A Opção selecionada foi a Opção número 3.");
                } else if (X == 4) {
                    Console.WriteLine("A Opção selecionada foi a Opção número 4.");
                } else if (X == 5) {
                    Console.WriteLine("A Opção selecionada foi a Opção número 5.");
                } else if (X == 6) {
                    Console.WriteLine("A Opção selecionada foi a Opção número 6.");
                } else if (X == 7) {
                    Console.WriteLine("A Opção selecionada foi a Opção número 7.");
                } else if (X == 8) {
                    Console.WriteLine("A Opção selecionada foi a Opção número 8.");
                } else if (X == 9) {
                    Console.WriteLine("A Opção selecionada foi a Opção número 9.");
                } else {
                    Console.WriteLine("A Opção selecionada foi a Opção número 10.");
                }
            } else {
                Console.WriteLine("3RR0R: valor inserido não está presente nas opções fornecidas...");
            }
        }
    }
}

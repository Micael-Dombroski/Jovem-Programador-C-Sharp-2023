using System;

namespace exer5
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
            while (X < 1 || X > 10)
            {
                Console.WriteLine("3RR0R: valor inserido não está presente nas opções fornecidas...");
                Console.WriteLine("Insira uma das opções disponíveis: ");
                ler = Console.ReadLine();
                X = Convert.ToInt32(ler);
            }
                switch (X)
                {
                    case 1:
                        Console.WriteLine("A Opção selecionada foi a Opção número 1.");
                    break;
                    case 2:
                        Console.WriteLine("A Opção selecionada foi a Opção número 2.");
                    break;
                    case 3:
                        Console.WriteLine("A Opção selecionada foi a Opção número 3.");
                    break;
                    case 4:
                        Console.WriteLine("A Opção selecionada foi a Opção número 4.");
                    break;
                    case 5:
                        Console.WriteLine("A Opção selecionada foi a Opção número 5.");
                    break;
                    case 6:
                        Console.WriteLine("A Opção selecionada foi a Opção número 6.");
                    break;
                    case 7:
                        Console.WriteLine("A Opção selecionada foi a Opção número 7.");
                    break;
                    case 8:
                        Console.WriteLine("A Opção selecionada foi a Opção número 8.");
                    break;
                    case 9:
                        Console.WriteLine("A Opção selecionada foi a Opção número 9.");
                    break;
                    default:
                        Console.WriteLine("A Opção selecionada foi a Opção número 10.");
                    break;
                }
        }
    }
}

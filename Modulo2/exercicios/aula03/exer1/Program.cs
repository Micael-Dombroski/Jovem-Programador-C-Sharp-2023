using System;

namespace exer1
{
    class Program
    {
        static void Main(string[] args)
        {
            string opt = "";
            string operacao = "";
            double n1;
            double n2;
            double resultado;
            string ler;
            do
            {
                Console.WriteLine("-----Calculadora-----");
                Console.WriteLine("[1] Soma");
                Console.WriteLine("[2] Subtração");
                Console.WriteLine("[3] Multiplicação");
                Console.WriteLine("[4] Divisão");
                Console.WriteLine("[5] Resto da Divisão");
                Console.WriteLine("[6] X²");
                Console.WriteLine("[7] X³");
                Console.WriteLine("[8] Sair");
                Console.WriteLine("---------------------");
                Console.Write("Informe o número da operação que deseja efetuar: ");
                opt = Console.ReadLine();
                Console.Clear();
                switch (opt)
                {
                    case "1":
                        operacao = "Soma";
                        Console.Write("Informe o Primeiro Número usado na operação: ");
                        ler = Console.ReadLine();
                        n1 = int.Parse(ler);
                        Console.Write("Informe o Segundo Número usado na operação: ");
                        ler = Console.ReadLine();
                        n2 = int.Parse(ler);
                        resultado = n1 + n2;
                        Console.WriteLine($"O Resultado da Operação {operacao} entre {n1} e {n2} é {resultado}");
                        break;
                    case "2":
                        operacao = "Subtração";
                        Console.Write("Informe o Primeiro Número usado na operação: ");
                        ler = Console.ReadLine();
                        n1 = int.Parse(ler);
                        Console.Write("Informe o Segundo Número usado na operação: ");
                        ler = Console.ReadLine();
                        n2 = int.Parse(ler);
                        resultado = n1 - n2;
                        Console.WriteLine($"O Resultado da Operação {operacao} entre {n1} e {n2} é {resultado}");
                        break;
                    case "3":
                        operacao = "Multiplicação";
                        Console.Write("Informe o Primeiro Número usado na operação: ");
                        ler = Console.ReadLine();
                        n1 = int.Parse(ler);
                        Console.Write("Informe o Segundo Número usado na operação: ");
                        ler = Console.ReadLine();
                        n2 = int.Parse(ler);
                        resultado = n1 * n2;
                        Console.WriteLine($"O Resultado da Operação {operacao} entre {n1} e {n2} é {resultado}");
                        break;
                    case "4":
                        operacao = "Divisão";
                        Console.Write("Informe o Primeiro Número usado na operação: ");
                        ler = Console.ReadLine();
                        n1 = int.Parse(ler);
                        Console.Write("Informe o Segundo Número usado na operação: ");
                        ler = Console.ReadLine();
                        n2 = int.Parse(ler);
                        resultado = n1 / n2;
                        Console.WriteLine($"O Resultado da Operação {operacao} entre {n1} e {n2} é {resultado}");
                        break;
                    case "5":
                        operacao = "Resto da Divisão";
                        Console.Write("Informe o Primeiro Número usado na operação: ");
                        ler = Console.ReadLine();
                        n1 = int.Parse(ler);
                        Console.Write("Informe o Segundo Número usado na operação: ");
                        ler = Console.ReadLine();
                        n2 = int.Parse(ler);
                        resultado = n1 % n2;
                        Console.WriteLine($"O Resultado da Operação {operacao} entre {n1} e {n2} é {resultado}");
                        break;
                    case "6":
                        operacao = "X²";
                        Console.Write("Informe o Número usado na operação: ");
                        ler = Console.ReadLine();
                        n1 = int.Parse(ler);
                        resultado = Math.Pow(n1,2);
                        Console.WriteLine($"O Resultado da Operação {operacao} com o valor {n1} é {resultado}");
                        break;
                    case "7":
                        operacao = "X³";
                        Console.Write("Informe o Número usado na operação: ");
                        ler = Console.ReadLine();
                        n1 = int.Parse(ler);
                        resultado = Math.Pow(n1,3);
                        Console.WriteLine($"O Resultado da Operação {operacao} com o valor {n1} é {resultado}");
                        break;
                    case "8":
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opção Inválida");
                        break;
                }
                if (opt != "8")
                {
                    Console.WriteLine("Pressione Qualquer tecla para voltar ao Menu: ");
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (opt != "8");
        }
    }
}

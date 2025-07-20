using System;

namespace exer03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual operação você deseja fazer: ");
            Console.WriteLine("1-Soma");
            Console.WriteLine("2-Subtração");
            Console.WriteLine("3-Divisão");
            Console.WriteLine("4-Multiplicação");
            Console.WriteLine("5-Potência Base 2");
            Console.WriteLine("6-Potência");
            Console.Write("Informe o número da opção desejada: ");
            string ler = Console.ReadLine();
            int opt = Convert.ToInt32(ler);
            double n1 = 0.0;
            double n2 = 0.0;
            switch (opt)
            {
                case 1:
                    Console.WriteLine("Você escolheu a operação de Soma!");
                    Console.Write("Informe o primeiro número: ");
                    ler = Console.ReadLine();
                    n1 = Convert.ToDouble(ler);
                    Console.Write("Informe o segundo número: ");
                    ler = Console.ReadLine();
                    n2 = Convert.ToDouble(ler);
                    Calculadora soma = new Soma(n1,n2);
                    Console.WriteLine($"Resultado: {soma.Operacao()}");
                break;
                case 2:
                    Console.WriteLine("Você escolheu a operação de Subtração!");
                    Console.Write("Informe o primeiro número: ");
                    ler = Console.ReadLine();
                    n1 = Convert.ToDouble(ler);
                    Console.Write("Informe o segundo número: ");
                    ler = Console.ReadLine();
                    n2 = Convert.ToDouble(ler);
                    Calculadora subtracao = new Subtracao(n1,n2);
                    Console.WriteLine($"Resultado: {subtracao.Operacao()}");
                break;
                case 3:
                    Console.WriteLine("Você escolheu a operação de Divisão!");
                    Console.Write("Informe um número: ");
                    ler = Console.ReadLine();
                    n1 = Convert.ToDouble(ler);
                    Console.Write("Informe o segundo número: ");
                    ler = Console.ReadLine();
                    n2 = Convert.ToDouble(ler);
                    Calculadora divisao = new Divisao(n1,n2);
                    Console.WriteLine($"Resultado: {divisao.Operacao()}");
                break;
                case 4:
                    Console.WriteLine("Você escolheu a operação de Multiplicação!");
                    Console.Write("Informe o primeiro número: ");
                    ler = Console.ReadLine();
                    n1 = Convert.ToDouble(ler);
                    Console.Write("Informe o segundo número: ");
                    ler = Console.ReadLine();
                    n2 = Convert.ToDouble(ler);
                    Calculadora multiplicacao = new Multiplicacao(n1,n2);
                    Console.WriteLine($"Resultado: {multiplicacao.Operacao()}");
                break;
                case 5:
                    Console.WriteLine("Você escolheu a operação de Potência Base 2!");
                    Console.Write("Informe o número da potência: ");
                    ler = Console.ReadLine();
                    n2 = Convert.ToDouble(ler);
                    Calculadora potenciaB2 = new PotenciaBase2(n1,n2);
                    Console.WriteLine($"Resultado: {potenciaB2.Operacao()}");
                break;
                case 6:
                    Console.WriteLine("Você escolheu a operação de Potência!");
                    Console.Write("Informe o número da base: ");
                    ler = Console.ReadLine();
                    n1 = Convert.ToDouble(ler);
                    Console.Write("Informe o número da potência: ");
                    ler = Console.ReadLine();
                    n2 = Convert.ToDouble(ler);
                    Calculadora potencia = new PotenciaBaseQualquer(n1,n2);
                    Console.WriteLine($"Resultado: {potencia.Operacao()}");
                break;
                default:
                    Console.WriteLine("A Opção informada não está disponível...");
                break;
            }
        }
    }
}

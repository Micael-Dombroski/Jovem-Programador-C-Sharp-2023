using System;
using exer01.Classes;

namespace exer01.ConsoleApp
{
    class Program
    {
        static string ler;
        static void Main(string[] args)
        {
            int opt=0;
            do
            {
                 do
                {
                    Console.WriteLine("Você quer calcular:");
                    Console.WriteLine("[1] A área de um Círculo");
                    Console.WriteLine("[2] A área de um Quadrado");
                    Console.WriteLine("[3] A área de um Retângulo");
                    Console.WriteLine("[4] Sair");
                    Console.Write("=> ");
                    ler = Console.ReadLine();
                } while (ENumero(ler) == false);
                opt = Convert.ToInt32(ler);
                switch (opt)
                {
                    case 1:
                        Console.WriteLine("Você escolheu a  opção 1, Calcular a área de  um Círculo");
                        do
                        {
                            Console.Write("Informe o Raio do Círculo: ");
                            ler = Console.ReadLine();
                        } while (EDOUBLE(ler) == false);
                        double raio = Convert.ToDouble(ler);
                        Circulo circulo = new Circulo(raio);
                        Console.WriteLine($"Um círculo com raio de {circulo.Raio} possui a área de {circulo.calculaArea()}");
                        break;
                    case 2:
                        Console.WriteLine("Você escolheu a  opção 2, Calcular a área de  um Quadrado");
                        do
                        {
                            Console.Write("Informe a medida de um dos lados do Quadrado: ");
                            ler = Console.ReadLine();
                        } while (EDOUBLE(ler) == false);
                        double lado = Convert.ToDouble(ler);
                        Quadrado quadrado = new Quadrado(lado);
                        Console.WriteLine($"Um círculo com um lado de comprimento igual a {quadrado.Lado} possui a área de {quadrado.calculaArea()}");
                        break;
                    case 3:
                        Console.WriteLine("Você escolheu a  opção 3, Calcular a área de um Retângulo");
                        do
                        {
                            Console.Write("Informe a medida da base do Retângulo: ");
                            ler = Console.ReadLine();
                        } while (EDOUBLE(ler) == false);
                        double baase = Convert.ToDouble(ler);
                        do
                        {
                            Console.Write("Informe a medida da altura do Retângulo: ");
                            ler = Console.ReadLine();
                        } while (EDOUBLE(ler) == false);
                        double altura = Convert.ToDouble(ler);
                        Retangulo retangulo = new Retangulo(baase, altura);
                        Console.WriteLine($"Um retângulo com base igual a {retangulo.Base} e altura igual a {retangulo.Altura} possui a área de {retangulo.calculaArea()}");
                        break;
                    case 4:
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("[3RR0R] Opção Inválida");
                        break;
                }
            } while (opt != 4);
               
            
        }
                static bool ENumero (string palavra)
        {
            for (int i = 0; i < palavra.Length; i++)
            {
                if (palavra[i] > 57 || palavra[i] < 48)
                {
                    Console.WriteLine("Use apenas números nesse campo");
                    return false;
                }
            }
            return true;
        }
        static bool EDOUBLE (string palavra)
        {
            int contarVirgula = 0;
            for (int i = 0; i < palavra.Length; i++)
            {
                if ((palavra[i] > 57 || palavra[i] < 48) && palavra[i] != 44)
                {
                    Console.WriteLine("Use apenas números nesse campo");
                    return false;
                } else if (palavra[i] == 44)
                {
                    contarVirgula++;
                    if (contarVirgula > 1)
                    {
                        Console.WriteLine("Não use mais de uma vírgula para esse valor");
                        return false;
                    } else if (i+2 != palavra.Length-1)
                    {
                        Console.WriteLine("O número só pode ter 2 casas decimais após a vírgula");
                        return false;
                    }
                }
            }
            return true;
        }
    }
}

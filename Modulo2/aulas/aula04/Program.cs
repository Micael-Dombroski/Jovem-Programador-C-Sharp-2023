using System;

namespace aula04
{
    class Program
    {
        static void Main(string[] args)
        {
            /*for (int ano = 2000; ano < 2024; ano++)
            {
                for (int mes = 1; mes < 13; mes++)
                {
                    for (int dia = 1; dia < 31; dia++)
                    {
                        Console.WriteLine($"{dia}/{mes}/{ano}");
                    }
                }
            }*/
            int[,] inteiro = new int [2,2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write($"Digite um valor para armazenar na posição [{i},{j}]: ");
                    inteiro[i,j] = int.Parse(Console.ReadLine());
                    Console.Clear();
                }
            }
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine($"inteiro[{i},{j}]: {inteiro[i,j]}");
                }
            }
        }
    }
}

using System;

namespace exer09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe a quantidade de alunos: ");
            int qtAlunos = int.Parse(Console.ReadLine());
            Console.Write("Informe a quantidade de aulas: ");
            int aulas = int.Parse(Console.ReadLine());
            string [,] boletim = new string [7,qtAlunos];
            for (int i = 0; i < qtAlunos; i++)
            {
                double n1,n2,n3;
                Console.Write("Informe o Nome do Aluno: ");
                boletim[0,i] = Console.ReadLine();
                do
                {
                    Console.Write("Informe a Primeira Nota do Aluno: ");
                    n1 = double.Parse(Console.ReadLine());
                    if (n1 < 0  || n1 > 10)
                    {
                        Console.WriteLine("[3RR0R] A Nota não pode ser inferior a 0 ou superior a 10");
                    }
                } while (n1 < 0  || n1 > 10);
                boletim[1,i] = $"{n1.ToString("F")}";
                do
                {
                    Console.Write("Informe a Segunda Nota do Aluno: ");
                    n2 = double.Parse(Console.ReadLine());
                    if (n2 < 0  || n2 > 10)
                    {
                        Console.WriteLine("[3RR0R] A Nota não pode ser inferior a 0 ou superior a 10");
                    }
                } while (n2 < 0  || n2 > 10);
                boletim[2,i] = $"{n2.ToString("F")}";
                do
                {
                    Console.Write("Informe a Terceira Nota do Aluno: ");
                    n3 = double.Parse(Console.ReadLine());
                    if (n3 < 0  || n3 > 10)
                    {
                        Console.WriteLine("[3RR0R] A Nota não pode ser inferior a 0 ou superior a 10");
                    }
                } while (n3 < 0  || n3 > 10);
                boletim[3,i] = $"{n3.ToString("F")}";
                do
                {
                    Console.Write("Informe a Quantidade de Faltas do Aluno: ");
                    boletim[4,i] = $"{int.Parse(Console.ReadLine())}";
                    if (int.Parse(boletim[4,i]) > aulas)
                    {
                        Console.WriteLine("[3RR0R] A quantidade de faltas não pode ser maior que a quantidade de aulas");
                    }
                } while (int.Parse(boletim[4,i]) > aulas);
                double media = (n1 + n2 + n3)/3;
                boletim[5,i] = $"{media.ToString("F")}";
                if (media >= 7 && int.Parse(boletim[4,i]) <= (aulas/4))
                {
                    boletim[6,i] = "Aprovado";
                } else if (media >= 5 && int.Parse(boletim[4,i]) <= (aulas/4))
                {
                    boletim[6,i] = "Recuperação";
                }
                else
                {
                    boletim[6,i] = "Reprovado";
                }
            }
            Console.WriteLine("Aluno   Nota 1   Nota 2   Nota 3   Faltas   Média   Situação");
            for (int i = 0; i < qtAlunos; i++)
            {
                Console.WriteLine($"{boletim[0,i]}       {boletim[1,i]}    {boletim[2,i]}    {boletim[3,i]}    {boletim[4,i]}    {boletim[5,i]}     {boletim[6,i]}");
            }
        }
    }
}

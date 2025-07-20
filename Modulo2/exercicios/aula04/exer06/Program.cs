using System;

namespace exer06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe a quantidade de alunos: ");
            int qtAlunos = int.Parse(Console.ReadLine());
            Console.Write("Informe a quantidade de aulas: ");
            int aulas = int.Parse(Console.ReadLine());
            string [] alunos = new string [qtAlunos];
            double [] n1 = new double [qtAlunos];
            double [] n2 = new double [qtAlunos];
            double [] n3 = new double [qtAlunos];
            int [] faltas = new int [qtAlunos];
            double [] media = new double [qtAlunos];
            string [] situacao = new string [qtAlunos];
            for (int i = 0; i < qtAlunos; i++)
            {
                Console.Write("Informe o Nome do Aluno: ");
                alunos[i] = Console.ReadLine();
                do
                {
                    Console.Write("Informe a Primeira Nota do Aluno: ");
                    n1[i] = double.Parse(Console.ReadLine());
                    if (n1[i] < 0  || n1[i] > 10)
                    {
                        Console.WriteLine("[3RR0R] A Nota não pode ser inferior a 0 ou superior a 10");
                    }
                } while (n1[i] < 0  || n1[i] > 10);
                do
                {
                    Console.Write("Informe a Segunda Nota do Aluno: ");
                    n2[i] = double.Parse(Console.ReadLine());
                    if (n2[i] < 0  || n2[i] > 10)
                    {
                        Console.WriteLine("[3RR0R] A Nota não pode ser inferior a 0 ou superior a 10");
                    }
                } while (n2[i] < 0  || n2[i] > 10);
                do
                {
                    Console.Write("Informe a Terceira Nota do Aluno: ");
                    n3[i] = double.Parse(Console.ReadLine());
                    if (n3[i] < 0  || n3[i] > 10)
                    {
                        Console.WriteLine("[3RR0R] A Nota não pode ser inferior a 0 ou superior a 10");
                    }
                } while (n3[i] < 0  || n3[i] > 10);
                do
                {
                    Console.Write("Informe a Quantidade de Faltas do Aluno: ");
                    faltas[i] = int.Parse(Console.ReadLine());
                    if (faltas[i] > aulas)
                    {
                        Console.WriteLine("[3RR0R] A quantidade de faltas não pode ser maior que a quantidade de aulas");
                    }
                } while (faltas[i] > aulas);
                media[i] = (n1[i] + n2[i] + n3[i])/3;
                if (media[i] >= 7 && faltas[i] <= (aulas/4))
                {
                    situacao[i] = "Aprovado";
                } else if (media[i] >= 5 && faltas[i] <= (aulas/4))
                {
                    situacao[i] = "Recuperação";
                }
                else
                {
                    situacao[i] = "Reprovado";
                }
            }
            Console.WriteLine("Aluno   Nota 1   Nota 2   Nota 3   Faltas   Média   Situação");
            for (int i = 0; i < qtAlunos; i++)
            {
                Console.WriteLine($"{alunos[i]}       {n1[i]}    {n2[i]}    {n3[i]}    {faltas[i]}    {media[i].ToString("F")}     {situacao[i]}");
            }
        }
    }
}

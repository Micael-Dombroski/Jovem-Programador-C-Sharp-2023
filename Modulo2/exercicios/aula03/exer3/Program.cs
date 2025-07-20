using System;

namespace exer3
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1;
            double n2;
            double n3;
            double n4;
            do
            {
                Console.Clear();
                Console.Write("Informe a Primeira Nota: ");
                n1 = double.Parse(Console.ReadLine());
            } while (n1 > 10 || n1 < 0);
            do
            {
                Console.Clear();
                Console.Write("Informe a Segunda Nota: ");
                n2 = double.Parse(Console.ReadLine());
            } while (n2 > 10 || n2 < 0);
            do
            {
                Console.Clear();
                Console.Write("Informe a Terceira Nota: ");
                n3 = double.Parse(Console.ReadLine());
            } while (n3 > 10 || n3 < 0);
            do
            {
                Console.Clear();
                Console.Write("Informe a Quarta Nota: ");
                n4 = double.Parse(Console.ReadLine());
            } while (n4 > 10 || n4 < 0);
            double media = (n1+n2+n3+n4)/4;
            string resultado;
            if (media >= 7)
            {
                resultado = "Aprovado";
            } else if (media >= 5)
            {
                resultado = "Em Recuperação";
            } else
            {
                resultado = "Reprovado";
            }
            Console.Clear();
            Console.WriteLine($"Média: {media.ToString("F")}, Situação do Aluno: {resultado}");
        }
    }
}

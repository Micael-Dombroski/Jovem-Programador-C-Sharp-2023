using System;

namespace exer01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculador de média escolar...");
            Console.Write("Quantas notas serão usadas para calcular a média? ");
            var ler = Console.ReadLine();
            int qt = Convert.ToInt32(ler);
            int [] notas = new int[qt];
            for (var c = 0; c < qt; c++)
            {
                Console.Write("Informe  o valor da nota " + (c+1) + ": ");
                ler = Console.ReadLine();
                notas [c] = Convert.ToInt32(ler);
                Console.WriteLine("");
            }
            int soma = 0;
            for (var c = 0; c < qt; c++)
            {
                soma += notas[c];
            }
            double  s = Convert.ToDouble(soma);
            double quant = Convert.ToDouble(qt);
            double media = s/quant;
            Console.WriteLine("A média do aluno é: " + media);
            if (media >= 7.0)
            {
                Console.WriteLine("Aluno aprovado!");
            } else if (media >= 5)
            {
                Console.WriteLine("O aluno está em recuperação!");
            } else 
            {
                Console.WriteLine("Aluno reprovado!");
            }
        }
    }
}

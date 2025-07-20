using System;

namespace exer01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o tamanho do vetor: ");
            int index = int.Parse(Console.ReadLine());
            int [] vetor= new int[index];
            for (int i = 0; i < index; i++)
            {
                Console.Write("Informe um número: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }
            int [] max = new int[2];
            int [] min = new int[2];
            max[0] = vetor[0];
            max[1] = 0;
            min[0] = vetor[0];
            min[1] = 0;
            for (int i = 0; i < index; i++)
            {
                if (vetor[i] > max[0])
                {
                    max[0] = vetor[i];
                    max[1] = i;
                }
                if (vetor[i] < min[0])
                {
                    min[0] = vetor[i];
                    min[1] = i;
                }
            }
            Console.Clear();
            Console.WriteLine($"O maior valor informado é {max[0]} na posição {max[1]} do vetor");
            Console.WriteLine($"O menor valor informado é {min[0]} na posição {min[1]} do vetor");
        }
    }
}

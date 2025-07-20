using System;

namespace exer02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o tamanho do vetor: ");
            int index = int.Parse(Console.ReadLine());
            int [] vetor= new int[index];
            int qtpares=0;
            int qtimpares=0;
            for (int i = 0; i < index; i++)
            {
                Console.Write("Informe um número: ");
                vetor[i] = int.Parse(Console.ReadLine());
                if (vetor[i]%2 == 0)
                {
                    qtpares++;
                }
                else
                {
                    qtimpares++;
                }
            }
            int [] pares = new int[qtpares];
            int [] impares = new int[qtimpares];
            int pospares=0;
            int posimpares=0;
            for (int i = 0; i < index; i++)
            {
                if (vetor[i]%2 ==0)
                {
                    pares[pospares] = vetor[i];
                    pospares++;
                }
                else
                {
                    impares[posimpares] = vetor[i];
                    posimpares++;
                }
            }
            Console.Clear();
            Console.WriteLine($"A quantidade de números pares inseridos foi {qtpares} e serão exibidos abaixo: ");
            for (int i = 0; i < qtpares; i++)
            {
                Console.WriteLine(pares[i]);
            }
            Console.WriteLine($"A quantidade de números ímpares inseridos foi {qtimpares} e serão exibidos abaixo: ");
            for (int i = 0; i < qtimpares; i++)
            {
                Console.WriteLine(impares[i]);
            }
        }
    }
}

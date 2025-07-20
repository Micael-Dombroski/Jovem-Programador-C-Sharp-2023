using System;

namespace exer04
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
            int [] ordenado = new int[index];
            for (int i = 0; i < index; i++)
            {
                ordenado[i] = vetor[i];
            }
            Array.Sort(ordenado);
            Console.WriteLine("Vetor Digitado: ");
            for (int i = 0; i < index; i++)
            {
                Console.WriteLine(vetor[i]);
            }
            Console.WriteLine("Vetor Organizado em Forma Crescente: ");
            for (int i = 0; i < index; i++)
            {
                Console.WriteLine(ordenado[i]);
            }
        }
    }
}

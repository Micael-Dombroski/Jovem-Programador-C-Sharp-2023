using System;

namespace exer03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe um número: ");
            int num = int.Parse(Console.ReadLine());
            int [] tabuada = new int[10]{num*1,num*2,num*3,num*4,num*5,num*6,num*7,num*8,num*9,num*10};
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine($"{num} x {i} = {tabuada[i]}");
                Console.ReadKey();
            }
        }
    }
}

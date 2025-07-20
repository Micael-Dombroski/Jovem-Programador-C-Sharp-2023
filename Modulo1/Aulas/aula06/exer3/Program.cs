using System;

namespace exer3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira um valor para A: ");
            var  A  = Console.ReadLine();
            Console.WriteLine("Insira outro valor para B: ");
            var B = Console.ReadLine();
            Console.WriteLine("Você escolhes os valores: " + A + " e " + B);
            Console.WriteLine("Passando o valor de A para B e de B para A...");
            var x = A;
            A = B;
            B = x;
            Console.WriteLine("Os valores foram trocado");
            Console.WriteLine("Agora o valor de A é: " + A + " e o valor de B é: " + B);
        }
    }
}

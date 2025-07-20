using System;

namespace exer04
{
    class Program
    {
        static void Main(string[] args)
        {
            const double n1 = 7.5;
            const double n2 = 9.0;
            const double n3 = 5.0;
            const double n4 = 8.5;
            Console.WriteLine("Suas notas foram: " + n1 + ", " + n2 + ", " + n3 + " e " + n4);
            const double media = (n1 + n2 + n3 + n4) / 4 ;
            Console.WriteLine("Sua média final foi: " + media);
            
            if (media > 6.0)
            {
                Console.WriteLine("Você passou, parabéns!");
            }
        }
    }
}

using System;

namespace exer2
{
    class Program
    {
        static void Main(string[] args)
        {
            //nota1
            Console.WriteLine("Insira a  primeira nota: ");
            var ler = Console.ReadLine();
            double n1 = Convert.ToDouble(ler);
            //nota2
            Console.WriteLine("Insira a  segunda nota: ");
            ler = Console.ReadLine();
            double n2 = Convert.ToDouble(ler);
            //nota3
            Console.WriteLine("Insira a  terceira nota: ");
            ler = Console.ReadLine();
            double n3 = Convert.ToDouble(ler);
            //nota4
            Console.WriteLine("Insira a  quarta nota: ");
            ler = Console.ReadLine();
            double n4 = Convert.ToDouble(ler);

            Console.WriteLine("Suas notas foram: " + n1 + ", " + n2 + ", " + n3 + " e " + n4);
            double media = (n1 + n2 + n3 + n4) / 4 ;
            Console.WriteLine("Sua média final foi: " + media);
            
            if (media >= 7.0) 
            {
                Console.WriteLine("Você está aprovado, parabéns!");
            } else if (media >= 5.0)
            {
                Console.WriteLine("Você está em recuperação mas não perca as esperanças!");
            } else {
                Console.WriteLine("Sinto muito, você está reprovado :( mais sorte no ano que vem!)");
            }
        }
    }
}

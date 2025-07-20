using System;

namespace exer7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o primeiro valor: ");
            var ler = Console.ReadLine();
            double n1 = Convert.ToDouble(ler);
            Console.WriteLine("Informe o segundo valor: ");
            ler = Console.ReadLine();
            double n2 = Convert.ToDouble(ler);
            Console.WriteLine("Informe o terceiro valor: ");
            ler = Console.ReadLine();
            double n3 = Convert.ToDouble(ler);
            string maior = "";
            if (n1 > n2 && n1 > n3)
            {
                maior = $"{n1}";
            } else if (n2 > n1 && n2 > n3) {
                maior = $"{n2}";
            } else  if (n3 > n2 && n3 > n1) {
                maior = $"{n3}";
            } else {
                maior = "nenhum";
            }
            Console. WriteLine("Entre os valores: " + n1 + ", " + n2 + " e " + n3 + ", o maior valor inserido foi: " + maior);
        }
    }
}

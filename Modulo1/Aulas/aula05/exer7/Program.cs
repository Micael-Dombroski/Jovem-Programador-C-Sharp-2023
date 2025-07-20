using System;
namespace exer7 
{
    class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um némero:");
            var num = Console.ReadLine();
            int valor = Convert.ToInt32(num);
            int dobro = valor * 2;
            int quadrado = dobro * dobro;
            int final = quadrado + 1;
            Console.WriteLine("O número inserido foi: " + num);
            Console.WriteLine("O dobro de " + num + " é: " + dobro);
            Console.WriteLine("O quadrado do dobro de " + num + " é: " + quadrado);
            Console.WriteLine("O quadrado do dobro de " + num + " somado com 1 é: " + final);
        }
    }
}

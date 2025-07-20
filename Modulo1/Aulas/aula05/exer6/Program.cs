using System;
namespace exer6 
{
    class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe sua idade:");
            var idade = Console.ReadLine();
            byte idade1 = Convert.ToByte(idade);
            Console.WriteLine("Maior de idade: " + (idade1 >= 18));
        }
    }
}
using System;

namespace exer02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira uma senha: ");
            string senha = Console.ReadLine();
            int letrasenha = 0, qtnumeros = 0, qtminus = 0, qtmaius = 0, qtcharespecial = 0;
            for (int c = 0; c < senha.Length;  c++)
            {
                letrasenha = senha[c];
                if (letrasenha > 64 && letrasenha < 91)
                {
                    qtmaius++;
                } else if (letrasenha > 96 && letrasenha < 123)
                {
                    qtminus++;
                } else if (letrasenha > 47 && letrasenha < 58)
                {
                    qtnumeros++;
                } else
                {
                    qtcharespecial++;
                }
            }
            Console.WriteLine("Letras maiúsculas: " + qtmaius);
            Console.WriteLine("Letras minúsculas: " + qtminus);
            Console.WriteLine("Números: " + qtnumeros);
            Console.WriteLine("Caracteres especiais: " + qtcharespecial);
        }
    }
}

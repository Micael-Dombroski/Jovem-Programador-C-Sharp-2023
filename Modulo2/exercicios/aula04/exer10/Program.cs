using System;

namespace exer10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos Contatos sua agenda possui?");
            int tamanho = int.Parse(Console.ReadLine());
            if (tamanho < 20)
            {
                tamanho=20;
            }
            string [,] agenda = new string[4,tamanho];
            for (int i = 0; i < tamanho; i++)
            {
                Console.Write("Informe o Nome do Contato: ");
                agenda[0,i] = Console.ReadLine();
                Console.Write("Informe o DDD do Contato: ");
                agenda[1,i] = Console.ReadLine();
                Console.Write("Informe o Telefone do Contato: ");
                agenda[2,i] = Console.ReadLine();
                Console.Write("Informe o WhatsApp do Contato: ");
                agenda[3,i] = Console.ReadLine();
            }
            Console.WriteLine("==========Agenda Telefônica==========");
            Console.WriteLine("Nome  DDD  Telefone  WhatsApp  ");
            for (int i = 0; i < tamanho; i++)
            {
                Console.WriteLine($"{agenda[0,i]}    {agenda[1,i]}    {agenda[2,i]}     {agenda[3,i]}");
            }
            Console.WriteLine("=====================================");
        }
    }
}

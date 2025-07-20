using System;
using System.Globalization;

namespace exer01
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo idioma = new CultureInfo("pt-BR");
            Console.Write("Informe o dia do seu aniversário: ");
            var ler = Console.ReadLine();
            int dia = Convert.ToInt32(ler);
            Console.WriteLine();
            Console.Write("Informe o mês do seu aniversário: ");
            ler = Console.ReadLine();
            int mes = Convert.ToInt32(ler);
            Console.WriteLine();
            Console.Write("Informe o ano que você nasceu (Ex: 1233): ");
            ler = Console.ReadLine();
            int ano = Convert.ToInt32(ler);
            var data = new DateTime(ano,mes,dia);
            Console.WriteLine("\n");
            Console.WriteLine("Data simplificada: " + data.ToShortDateString());
            Console.Write("Data completa (por extenso): " + data.Day + " de ");
            Console.Write(idioma.DateTimeFormat.GetMonthName(data.Month) + " de ");
            Console.WriteLine(data.Year);
        }
    }
}

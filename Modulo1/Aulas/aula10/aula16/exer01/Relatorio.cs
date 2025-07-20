using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer01
{
    public class Relatorio
    {
        public void MostrarRelatorio(Animal animal)
        {
            Console.WriteLine("\n");
            Console.WriteLine("=============Relatório=============\n");
            Console.WriteLine($"Nome do Animal.....: {animal.Nome}");
            Console.WriteLine($"Nome do Dono.......: {animal.Dono}");
            Console.WriteLine($"Categoria do Animal: {animal.ShowCategoria()}\n");
            Console.WriteLine("===================================");
        }
    }
}
using System;

namespace exer01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o tipo do animal: 1-Cachorro,2-Gato,3-Vaca,4-Cavalo");
            string ler = Console.ReadLine();
            int opt = Convert.ToInt32(ler);
            string nome = "";
            string dono = "";
            switch (opt)
            {
                case 1:
                    var cachorro = new AnimalCachorro();
                    Console.Write("Informe o nome do animal: ");
                    nome = Console.ReadLine();
                    Console.Write("Informe o nome do dono do animal: ");
                    dono = Console.ReadLine();
                    cachorro.Nome = nome;
                    cachorro.Dono = dono;
                    Console.WriteLine($"Categoria do animal: Cachorro - Nome: {cachorro.Nome} - Dono: {cachorro.Dono}");
                break;
                case 2:
                    var gato = new AnimalGato();
                    Console.Write("Informe o nome do animal: ");
                    nome = Console.ReadLine();
                    Console.Write("Informe o nome do dono do animal: ");
                    dono = Console.ReadLine();
                    gato.Nome = nome;
                    gato.Dono = dono;
                    Console.WriteLine($"Categoria do animal: Gato - Nome: {gato.Nome} - Dono: {gato.Dono}");
                break;
                case 3:
                    var vaca = new AnimalVaca();
                    Console.Write("Informe o nome do animal: ");
                    nome = Console.ReadLine();
                    Console.Write("Informe o nome do dono do animal: ");
                    dono = Console.ReadLine();
                    vaca.Nome = nome;
                    vaca.Dono = dono;
                    Console.WriteLine($"Categoria do animal: Vaca - Nome: {vaca.Nome} - Dono: {vaca.Dono}");
                break;
                case 4:
                    var cavalo = new AnimalCavalo();
                    Console.Write("Informe o nome do animal: ");
                    nome = Console.ReadLine();
                    Console.Write("Informe o nome do dono do animal: ");
                    dono = Console.ReadLine();
                    cavalo.Nome = nome;
                    cavalo.Dono = dono;
                    Console.WriteLine($"Categoria do animal: Cavalo - Nome: {cavalo.Nome} - Dono: {cavalo.Dono}");
                break;
                default:
                    Console.WriteLine("Opção indisponível...");
                break;
            }
        }
    }
}

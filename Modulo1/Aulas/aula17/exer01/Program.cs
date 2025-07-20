using System;

namespace exer01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Deseja Categorizar um animal? Sim/Não");
            string ler = Console.ReadLine();
            while(ler.ToLower()== "sim")
            {
                Console.Write("Informe o nome do Animal: ");
                string nome = Console.ReadLine();
                Console.Write("Informe o nome do Dono do Animal: ");
                string dono = Console.ReadLine();
                Console.WriteLine("Qual a Categoria do Animal?");
                Console.WriteLine("1-Cachorro");
                Console.WriteLine("2-Gato");
                Console.WriteLine("3-Vaca");
                Console.WriteLine("4-Cavalo");
                Console.WriteLine("5-Peixe");
                Console.Write("Informe o número que represente a Categoria do seu Animal: ");
                ler = Console.ReadLine();
                int opt = Convert.ToInt32(ler);
                string caminhando="";
                switch (opt)
                {
                    case 1:
                        Cachorro cachorro = new Cachorro(nome,dono);
                        cachorro.DefinirCategoria();
                        Console.WriteLine("Esse animal está caminhando? Sim/Não");
                        ler = Console.ReadLine();
                        if (cachorro.EstaCaminhando(ler))
                        {
                            caminhando="Sim";
                        }
                        else 
                        {
                            caminhando="Não";
                        }
                        Console.WriteLine("\n========================================\n");
                        Console.WriteLine("=======Informações sobre o Animal=======");
                        Console.WriteLine("\n========================================\n");
                        Console.WriteLine($"Nome: {cachorro.Nome}");
                        Console.WriteLine($"Dono: {cachorro.Dono}");
                        Console.WriteLine($"Categoria: {cachorro.MostrarCategoria()}");
                        Console.Write($"Caminhando: {caminhando}");
                        Console.WriteLine("\n========================================\n");
                    break;
                    case 2:
                        Gato gato = new Gato(nome,dono);
                        gato.DefinirCategoria();
                        Console.WriteLine("Esse animal está caminhando? Sim/Não");
                        ler = Console.ReadLine();
                        if (gato.EstaCaminhando(ler))
                        {
                            caminhando="Sim";
                        }
                        else 
                        {
                            caminhando="Não";
                        }
                        Console.WriteLine("\n========================================\n");
                        Console.WriteLine("=======Informações sobre o Animal=======");
                        Console.WriteLine("\n========================================\n");
                        Console.WriteLine($"Nome: {gato.Nome}");
                        Console.WriteLine($"Dono: {gato.Dono}");
                        Console.WriteLine($"Categoria: {gato.MostrarCategoria()}");
                        Console.Write($"Caminhando: {caminhando}");
                        Console.WriteLine("\n========================================\n");
                    break;
                    case 3:
                        Vaca vaca = new Vaca(nome,dono);
                        vaca.DefinirCategoria();
                        Console.WriteLine("Esse animal está caminhando? Sim/Não");
                        ler = Console.ReadLine();
                        if (vaca.EstaCaminhando(ler))
                        {
                            caminhando="Sim";
                        }
                        else 
                        {
                            caminhando="Não";
                        }
                        Console.WriteLine("\n========================================\n");
                        Console.WriteLine("=======Informações sobre o Animal=======");
                        Console.WriteLine("\n========================================\n");
                        Console.WriteLine($"Nome: {vaca.Nome}");
                        Console.WriteLine($"Dono: {vaca.Dono}");
                        Console.WriteLine($"Categoria: {vaca.MostrarCategoria()}");
                        Console.Write($"Caminhando: {caminhando}");
                        Console.WriteLine("\n========================================\n");
                    break;
                    case 4:
                        Cavalo cavalo = new Cavalo(nome,dono);
                        cavalo.DefinirCategoria();
                        Console.WriteLine("Esse animal está caminhando? Sim/Não");
                        ler = Console.ReadLine();
                        if (cavalo.EstaCaminhando(ler))
                        {
                            caminhando="Sim";
                        }
                        else 
                        {
                            caminhando="Não";
                        }
                        Console.WriteLine("\n========================================\n");
                        Console.WriteLine("=======Informações sobre o Animal=======");
                        Console.WriteLine("\n========================================\n");
                        Console.WriteLine($"Nome: {cavalo.Nome}");
                        Console.WriteLine($"Dono: {cavalo.Dono}");
                        Console.WriteLine($"Categoria: {cavalo.MostrarCategoria()}");
                        Console.Write($"Caminhando: {caminhando}");
                        Console.WriteLine("\n========================================\n");
                    break;
                    case 5:
                        Peixe peixe = new Peixe(nome,dono);
                        peixe.DefinirCategoria();
                        Console.WriteLine("\n========================================\n");
                        Console.WriteLine("=======Informações sobre o Animal=======");
                        Console.WriteLine("\n========================================\n");
                        Console.WriteLine($"Nome: {peixe.Nome}");
                        Console.WriteLine($"Dono: {peixe.Dono}");
                        Console.WriteLine($"Categoria: {peixe.MostrarCategoria()}");
                        Console.WriteLine("\n========================================\n");
                    break;
                    default:
                        Console.WriteLine("A Opção escolhida não está disponível no nosso Menu de Categorias...");
                    break;
                }
                Console.WriteLine("Deseja Categorizar um animal? Sim/Não");
                ler = Console.ReadLine();
            }
        }
    }
}

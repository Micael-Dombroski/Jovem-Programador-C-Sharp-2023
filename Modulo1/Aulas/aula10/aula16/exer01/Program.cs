using System;

namespace exer01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o nome do animal: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Informe o nome do dono: ");
            string dono = Console.ReadLine();
            Console.WriteLine("Qual a categoria do seu animal: 1-Cachorro, 2-Gato, 3-Vaca, 4-Cavalo");
            string ler = Console.ReadLine();
            int opt = Convert.ToInt32(ler);
            var relatorio = new Relatorio();
            switch(opt)
            {
                case 1:
                    Animal cachorro = new Cachorro(nome,dono);
                    Console.WriteLine($"Nome: {cachorro.Nome} - Dono: {cachorro.Dono} - Categoria: {cachorro.GetCategoria()}");
                    relatorio = new Relatorio();
                    relatorio.MostrarRelatorio(cachorro);
                break;
                case 2:
                    Animal gato = new Gato(nome,dono);
                    Console.WriteLine($"Nome: {gato.Nome} - Dono: {gato.Dono} - Categoria: {gato.GetCategoria()}");
                    relatorio = new Relatorio();
                    relatorio.MostrarRelatorio(gato);
                break;
                case 3:
                    Animal vaca = new Vaca(nome,dono);
                    Console.WriteLine($"Nome: {vaca.Nome} - Dono: {vaca.Dono} - Categoria: {vaca.GetCategoria()}");
                    relatorio = new Relatorio();
                    relatorio.MostrarRelatorio(vaca);
                break;
                case 4:
                    Animal cavalo = new Cavalo(nome,dono);
                    Console.WriteLine($"Nome: {cavalo.Nome} - Dono: {cavalo.Dono} - Categoria: {cavalo.GetCategoria()}");
                    relatorio = new Relatorio();
                    relatorio.MostrarRelatorio(cavalo);
                break;
                default:
                    Console.WriteLine("A opção escolhida está indisponível...");
                break;
            }
        }
    }
}

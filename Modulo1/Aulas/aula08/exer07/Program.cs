using System;

namespace exer07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos tipos de produtos temos?");
            var ler = Console.ReadLine();
            int i = Convert.ToInt32(ler);
            string [] nomeproduto = new string [i];
            double [] valorproduto = new double [i];
            int [] nprodutos = new int [i];
            int totaldeprodutos = 0;
            for (int c =0; c < i; c++)
            {
                Console.Write("Informe o nome do produto " + (c+1) + ": ");
                nomeproduto [c] = Console.ReadLine();
                Console.WriteLine("");
                Console.Write("Informe o valor desse produto: R$ ");
                ler = Console.ReadLine();
                Console.WriteLine("");
                valorproduto[c] = Convert.ToDouble(ler);
                Console.Write("Informe a quatidade desse produto no estoque: ");
                ler = Console.ReadLine();
                Console.WriteLine("");
                nprodutos[c] = Convert.ToInt32(ler);
                totaldeprodutos += nprodutos[c];
            }
            Console.WriteLine("===========================");
            Console.WriteLine("   Relatório de Produtos   ");
            Console.WriteLine("===========================");
            for (int c =0; c< i; c++)
            {
                Console.WriteLine("Produto " + (c+1));
                Console.WriteLine("Nome: " + nomeproduto[c]);
                Console.WriteLine("Valor: R$" + valorproduto[c]);
                Console.WriteLine("Quantidade: " + nprodutos[c]);
                Console.WriteLine("");
            }
            Console.WriteLine("===========================");
            Console.WriteLine("Ao todo temos " + totaldeprodutos + " produtos!");
            Console.WriteLine("===========================");
        }
    }
}

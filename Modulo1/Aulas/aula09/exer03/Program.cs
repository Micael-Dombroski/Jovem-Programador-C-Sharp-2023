using System;

namespace exer03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos tipos de produtos temos?");
            var ler = Console.ReadLine();
            int n = Convert.ToInt32(ler);
            string [,] produtoinfo = new string [n,3];
            int totaldeprodutos = 0;
            for (int c =0; c < n; c++)
            {
                Console.Write("Informe o nome do produto " + (c+1) + ": ");
                produtoinfo [c,0] = Console.ReadLine();
                Console.WriteLine("");
                Console.Write("Informe o valor desse produto: R$ ");
                ler = Console.ReadLine();
                Console.WriteLine("");
                double valorproduto = Convert.ToDouble(ler);
                produtoinfo [c,1] = $"R$ {valorproduto}";
                Console.Write("Informe a quatidade desse produto no estoque: ");
                ler = Console.ReadLine();
                Console.WriteLine("");
                int nprodutos = Convert.ToInt32(ler);
                produtoinfo [c,2] = $"{nprodutos}";
                totaldeprodutos += nprodutos;
            }
            Console.WriteLine("===========================");
            Console.WriteLine("   Relatório de Produtos   ");
            Console.WriteLine("===========================");
            for (int c =0; c< n; c++)
            {
                Console.WriteLine("Produto " + (c+1));
                Console.WriteLine("Nome: " + produtoinfo [c,0]);
                Console.WriteLine("Valor: " + produtoinfo [c,1]);
                Console.WriteLine("Quantidade: " + produtoinfo [c,2]);
                Console.WriteLine("");
            }
            Console.WriteLine("===========================");
            Console.WriteLine("Ao todo temos " + totaldeprodutos + " produtos!");
            Console.WriteLine("===========================");
        }
    }
}

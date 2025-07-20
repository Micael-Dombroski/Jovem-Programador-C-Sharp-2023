using System;

namespace exer01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("De quantos habitantes os dados analisados foram coletados?");
            var ler = Console.ReadLine();
            int n = Convert.ToInt32(ler);
            double [,] infos = new double [n,2];
            double totsalario = 0.0, maiorsalario = 0.0, menorsalario = 100000000.0;
            int totfilhos = 0;
            int abaixomeiosalario = 0;
            
            for (int c = 0; c < n; c++)
            {
                Console.Write("Informe o salário da pessoa " + (c +1) + ": R$ ");
                ler = Console.ReadLine();
                infos [c,0] = Convert.ToDouble(ler);
                totsalario += infos[c,0];
                Console.WriteLine("");
                Console.Write("Informe a quantidade de filhos da pessoa " + (c +1) + ": ");
                ler = Console.ReadLine();
                infos [c,1] = Convert.ToDouble(ler);
                totfilhos += Convert.ToInt16(infos[c,1]);
                Console.WriteLine("");
                if (maiorsalario < infos[c,0])
                {
                    maiorsalario = infos[c,0];
                }
                if (menorsalario > infos[c,0])
                {
                    menorsalario = infos[c,0];
                }
                if (infos[c,0] <= 606.0)
                {
                    abaixomeiosalario++;
                }
            }
            double mediasalario = totsalario/n;
            double mediafilhos = totfilhos/n;
            double qtpessoas = Convert.ToDouble(n);
            double pctabaixomeiosalario = abaixomeiosalario/(qtpessoas/100);
            Console.WriteLine("---------Relatório IBGE---------");
            Console.WriteLine("Foram coletados os dados de " + n + " pessoas para essa pesquisa...");
            Console.WriteLine("A média salarial da população é R$ " + mediasalario);
            Console.WriteLine("A média do número de filhos da população é " + mediafilhos);
            Console.WriteLine("O maior salário registrado foi de R$ " + maiorsalario);
            Console.WriteLine("O menor salário registrado foi de R$ " + menorsalario);
            Console.WriteLine("O percentual de pessoal com salário abaixo de meio salário é de " + pctabaixomeiosalario + "%");
            Console.WriteLine("--------------------------------");
            /*Console.Write("Insira seu nome: ");
            var ler = Console.ReadLine();
            string nome = $"{ler}";
            Console.Clear();
            for (int i = 0; i < nome.Length; i++)
            {
                int numeroLetra = Convert.ToInt32(nome[i]);
                double adaptandoPraDivisao = Convert.ToDouble(numeroLetra);
                double divisao = adaptandoPraDivisao/4;
                var parteFracionada = divisao - Math.Truncate(divisao);
                string ptFracionada = $"{parteFracionada}";
                string div = $"{divisao}";
                string restDiv = $"{adaptandoPraDivisao%4}";
                Console.WriteLine($"{nome[i]} = {numeroLetra} = {numeroLetra}/4 = {div.Replace(",",".")}, {(int)divisao}, {ptFracionada.Replace(",",".")}, {restDiv.Replace(",",".")}");
            }*/
        }
    }
}

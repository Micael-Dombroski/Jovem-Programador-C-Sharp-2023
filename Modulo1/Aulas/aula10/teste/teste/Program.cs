using System;

namespace teste
{
    class Program
    {
        static int i = 0;
        static Conta [] correntistas = new Conta[0];
        static void Main(string[] args)
        {
            string ler = "";
            do {
                Console.Write("Informe o nome do correntista: ");
                ler = Console.ReadLine();
                var correntista = new Conta();
                correntista.Nome = ler;
                AumentarArray(correntista);
                Console.WriteLine(i);
                Console.WriteLine("Deseja continuar adicionando correntistas? Sim/Não");
                ler = Console.ReadLine();
            } while (ler.ToLower() == "sim");
            for (int j = 0; j < i; j++)
            {
                Console.WriteLine(correntistas[j].Nome);
            }
        }

        static void AumentarArray(Conta correntista)
        {
            Conta [] tempCorrentista = new Conta[correntistas.Length + 1];
            for (int j = 0; j < correntistas.Length; j++)
            {
                tempCorrentista[j] = correntistas[j];
            }
            correntistas = tempCorrentista;
            correntistas[i] = correntista;
            i++;
        }
    }
}

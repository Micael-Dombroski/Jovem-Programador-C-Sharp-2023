using System;

namespace exer03
{
    class Program
    {
        static int i = 0;
        static void Main(string[] args)
        {
            //int [] numeros = new int [1];
            //string [] horario = new string [1];
            //int c = 0;

            string[] numeroSorteio = new string[1];
            string[] horarioSorteio = new string[1];
            string[] dataSorteio = new string[1];
            Random aleatorio = new Random();

            Console.WriteLine("Deseja  sortear  um número de 0 até 100? Sim/Não");
            string ler = Console.ReadLine();
            if (ler.ToLower() == "sim")
            {
                while (ler.ToLower() == "sim")
                {
                    var data = DateTime.Now;
                    numeroSorteio[i] = $"{aleatorio.Next(0, 101)}";
                    dataSorteio[i] = data.ToString("dd/MM/yyyy");
                    horarioSorteio[i] = data.ToString("HH:mm:ss");

                    Console.WriteLine("Deseja  sortear outro número de 0 até 100? Sim/Não");
                    ler = Console.ReadLine();

                    if (ler.ToLower() == "sim")
                    {
                        AumentarArray(ref numeroSorteio);
                        AumentarArray(ref dataSorteio);
                        AumentarArray(ref horarioSorteio);

                        i++;
                    }
                }
                for (int j = 0; j <= i; j++)
                {
                    Console.WriteLine($"Sorteio Nº{j+1} => Número Sorteado: {numeroSorteio[j]} - Data do Sorteio: {dataSorteio[j]} - Horário do Sorteio: {horarioSorteio[j]}");
                }         
            } else 
            {
                Console.WriteLine("Ok...");
            }
        }

        static void AumentarArray(ref string[] array)
        {
            string[] arrayTemp = new string[array.Length + 1];

            for (int j = 0; j <= i; j++)
            {
                arrayTemp[j] = array[j];
            }

            array = arrayTemp;
        }
    }
}

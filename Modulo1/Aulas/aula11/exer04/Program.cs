using System;

namespace exer04
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            string[] numeroSorteio = new string[1];
            string[] horarioSorteio = new string[1];
            string[] dataSorteio = new string[1];
            Random aleatorio = new Random();

            Console.WriteLine("Deseja  sortear  um número? Sim/Não");
            string ler = Console.ReadLine();
            if (ler.ToLower() == "sim")
            {
                Console.WriteLine("Qual será o valor máximo que poderá ser obtido no sorteio?");
                int valmax = int.Parse(Console.ReadLine());
                while (ler.ToLower() == "sim")
                {
                    var data = DateTime.Now;
                    numeroSorteio[i] = $"{aleatorio.Next(0, valmax)}";
                    dataSorteio[i] = data.ToString("dd/MM/yyyy");
                    horarioSorteio[i] = data.ToString("HH:mm:ss");

                    if (i >= 1) 
                    {
                        int j = 0;
                        while (j < i)
                        {
                            if (numeroSorteio[i] == numeroSorteio[j])
                            {
                                numeroSorteio[i] = $"{aleatorio.Next(0, valmax+1)}";
                                j=0;    
                            } else
                            {
                                j++;
                            }

                        }
                    }

                    Console.WriteLine("Deseja  sortear outro número de 0 até " + valmax +  "? Sim/Não");
                    ler = Console.ReadLine();

                    if (ler.ToLower() == "sim")
                    {
                        AumentarArray(ref numeroSorteio,i);
                        AumentarArray(ref dataSorteio,i);
                        AumentarArray(ref horarioSorteio,i);

                        i++;
                    }
                    if (i > valmax)
                    {
                        ler = "não";
                        i--;
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

        static void AumentarArray(ref string[] array, int i)
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

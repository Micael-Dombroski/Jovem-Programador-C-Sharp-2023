using System;

namespace exer08
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] municipios = new string [1];
            int cont = 0;
            bool sair = false;
            do
            {
                Console.Write("Informe o nome de um município (para sair basta escrever 'sair'): ");
                string municipio = Console.ReadLine();
                if (municipio.ToLower() == "sair")
                {
                    sair = true;
                }
                else
                {
                    if (cont > 0)
                    {
                        string [] aumentar = new string[cont+1];
                        for (int i = 0; i < cont; i++)
                        {
                            aumentar[i] = municipios[i];
                        }
                        aumentar[cont] = municipio;
                        municipios=aumentar;
                        cont++;
                    }
                    else
                    {
                        municipios[0] = municipio;
                        cont++;
                    }
                }
            } while (sair == false);
            Console.WriteLine($"A quantidade de municípios inseridos foi: {municipios.Length}");
            Console.WriteLine("Os municípios inseridos foram: ");
            for (int i = 0; i < municipios.Length; i++)
            {
                Console.WriteLine(municipios[i]);
            }
        }
    }
}

using System;

namespace exer5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conversor de  Temperatura");
            Console.WriteLine("Escolha o tipo de conversão que deseja fazer: ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("[1] Celcius para fahrenheit;");
            Console.WriteLine("[2] Celsius para kelvin;");
            Console.WriteLine("[3] Fahrenheit para celcius;");
            Console.WriteLine("[4] Fahrenheit para kelvin;");
            Console.WriteLine("[5] Kelvin para celcius;");
            Console.WriteLine("[6] Kelvin para fahrenheit;");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Informe a opção de conversão que deseja fazer: ");
            string ler = Console.ReadLine();
            int opt = int.Parse(ler);
            double tempIn = 0.0;
            double tempConv = 0.0; 
            while (opt < 1 || opt > 10) {
                Console.WriteLine("3RR0R: A opção escolhida não está disponível, escolha outra opção: ");
                ler = Console.ReadLine();
                opt = int.Parse(ler);
            }
            switch(opt) {
                case 1:
                    Console.WriteLine("Insira uma temperatura em celsius: ");
                    ler = Console.ReadLine();
                    tempIn = double.Parse(ler);
                    tempConv = tempIn * 1.8 + 32;
                    Console.WriteLine(tempIn + " graus celcius foram convertidos para " + tempConv + " graus fahrenheit");
                break;
                case 2:
                    Console.WriteLine("Insira uma temperatura em celsius: ");
                    ler = Console.ReadLine();
                    tempIn = double.Parse(ler);
                    tempConv = tempIn + 273;
                    Console.WriteLine(tempIn + " graus celcius foram convertidos para " + tempConv + " graus kelvin");
                break;
                case 3:
                    Console.WriteLine("Insira uma temperatura em fahrenheit: ");
                    ler = Console.ReadLine();
                    tempIn = double.Parse(ler);
                    tempConv = ((tempIn-32)*5)/9;
                    Console.WriteLine(tempIn + " graus fahrenheit foram convertidos para " + tempConv + " graus celcius");
                break;
                case 4:
                    Console.WriteLine("Insira uma temperatura em fahrenheit: ");
                    ler = Console.ReadLine();
                    tempIn = double.Parse(ler);
                    tempConv = (((tempIn-32)/9) * 5) + 273;
                    Console.WriteLine(tempIn + " graus fahrenheit foram convertidos para " + tempConv + " graus kelvin");
                break;
                case 5:
                    Console.WriteLine("Insira uma temperatura em kelvin: ");
                    ler = Console.ReadLine();
                    tempIn = double.Parse(ler);
                    tempConv = tempIn-273;
                    Console.WriteLine(tempIn + " graus kelvin foram convertidos para " + tempConv + " graus celcius");
                break;
                default:
                    Console.WriteLine("Insira uma temperatura em kelvin: ");
                    ler = Console.ReadLine();
                    tempIn = double.Parse(ler);
                    tempConv = (tempIn - 273) * 9 + 32 * 5;
                    Console.WriteLine(tempIn + " graus kelvin foram convertidos para " + tempConv + " graus fahrenheit");
                break;
            }
        }
    }
}
